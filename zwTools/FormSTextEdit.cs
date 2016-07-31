using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;

namespace zwTools
{

    public partial class FormSTextEdit : Form
    {
        public FormSTextEdit()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DBObjectCollection EntityCollection;
            Editor ed = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument.Editor;
            using (EditorUserInteraction edUsrInt = ed.StartUserInteraction(this))
            {
                //交互过程
                FilterType TextType = FilterType.Text;
                FilterType[] Types = new FilterType[1];
                Types[0] = TextType;
                EntityCollection = Selection.GetSelection(Types);
                edUsrInt.End(); //交互结束.
                this.Focus();
            }

            Database db = HostApplicationServices.WorkingDatabase;//打开当前文档的数据库
            if (rbTail.Checked == true)
            {  
                using (Transaction transaction = db.TransactionManager.StartTransaction())
                {
                    foreach (Entity ent in EntityCollection)
                    {
                        DBText text = (DBText)transaction.GetObject(ent.ObjectId, OpenMode.ForWrite, true);
                        if (tbTailLoc.Text == "")
                            tbTailLoc.Text = "0";
                        text.TextString = text.TextString.Insert(text.TextString.Length - int.Parse(tbTailLoc.Text), tbTailAdd.Text);
                    }
                    transaction.Commit();
                }
            }
            if (rbAdd.Checked == true)
            {
                using (Transaction transaction = db.TransactionManager.StartTransaction())
                {
                    foreach (Entity ent in EntityCollection)
                    {
                        DBText text = (DBText)transaction.GetObject(ent.ObjectId, OpenMode.ForWrite, true);
                        if (tbAddLoc.Text == "")
                            tbAddLoc.Text = "0";
                        text.TextString = text.TextString.Insert(int.Parse(tbAddLoc.Text), tbAddAdd.Text);
                    }
                    transaction.Commit();
                }
            }
            if (rbSub.Checked == true)
            {
                using (Transaction transaction = db.TransactionManager.StartTransaction())
                {
                    foreach (Entity ent in EntityCollection)
                    {
                        DBText text = (DBText)transaction.GetObject(ent.ObjectId, OpenMode.ForWrite, true);
                        text.TextString = text.TextString.Replace(tbSubFind.Text, tbSubAdd.Text);
                    }
                    transaction.Commit();
                }
            }
        }

        private void tbLoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            } 
        }
    }
}
