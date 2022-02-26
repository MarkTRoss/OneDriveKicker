namespace OneDriveKicker
{
    public static class Settings
    {



        static string fileName = "Settings.ini";
        public static string AppName = "OneDrive Kicker";
        public static string WatchFolder = "";
        public static bool WatchFolder_IncludeSubFolders = true;
        public static string OneDriveFolder = "";
        /// <summary>
        /// Delay to Wait in seconds
        /// </summary>
        public static int Delay = 120;
        /// <summary>
        /// Run anyway delay in seconds
        /// </summary>
        public static int DelayOverride = 600;
        public static bool DisplayCopyright = true;



        public static bool ReadFile()
        {
            String? line;
            try
            {
                StreamReader sr = new StreamReader(fileName);

                do
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string str0 = line.Split('=')[0];
                        string str1 = line.Split('=')[1];
                        int int1 = 0;
                        Int32.TryParse(str1, out int1);

                        switch (str0)
                        {
                            case "AppName": AppName = str1; break;
                            case "WatchFolder": WatchFolder = str1; break;
                            case "WatchFolder_IncludeSubFolders": WatchFolder_IncludeSubFolders = (str1 == "True"); break;
                            case "OneDriveFolder": OneDriveFolder = str1; break;
                            case "Delay": Delay = int1; break;
                            case "DelayOverride": DelayOverride = int1; break;
                            case "DisplayCopyright": DisplayCopyright = (str1 == "True"); break;
                        }

                    }
                }
                while (line != null);

                sr.Close();
                Console.ReadLine();
                return true;
            }
            catch
            {
                return false;
            }

        }  //ReadFile()



        public static bool WriteFile()
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName);
                sw.WriteLine("AppName=" + AppName);
                sw.WriteLine("WatchFolder=" + WatchFolder);
                sw.WriteLine("WatchFolder_IncludeSubFolders=" + WatchFolder_IncludeSubFolders);
                sw.WriteLine("OneDriveFolder=" + OneDriveFolder);
                sw.WriteLine("Delay=" + Delay);
                sw.WriteLine("DelayOverride=" + DelayOverride);
                sw.WriteLine("DisplayCopyright=" + DisplayCopyright);
                sw.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }  //WriteFile()



    }  //class
}  //namespace