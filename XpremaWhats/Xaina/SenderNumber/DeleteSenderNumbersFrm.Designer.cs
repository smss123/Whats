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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteSenderNumbersFrm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.StatusSerchlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.SenderNumberSearchlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.SenderNumbersSearchlayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.StatuslayoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xdb = new Xprema.Data.Xdb();
            this.senderNumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senderNumberBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.senderNumberBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.senderNumberGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusSerchlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumberSearchlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumbersSearchlayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatuslayoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senderNumberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senderNumberBindingNavigator)).BeginInit();
            this.senderNumberBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.senderNumberGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(952, 73);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "groupControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.StatusSerchlookUpEdit);
            this.layoutControl1.Controls.Add(this.SenderNumberSearchlookUpEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(239, 218, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(948, 50);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(856, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(78, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // StatusSerchlookUpEdit
            // 
            this.StatusSerchlookUpEdit.Location = new System.Drawing.Point(627, 12);
            this.StatusSerchlookUpEdit.Name = "StatusSerchlookUpEdit";
            this.StatusSerchlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StatusSerchlookUpEdit.Size = new System.Drawing.Size(225, 20);
            this.StatusSerchlookUpEdit.StyleController = this.layoutControl1;
            this.StatusSerchlookUpEdit.TabIndex = 5;
            // 
            // SenderNumberSearchlookUpEdit
            // 
            this.SenderNumberSearchlookUpEdit.Location = new System.Drawing.Point(115, 12);
            this.SenderNumberSearchlookUpEdit.Name = "SenderNumberSearchlookUpEdit";
            this.SenderNumberSearchlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SenderNumberSearchlookUpEdit.Size = new System.Drawing.Size(403, 20);
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
            this.simpleSeparator2,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(948, 50);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // SenderNumbersSearchlayoutControlItem
            // 
            this.SenderNumbersSearchlayoutControlItem.Control = this.SenderNumberSearchlookUpEdit;
            this.SenderNumbersSearchlayoutControlItem.CustomizationFormText = "SenderNumbersSearchlayoutControlItem";
            this.SenderNumbersSearchlayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.SenderNumbersSearchlayoutControlItem.Name = "SenderNumbersSearchlayoutControlItem";
            this.SenderNumbersSearchlayoutControlItem.Size = new System.Drawing.Size(510, 30);
            this.SenderNumbersSearchlayoutControlItem.Text = "Search By Numbers :";
            this.SenderNumbersSearchlayoutControlItem.TextSize = new System.Drawing.Size(100, 13);
            // 
            // StatuslayoutControlItem1
            // 
            this.StatuslayoutControlItem1.Control = this.StatusSerchlookUpEdit;
            this.StatuslayoutControlItem1.CustomizationFormText = "Search by Status:";
            this.StatuslayoutControlItem1.Location = new System.Drawing.Point(512, 0);
            this.StatuslayoutControlItem1.Name = "StatuslayoutControlItem1";
            this.StatuslayoutControlItem1.Size = new System.Drawing.Size(332, 30);
            this.StatuslayoutControlItem1.Text = "Search by Status:";
            this.StatuslayoutControlItem1.TextSize = new System.Drawing.Size(100, 13);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(510, 0);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(2, 30);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.CustomizationFormText = "simpleSeparator2";
            this.simpleSeparator2.Location = new System.Drawing.Point(926, 0);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(2, 30);
            this.simpleSeparator2.Text = "simpleSeparator2";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(844, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(82, 30);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // xdb
            // 
            this.xdb.DataSetName = "Xdb";
            this.xdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // senderNumberBindingSource
            // 
            this.senderNumberBindingSource.DataMember = "SenderNumber";
            this.senderNumberBindingSource.DataSource = this.xdb;
            // 
            // senderNumberBindingNavigator
            // 
            this.senderNumberBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.senderNumberBindingNavigator.BindingSource = this.senderNumberBindingSource;
            this.senderNumberBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.senderNumberBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.senderNumberBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.senderNumberBindingNavigatorSaveItem});
            this.senderNumberBindingNavigator.Location = new System.Drawing.Point(0, 73);
            this.senderNumberBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.senderNumberBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.senderNumberBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.senderNumberBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.senderNumberBindingNavigator.Name = "senderNumberBindingNavigator";
            this.senderNumberBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.senderNumberBindingNavigator.Size = new System.Drawing.Size(952, 25);
            this.senderNumberBindingNavigator.TabIndex = 7;
            this.senderNumberBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // senderNumberBindingNavigatorSaveItem
            // 
            this.senderNumberBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.senderNumberBindingNavigatorSaveItem.Enabled = false;
            this.senderNumberBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("senderNumberBindingNavigatorSaveItem.Image")));
            this.senderNumberBindingNavigatorSaveItem.Name = "senderNumberBindingNavigatorSaveItem";
            this.senderNumberBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.senderNumberBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // senderNumberGridControl
            // 
            this.senderNumberGridControl.DataSource = this.senderNumberBindingSource;
            this.senderNumberGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.senderNumberGridControl.Location = new System.Drawing.Point(0, 98);
            this.senderNumberGridControl.MainView = this.gridView1;
            this.senderNumberGridControl.Name = "senderNumberGridControl";
            this.senderNumberGridControl.Size = new System.Drawing.Size(952, 465);
            this.senderNumberGridControl.TabIndex = 7;
            this.senderNumberGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.senderNumberGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // DeleteSenderNumbersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 563);
            this.Controls.Add(this.senderNumberGridControl);
            this.Controls.Add(this.senderNumberBindingNavigator);
            this.Controls.Add(this.groupControl1);
            this.Name = "DeleteSenderNumbersFrm";
            this.Text = "DeleteSenderNumbersFrm";
            this.Load += new System.EventHandler(this.DeleteSenderNumbersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StatusSerchlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumberSearchlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumbersSearchlayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatuslayoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senderNumberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senderNumberBindingNavigator)).EndInit();
            this.senderNumberBindingNavigator.ResumeLayout(false);
            this.senderNumberBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.senderNumberGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit SenderNumberSearchlookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem SenderNumbersSearchlayoutControlItem;
        private DevExpress.XtraEditors.LookUpEdit StatusSerchlookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem StatuslayoutControlItem1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Xprema.Data.Xdb xdb;
        private System.Windows.Forms.BindingSource senderNumberBindingSource;
        private System.Windows.Forms.BindingNavigator senderNumberBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton senderNumberBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl senderNumberGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}