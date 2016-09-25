using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Autodesk.AutoCAD;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;


namespace zwTools
{
    public partial class btnSel : Form
    {
        private DBObjectCollection EntityCollection;
        public btnSel()
        {
            InitializeComponent();
        }

        private void btYes_Click(object sender, EventArgs e)
        {
             Database db = HostApplicationServices.WorkingDatabase;//打开当前文档的数据库
             using (Transaction transaction = db.TransactionManager.StartTransaction())
             {
                 foreach (Entity ent in EntityCollection)
                 {
                     BlockReference block = (BlockReference)transaction.GetObject(ent.ObjectId, OpenMode.ForWrite, true);
                     BlockTableRecord blkRef = (BlockTableRecord)transaction.GetObject(block.BlockTableRecord, OpenMode.ForWrite, true);
                     Autodesk.AutoCAD.DatabaseServices.AttributeCollection attCol = block.AttributeCollection;
                     foreach (ObjectId attId in attCol)
                     {
                         AttributeReference attRef = (AttributeReference)transaction.GetObject(attId, OpenMode.ForWrite, true);
                         if (attRef.Tag == cbbProperties.SelectedItem.ToString())
                         {
                             attRef.TextString = tbValue.Text;
                         }
                     }
                 }
                 transaction.Commit();
             }
             this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //选择块
            Editor ed = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor;
            using (EditorUserInteraction edUsrInt = ed.StartUserInteraction(this))
            {
                //交互过程
                FilterType BlockRefype = FilterType.Insert;
                FilterType[] Types = new FilterType[1];
                Types[0] = BlockRefype;
                EntityCollection = Selection.GetSelection(Types);
                edUsrInt.End(); //交互结束.                
            }

            

            //遍历属性
            Database db = HostApplicationServices.WorkingDatabase;//打开当前文档的数据库
            using (Transaction transaction = db.TransactionManager.StartTransaction())
            {
                List<string> listBtr = new List<string>();
                foreach (Entity ent in EntityCollection)
                {
                    BlockReference block = (BlockReference)transaction.GetObject(ent.ObjectId, OpenMode.ForRead, true);
                    BlockTableRecord blkRef = (BlockTableRecord)transaction.GetObject(block.BlockTableRecord, OpenMode.ForRead, true);
                    Autodesk.AutoCAD.DatabaseServices.AttributeCollection attCol = block.AttributeCollection;
                    foreach (ObjectId attId in attCol)
                    {
                        AttributeReference attRef = (AttributeReference)transaction.GetObject(attId, OpenMode.ForRead);
                        listBtr.Add(attRef.Tag);
                    }
                }
                for (int i = listBtr.Count - 1; i >= 0; i--)
                    if (listBtr.IndexOf(listBtr[i]) != i)
                        listBtr.RemoveAt(i);
                cbbProperties.DataSource = listBtr;
            }
            this.Focus();
        }
    }
}
