using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;

[assembly: CommandClass(typeof(zwTools.STest))]
namespace zwTools
{
    public class STest
    {
        [CommandMethod("ZT")]
        public void STestEdit()
        {
            FormSTextEdit form = new FormSTextEdit();
            Application.ShowModalDialog(form);
        }
    }
}
