﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Hollywood.MovieInfoServiceSoapClient HwClient;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            HwClient = new Hollywood.MovieInfoServiceSoapClient("MovieInfoServiceSoap");
            Application.Run(new Form1()); 
        }
    }
}
