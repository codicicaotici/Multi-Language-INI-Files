using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MultiLanguageINIFiles
{
    class readLngFile
    {
        [DllImport("KERNEL32.DLL", EntryPoint = "GetPrivateProfileStringW",
             SetLastError = true,
             CharSet = CharSet.Unicode, ExactSpelling = true,
             CallingConvention = CallingConvention.StdCall)]
        private static extern int GetPrivateProfileString
             (
             string lpAppName,
             string lpKeyName,
             string lpDefault,
             string lpReturnString,
             int nSize,
             string lpFilename
             );
        public string getValue(string lngFile, string category, string key)
        {
            string defaultValue = "";
            string returnString = new string(' ', 65536);
            GetPrivateProfileString(category, key, defaultValue, returnString, 65536, lngFile);
            return returnString.Split('\0')[0];
        }/// 
    }
}
