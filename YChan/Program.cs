﻿/************************************************************************
 * Copyright (C) 2015 by themirage <mirage@secure-mail.biz>             *
 *                                                                      *
 * This program is free software: you can redistribute it and/or modify *
 * it under the terms of the GNU General Public License as published by *
 * the Free Software Foundation, either version 3 of the License, or    *
 * (at your option) any later version.                                  *
 *                                                                      *
 * This program is distributed in the hope that it will be useful,      *
 * but WITHOUT ANY WARRANTY; without even the implied warranty of       *
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the        *
 * GNU General Public License for more details.                         *
 *                                                                      *
 * You should have received a copy of the GNU General Public License    *
 * along with this program.  If not, see <http://www.gnu.org/licenses/> *
 ************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace YChan {

    static class Program {

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);


        public static frmMain MainFrame;
        /// <summary>
        /// Main thread exception handler
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        public static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e) {
            General.setSettings(General.path, General.timer, General.loadHTML, true, General.minimizeToTray, General.warnOnClose);
            try {
                General.writeURLs(MainFrame.clBoards, MainFrame.clThreads);
            } catch(Exception eX) {
                MessageBox.Show(eX.Message);
            }
        }

        /// <summary>
        /// Application domain exception handler
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        public static void AppDomain_UnhandledException(object sender, System.UnhandledExceptionEventArgs e) {
            General.setSettings(General.path, General.timer, General.loadHTML, true, General.minimizeToTray, General.warnOnClose);
            try {
                General.writeURLs(MainFrame.clBoards, MainFrame.clThreads);
            } catch(Exception eX) {
                MessageBox.Show(eX.Message);
            }
        }

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main() {
            bool createdNew = true;
            using (Mutex mutex = new Mutex(true, "BetterYChan", out createdNew))
            {
                if (createdNew)
                {
                    // Unhandled exceptions for our Application Domain
                    AppDomain.CurrentDomain.UnhandledException += new System.UnhandledExceptionEventHandler(AppDomain_UnhandledException);

                    // Unhandled exceptions for the executing UI thread
                    Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    MainFrame = new frmMain();
                    Application.Run(MainFrame);
                }
                else
                {
                    Process current = Process.GetCurrentProcess();
                    foreach (Process process in Process.GetProcessesByName(current.ProcessName))
                    {
                        if (process.Id != current.Id)
                        {
                            SetForegroundWindow(process.MainWindowHandle);
                            break;
                        }
                    }
                }
            }

        }
    }
}
