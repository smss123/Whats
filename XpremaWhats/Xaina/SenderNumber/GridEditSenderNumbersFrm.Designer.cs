namespace Xaina.SenderNumber
{
    partial class GridEditSenderNumbersFrm
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
            this.SenderNumberEditGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.StatusSerchlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.SenderNumberSearchlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.SenderNumbersSearchlayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.StatuslayoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumberEditGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusSerchlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumberSearchlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumbersSearchlayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatuslayoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // SenderNumberEditGridControl
            // 
            this.SenderNumberEditGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SenderNumberEditGridControl.Location = new System.Drawing.Point(0, 73);
            this.SenderNumberEditGridControl.MainView = this.gridView1;
            this.SenderNumberEditGridControl.Name = "SenderNumberEditGridControl";
            this.SenderNumberEditGridControl.Size = new System.Drawing.Size(851, 520);
            this.SenderNumberEditGridControl.TabIndex = 5;
            this.SenderNumberEditGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.SenderNumberEditGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(851, 73);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.StatusSerchlookUpEdit);
            this.layoutControl1.Controls.Add(this.SenderNumberSearchlookUpEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(847, 50);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // StatusSerchlookUpEdit
            // 
            this.StatusSerchlookUpEdit.Location = new System.Drawing.Point(586, 12);
            this.StatusSerchlookUpEdit.Name = "StatusSerchlookUpEdit";
            this.StatusSerchlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StatusSerchlookUpEdit.Size = new System.Drawing.Size(249, 20);
            this.StatusSerchlookUpEdit.StyleController = this.layoutControl1;
            this.StatusSerchlookUpEdit.TabIndex = 5;
            // 
            // SenderNumberSearchlookUpEdit
            // 
            this.SenderNumberSearchlookUpEdit.Location = new System.Drawing.Point(115, 12);
            this.SenderNumberSearchlookUpEdit.Name = "SenderNumberSearchlookUpEdit";
            this.SenderNumberSearchlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SenderNumberSearchlookUpEdit.Size = new System.Drawing.Size(364, 20);
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
            this.StatuslayoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(847, 50);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // SenderNumbersSearchlayoutControlItem
            // 
            this.SenderNumbersSearchlayoutControlItem.Control = this.SenderNumberSearchlookUpEdit;
            this.SenderNumbersSearchlayoutControlItem.CustomizationFormText = "SenderNumbersSearchlayoutControlItem";
            this.SenderNumbersSearchlayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.SenderNumbersSearchlayoutControlItem.Name = "SenderNumbersSearchlayoutControlItem";
            this.SenderNumbersSearchlayoutControlItem.Size = new System.Drawing.Size(471, 30);
            this.SenderNumbersSearchlayoutControlItem.Text = "Search By Numbers :";
            this.SenderNumbersSearchlayoutControlItem.TextSize = new System.Drawing.Size(100, 13);
            // 
            // StatuslayoutControlItem1
            // 
            this.StatuslayoutControlItem1.Control = this.StatusSerchlookUpEdit;
            this.StatuslayoutControlItem1.CustomizationFormText = "Search By Status:";
            this.StatuslayoutControlItem1.Location = new System.Drawing.Point(471, 0);
            this.StatuslayoutControlItem1.Name = "StatuslayoutControlItem1";
            this.StatuslayoutControlItem1.Size = new System.Drawing.Size(356, 30);
            this.StatuslayoutControlItem1.Text = "Search By Status:";
            this.StatuslayoutControlItem1.TextSize = new System.Drawing.Size(100, 13);
            // 
            // GridEditSenderNumbersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 593);
            this.Controls.Add(this.SenderNumberEditGridControl);
            this.Controls.Add(this.groupControl1);
            this.Name = "GridEditSenderNumbersFrm";
            this.Text = "GridEditSenderNumbersFrm";
            this.Load += new System.EventHandler(this.GridEditSenderNumbersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumberEditGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StatusSerchlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumberSearchlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumbersSearchlayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatuslayoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl SenderNumberEditGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit SenderNumberSearchlookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem SenderNumbersSearchlayoutControlItem;
        private DevExpress.XtraEditors.LookUpEdit StatusSerchlookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem StatuslayoutControlItem1;
    }
}