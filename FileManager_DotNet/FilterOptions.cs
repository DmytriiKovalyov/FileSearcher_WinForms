namespace FileManager_DotNet
{
    /*******************************************************************************/
    public static class FilterOptions
    {
        public static string FolderPath { get; set; }

        public static string FileName { get; set; }

        public static string FileExtension { get; set; }

        public static long FileMinSize { get; set; } = 0;

        public static long FileMaxSize { get; set; } = long.MaxValue;

        /*******************************************************************************/
        public static void SetSearchedFileNames(bool check, string file_name)
        {
            FileName = (!check && file_name != string.Empty) ?
                "*" + file_name + "*" :
                "";
        }

        /*******************************************************************************/
        public static void SetSearchedFileExtensions(bool check, string file_type)
        {
            FileExtension = (!check && file_type != string.Empty) ?
                "*." + file_type.Trim(new char[] { ' ', '*', '.' }) :
                "*";
        }

        /*******************************************************************************/
        public static void SetSearchedFileSizes(bool check, string file1_size, string file2_size)
        {
            if (!check && file2_size != string.Empty)
            {
                long max_size;

                if (long.TryParse(file2_size, out max_size) && max_size > 0)
                {
                    FileMaxSize = max_size;
                }

                long min_size;

                if (long.TryParse(file1_size, out min_size) && min_size <= max_size)
                {
                    FileMinSize = min_size;
                }
                else
                {
                    FileMinSize = 0;
                    FileMaxSize = long.MaxValue;
                }
            }
        }

        /*******************************************************************************/
        public static void SetSizesToDefault()
        {
            FileMinSize = 0;
            FileMaxSize = long.MaxValue;
        }
    }
}
