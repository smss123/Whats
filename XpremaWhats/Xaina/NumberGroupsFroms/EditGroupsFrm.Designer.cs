namespace Xaina.NumberGroupsFroms
{
    partial class EditGroupsFrm
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.EditGrouptextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EditGrouplayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.SaveGroupBtn = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.SelectGrouplookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.SelectGroupslayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditGrouptextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditGrouplayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectGrouplookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectGroupslayoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.SelectGrouplookUpEdit);
            this.layoutControl1.Controls.Add(this.SaveGroupBtn);
            this.layoutControl1.Controls.Add(this.EditGrouptextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(337, 108);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.EditGrouplayoutControlItem,
            this.layoutControlItem2,
            this.SelectGroupslayoutControlItem});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(337, 108);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // EditGrouptextEdit
            // 
            this.EditGrouptextEdit.Location = new System.Drawing.Point(99, 36);
            this.EditGrouptextEdit.Name = "EditGrouptextEdit";
            this.EditGrouptextEdit.Size = new System.Drawing.Size(226, 20);
            this.EditGrouptextEdit.StyleController = this.layoutControl1;
            this.EditGrouptextEdit.TabIndex = 4;
            // 
            // EditGrouplayoutControlItem
            // 
            this.EditGrouplayoutControlItem.Control = this.EditGrouptextEdit;
            this.EditGrouplayoutControlItem.CustomizationFormText = "Edit Group Name:";
            this.EditGrouplayoutControlItem.Location = new System.Drawing.Point(0, 24);
            this.EditGrouplayoutControlItem.Name = "EditGrouplayoutControlItem";
            this.EditGrouplayoutControlItem.Size = new System.Drawing.Size(317, 24);
            this.EditGrouplayoutControlItem.Text = "Edit Group Name:";
            this.EditGrouplayoutControlItem.TextSize = new System.Drawing.Size(84, 13);
            // 
            // SaveGroupBtn
            // 
            this.SaveGroupBtn.Location = new System.Drawing.Point(12, 60);
            this.SaveGroupBtn.Name = "SaveGroupBtn";
            this.SaveGroupBtn.Size = new System.Drawing.Size(313, 22);
            this.SaveGroupBtn.StyleController = this.layoutControl1;
            this.SaveGroupBtn.TabIndex = 5;
            this.SaveGroupBtn.Text = "Save";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.SaveGroupBtn;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(317, 40);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // SelectGrouplookUpEdit
            // 
            this.SelectGrouplookUpEdit.Location = new System.Drawing.Point(99, 12);
            this.SelectGrouplookUpEdit.Name = "SelectGrouplookUpEdit";
            this.SelectGrouplookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SelectGrouplookUpEdit.Size = new System.Drawing.Size(226, 20);
            this.SelectGrouplookUpEdit.StyleController = this.layoutControl1;
            this.SelectGrouplookUpEdit.TabIndex = 6;
            // 
            // SelectGroupslayoutControlItem
            // 
            this.SelectGroupslayoutControlItem.Control = this.SelectGrouplookUpEdit;
            this.SelectGroupslayoutControlItem.CustomizationFormText = "Select Group:";
            this.SelectGroupslayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.SelectGroupslayoutControlItem.Name = "SelectGroupslayoutControlItem";
            this.SelectGroupslayoutControlItem.Size = new System.Drawing.Size(317, 24);
            this.SelectGroupslayoutControlItem.Text = "Select Group:";
            this.SelectGroupslayoutControlItem.TextSize = new System.Drawing.Size(84, 13);
            // 
            // EditGroupsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 108);
            this.Controls.Add(this.layoutControl1);
            this.Name = "EditGroupsFrm";
            this.Text = "EditGroupsFrm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditGrouptextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditGrouplayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectGrouplookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectGroupslayoutControlItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton SaveGroupBtn;
        private DevExpress.XtraEditors.TextEdit EditGrouptextEdit;
        private DevExpress.XtraLayout.LayoutControlItem EditGrouplayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit SelectGrouplookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem SelectGroupslayoutControlItem;
    }
}