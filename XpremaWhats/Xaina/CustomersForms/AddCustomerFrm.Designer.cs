namespace Xaina.CustomersForms
{
    partial class AddCustomerFrm
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
            this.CustomerNametextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CustomerNamelayoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CustomerPhonetextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CustomerPhonelayoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CustomerEmailtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CustomerEmaillayoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.CustomerCreatDatelayoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.AddCoustmersBtn = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNametextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNamelayoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPhonetextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPhonelayoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerEmailtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerEmaillayoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerCreatDatelayoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.AddCoustmersBtn);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Controls.Add(this.CustomerEmailtextEdit);
            this.layoutControl1.Controls.Add(this.CustomerPhonetextEdit);
            this.layoutControl1.Controls.Add(this.CustomerNametextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(364, 225);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.CustomerNamelayoutControlItem1,
            this.CustomerPhonelayoutControlItem2,
            this.CustomerEmaillayoutControlItem3,
            this.CustomerCreatDatelayoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(364, 225);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // CustomerNametextEdit
            // 
            this.CustomerNametextEdit.Location = new System.Drawing.Point(12, 29);
            this.CustomerNametextEdit.Name = "CustomerNametextEdit";
            this.CustomerNametextEdit.Size = new System.Drawing.Size(340, 20);
            this.CustomerNametextEdit.StyleController = this.layoutControl1;
            this.CustomerNametextEdit.TabIndex = 4;
            // 
            // CustomerNamelayoutControlItem1
            // 
            this.CustomerNamelayoutControlItem1.Control = this.CustomerNametextEdit;
            this.CustomerNamelayoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.CustomerNamelayoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.CustomerNamelayoutControlItem1.Name = "CustomerNamelayoutControlItem1";
            this.CustomerNamelayoutControlItem1.Size = new System.Drawing.Size(344, 41);
            this.CustomerNamelayoutControlItem1.Text = "Customer Name:";
            this.CustomerNamelayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.CustomerNamelayoutControlItem1.TextSize = new System.Drawing.Size(83, 13);
            // 
            // CustomerPhonetextEdit
            // 
            this.CustomerPhonetextEdit.Location = new System.Drawing.Point(12, 70);
            this.CustomerPhonetextEdit.Name = "CustomerPhonetextEdit";
            this.CustomerPhonetextEdit.Size = new System.Drawing.Size(340, 20);
            this.CustomerPhonetextEdit.StyleController = this.layoutControl1;
            this.CustomerPhonetextEdit.TabIndex = 5;
            // 
            // CustomerPhonelayoutControlItem2
            // 
            this.CustomerPhonelayoutControlItem2.Control = this.CustomerPhonetextEdit;
            this.CustomerPhonelayoutControlItem2.CustomizationFormText = "Customer Phone:";
            this.CustomerPhonelayoutControlItem2.Location = new System.Drawing.Point(0, 41);
            this.CustomerPhonelayoutControlItem2.Name = "CustomerPhonelayoutControlItem2";
            this.CustomerPhonelayoutControlItem2.Size = new System.Drawing.Size(344, 41);
            this.CustomerPhonelayoutControlItem2.Text = "Customer Phone:";
            this.CustomerPhonelayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.CustomerPhonelayoutControlItem2.TextSize = new System.Drawing.Size(83, 13);
            // 
            // CustomerEmailtextEdit
            // 
            this.CustomerEmailtextEdit.Location = new System.Drawing.Point(12, 111);
            this.CustomerEmailtextEdit.Name = "CustomerEmailtextEdit";
            this.CustomerEmailtextEdit.Size = new System.Drawing.Size(340, 20);
            this.CustomerEmailtextEdit.StyleController = this.layoutControl1;
            this.CustomerEmailtextEdit.TabIndex = 6;
            // 
            // CustomerEmaillayoutControlItem3
            // 
            this.CustomerEmaillayoutControlItem3.Control = this.CustomerEmailtextEdit;
            this.CustomerEmaillayoutControlItem3.CustomizationFormText = "Customer Email:";
            this.CustomerEmaillayoutControlItem3.Location = new System.Drawing.Point(0, 82);
            this.CustomerEmaillayoutControlItem3.Name = "CustomerEmaillayoutControlItem3";
            this.CustomerEmaillayoutControlItem3.Size = new System.Drawing.Size(344, 41);
            this.CustomerEmaillayoutControlItem3.Text = "Customer Email:";
            this.CustomerEmaillayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.CustomerEmaillayoutControlItem3.TextSize = new System.Drawing.Size(83, 13);
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(12, 152);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(340, 20);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 7;
            // 
            // CustomerCreatDatelayoutControlItem4
            // 
            this.CustomerCreatDatelayoutControlItem4.Control = this.dateEdit1;
            this.CustomerCreatDatelayoutControlItem4.CustomizationFormText = "Creat Date:";
            this.CustomerCreatDatelayoutControlItem4.Location = new System.Drawing.Point(0, 123);
            this.CustomerCreatDatelayoutControlItem4.Name = "CustomerCreatDatelayoutControlItem4";
            this.CustomerCreatDatelayoutControlItem4.Size = new System.Drawing.Size(344, 41);
            this.CustomerCreatDatelayoutControlItem4.Text = "Creat Date:";
            this.CustomerCreatDatelayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.CustomerCreatDatelayoutControlItem4.TextSize = new System.Drawing.Size(83, 13);
            // 
            // AddCoustmersBtn
            // 
            this.AddCoustmersBtn.Location = new System.Drawing.Point(12, 176);
            this.AddCoustmersBtn.Name = "AddCoustmersBtn";
            this.AddCoustmersBtn.Size = new System.Drawing.Size(340, 22);
            this.AddCoustmersBtn.StyleController = this.layoutControl1;
            this.AddCoustmersBtn.TabIndex = 8;
            this.AddCoustmersBtn.Text = "Add";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.AddCoustmersBtn;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 164);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(344, 41);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // AddCustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 225);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AddCustomerFrm";
            this.Text = "AddCustomerFrm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNametextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNamelayoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPhonetextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPhonelayoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerEmailtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerEmaillayoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerCreatDatelayoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton AddCoustmersBtn;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.TextEdit CustomerEmailtextEdit;
        private DevExpress.XtraEditors.TextEdit CustomerPhonetextEdit;
        private DevExpress.XtraEditors.TextEdit CustomerNametextEdit;
        private DevExpress.XtraLayout.LayoutControlItem CustomerNamelayoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem CustomerPhonelayoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem CustomerEmaillayoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem CustomerCreatDatelayoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}