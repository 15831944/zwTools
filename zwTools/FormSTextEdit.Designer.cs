namespace zwTools
{
    partial class FormSTextEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelect = new System.Windows.Forms.Button();
            this.rbTail = new System.Windows.Forms.RadioButton();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbSub = new System.Windows.Forms.RadioButton();
            this.tbTailAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSubAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAddLoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSubFind = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTailLoc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(135, 248);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "选择";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // rbTail
            // 
            this.rbTail.AutoSize = true;
            this.rbTail.Checked = true;
            this.rbTail.Location = new System.Drawing.Point(16, 20);
            this.rbTail.Name = "rbTail";
            this.rbTail.Size = new System.Drawing.Size(83, 16);
            this.rbTail.TabIndex = 1;
            this.rbTail.TabStop = true;
            this.rbTail.Text = "添加(倒数)";
            this.rbTail.UseVisualStyleBackColor = true;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(16, 89);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(83, 16);
            this.rbAdd.TabIndex = 2;
            this.rbAdd.Text = "添加(正数)";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // rbSub
            // 
            this.rbSub.AutoSize = true;
            this.rbSub.Location = new System.Drawing.Point(16, 158);
            this.rbSub.Name = "rbSub";
            this.rbSub.Size = new System.Drawing.Size(47, 16);
            this.rbSub.TabIndex = 3;
            this.rbSub.Text = "替换";
            this.rbSub.UseVisualStyleBackColor = true;
            // 
            // tbTailAdd
            // 
            this.tbTailAdd.Location = new System.Drawing.Point(81, 52);
            this.tbTailAdd.Name = "tbTailAdd";
            this.tbTailAdd.Size = new System.Drawing.Size(81, 21);
            this.tbTailAdd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "添加文字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "添加文字";
            // 
            // tbAddAdd
            // 
            this.tbAddAdd.Location = new System.Drawing.Point(81, 119);
            this.tbAddAdd.Name = "tbAddAdd";
            this.tbAddAdd.Size = new System.Drawing.Size(81, 21);
            this.tbAddAdd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "替换文字";
            // 
            // tbSubAdd
            // 
            this.tbSubAdd.Location = new System.Drawing.Point(81, 190);
            this.tbSubAdd.Name = "tbSubAdd";
            this.tbSubAdd.Size = new System.Drawing.Size(81, 21);
            this.tbSubAdd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "添加位置";
            // 
            // tbAddLoc
            // 
            this.tbAddLoc.Location = new System.Drawing.Point(230, 119);
            this.tbAddLoc.Name = "tbAddLoc";
            this.tbAddLoc.Size = new System.Drawing.Size(81, 21);
            this.tbAddLoc.TabIndex = 10;
            this.tbAddLoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLoc_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "查找文字";
            // 
            // tbSubFind
            // 
            this.tbSubFind.Location = new System.Drawing.Point(230, 190);
            this.tbSubFind.Name = "tbSubFind";
            this.tbSubFind.Size = new System.Drawing.Size(81, 21);
            this.tbSubFind.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbTailLoc);
            this.groupBox1.Controls.Add(this.rbTail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbAdd);
            this.groupBox1.Controls.Add(this.tbSubFind);
            this.groupBox1.Controls.Add(this.rbSub);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbTailAdd);
            this.groupBox1.Controls.Add(this.tbAddLoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAddAdd);
            this.groupBox1.Controls.Add(this.tbSubAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 230);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "处理方式";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "添加位置";
            // 
            // tbTailLoc
            // 
            this.tbTailLoc.Location = new System.Drawing.Point(230, 52);
            this.tbTailLoc.Name = "tbTailLoc";
            this.tbTailLoc.Size = new System.Drawing.Size(81, 21);
            this.tbTailLoc.TabIndex = 14;
            this.tbTailLoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLoc_KeyPress);
            // 
            // FormSTextEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSTextEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "单行文字处理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.RadioButton rbTail;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbSub;
        private System.Windows.Forms.TextBox tbTailAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSubAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddLoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSubFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTailLoc;
    }
}