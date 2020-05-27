using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager_DotNet
{
    /*******************************************************************************/
    public class FileSearcherIEnumerable
    {
        private static TaskScheduler uiScheduler;

        /*******************************************************************************/
        public FileSearcherIEnumerable(TaskScheduler UIScheduler)
        {
            uiScheduler = UIScheduler;
        }

        /*******************************************************************************/
        public static void CurrentFileToListView(FileInfo file, ListView listView, Label counterLabel,
            CancellationToken cancellationToken)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    ListViewAddItem(file, listView, counterLabel);

                    cancellationToken.ThrowIfCancellationRequested();

                }, cancellationToken, TaskCreationOptions.None, uiScheduler);
            }
            catch(OperationCanceledException) { }
        }

        /*******************************************************************************/
        public static void ListViewAddItem(FileInfo file, ListView listView, Label counterLabel)
        {
            var fileName = file.Name;
            var folderName = file.FullName;
            var fileType = file.Extension;
            var fileSize = file.Length / 1024;
            var fileSizetoKB = (fileSize < 1) ? 1.ToString() : fileSize.ToString();

            ListViewItem lvi = new ListViewItem(fileName);

            lvi.SubItems.Add(folderName);
            lvi.SubItems.Add(fileType);
            lvi.SubItems.Add(fileSizetoKB);
            listView.Items.Add(lvi);

            counterLabel.Text = listView.Items.Count.ToString();
        }

        /*******************************************************************************/
        public void StartFileSearch(
            string path, string pattern, long minSize, long maxSize, ListView listView, Label counterLabel,
            Action<FileInfo, ListView, Label, CancellationToken> fileToWrite, CancellationToken cancellationToken)
        {
            foreach (DirectoryInfo dir in GetDirectories(new DirectoryInfo(path)))
            {
                foreach (FileInfo file in dir.EnumerateFiles(pattern))
                {
                    var fileSize = file.Length / 1024;

                    if (fileSize >= minSize && fileSize <= maxSize)
                    {
                        Thread.Sleep(1);
                        fileToWrite(file, listView, counterLabel, cancellationToken);
                    }
                }
            }
        }

        /*******************************************************************************/
        public static IEnumerable<DirectoryInfo> GetDirectories(DirectoryInfo directoryInfo)
        {
            var list = new List<DirectoryInfo>
            {
                directoryInfo
            };

            foreach (var item in directoryInfo.EnumerateDirectories())
            {
                try
                {
                    foreach (var subitem in GetDirectories(item))
                    {
                        list.Add(subitem);
                    }
                }
                catch (UnauthorizedAccessException) { }
                catch (PathTooLongException) { }
                catch (DirectoryNotFoundException) { }
            }

            foreach (var listitem in list)
            {
                yield return listitem;
            }
        }
    }

}
