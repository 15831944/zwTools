using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;

namespace zwTools
{
    public class Selection
    {
        public static DBObjectCollection GetSelection(FilterType[] tps)
        {
            Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;
            Entity entity = null;
            DBObjectCollection EntityCollection = new DBObjectCollection();
            PromptSelectionOptions selops = new PromptSelectionOptions();
            // 建立选择的过滤器内容
            TypedValue[] filList = new TypedValue[tps.Length + 2];
            filList[0] = new TypedValue((int)DxfCode.Operator, "<or");
            filList[tps.Length + 1] = new TypedValue((int)DxfCode.Operator, "or>");
            for (int i = 0; i < tps.Length; i++)
            {
                filList[i + 1] = new TypedValue((int)DxfCode.Start, tps[i].ToString());
            }
            // 建立过滤器
            SelectionFilter filter = new SelectionFilter(filList);
            // 按照过滤器进行选择
            PromptSelectionResult ents = ed.GetSelection(selops, filter);
            if (ents.Status == PromptStatus.OK)
            {
                using (Transaction transaction = db.TransactionManager.StartTransaction())
                {
                    SelectionSet SS = ents.Value;
                    foreach (ObjectId id in SS.GetObjectIds())
                    {
                        entity = (Entity)transaction.GetObject(id, OpenMode.ForWrite, true);
                        if (entity != null)
                            EntityCollection.Add(entity);
                    }
                    transaction.Commit();
                }
            }
            return EntityCollection;
        }

    }

    /// <summary>
    /// 类型过滤枚举类
    /// </summary>
    public enum FilterType
    {
        Curve, Dimension, Polyline, BlockRef, Circle, Line, Arc, Text, MText
    }

   
}
