﻿namespace Xaina.ServicesForms
{
    partial class GeneratNumberFrm
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
            this.XKeys = new DevExpress.XtraEditors.TextEdit();
            this.NumbersBox = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.CmbKeys = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CmbCountries = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CmbPhones = new DevExpress.XtraEditors.ComboBoxEdit();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.XKeys.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumbersBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbKeys.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCountries.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPhones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // XKeys
            // 
            this.XKeys.Location = new System.Drawing.Point(115, 73);
            this.XKeys.Name = "XKeys";
            this.XKeys.Size = new System.Drawing.Size(80, 20);
            this.XKeys.TabIndex = 0;
            // 
            // NumbersBox
            // 
            this.NumbersBox.Location = new System.Drawing.Point(211, 73);
            this.NumbersBox.Name = "NumbersBox";
            this.NumbersBox.Size = new System.Drawing.Size(188, 20);
            this.NumbersBox.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(115, 141);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(122, 36);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // CmbKeys
            // 
            this.CmbKeys.Location = new System.Drawing.Point(12, 419);
            this.CmbKeys.Name = "CmbKeys";
            this.CmbKeys.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbKeys.Size = new System.Drawing.Size(122, 20);
            this.CmbKeys.TabIndex = 3;
            this.CmbKeys.SelectedIndexChanged += new System.EventHandler(this.CmbKeys_SelectedIndexChanged_1);
            // 
            // CmbCountries
            // 
            this.CmbCountries.Location = new System.Drawing.Point(115, 47);
            this.CmbCountries.Name = "CmbCountries";
            this.CmbCountries.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbCountries.Size = new System.Drawing.Size(284, 20);
            this.CmbCountries.TabIndex = 4;
            this.CmbCountries.SelectedIndexChanged += new System.EventHandler(this.CmbCountries_SelectedIndexChanged_1);
            // 
            // CmbPhones
            // 
            this.CmbPhones.Location = new System.Drawing.Point(115, 232);
            this.CmbPhones.Name = "CmbPhones";
            this.CmbPhones.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbPhones.Size = new System.Drawing.Size(284, 20);
            this.CmbPhones.TabIndex = 5;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(115, 295);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(284, 18);
            this.progressBarControl1.TabIndex = 6;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(277, 141);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(122, 36);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "simpleButton2";
            // 
            // GeneratNumberFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 451);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.CmbPhones);
            this.Controls.Add(this.CmbCountries);
            this.Controls.Add(this.CmbKeys);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.NumbersBox);
            this.Controls.Add(this.XKeys);
            this.Name = "GeneratNumberFrm";
            this.Text = "GeneratNumberFrm";
            this.Load += new System.EventHandler(this.GeneratNumberFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XKeys.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumbersBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbKeys.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCountries.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPhones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit XKeys;
        private DevExpress.XtraEditors.TextEdit NumbersBox;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit CmbKeys;
        private DevExpress.XtraEditors.ComboBoxEdit CmbCountries;
        private DevExpress.XtraEditors.ComboBoxEdit CmbPhones;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}