using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;

[assembly: CommandClass(typeof(zwTools.SameAttri))]
namespace zwTools
{  
    public class SameAttri
    {
        [CommandMethod("ZSA")]
        public void Same()
        {
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
            Entity ent = Selection.SelectS("\n 选择对象");
            if (ent != null)
                ed.WriteMessage("\n 你选择的对象ObjectId:" + ent.ObjectId.ToString());
            else
                return;
        }
    }
}
