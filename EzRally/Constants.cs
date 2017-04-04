using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzRally
{
    public static class Constants
    {
        public static string APPTITLE = "Ez Rally";

        #region "Messages"
        public static string CONFIG_FILE_NOT_SELECTED = "Please select all input files and output file name";
        public static string CONFIG_FILE_MISSING = "File not found: {0}";
        public static string CONFIG_FILES_NOT_SETUP = "Please complete setup of config files from 'File Settings' tab";
        public static string CONFIG_FILES_NOT_SETUP_2 = "Setup of config files from 'File Settings' tab is not complete";

        public static string TASK_CONFIG_NOT_HUNDRED = "Percentage allocation of tasks is not correct - it should be 100";
        public static string CONFIG_LOAD_EXCEPTION = "Error loading data from file: {0}";
        #endregion
    }
}
