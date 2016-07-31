using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;

[assembly: CommandClass(typeof(zwTools.About))]
namespace zwTools
{
    public class About
    {
        [CommandMethod("ZAB")]
        public void ABOUT()
        {
            FormAbout form = new FormAbout();
            Application.ShowModalDialog(form);
        }
    }
}
