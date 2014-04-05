namespace Xaina.WhatsAppNumberForms
{
    partial class AddWhatsappNumbersfrm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.AddBtn = new DevExpress.XtraEditors.SimpleButton();
            this.CmbCountries = new DevExpress.XtraEditors.ComboBoxEdit();
            this.StatusBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.NameBox = new DevExpress.XtraEditors.TextEdit();
            this.PhoneBox = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.PhoneNumberlayoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.NamelayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.StatuslayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.ContrylayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator3 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator4 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator5 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator6 = new DevExpress.XtraLayout.SimpleSeparator();
            this.KeyBox = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CmbAllKeyes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCountries.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberlayoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamelayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatuslayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrylayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.KeyBox);
            this.layoutControl1.Controls.Add(this.AddBtn);
            this.layoutControl1.Controls.Add(this.CmbCountries);
            this.layoutControl1.Controls.Add(this.StatusBox);
            this.layoutControl1.Controls.Add(this.NameBox);
            this.layoutControl1.Controls.Add(this.PhoneBox);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.ForeColor = System.Drawing.Color.Red;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(569, 94, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(447, 268);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 182);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(423, 22);
            this.AddBtn.StyleController = this.layoutControl1;
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.WhatsAppNumberAddBtn_Click);
            // 
            // CmbCountries
            // 
            this.CmbCountries.Location = new System.Drawing.Point(12, 156);
            this.CmbCountries.Name = "CmbCountries";
            this.CmbCountries.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbCountries.Size = new System.Drawing.Size(423, 20);
            this.CmbCountries.StyleController = this.layoutControl1;
            this.CmbCountries.TabIndex = 8;
            this.CmbCountries.SelectedIndexChanged += new System.EventHandler(this.CmbCountries_SelectedIndexChanged);
            // 
            // StatusBox
            // 
            this.StatusBox.Location = new System.Drawing.Point(12, 114);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StatusBox.Size = new System.Drawing.Size(423, 20);
            this.StatusBox.StyleController = this.layoutControl1;
            this.StatusBox.TabIndex = 7;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 72);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(423, 20);
            this.NameBox.StyleController = this.layoutControl1;
            this.NameBox.TabIndex = 6;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(145, 28);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(290, 20);
            this.PhoneBox.StyleController = this.layoutControl1;
            this.PhoneBox.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.PhoneNumberlayoutControlItem1,
            this.NamelayoutControlItem,
            this.StatuslayoutControlItem,
            this.ContrylayoutControlItem,
            this.layoutControlItem6,
            this.simpleSeparator1,
            this.simpleSeparator2,
            this.simpleSeparator3,
            this.simpleSeparator4,
            this.simpleSeparator5,
            this.simpleSeparator6,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(447, 268);
            this.layoutControlGroup1.Text = "Root";
            // 
            // PhoneNumberlayoutControlItem1
            // 
            this.PhoneNumberlayoutControlItem1.Control = this.PhoneBox;
            this.PhoneNumberlayoutControlItem1.CustomizationFormText = "Phone Number:";
            this.PhoneNumberlayoutControlItem1.Location = new System.Drawing.Point(133, 0);
            this.PhoneNumberlayoutControlItem1.Name = "PhoneNumberlayoutControlItem1";
            this.PhoneNumberlayoutControlItem1.Size = new System.Drawing.Size(294, 40);
            this.PhoneNumberlayoutControlItem1.Text = "Phone Number:";
            this.PhoneNumberlayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.PhoneNumberlayoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
            // 
            // NamelayoutControlItem
            // 
            this.NamelayoutControlItem.Control = this.NameBox;
            this.NamelayoutControlItem.CustomizationFormText = "Name:";
            this.NamelayoutControlItem.Location = new System.Drawing.Point(0, 44);
            this.NamelayoutControlItem.Name = "NamelayoutControlItem";
            this.NamelayoutControlItem.Size = new System.Drawing.Size(427, 40);
            this.NamelayoutControlItem.Text = "Name:";
            this.NamelayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.NamelayoutControlItem.TextSize = new System.Drawing.Size(93, 13);
            // 
            // StatuslayoutControlItem
            // 
            this.StatuslayoutControlItem.Control = this.StatusBox;
            this.StatuslayoutControlItem.CustomizationFormText = "Status:";
            this.StatuslayoutControlItem.Location = new System.Drawing.Point(0, 86);
            this.StatuslayoutControlItem.Name = "StatuslayoutControlItem";
            this.StatuslayoutControlItem.Size = new System.Drawing.Size(427, 40);
            this.StatuslayoutControlItem.Text = "Status:";
            this.StatuslayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.StatuslayoutControlItem.TextSize = new System.Drawing.Size(93, 13);
            // 
            // ContrylayoutControlItem
            // 
            this.ContrylayoutControlItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.ContrylayoutControlItem.Control = this.CmbCountries;
            this.ContrylayoutControlItem.CustomizationFormText = "Contry:";
            this.ContrylayoutControlItem.Location = new System.Drawing.Point(0, 128);
            this.ContrylayoutControlItem.Name = "ContrylayoutControlItem";
            this.ContrylayoutControlItem.Size = new System.Drawing.Size(427, 40);
            this.ContrylayoutControlItem.Tag = "Contry";
            this.ContrylayoutControlItem.Text = "Contry:";
            this.ContrylayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.ContrylayoutControlItem.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.AddBtn;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 170);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(427, 78);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 40);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(427, 2);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.CustomizationFormText = "simpleSeparator2";
            this.simpleSeparator2.Location = new System.Drawing.Point(0, 42);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(427, 2);
            this.simpleSeparator2.Text = "simpleSeparator2";
            // 
            // simpleSeparator3
            // 
            this.simpleSeparator3.AllowHotTrack = false;
            this.simpleSeparator3.CustomizationFormText = "simpleSeparator3";
            this.simpleSeparator3.Location = new System.Drawing.Point(0, 84);
            this.simpleSeparator3.Name = "simpleSeparator3";
            this.simpleSeparator3.Size = new System.Drawing.Size(427, 2);
            this.simpleSeparator3.Text = "simpleSeparator3";
            // 
            // simpleSeparator4
            // 
            this.simpleSeparator4.AllowHotTrack = false;
            this.simpleSeparator4.CustomizationFormText = "simpleSeparator4";
            this.simpleSeparator4.Location = new System.Drawing.Point(0, 126);
            this.simpleSeparator4.Name = "simpleSeparator4";
            this.simpleSeparator4.Size = new System.Drawing.Size(427, 2);
            this.simpleSeparator4.Text = "simpleSeparator4";
            // 
            // simpleSeparator5
            // 
            this.simpleSeparator5.AllowHotTrack = false;
            this.simpleSeparator5.CustomizationFormText = "simpleSeparator5";
            this.simpleSeparator5.Location = new System.Drawing.Point(0, 168);
            this.simpleSeparator5.Name = "simpleSeparator5";
            this.simpleSeparator5.Size = new System.Drawing.Size(427, 2);
            this.simpleSeparator5.Text = "simpleSeparator5";
            // 
            // simpleSeparator6
            // 
            this.simpleSeparator6.AllowHotTrack = false;
            this.simpleSeparator6.CustomizationFormText = "simpleSeparator6";
            this.simpleSeparator6.Location = new System.Drawing.Point(0, 0);
            this.simpleSeparator6.Name = "simpleSeparator6";
            this.simpleSeparator6.Size = new System.Drawing.Size(3, 40);
            this.simpleSeparator6.Text = "simpleSeparator6";
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(15, 28);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(126, 20);
            this.KeyBox.StyleController = this.layoutControl1;
            this.KeyBox.TabIndex = 11;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.KeyBox;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(3, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(130, 40);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 13);
            // 
            // CmbAllKeyes
            // 
            this.CmbAllKeyes.FormattingEnabled = true;
            this.CmbAllKeyes.Location = new System.Drawing.Point(20, 274);
            this.CmbAllKeyes.Name = "CmbAllKeyes";
            this.CmbAllKeyes.Size = new System.Drawing.Size(214, 21);
            this.CmbAllKeyes.TabIndex = 1;
            this.CmbAllKeyes.Visible = false;
            // 
            // AddWhatsappNumbersfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 211);
            this.Controls.Add(this.CmbAllKeyes);
            this.Controls.Add(this.layoutControl1);
            this.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.Name = "AddWhatsappNumbersfrm";
            this.Text = "AddWhatsappNumbers";
            this.Load += new System.EventHandler(this.AddWhatsappNumbersfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CmbCountries.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberlayoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NamelayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatuslayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrylayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit PhoneBox;
        private DevExpress.XtraLayout.LayoutControlItem PhoneNumberlayoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton AddBtn;
        private DevExpress.XtraEditors.ComboBoxEdit CmbCountries;
        private DevExpress.XtraEditors.ComboBoxEdit StatusBox;
        private DevExpress.XtraEditors.TextEdit NameBox;
        private DevExpress.XtraLayout.LayoutControlItem NamelayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem StatuslayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem ContrylayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator3;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator4;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator5;
        private DevExpress.XtraEditors.TextEdit KeyBox;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.ComboBox CmbAllKeyes;
    }
}