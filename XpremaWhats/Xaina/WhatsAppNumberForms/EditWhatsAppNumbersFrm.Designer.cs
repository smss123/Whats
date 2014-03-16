namespace Xaina.WhatsAppNumberForms
{
    partial class EditWhatsAppNumbersFrm
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
            this.SearchgroupControl = new DevExpress.XtraEditors.GroupControl();
            this.EditWhatsAppNumbersgridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.NumbersSearchtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NumbersSearchlayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.CountrySearchcomboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CountrySearchlayoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.StatusSearchcomboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator3 = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.SearchgroupControl)).BeginInit();
            this.SearchgroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditWhatsAppNumbersgridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumbersSearchtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumbersSearchlayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountrySearchcomboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountrySearchlayoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusSearchcomboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchgroupControl
            // 
            this.SearchgroupControl.Controls.Add(this.layoutControl1);
            this.SearchgroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchgroupControl.Location = new System.Drawing.Point(0, 0);
            this.SearchgroupControl.Name = "SearchgroupControl";
            this.SearchgroupControl.Size = new System.Drawing.Size(848, 77);
            this.SearchgroupControl.TabIndex = 0;
            this.SearchgroupControl.Text = "Shearch:";
            // 
            // EditWhatsAppNumbersgridControl
            // 
            this.EditWhatsAppNumbersgridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditWhatsAppNumbersgridControl.Location = new System.Drawing.Point(0, 77);
            this.EditWhatsAppNumbersgridControl.MainView = this.gridView1;
            this.EditWhatsAppNumbersgridControl.Name = "EditWhatsAppNumbersgridControl";
            this.EditWhatsAppNumbersgridControl.Size = new System.Drawing.Size(848, 380);
            this.EditWhatsAppNumbersgridControl.TabIndex = 1;
            this.EditWhatsAppNumbersgridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.EditWhatsAppNumbersgridControl;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.StatusSearchcomboBoxEdit);
            this.layoutControl1.Controls.Add(this.CountrySearchcomboBoxEdit);
            this.layoutControl1.Controls.Add(this.NumbersSearchtextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(844, 54);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.NumbersSearchlayoutControlItem,
            this.CountrySearchlayoutControlItem2,
            this.layoutControlItem3,
            this.simpleSeparator1,
            this.simpleSeparator2,
            this.simpleSeparator3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(844, 54);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // NumbersSearchtextEdit
            // 
            this.NumbersSearchtextEdit.Location = new System.Drawing.Point(110, 12);
            this.NumbersSearchtextEdit.Name = "NumbersSearchtextEdit";
            this.NumbersSearchtextEdit.Size = new System.Drawing.Size(222, 20);
            this.NumbersSearchtextEdit.StyleController = this.layoutControl1;
            this.NumbersSearchtextEdit.TabIndex = 4;
            // 
            // NumbersSearchlayoutControlItem
            // 
            this.NumbersSearchlayoutControlItem.Control = this.NumbersSearchtextEdit;
            this.NumbersSearchlayoutControlItem.CustomizationFormText = "search By Number:";
            this.NumbersSearchlayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.NumbersSearchlayoutControlItem.Name = "NumbersSearchlayoutControlItem";
            this.NumbersSearchlayoutControlItem.Size = new System.Drawing.Size(324, 34);
            this.NumbersSearchlayoutControlItem.Text = "search By Number:";
            this.NumbersSearchlayoutControlItem.TextSize = new System.Drawing.Size(94, 13);
            // 
            // CountrySearchcomboBoxEdit
            // 
            this.CountrySearchcomboBoxEdit.Location = new System.Drawing.Point(436, 12);
            this.CountrySearchcomboBoxEdit.Name = "CountrySearchcomboBoxEdit";
            this.CountrySearchcomboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CountrySearchcomboBoxEdit.Size = new System.Drawing.Size(153, 20);
            this.CountrySearchcomboBoxEdit.StyleController = this.layoutControl1;
            this.CountrySearchcomboBoxEdit.TabIndex = 5;
            // 
            // CountrySearchlayoutControlItem2
            // 
            this.CountrySearchlayoutControlItem2.Control = this.CountrySearchcomboBoxEdit;
            this.CountrySearchlayoutControlItem2.CustomizationFormText = "Search By Country:";
            this.CountrySearchlayoutControlItem2.Location = new System.Drawing.Point(326, 0);
            this.CountrySearchlayoutControlItem2.Name = "CountrySearchlayoutControlItem2";
            this.CountrySearchlayoutControlItem2.Size = new System.Drawing.Size(255, 34);
            this.CountrySearchlayoutControlItem2.Text = "Search By Country:";
            this.CountrySearchlayoutControlItem2.TextSize = new System.Drawing.Size(94, 13);
            // 
            // StatusSearchcomboBoxEdit
            // 
            this.StatusSearchcomboBoxEdit.Location = new System.Drawing.Point(693, 12);
            this.StatusSearchcomboBoxEdit.Name = "StatusSearchcomboBoxEdit";
            this.StatusSearchcomboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StatusSearchcomboBoxEdit.Size = new System.Drawing.Size(137, 20);
            this.StatusSearchcomboBoxEdit.StyleController = this.layoutControl1;
            this.StatusSearchcomboBoxEdit.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.StatusSearchcomboBoxEdit;
            this.layoutControlItem3.CustomizationFormText = "Shearch By Status:";
            this.layoutControlItem3.Location = new System.Drawing.Point(583, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(239, 34);
            this.layoutControlItem3.Text = "Shearch By Status:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(94, 13);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(324, 0);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(2, 34);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.CustomizationFormText = "simpleSeparator2";
            this.simpleSeparator2.Location = new System.Drawing.Point(581, 0);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(2, 34);
            this.simpleSeparator2.Text = "simpleSeparator2";
            // 
            // simpleSeparator3
            // 
            this.simpleSeparator3.AllowHotTrack = false;
            this.simpleSeparator3.CustomizationFormText = "simpleSeparator3";
            this.simpleSeparator3.Location = new System.Drawing.Point(822, 0);
            this.simpleSeparator3.Name = "simpleSeparator3";
            this.simpleSeparator3.Size = new System.Drawing.Size(2, 34);
            this.simpleSeparator3.Text = "simpleSeparator3";
            // 
            // EditWhatsAppNumbersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 457);
            this.Controls.Add(this.EditWhatsAppNumbersgridControl);
            this.Controls.Add(this.SearchgroupControl);
            this.Name = "EditWhatsAppNumbersFrm";
            this.Text = "EditWhatsAppNumbersFrm";
            ((System.ComponentModel.ISupportInitialize)(this.SearchgroupControl)).EndInit();
            this.SearchgroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditWhatsAppNumbersgridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumbersSearchtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumbersSearchlayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountrySearchcomboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountrySearchlayoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusSearchcomboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl SearchgroupControl;
        private DevExpress.XtraGrid.GridControl EditWhatsAppNumbersgridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit StatusSearchcomboBoxEdit;
        private DevExpress.XtraEditors.ComboBoxEdit CountrySearchcomboBoxEdit;
        private DevExpress.XtraEditors.TextEdit NumbersSearchtextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem NumbersSearchlayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem CountrySearchlayoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator3;
    }
}