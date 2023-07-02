
namespace Sernic
{
    partial class MainMDI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMDI));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MasterMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripItemmaster = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCityMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.TransactionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSale = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.batchMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shadeMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandMAsterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MasterMenu,
            this.TransactionMenu,
            this.ReportMenu,
            this.SettingMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1386, 35);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MasterMenu
            // 
            this.MasterMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemmaster,
            this.toolStripCityMaster,
            this.batchMasterToolStripMenuItem,
            this.gToolStripMenuItem,
            this.categoryMasterToolStripMenuItem,
            this.shadeMasterToolStripMenuItem,
            this.sizeMasterToolStripMenuItem,
            this.brandMAsterToolStripMenuItem,
            this.productMasterToolStripMenuItem,
            this.grToolStripMenuItem,
            this.transportMasterToolStripMenuItem,
            this.userMasterToolStripMenuItem,
            this.aToolStripMenuItem});
            this.MasterMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.MasterMenu.Name = "MasterMenu";
            this.MasterMenu.Size = new System.Drawing.Size(82, 29);
            this.MasterMenu.Text = "&Master";
            // 
            // toolStripItemmaster
            // 
            this.toolStripItemmaster.Name = "toolStripItemmaster";
            this.toolStripItemmaster.Size = new System.Drawing.Size(270, 34);
            this.toolStripItemmaster.Text = "Item Master";
            this.toolStripItemmaster.Click += new System.EventHandler(this.toolStripItemmaster_Click);
            // 
            // toolStripCityMaster
            // 
            this.toolStripCityMaster.Name = "toolStripCityMaster";
            this.toolStripCityMaster.Size = new System.Drawing.Size(270, 34);
            this.toolStripCityMaster.Text = "City Master";
            this.toolStripCityMaster.Click += new System.EventHandler(this.toolStripCityMaster_Click);
            // 
            // TransactionMenu
            // 
            this.TransactionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPurchase,
            this.toolStripSale});
            this.TransactionMenu.Name = "TransactionMenu";
            this.TransactionMenu.Size = new System.Drawing.Size(116, 29);
            this.TransactionMenu.Text = "&Transaction";
            // 
            // toolStripPurchase
            // 
            this.toolStripPurchase.Name = "toolStripPurchase";
            this.toolStripPurchase.Size = new System.Drawing.Size(184, 34);
            this.toolStripPurchase.Text = "Purchase";
            // 
            // toolStripSale
            // 
            this.toolStripSale.Name = "toolStripSale";
            this.toolStripSale.Size = new System.Drawing.Size(184, 34);
            this.toolStripSale.Text = "Sale";
            // 
            // ReportMenu
            // 
            this.ReportMenu.Name = "ReportMenu";
            this.ReportMenu.Size = new System.Drawing.Size(81, 29);
            this.ReportMenu.Text = "&Report";
            // 
            // SettingMenu
            // 
            this.SettingMenu.Name = "SettingMenu";
            this.SettingMenu.Size = new System.Drawing.Size(92, 29);
            this.SettingMenu.Text = "&Settings";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.printPreviewToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip.Location = new System.Drawing.Point(0, 37);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip.Size = new System.Drawing.Size(1386, 38);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            this.toolStrip.Visible = false;
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(34, 33);
            this.newToolStripButton.Text = "New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(34, 33);
            this.openToolStripButton.Text = "Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(34, 33);
            this.saveToolStripButton.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(34, 33);
            this.printToolStripButton.Text = "Print";
            // 
            // printPreviewToolStripButton
            // 
            this.printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripButton.Image")));
            this.printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new System.Drawing.Size(34, 33);
            this.printPreviewToolStripButton.Text = "Print Preview";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(34, 33);
            this.helpToolStripButton.Text = "Help";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 33);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 33);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 686);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1386, 32);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // batchMasterToolStripMenuItem
            // 
            this.batchMasterToolStripMenuItem.Name = "batchMasterToolStripMenuItem";
            this.batchMasterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.batchMasterToolStripMenuItem.Text = "Batch Master";
            this.batchMasterToolStripMenuItem.Click += new System.EventHandler(this.batchMasterToolStripMenuItem_Click);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.gToolStripMenuItem.Text = "Godown Master";
            // 
            // categoryMasterToolStripMenuItem
            // 
            this.categoryMasterToolStripMenuItem.Name = "categoryMasterToolStripMenuItem";
            this.categoryMasterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.categoryMasterToolStripMenuItem.Text = "Category Master";
            // 
            // shadeMasterToolStripMenuItem
            // 
            this.shadeMasterToolStripMenuItem.Name = "shadeMasterToolStripMenuItem";
            this.shadeMasterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.shadeMasterToolStripMenuItem.Text = "Shade Master";
            // 
            // sizeMasterToolStripMenuItem
            // 
            this.sizeMasterToolStripMenuItem.Name = "sizeMasterToolStripMenuItem";
            this.sizeMasterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sizeMasterToolStripMenuItem.Text = "Size Master";
            // 
            // brandMAsterToolStripMenuItem
            // 
            this.brandMAsterToolStripMenuItem.Name = "brandMAsterToolStripMenuItem";
            this.brandMAsterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.brandMAsterToolStripMenuItem.Text = "Brand Master";
            // 
            // productMasterToolStripMenuItem
            // 
            this.productMasterToolStripMenuItem.Name = "productMasterToolStripMenuItem";
            this.productMasterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.productMasterToolStripMenuItem.Text = "Product Master";
            // 
            // grToolStripMenuItem
            // 
            this.grToolStripMenuItem.Name = "grToolStripMenuItem";
            this.grToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.grToolStripMenuItem.Text = "Grade Master";
            // 
            // transportMasterToolStripMenuItem
            // 
            this.transportMasterToolStripMenuItem.Name = "transportMasterToolStripMenuItem";
            this.transportMasterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.transportMasterToolStripMenuItem.Text = "Transport Master";
            // 
            // userMasterToolStripMenuItem
            // 
            this.userMasterToolStripMenuItem.Name = "userMasterToolStripMenuItem";
            this.userMasterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.userMasterToolStripMenuItem.Text = "User Master";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aToolStripMenuItem.Text = "Area Master";
            // 
            // MainMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1386, 718);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMDI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem MasterMenu;
        private System.Windows.Forms.ToolStripMenuItem TransactionMenu;
        private System.Windows.Forms.ToolStripMenuItem ReportMenu;
        private System.Windows.Forms.ToolStripMenuItem SettingMenu;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemmaster;
        private System.Windows.Forms.ToolStripMenuItem toolStripCityMaster;
        private System.Windows.Forms.ToolStripMenuItem toolStripPurchase;
        private System.Windows.Forms.ToolStripMenuItem toolStripSale;
        private System.Windows.Forms.ToolStripMenuItem batchMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shadeMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandMAsterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
    }
}



