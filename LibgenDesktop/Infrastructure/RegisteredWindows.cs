using System;
using System.Collections.Generic;
using LibgenDesktop.ViewModels.Windows;
using LibgenDesktop.Views.Windows;

namespace LibgenDesktop.Infrastructure
{
    internal static class RegisteredWindows
    {
        internal enum WindowKey
        {
            Main_Window = 1,
            Non_Fiction_Details_Window,
            Fiction_Detail_Window,
            Sci_Mag_Detail_WIndow,
            Error_Window,
            Import_WIndow,
            Setup_Wizard_WIndow,
            SETUP_WIZARD_PROXY_SETTINGS_WINDOW,
            Settings_Window,
            Synchronization_Window,
            Application_Update_Window,
            Library_Window,
            Database_Window,
            Database_Error_Window,
            About_Window,
            SQL_Debugger_Window
        }

        internal class RegisteredWindow
        {
            public RegisteredWindow(WindowKey windowKey, Type windowType, Type viewModelType)
            {
                WindowKey = windowKey;
                WindowType = windowType;
                ViewModelType = viewModelType;
            }

            public WindowKey WindowKey { get; }
            public Type WindowType { get; }
            public Type ViewModelType { get; }
        }

        static RegisteredWindows()
        {
            AllWindows = new Dictionary<WindowKey, RegisteredWindow>();
            RegisterWindow(WindowKey.Main_Window, typeof(MainWindow), typeof(MainWindowViewModel));
            RegisterWindow(WindowKey.Non_Fiction_Details_Window, typeof(NonFictionDetailsWindow), typeof(NonFictionDetailsWindowViewModel));
            RegisterWindow(WindowKey.Fiction_Detail_Window, typeof(FictionDetailsWindow), typeof(FictionDetailsWindowViewModel));
            RegisterWindow(WindowKey.Sci_Mag_Detail_WIndow, typeof(SciMagDetailsWindow), typeof(SciMagDetailsWindowViewModel));
            RegisterWindow(WindowKey.Error_Window, typeof(ErrorWindow), typeof(ErrorWindowViewModel));
            RegisterWindow(WindowKey.Import_WIndow, typeof(ImportWindow), typeof(ImportWindowViewModel));
            RegisterWindow(WindowKey.Setup_Wizard_WIndow, typeof(SetupWizardWindow), typeof(SetupWizardWindowViewModel));
            RegisterWindow(WindowKey.SETUP_WIZARD_PROXY_SETTINGS_WINDOW, typeof(SetupWizardProxySettingsWindow), typeof(SetupWizardProxySettingsWindowViewModel));
            RegisterWindow(WindowKey.Settings_Window, typeof(SettingsWindow), typeof(SettingsWindowViewModel));
            RegisterWindow(WindowKey.Synchronization_Window, typeof(SynchronizationWindow), typeof(SynchronizationWindowViewModel));
            RegisterWindow(WindowKey.Application_Update_Window, typeof(ApplicationUpdateWindow), typeof(ApplicationUpdateWindowViewModel));
            RegisterWindow(WindowKey.Database_Window, typeof(DatabaseWindow), typeof(DatabaseWindowViewModel));
            RegisterWindow(WindowKey.Database_Error_Window, typeof(DatabaseErrorWindow), typeof(DatabaseErrorWindowViewModel));
            RegisterWindow(WindowKey.About_Window, typeof(AboutWindow), typeof(AboutWindowViewModel));
            RegisterWindow(WindowKey.SQL_Debugger_Window, typeof(SqlDebuggerWindow), typeof(SqlDebuggerWindowViewModel));
            MessageBox = new MessageBox();
        }

        public static Dictionary<WindowKey, RegisteredWindow> AllWindows { get; }
        public static IMessageBox MessageBox { get; }

        private static void RegisterWindow(WindowKey windowKey, Type windowType, Type viewModelType)
        {
            AllWindows.Add(windowKey, new RegisteredWindow(windowKey, windowType, viewModelType));
        }
    }
}
