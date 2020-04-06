using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileManager_DotNet
{
    /*******************************************************************************/
    public static class FileSearcherAsync
    {
        public static List<string> FoundFiles;

        /*******************************************************************************/
        public static async void StartFileSearchAsync()
        {
            FoundFiles = await GetFilesAsync(
                FilterOptions.FolderPath,
                FilterOptions.FileName + FilterOptions.FileExtension)
                .ConfigureAwait(false);
        }

        /*******************************************************************************/
        public static Task<List<string>> GetFilesAsync(string path, string pattern)
        {
            return Task.Run(() =>
            {
                return GetFiles(path, pattern);
            });
        }

        /*******************************************************************************/
        public static List<string> GetFiles(string path, string pattern)
        {
            var files = new List<string>();

            try
            {
                files.AddRange(Directory.EnumerateFiles(
                    path,
                    pattern,
                    SearchOption.TopDirectoryOnly));

                foreach (var directory in Directory.EnumerateDirectories(path))
                {
                    files.AddRange(GetFiles(directory, pattern));
                }
            }
            catch (UnauthorizedAccessException) { return new List<string>(); }
            catch (PathTooLongException) { }
            catch (DirectoryNotFoundException) { return new List<string>(); }

            return files;
        }

        /*******************************************************************************/
        public static void ClearFoundFilesList()
        {
            if ((FoundFiles != null) && (!FoundFiles.Any()))
            {
                FoundFiles.Clear();
            }
        }
    }
}
