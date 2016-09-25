using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;

[assembly: CommandClass(typeof(zwTools.BlockP))]
namespace zwTools
{
    public class BlockP
    {
        [CommandMethod("ZB")]
        public void STestEdit()
        {
            btnSel form = new btnSel();
            Application.ShowModalDialog(form);
        }
    }
}
