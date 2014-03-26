namespace Xaina.Advertisement_Forms
{
    partial class deleteAdvertisementFrm
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
            this.AdvertisemenEditgridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.SearchDateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SelectDateTodateEdit = new DevExpress.XtraEditors.DateEdit();
            this.SelectDateFromedateEdit = new DevExpress.XtraEditors.DateEdit();
            this.SelectCustomerlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.SelectTitletextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.AdvertisemenEditgridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDateTodateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDateTodateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDateFromedateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDateFromedateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectCustomerlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectTitletextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // AdvertisemenEditgridControl
            // 
            this.AdvertisemenEditgridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvertisemenEditgridControl.Location = new System.Drawing.Point(0, 98);
            this.AdvertisemenEditgridControl.MainView = this.gridView1;
            this.AdvertisemenEditgridControl.Name = "AdvertisemenEditgridControl";
            this.AdvertisemenEditgridControl.Size = new System.Drawing.Size(917, 482);
            this.AdvertisemenEditgridControl.TabIndex = 3;
            this.AdvertisemenEditgridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.AdvertisemenEditgridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(917, 98);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "groupControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.SearchDateBtn);
            this.layoutControl1.Controls.Add(this.SelectDateTodateEdit);
            this.layoutControl1.Controls.Add(this.SelectDateFromedateEdit);
            this.layoutControl1.Controls.Add(this.SelectCustomerlookUpEdit);
            this.layoutControl1.Controls.Add(this.SelectTitletextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(913, 75);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // SearchDateBtn
            // 
            this.SearchDateBtn.Location = new System.Drawing.Point(706, 36);
            this.SearchDateBtn.Name = "SearchDateBtn";
            this.SearchDateBtn.Size = new System.Drawing.Size(195, 22);
            this.SearchDateBtn.StyleController = this.layoutControl1;
            this.SearchDateBtn.TabIndex = 9;
            this.SearchDateBtn.Text = "Search By date";
            this.SearchDateBtn.Click += new System.EventHandler(this.SearchDateBtn_Click);
            // 
            // SelectDateTodateEdit
            // 
            this.SelectDateTodateEdit.EditValue = null;
            this.SelectDateTodateEdit.Location = new System.Drawing.Point(457, 36);
            this.SelectDateTodateEdit.Name = "SelectDateTodateEdit";
            this.SelectDateTodateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SelectDateTodateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SelectDateTodateEdit.Size = new System.Drawing.Size(245, 20);
            this.SelectDateTodateEdit.StyleController = this.layoutControl1;
            this.SelectDateTodateEdit.TabIndex = 8;
            // 
            // SelectDateFromedateEdit
            // 
            this.SelectDateFromedateEdit.EditValue = null;
            this.SelectDateFromedateEdit.Location = new System.Drawing.Point(97, 36);
            this.SelectDateFromedateEdit.Name = "SelectDateFromedateEdit";
            this.SelectDateFromedateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SelectDateFromedateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SelectDateFromedateEdit.Size = new System.Drawing.Size(271, 20);
            this.SelectDateFromedateEdit.StyleController = this.layoutControl1;
            this.SelectDateFromedateEdit.TabIndex = 7;
            // 
            // SelectCustomerlookUpEdit
            // 
            this.SelectCustomerlookUpEdit.Location = new System.Drawing.Point(457, 12);
            this.SelectCustomerlookUpEdit.Name = "SelectCustomerlookUpEdit";
            this.SelectCustomerlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SelectCustomerlookUpEdit.Size = new System.Drawing.Size(444, 20);
            this.SelectCustomerlookUpEdit.StyleController = this.layoutControl1;
            this.SelectCustomerlookUpEdit.TabIndex = 6;
            // 
            // SelectTitletextEdit
            // 
            this.SelectTitletextEdit.Location = new System.Drawing.Point(97, 12);
            this.SelectTitletextEdit.Name = "SelectTitletextEdit";
            this.SelectTitletextEdit.Size = new System.Drawing.Size(271, 20);
            this.SelectTitletextEdit.StyleController = this.layoutControl1;
            this.SelectTitletextEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(913, 75);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.SelectTitletextEdit;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(360, 24);
            this.layoutControlItem1.Text = "Select Title:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.SelectCustomerlookUpEdit;
            this.layoutControlItem3.CustomizationFormText = "Customers:";
            this.layoutControlItem3.Location = new System.Drawing.Point(360, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(533, 24);
            this.layoutControlItem3.Text = "Select Customer:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.SelectDateFromedateEdit;
            this.layoutControlItem2.CustomizationFormText = "From";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(360, 31);
            this.layoutControlItem2.Text = "From";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.SelectDateTodateEdit;
            this.layoutControlItem4.CustomizationFormText = "to";
            this.layoutControlItem4.Location = new System.Drawing.Point(360, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(334, 31);
            this.layoutControlItem4.Text = "to";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(82, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.SearchDateBtn;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(694, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(199, 31);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // deleteAdvertisementFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 580);
            this.Controls.Add(this.AdvertisemenEditgridControl);
            this.Controls.Add(this.groupControl1);
            this.Name = "deleteAdvertisementFrm";
            this.Text = "deleteAdvertisementFrm";
            ((System.ComponentModel.ISupportInitialize)(this.AdvertisemenEditgridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectDateTodateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDateTodateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDateFromedateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDateFromedateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectCustomerlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectTitletextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl AdvertisemenEditgridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton SearchDateBtn;
        private DevExpress.XtraEditors.DateEdit SelectDateTodateEdit;
        private DevExpress.XtraEditors.DateEdit SelectDateFromedateEdit;
        private DevExpress.XtraEditors.LookUpEdit SelectCustomerlookUpEdit;
        private DevExpress.XtraEditors.TextEdit SelectTitletextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}