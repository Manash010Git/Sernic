
namespace Sernic.Transactions
{
    partial class FrmOrderMaster
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
            this.BtnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnCancle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRefParty = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbGroup = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbllState = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.CmbBrand = new System.Windows.Forms.ComboBox();
            this.CmbSize = new System.Windows.Forms.ComboBox();
            this.CmbCateGory = new System.Windows.Forms.ComboBox();
            this.CmbState = new System.Windows.Forms.ComboBox();
            this.CmbProduct = new System.Windows.Forms.ComboBox();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CmbTrnsport = new System.Windows.Forms.ComboBox();
            this.CmbTax = new System.Windows.Forms.ComboBox();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.DtEntryDate = new System.Windows.Forms.DateTimePicker();
            this.DtBillDate = new System.Windows.Forms.DateTimePicker();
            this.txtPaty = new System.Windows.Forms.TextBox();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.txtTruckNo = new System.Windows.Forms.TextBox();
            this.txtpNo = new System.Windows.Forms.TextBox();
            this.txtPONo = new System.Windows.Forms.TextBox();
            this.txtSoldBy = new System.Windows.Forms.TextBox();
            this.txtLRNo = new System.Windows.Forms.TextBox();
            this.txtFreightNo = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Order_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESIGN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIZE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BATCH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SHADE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LOCATION = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BRAND = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1321, 838);
            this.panel1.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtnClear);
            this.panel5.Controls.Add(this.BtnShow);
            this.panel5.Controls.Add(this.BtnCancle);
            this.panel5.Controls.Add(this.BtnEdit);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(16, 750);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1305, 88);
            this.panel5.TabIndex = 3;
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
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 800);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1321, 38);
            this.panel2.TabIndex = 0;
            // 
            // lblRefParty
            // 
            this.lblRefParty.AutoSize = true;
            this.lblRefParty.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefParty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefParty.Location = new System.Drawing.Point(12, 48);
            this.lblRefParty.Name = "lblRefParty";
            this.lblRefParty.Size = new System.Drawing.Size(78, 21);
            this.lblRefParty.TabIndex = 18;
            this.lblRefParty.Text = "Customer";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLocation.Location = new System.Drawing.Point(12, 217);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(41, 21);
            this.lblLocation.TabIndex = 19;
            this.lblLocation.Text = "Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(324, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sold By";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(12, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(597, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Bill No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(597, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "LR No";
            // 
            // lbGroup
            // 
            this.lbGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGroup.AutoSize = true;
            this.lbGroup.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbGroup.Location = new System.Drawing.Point(324, 172);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(51, 21);
            this.lbGroup.TabIndex = 20;
            this.lbGroup.Text = "Brand";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(943, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "FreightNo";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(597, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 21);
            this.label13.TabIndex = 20;
            this.label13.Text = "Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(597, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Truck No";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(944, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 21);
            this.label14.TabIndex = 20;
            this.label14.Text = "Category";
            // 
            // lbllState
            // 
            this.lbllState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllState.AutoSize = true;
            this.lbllState.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbllState.Location = new System.Drawing.Point(12, 87);
            this.lbllState.Name = "lbllState";
            this.lbllState.Size = new System.Drawing.Size(45, 21);
            this.lbllState.TabIndex = 21;
            this.lbllState.Text = "State";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(943, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Po No";
            // 
            // lblCity
            // 
            this.lblCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCity.Location = new System.Drawing.Point(330, 86);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(37, 21);
            this.lblCity.TabIndex = 22;
            this.lblCity.Text = "City";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Order Type";
            // 
            // lblFromDate
            // 
            this.lblFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFromDate.Location = new System.Drawing.Point(12, 11);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(42, 21);
            this.lblFromDate.TabIndex = 23;
            this.lblFromDate.Text = "Date";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(597, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Trnasport";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(943, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tax";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(330, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Type";
            // 
            // lblToDate
            // 
            this.lblToDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToDate.Location = new System.Drawing.Point(943, 12);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(67, 21);
            this.lblToDate.TabIndex = 24;
            this.lblToDate.Text = "Bill Date";
            // 
            // CmbBrand
            // 
            this.CmbBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbBrand.FormattingEnabled = true;
            this.CmbBrand.Location = new System.Drawing.Point(391, 164);
            this.CmbBrand.Name = "CmbBrand";
            this.CmbBrand.Size = new System.Drawing.Size(200, 28);
            this.CmbBrand.TabIndex = 27;
            // 
            // CmbSize
            // 
            this.CmbSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbSize.FormattingEnabled = true;
            this.CmbSize.Location = new System.Drawing.Point(681, 162);
            this.CmbSize.Name = "CmbSize";
            this.CmbSize.Size = new System.Drawing.Size(247, 28);
            this.CmbSize.TabIndex = 27;
            // 
            // CmbCateGory
            // 
            this.CmbCateGory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbCateGory.FormattingEnabled = true;
            this.CmbCateGory.Location = new System.Drawing.Point(1028, 164);
            this.CmbCateGory.Name = "CmbCateGory";
            this.CmbCateGory.Size = new System.Drawing.Size(247, 28);
            this.CmbCateGory.TabIndex = 27;
            // 
            // CmbState
            // 
            this.CmbState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbState.FormattingEnabled = true;
            this.CmbState.Location = new System.Drawing.Point(116, 86);
            this.CmbState.Name = "CmbState";
            this.CmbState.Size = new System.Drawing.Size(200, 28);
            this.CmbState.TabIndex = 28;
            // 
            // CmbProduct
            // 
            this.CmbProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbProduct.FormattingEnabled = true;
            this.CmbProduct.Location = new System.Drawing.Point(116, 168);
            this.CmbProduct.Name = "CmbProduct";
            this.CmbProduct.Size = new System.Drawing.Size(200, 28);
            this.CmbProduct.TabIndex = 27;
            // 
            // CmbCity
            // 
            this.CmbCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(390, 84);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(200, 28);
            this.CmbCity.TabIndex = 29;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 28;
            // 
            // CmbTrnsport
            // 
            this.CmbTrnsport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbTrnsport.FormattingEnabled = true;
            this.CmbTrnsport.Location = new System.Drawing.Point(681, 84);
            this.CmbTrnsport.Name = "CmbTrnsport";
            this.CmbTrnsport.Size = new System.Drawing.Size(247, 28);
            this.CmbTrnsport.TabIndex = 29;
            // 
            // CmbTax
            // 
            this.CmbTax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbTax.FormattingEnabled = true;
            this.CmbTax.Location = new System.Drawing.Point(1028, 84);
            this.CmbTax.Name = "CmbTax";
            this.CmbTax.Size = new System.Drawing.Size(247, 28);
            this.CmbTax.TabIndex = 29;
            // 
            // CmbType
            // 
            this.CmbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "Entry"});
            this.CmbType.Location = new System.Drawing.Point(390, 8);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(200, 28);
            this.CmbType.TabIndex = 29;
            // 
            // DtEntryDate
            // 
            this.DtEntryDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DtEntryDate.Location = new System.Drawing.Point(116, 7);
            this.DtEntryDate.Name = "DtEntryDate";
            this.DtEntryDate.Size = new System.Drawing.Size(200, 26);
            this.DtEntryDate.TabIndex = 30;
            // 
            // DtBillDate
            // 
            this.DtBillDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DtBillDate.Location = new System.Drawing.Point(1028, 11);
            this.DtBillDate.Name = "DtBillDate";
            this.DtBillDate.Size = new System.Drawing.Size(247, 26);
            this.DtBillDate.TabIndex = 31;
            // 
            // txtPaty
            // 
            this.txtPaty.Location = new System.Drawing.Point(116, 47);
            this.txtPaty.Name = "txtPaty";
            this.txtPaty.Size = new System.Drawing.Size(474, 26);
            this.txtPaty.TabIndex = 32;
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(681, 8);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(247, 26);
            this.txtBillNo.TabIndex = 32;
            // 
            // txtTruckNo
            // 
            this.txtTruckNo.Location = new System.Drawing.Point(681, 46);
            this.txtTruckNo.Name = "txtTruckNo";
            this.txtTruckNo.Size = new System.Drawing.Size(247, 26);
            this.txtTruckNo.TabIndex = 32;
            // 
            // txtpNo
            // 
            this.txtpNo.Location = new System.Drawing.Point(1028, 46);
            this.txtpNo.Name = "txtpNo";
            this.txtpNo.Size = new System.Drawing.Size(247, 26);
            this.txtpNo.TabIndex = 32;
            // 
            // txtPONo
            // 
            this.txtPONo.Location = new System.Drawing.Point(1393, -56);
            this.txtPONo.Name = "txtPONo";
            this.txtPONo.Size = new System.Drawing.Size(247, 26);
            this.txtPONo.TabIndex = 32;
            // 
            // txtSoldBy
            // 
            this.txtSoldBy.Location = new System.Drawing.Point(391, 125);
            this.txtSoldBy.Name = "txtSoldBy";
            this.txtSoldBy.Size = new System.Drawing.Size(199, 26);
            this.txtSoldBy.TabIndex = 32;
            // 
            // txtLRNo
            // 
            this.txtLRNo.Location = new System.Drawing.Point(681, 124);
            this.txtLRNo.Name = "txtLRNo";
            this.txtLRNo.Size = new System.Drawing.Size(247, 26);
            this.txtLRNo.TabIndex = 32;
            // 
            // txtFreightNo
            // 
            this.txtFreightNo.Location = new System.Drawing.Point(1028, 124);
            this.txtFreightNo.Name = "txtFreightNo";
            this.txtFreightNo.Size = new System.Drawing.Size(247, 26);
            this.txtFreightNo.TabIndex = 32;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(116, 213);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(200, 26);
            this.txtItem.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.txtPONo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(16, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1305, 800);
            this.panel4.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_No,
            this.DESIGN,
            this.SIZE,
            this.BATCH,
            this.SHADE,
            this.LOCATION,
            this.BRAND,
            this.PCS,
            this.BOX});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1305, 258);
            this.dataGridView1.TabIndex = 33;
            // 
            // Order_No
            // 
            this.Order_No.HeaderText = "Order No";
            this.Order_No.MinimumWidth = 8;
            this.Order_No.Name = "Order_No";
            this.Order_No.ReadOnly = true;
            this.Order_No.Width = 150;
            // 
            // DESIGN
            // 
            this.DESIGN.HeaderText = "Design";
            this.DESIGN.MinimumWidth = 8;
            this.DESIGN.Name = "DESIGN";
            this.DESIGN.ReadOnly = true;
            this.DESIGN.Width = 150;
            // 
            // SIZE
            // 
            this.SIZE.HeaderText = "Size";
            this.SIZE.MinimumWidth = 8;
            this.SIZE.Name = "SIZE";
            this.SIZE.ReadOnly = true;
            this.SIZE.Width = 150;
            // 
            // BATCH
            // 
            this.BATCH.HeaderText = "Batch";
            this.BATCH.MinimumWidth = 8;
            this.BATCH.Name = "BATCH";
            this.BATCH.ReadOnly = true;
            this.BATCH.Width = 150;
            // 
            // SHADE
            // 
            this.SHADE.HeaderText = "Shade";
            this.SHADE.MinimumWidth = 8;
            this.SHADE.Name = "SHADE";
            this.SHADE.ReadOnly = true;
            this.SHADE.Width = 150;
            // 
            // LOCATION
            // 
            this.LOCATION.HeaderText = "Location";
            this.LOCATION.MinimumWidth = 8;
            this.LOCATION.Name = "LOCATION";
            this.LOCATION.ReadOnly = true;
            this.LOCATION.Width = 150;
            // 
            // BRAND
            // 
            this.BRAND.HeaderText = "Brand";
            this.BRAND.MinimumWidth = 8;
            this.BRAND.Name = "BRAND";
            this.BRAND.ReadOnly = true;
            this.BRAND.Width = 150;
            // 
            // PCS
            // 
            this.PCS.HeaderText = "Pcs";
            this.PCS.MinimumWidth = 8;
            this.PCS.Name = "PCS";
            this.PCS.ReadOnly = true;
            this.PCS.Width = 150;
            // 
            // BOX
            // 
            this.BOX.HeaderText = "Box";
            this.BOX.MinimumWidth = 8;
            this.BOX.Name = "BOX";
            this.BOX.ReadOnly = true;
            this.BOX.Width = 150;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.CmbBrand);
            this.panel6.Controls.Add(this.lblRefParty);
            this.panel6.Controls.Add(this.txtItem);
            this.panel6.Controls.Add(this.lblLocation);
            this.panel6.Controls.Add(this.txtFreightNo);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.txtLRNo);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.txtSoldBy);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.txtpNo);
            this.panel6.Controls.Add(this.lbGroup);
            this.panel6.Controls.Add(this.txtTruckNo);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.txtBillNo);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.txtPaty);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.DtBillDate);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.DtEntryDate);
            this.panel6.Controls.Add(this.lbllState);
            this.panel6.Controls.Add(this.CmbType);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.CmbTax);
            this.panel6.Controls.Add(this.lblCity);
            this.panel6.Controls.Add(this.CmbTrnsport);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Controls.Add(this.lblFromDate);
            this.panel6.Controls.Add(this.CmbCity);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.CmbProduct);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.CmbState);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.CmbCateGory);
            this.panel6.Controls.Add(this.lblToDate);
            this.panel6.Controls.Add(this.CmbSize);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1305, 242);
            this.panel6.TabIndex = 34;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 242);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1305, 258);
            this.panel7.TabIndex = 35;
            // 
            // FrmOrderMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 838);
            this.Controls.Add(this.panel1);
            this.Name = "FrmOrderMaster";
            this.Text = "FrmOrderMaster";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnCancle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtFreightNo;
        private System.Windows.Forms.TextBox txtLRNo;
        private System.Windows.Forms.TextBox txtSoldBy;
        private System.Windows.Forms.TextBox txtPONo;
        private System.Windows.Forms.TextBox txtpNo;
        private System.Windows.Forms.TextBox txtTruckNo;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.TextBox txtPaty;
        private System.Windows.Forms.DateTimePicker DtBillDate;
        private System.Windows.Forms.DateTimePicker DtEntryDate;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.ComboBox CmbTax;
        private System.Windows.Forms.ComboBox CmbTrnsport;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.ComboBox CmbProduct;
        private System.Windows.Forms.ComboBox CmbState;
        private System.Windows.Forms.ComboBox CmbCateGory;
        private System.Windows.Forms.ComboBox CmbSize;
        private System.Windows.Forms.ComboBox CmbBrand;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbllState;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbGroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblRefParty;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESIGN;
        private System.Windows.Forms.DataGridViewComboBoxColumn SIZE;
        private System.Windows.Forms.DataGridViewComboBoxColumn BATCH;
        private System.Windows.Forms.DataGridViewComboBoxColumn SHADE;
        private System.Windows.Forms.DataGridViewComboBoxColumn LOCATION;
        private System.Windows.Forms.DataGridViewComboBoxColumn BRAND;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOX;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
    }
}