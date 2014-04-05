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
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.StatusSerchlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.SenderNumberSearchlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.SenderNumbersSearchlayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.StatuslayoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSenderNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumberOfMessageInDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCounter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.senderNumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusSerchlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumberSearchlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumbersSearchlayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatuslayoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senderNumberBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.layoutControl1.Controls.Add(this.simpleButton1);
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
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(757, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(78, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // StatusSerchlookUpEdit
            // 
            this.StatusSerchlookUpEdit.Location = new System.Drawing.Point(543, 12);
            this.StatusSerchlookUpEdit.Name = "StatusSerchlookUpEdit";
            this.StatusSerchlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StatusSerchlookUpEdit.Size = new System.Drawing.Size(210, 20);
            this.StatusSerchlookUpEdit.StyleController = this.layoutControl1;
            this.StatusSerchlookUpEdit.TabIndex = 5;
            // 
            // SenderNumberSearchlookUpEdit
            // 
            this.SenderNumberSearchlookUpEdit.Location = new System.Drawing.Point(115, 12);
            this.SenderNumberSearchlookUpEdit.Name = "SenderNumberSearchlookUpEdit";
            this.SenderNumberSearchlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SenderNumberSearchlookUpEdit.Size = new System.Drawing.Size(321, 20);
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
            this.layoutControlItem1});
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
            this.SenderNumbersSearchlayoutControlItem.Size = new System.Drawing.Size(428, 30);
            this.SenderNumbersSearchlayoutControlItem.Text = "Search By Numbers :";
            this.SenderNumbersSearchlayoutControlItem.TextSize = new System.Drawing.Size(100, 13);
            // 
            // StatuslayoutControlItem1
            // 
            this.StatuslayoutControlItem1.Control = this.StatusSerchlookUpEdit;
            this.StatuslayoutControlItem1.CustomizationFormText = "Search By Status:";
            this.StatuslayoutControlItem1.Location = new System.Drawing.Point(428, 0);
            this.StatuslayoutControlItem1.Name = "StatuslayoutControlItem1";
            this.StatuslayoutControlItem1.Size = new System.Drawing.Size(317, 30);
            this.StatuslayoutControlItem1.Text = "Search By Status:";
            this.StatuslayoutControlItem1.TextSize = new System.Drawing.Size(100, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(745, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(82, 30);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.senderNumberBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 73);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(851, 520);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSenderNumber,
            this.colPassword,
            this.colNumberOfMessageInDay,
            this.colCounter,
            this.colStatus});
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colSenderNumber
            // 
            this.colSenderNumber.FieldName = "SenderNumber";
            this.colSenderNumber.Name = "colSenderNumber";
            this.colSenderNumber.Visible = true;
            this.colSenderNumber.VisibleIndex = 1;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 2;
            // 
            // colNumberOfMessageInDay
            // 
            this.colNumberOfMessageInDay.FieldName = "NumberOfMessageInDay";
            this.colNumberOfMessageInDay.Name = "colNumberOfMessageInDay";
            this.colNumberOfMessageInDay.Visible = true;
            this.colNumberOfMessageInDay.VisibleIndex = 3;
            // 
            // colCounter
            // 
            this.colCounter.FieldName = "Counter";
            this.colCounter.Name = "colCounter";
            this.colCounter.Visible = true;
            this.colCounter.VisibleIndex = 4;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
            // 
            // senderNumberBindingSource
            // 
            this.senderNumberBindingSource.DataMember = "SenderNumber";
            this.senderNumberBindingSource.DataSource = typeof(Xprema.Data.Xdb);
            // 
            // GridEditSenderNumbersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 593);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "GridEditSenderNumbersFrm";
            this.Text = "GridEditSenderNumbersFrm";
            this.Load += new System.EventHandler(this.GridEditSenderNumbersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StatusSerchlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumberSearchlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SenderNumbersSearchlayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatuslayoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senderNumberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit SenderNumberSearchlookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem SenderNumbersSearchlayoutControlItem;
        private DevExpress.XtraEditors.LookUpEdit StatusSerchlookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem StatuslayoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSenderNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberOfMessageInDay;
        private DevExpress.XtraGrid.Columns.GridColumn colCounter;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private System.Windows.Forms.BindingSource senderNumberBindingSource;
    }
}