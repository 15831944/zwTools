using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;

[assembly: CommandClass(typeof(zwTools.Help))]
namespace zwTools
{
    public class Help
    {
        [CommandMethod("ZWABOUT")]
        public void ABOUT()
        {
            FormAbout form = new FormAbout();
            Application.ShowModalDialog(form);
        }
    }
}
