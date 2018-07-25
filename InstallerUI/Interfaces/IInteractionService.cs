﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallerUI.Interfaces
{
    public interface IInteractionService
    {
        void ShowMessageBox(string message);
        void CloseUIAndExit();
        void RunOnUIThread(Action body);
        IntPtr GetMainWindowHandle();
    }
}
