namespace Xaina.SenderNumber
{
    partial class DeleteSenderNumbersFrm
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
            this.SenderNumberDeleteGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.SenderNumberSearchlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.SenderNumbersSearchlayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.StatusSerchlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.StatuslayoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumberDeleteGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumberSearchlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumbersSearchlayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusSerchlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatuslayoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            this.SuspendLayout();
            // 
            // SenderNumberDeleteGridControl
            // 
            this.SenderNumberDeleteGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SenderNumberDeleteGridControl.Location = new System.Drawing.Point(0, 73);
            this.SenderNumberDeleteGridControl.MainView = this.gridView1;
            this.SenderNumberDeleteGridControl.Name = "SenderNumberDeleteGridControl";
            this.SenderNumberDeleteGridControl.Size = new System.Drawing.Size(816, 513);
            this.SenderNumberDeleteGridControl.TabIndex = 7;
            this.SenderNumberDeleteGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.SenderNumberDeleteGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(816, 73);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "groupControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.StatusSerchlookUpEdit);
            this.layoutControl1.Controls.Add(this.SenderNumberSearchlookUpEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(239, 218, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(812, 50);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // SenderNumberSearchlookUpEdit
            // 
            this.SenderNumberSearchlookUpEdit.Location = new System.Drawing.Point(115, 12);
            this.SenderNumberSearchlookUpEdit.Name = "SenderNumberSearchlookUpEdit";
            this.SenderNumberSearchlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SenderNumberSearchlookUpEdit.Size = new System.Drawing.Size(328, 20);
            this.SenderNumberSearchlookUpEdit.StyleController = this.layoutControl1;
            this.SenderNumberSearchlookUpEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.SenderNumbersSearchlayoutControlItem,
            this.StatuslayoutControlItem1,
            this.simpleSeparator1,
            this.simpleSeparator2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(812, 50);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // SenderNumbersSearchlayoutControlItem
            // 
            this.SenderNumbersSearchlayoutControlItem.Control = this.SenderNumberSearchlookUpEdit;
            this.SenderNumbersSearchlayoutControlItem.CustomizationFormText = "SenderNumbersSearchlayoutControlItem";
            this.SenderNumbersSearchlayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.SenderNumbersSearchlayoutControlItem.Name = "SenderNumbersSearchlayoutControlItem";
            this.SenderNumbersSearchlayoutControlItem.Size = new System.Drawing.Size(435, 30);
            this.SenderNumbersSearchlayoutControlItem.Text = "Search By Numbers :";
            this.SenderNumbersSearchlayoutControlItem.TextSize = new System.Drawing.Size(100, 13);
            // 
            // StatusSerchlookUpEdit
            // 
            this.StatusSerchlookUpEdit.Location = new System.Drawing.Point(552, 12);
            this.StatusSerchlookUpEdit.Name = "StatusSerchlookUpEdit";
            this.StatusSerchlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StatusSerchlookUpEdit.Size = new System.Drawing.Size(246, 20);
            this.StatusSerchlookUpEdit.StyleController = this.layoutControl1;
            this.StatusSerchlookUpEdit.TabIndex = 5;
            // 
            // StatuslayoutControlItem1
            // 
            this.StatuslayoutControlItem1.Control = this.StatusSerchlookUpEdit;
            this.StatuslayoutControlItem1.CustomizationFormText = "Search by Status:";
            this.StatuslayoutControlItem1.Location = new System.Drawing.Point(437, 0);
            this.StatuslayoutControlItem1.Name = "StatuslayoutControlItem1";
            this.StatuslayoutControlItem1.Size = new System.Drawing.Size(353, 30);
            this.StatuslayoutControlItem1.Text = "Search by Status:";
            this.StatuslayoutControlItem1.TextSize = new System.Drawing.Size(100, 13);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(435, 0);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(2, 30);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.CustomizationFormText = "simpleSeparator2";
            this.simpleSeparator2.Location = new System.Drawing.Point(790, 0);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(2, 30);
            this.simpleSeparator2.Text = "simpleSeparator2";
            // 
            // DeleteSenderNumbersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 586);
            this.Controls.Add(this.SenderNumberDeleteGridControl);
            this.Controls.Add(this.groupControl1);
            this.Name = "DeleteSenderNumbersFrm";
            this.Text = "DeleteSenderNumbersFrm";
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumberDeleteGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumberSearchlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumbersSearchlayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusSerchlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatuslayoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl SenderNumberDeleteGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit SenderNumberSearchlookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem SenderNumbersSearchlayoutControlItem;
        private DevExpress.XtraEditors.LookUpEdit StatusSerchlookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem StatuslayoutControlItem1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
    }
}