
namespace Sernic.Transactions
{
    partial class FrmSales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbldate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.lbltype = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblBillno = new System.Windows.Forms.Label();
            this.txtBillno = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBillno);
            this.panel1.Controls.Add(this.lblBillno);
            this.panel1.Controls.Add(this.cbType);
            this.panel1.Controls.Add(this.lbltype);
            this.panel1.Controls.Add(this.dtdate);
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 491);
            this.panel1.TabIndex = 0;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(138, 58);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(30, 13);
            this.lbldate.TabIndex = 0;
            this.lbldate.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnExit);
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Controls.Add(this.BtnNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 32);
            this.panel2.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(255, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "&Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(174, 5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(93, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "&SAVE";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            this.BtnNew.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Location = new System.Drawing.Point(12, 5);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "&NEW";
            this.BtnNew.UseVisualStyleBackColor = true;
            // 
            // dtdate
            // 
            this.dtdate.Location = new System.Drawing.Point(204, 58);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(200, 20);
            this.dtdate.TabIndex = 1;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(420, 64);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(31, 13);
            this.lbltype.TabIndex = 2;
            this.lbltype.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(470, 64);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 3;
            // 
            // lblBillno
            // 
            this.lblBillno.AutoSize = true;
            this.lblBillno.Location = new System.Drawing.Point(597, 67);
            this.lblBillno.Name = "lblBillno";
            this.lblBillno.Size = new System.Drawing.Size(35, 13);
            this.lblBillno.TabIndex = 4;
            this.lblBillno.Text = "Bill no";
            // 
            // txtBillno
            // 
            this.txtBillno.Location = new System.Drawing.Point(630, 64);
            this.txtBillno.Name = "txtBillno";
            this.txtBillno.Size = new System.Drawing.Size(118, 20);
            this.txtBillno.TabIndex = 5;
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmSales";
            this.ShowIcon = false;
            this.Text = "Less Stock Entry";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button BtnExit;
        public System.Windows.Forms.Button BtnDelete;
        public System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox txtBillno;
        private System.Windows.Forms.Label lblBillno;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.DateTimePicker dtdate;
    }
}