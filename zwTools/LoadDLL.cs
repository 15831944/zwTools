using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.Windows;

namespace zwTools
{

    public class LoadDLL : IExtensionApplication
    {
        public void Initialize()
        {
            //程序加载后立即执行的代码
            Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.SendStringToExecute("AddRibbon\n", true, false, true);
        }
        public void Terminate()
        {
        }
    }
}
