namespace Xaina.NumberGroupsFroms
{
    partial class DeleteGroupsFrm
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
            this.GroupDeleteGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GroupSearchlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.GroupsSearchlayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.GroupDeleteGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupSearchlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsSearchlayoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupDeleteGridControl
            // 
            this.GroupDeleteGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupDeleteGridControl.Location = new System.Drawing.Point(0, 73);
            this.GroupDeleteGridControl.MainView = this.gridView1;
            this.GroupDeleteGridControl.Name = "GroupDeleteGridControl";
            this.GroupDeleteGridControl.Size = new System.Drawing.Size(790, 532);
            this.GroupDeleteGridControl.TabIndex = 3;
            this.GroupDeleteGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GroupDeleteGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(790, 73);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "groupControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GroupSearchlookUpEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(786, 50);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GroupSearchlookUpEdit
            // 
            this.GroupSearchlookUpEdit.Location = new System.Drawing.Point(129, 12);
            this.GroupSearchlookUpEdit.Name = "GroupSearchlookUpEdit";
            this.GroupSearchlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GroupSearchlookUpEdit.Size = new System.Drawing.Size(645, 20);
            this.GroupSearchlookUpEdit.StyleController = this.layoutControl1;
            this.GroupSearchlookUpEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.GroupsSearchlayoutControlItem});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(786, 50);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // GroupsSearchlayoutControlItem
            // 
            this.GroupsSearchlayoutControlItem.Control = this.GroupSearchlookUpEdit;
            this.GroupsSearchlayoutControlItem.CustomizationFormText = "GroupsSearchlayoutControlItem";
            this.GroupsSearchlayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.GroupsSearchlayoutControlItem.Name = "GroupsSearchlayoutControlItem";
            this.GroupsSearchlayoutControlItem.Size = new System.Drawing.Size(766, 30);
            this.GroupsSearchlayoutControlItem.Text = "Search By Group Name:";
            this.GroupsSearchlayoutControlItem.TextSize = new System.Drawing.Size(114, 13);
            // 
            // DeleteGroupsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 605);
            this.Controls.Add(this.GroupDeleteGridControl);
            this.Controls.Add(this.groupControl1);
            this.Name = "DeleteGroupsFrm";
            this.Text = "DeleteGroupsFrm";
            ((System.ComponentModel.ISupportInitialize)(this.GroupDeleteGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupSearchlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsSearchlayoutControlItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GroupDeleteGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit GroupSearchlookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem GroupsSearchlayoutControlItem;
    }
}