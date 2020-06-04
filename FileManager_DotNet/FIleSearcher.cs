using System;
using System.Collections.Generic;
using System.IO;

namespace FileManager_DotNet
{
    /*******************************************************************************/
    public class FileSearcher
    {
        /***********************************************************/
        public IEnumerable<FileInfo> SearchResults(string path, string pattern, long minSize, long maxSize)
        {
            foreach (DirectoryInfo dir in GetDirectories(new DirectoryInfo(path)))
            {
                foreach (FileInfo file in dir.EnumerateFiles(pattern))
                {
                    var fileSize = file.Length / 1024;

                    if (fileSize >= minSize && fileSize <= maxSize)
                    {
                        FilterOptions.FilesCount++;
                        yield return file;
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