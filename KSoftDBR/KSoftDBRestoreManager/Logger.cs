﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSoftDBRestoreManager
{
    static class Logger
    {
        private static String fileName = "log";


        public static void log(String Logline)
        {
            Logline += "\n";
            System.IO.File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + fileName, Logline);
        }
    }
}
