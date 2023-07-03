
namespace Sernic.Masters
{
    partial class FrmTransTypeMaster
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTransTypeCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTransTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnCancle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTransType = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTransType);
            this.panel4.Controls.Add(this.txtTransTypeCode);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtTransTypeName);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(45, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(755, 324);
            this.panel4.TabIndex = 2;
            // 
            // txtTransTypeCode
            // 
            this.txtTransTypeCode.Enabled = false;
            this.txtTransTypeCode.Location = new System.Drawing.Point(19, 85);
            this.txtTransTypeCode.Name = "txtTransTypeCode";
            this.txtTransTypeCode.Size = new System.Drawing.Size(651, 26);
            this.txtTransTypeCode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "TransType Code";
            // 
            // txtTransTypeName
            // 
            this.txtTransTypeName.Location = new System.Drawing.Point(19, 153);
            this.txtTransTypeName.Name = "txtTransTypeName";
            this.txtTransTypeName.Size = new System.Drawing.Size(651, 26);
            this.txtTransTypeName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TransType Name";
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(474, 21);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(113, 46);
            this.BtnClear.TabIndex = 11;
            this.BtnClear.Text = "&Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(19, 20);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(113, 46);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "&Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtnClear);
            this.panel5.Controls.Add(this.BtnShow);
            this.panel5.Controls.Add(this.BtnCancle);
            this.panel5.Controls.Add(this.BtnEdit);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(45, 362);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(755, 88);
            this.panel5.TabIndex = 3;
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnShow.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShow.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShow.Location = new System.Drawing.Point(321, 21);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(113, 46);
            this.BtnShow.TabIndex = 10;
            this.BtnShow.Text = "&Show";
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnCancle
            // 
            this.BtnCancle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCancle.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancle.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancle.Location = new System.Drawing.Point(163, 20);
            this.BtnCancle.Name = "BtnCancle";
            this.BtnCancle.Size = new System.Drawing.Size(113, 46);
            this.BtnCancle.TabIndex = 4;
            this.BtnCancle.Text = "&Delete";
            this.BtnCancle.UseVisualStyleBackColor = false;
            this.BtnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(45, 412);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 38);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "TransType";
            // 
            // txtTransType
            // 
            this.txtTransType.Enabled = false;
            this.txtTransType.Location = new System.Drawing.Point(19, 214);
            this.txtTransType.Name = "txtTransType";
            this.txtTransType.Size = new System.Drawing.Size(651, 26);
            this.txtTransType.TabIndex = 3;
            // 
            // FrmTransTypeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTransTypeMaster";
            this.Text = "FrmTransTypeMaster";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTransTypeCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTransTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnCancle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTransType;
        private System.Windows.Forms.Label label4;
    }
}