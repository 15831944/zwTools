using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;

[assembly: CommandClass(typeof(zwTools.SameSel))]
namespace zwTools
{  
    public class SameSel
    {
        [CommandMethod("ZSS")]
        public void Same()
        {
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
            Entity ent = Selection.SelectS("\n 选择对象");
            if (ent == null)
                //ed.WriteMessage("\n 你选择的对象ObjectId:" + ent.ObjectId.ToString());
                return;

            //DBObjectCollection EntityCollection;
            //Editor ed1 = Application.DocumentManager.MdiActiveDocument.Editor;
            //if (ent is DBText)
            //{
            //    FilterType TextType = FilterType.Text;
            //    FilterType[] Types = new FilterType[1];
            //    Types[0] = TextType;
            //    EntityCollection = Selection.GetSelection(Types);
            //}
        }
    }
}
