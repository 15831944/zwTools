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
            Entity ent = Selection.SelectSFilter("请选择块", "选择错误！", "请选择块", typeof(BlockReference),true);
            if (ent != null)
                ed.WriteMessage("\n 你选择的对象ObjectId:" + ent.ObjectId.ToString());
            else
                return;

            //Database db = HostApplicationServices.WorkingDatabase;//打开当前文档的数据库
            //using (Transaction transaction = db.TransactionManager.StartTransaction())
            //{
            //    BlockReference block = (BlockReference)transaction.GetObject(ent.ObjectId, OpenMode.ForWrite, true);
            //    AttributeCollection attri = block.AttributeCollection;
            //    transaction.Commit();
            //}
        }
    }
}
