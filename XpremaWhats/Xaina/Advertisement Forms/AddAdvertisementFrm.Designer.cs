namespace Xaina.Advertisement_Forms
{
    partial class AddAdvertisementFrm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.CustomersLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.MessgTextrichTextBox = new System.Windows.Forms.RichTextBox();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.AddAdvertisementlayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.TitleAdvertisementayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator3 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator4 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.AddAdvertisementBtn = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAdvertisementlayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleAdvertisementayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.AddAdvertisementBtn);
            this.layoutControl1.Controls.Add(this.CustomersLookUpEdit);
            this.layoutControl1.Controls.Add(this.MessgTextrichTextBox);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.AddAdvertisementlayoutControlGroup;
            this.layoutControl1.Size = new System.Drawing.Size(755, 372);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CustomersLookUpEdit
            // 
            this.CustomersLookUpEdit.Location = new System.Drawing.Point(432, 14);
            this.CustomersLookUpEdit.Name = "CustomersLookUpEdit";
            this.CustomersLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomersLookUpEdit.Properties.DataSource = this.customersBindingSource;
            this.CustomersLookUpEdit.Properties.DisplayMember = "CustomerName";
            this.CustomersLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.CustomersLookUpEdit.Properties.ValueMember = "ID";
            this.CustomersLookUpEdit.Size = new System.Drawing.Size(307, 20);
            this.CustomersLookUpEdit.StyleController = this.layoutControl1;
            this.CustomersLookUpEdit.TabIndex = 10;
            // 
            // MessgTextrichTextBox
            // 
            this.MessgTextrichTextBox.Location = new System.Drawing.Point(112, 41);
            this.MessgTextrichTextBox.Name = "MessgTextrichTextBox";
            this.MessgTextrichTextBox.Size = new System.Drawing.Size(631, 293);
            this.MessgTextrichTextBox.TabIndex = 7;
            this.MessgTextrichTextBox.Text = "";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(112, 14);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(214, 20);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 4;
            // 
            // AddAdvertisementlayoutControlGroup
            // 
            this.AddAdvertisementlayoutControlGroup.CustomizationFormText = "Root";
            this.AddAdvertisementlayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.AddAdvertisementlayoutControlGroup.GroupBordersVisible = false;
            this.AddAdvertisementlayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.TitleAdvertisementayoutControlItem,
            this.simpleSeparator1,
            this.simpleSeparator2,
            this.simpleSeparator3,
            this.simpleSeparator4,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1});
            this.AddAdvertisementlayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.AddAdvertisementlayoutControlGroup.Name = "Root";
            this.AddAdvertisementlayoutControlGroup.Size = new System.Drawing.Size(755, 372);
            this.AddAdvertisementlayoutControlGroup.Text = "Root";
            this.AddAdvertisementlayoutControlGroup.TextVisible = false;
            // 
            // TitleAdvertisementayoutControlItem
            // 
            this.TitleAdvertisementayoutControlItem.Control = this.textEdit1;
            this.TitleAdvertisementayoutControlItem.CustomizationFormText = "Title Advertisement:";
            this.TitleAdvertisementayoutControlItem.Location = new System.Drawing.Point(0, 2);
            this.TitleAdvertisementayoutControlItem.MinSize = new System.Drawing.Size(155, 24);
            this.TitleAdvertisementayoutControlItem.Name = "TitleAdvertisementayoutControlItem";
            this.TitleAdvertisementayoutControlItem.Size = new System.Drawing.Size(318, 27);
            this.TitleAdvertisementayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.TitleAdvertisementayoutControlItem.Text = "Title Advertisement:";
            this.TitleAdvertisementayoutControlItem.TextSize = new System.Drawing.Size(97, 13);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 0);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(735, 2);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.CustomizationFormText = "simpleSeparator2";
            this.simpleSeparator2.Location = new System.Drawing.Point(731, 2);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(2, 27);
            this.simpleSeparator2.Text = "simpleSeparator2";
            // 
            // simpleSeparator3
            // 
            this.simpleSeparator3.AllowHotTrack = false;
            this.simpleSeparator3.CustomizationFormText = "simpleSeparator3";
            this.simpleSeparator3.Location = new System.Drawing.Point(318, 2);
            this.simpleSeparator3.Name = "simpleSeparator3";
            this.simpleSeparator3.Size = new System.Drawing.Size(2, 27);
            this.simpleSeparator3.Text = "simpleSeparator3";
            // 
            // simpleSeparator4
            // 
            this.simpleSeparator4.AllowHotTrack = false;
            this.simpleSeparator4.CustomizationFormText = "simpleSeparator4";
            this.simpleSeparator4.Location = new System.Drawing.Point(733, 2);
            this.simpleSeparator4.Name = "simpleSeparator4";
            this.simpleSeparator4.Size = new System.Drawing.Size(2, 27);
            this.simpleSeparator4.Text = "simpleSeparator4";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.MessgTextrichTextBox;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(735, 297);
            this.layoutControlItem3.Text = "Message Text:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(97, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.CustomersLookUpEdit;
            this.layoutControlItem4.CustomizationFormText = "Customers:";
            this.layoutControlItem4.Location = new System.Drawing.Point(320, 2);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(155, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(411, 27);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Customers:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(97, 13);
            // 
            // AddAdvertisementBtn
            // 
            this.AddAdvertisementBtn.Location = new System.Drawing.Point(12, 338);
            this.AddAdvertisementBtn.Name = "AddAdvertisementBtn";
            this.AddAdvertisementBtn.Size = new System.Drawing.Size(731, 22);
            this.AddAdvertisementBtn.StyleController = this.layoutControl1;
            this.AddAdvertisementBtn.TabIndex = 11;
            this.AddAdvertisementBtn.Text = "simpleButton1";
            this.AddAdvertisementBtn.Click += new System.EventHandler(this.AddAdvertisementBtn_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.AddAdvertisementBtn;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 326);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(735, 26);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = typeof(Xprema.Data.Xdb);
            // 
            // AddAdvertisementFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 372);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AddAdvertisementFrm";
            this.Text = "AddAdvertisementFrm";
            this.Load += new System.EventHandler(this.AddAdvertisementFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAdvertisementlayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleAdvertisementayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup AddAdvertisementlayoutControlGroup;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem TitleAdvertisementayoutControlItem;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraEditors.LookUpEdit CustomersLookUpEdit;
        private System.Windows.Forms.RichTextBox MessgTextrichTextBox;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator3;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton AddAdvertisementBtn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource customersBindingSource;
    }
}