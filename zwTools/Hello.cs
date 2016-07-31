using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;

[assembly: CommandClass(typeof(zwTools.Hello))]
namespace zwTools
{
    public class Hello
    {
        [CommandMethod("HELLO")]
        public void HELLO()
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            ed.WriteMessage("Hello World!");
        }
    }

}
