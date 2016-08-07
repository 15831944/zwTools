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
    public class DBOperator
    {
        /// <summary>
        /// 获取块表
        /// </summary>
        /// <param name="db">数据库</param>
        /// <returns></returns>
        public static BlockTable BlockTable(Database db)
        {
            BlockTable bt;
            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                bt = tr.GetObject(db.BlockTableId, OpenMode.ForWrite) as BlockTable;
                tr.Commit();
            }
            return bt;
        }

        /// <summary>
        /// 由块表记录名获得块表记录
        /// </summary>
        /// <param name="btrName">块表记录名</param>
        /// <param name="db">数据库</param>
        /// <returns></returns>
        public static BlockTableRecord GetBlockbyName(string btrName, Database db)
        {
            BlockTableRecord block = new BlockTableRecord();
            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                BlockTable bt = tr.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                block = tr.GetObject(bt[btrName], OpenMode.ForRead) as BlockTableRecord;
                tr.Commit();
            }
            return block;
        }

    }
}
