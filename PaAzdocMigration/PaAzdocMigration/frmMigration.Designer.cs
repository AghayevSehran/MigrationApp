namespace PaAzdocMigration
{
    partial class frmMigration
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
            this.lblSource = new System.Windows.Forms.Label();
            this.cmbSourceTable = new System.Windows.Forms.ComboBox();
            this.chckTurnOff = new System.Windows.Forms.CheckBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.progressBarCopyResult = new System.Windows.Forms.ProgressBar();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.dtgwSourceTable = new System.Windows.Forms.DataGridView();
            this.lblMigrationName = new System.Windows.Forms.Label();
            this.cmbMigration = new System.Windows.Forms.ComboBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwSourceTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(4, 11);
            this.lblSource.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(50, 16);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source";
            // 
            // cmbSourceTable
            // 
            this.cmbSourceTable.DisplayMember = "DisplayText";
            this.cmbSourceTable.FormattingEnabled = true;
            this.cmbSourceTable.Location = new System.Drawing.Point(58, 9);
            this.cmbSourceTable.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSourceTable.Name = "cmbSourceTable";
            this.cmbSourceTable.Size = new System.Drawing.Size(247, 21);
            this.cmbSourceTable.TabIndex = 2;
            this.cmbSourceTable.ValueMember = "Value";
            // 
            // chckTurnOff
            // 
            this.chckTurnOff.AutoSize = true;
            this.chckTurnOff.Location = new System.Drawing.Point(626, 10);
            this.chckTurnOff.Margin = new System.Windows.Forms.Padding(2);
            this.chckTurnOff.Name = "chckTurnOff";
            this.chckTurnOff.Size = new System.Drawing.Size(215, 20);
            this.chckTurnOff.TabIndex = 4;
            this.chckTurnOff.Text = "Turn off auto increment on target";
            this.chckTurnOff.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(700, 66);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(141, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy ";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // progressBarCopyResult
            // 
            this.progressBarCopyResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarCopyResult.Location = new System.Drawing.Point(0, 432);
            this.progressBarCopyResult.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarCopyResult.Name = "progressBarCopyResult";
            this.progressBarCopyResult.Size = new System.Drawing.Size(852, 19);
            this.progressBarCopyResult.TabIndex = 6;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cmbMigration);
            this.pnlTop.Controls.Add(this.lblMigrationName);
            this.pnlTop.Controls.Add(this.btnCopy);
            this.pnlTop.Controls.Add(this.lblSource);
            this.pnlTop.Controls.Add(this.cmbSourceTable);
            this.pnlTop.Controls.Add(this.chckTurnOff);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(852, 109);
            this.pnlTop.TabIndex = 7;
            // 
            // dtgwSourceTable
            // 
            this.dtgwSourceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwSourceTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgwSourceTable.Location = new System.Drawing.Point(0, 109);
            this.dtgwSourceTable.Margin = new System.Windows.Forms.Padding(2);
            this.dtgwSourceTable.Name = "dtgwSourceTable";
            this.dtgwSourceTable.RowTemplate.Height = 24;
            this.dtgwSourceTable.Size = new System.Drawing.Size(852, 323);
            this.dtgwSourceTable.TabIndex = 8;
            // 
            // lblMigrationName
            // 
            this.lblMigrationName.AutoSize = true;
            this.lblMigrationName.Location = new System.Drawing.Point(347, 11);
            this.lblMigrationName.Name = "lblMigrationName";
            this.lblMigrationName.Size = new System.Drawing.Size(62, 16);
            this.lblMigrationName.TabIndex = 6;
            this.lblMigrationName.Text = "Migration";
            // 
            // cmbMigration
            // 
            this.cmbMigration.DisplayMember = "DisplayText";
            this.cmbMigration.FormattingEnabled = true;
            this.cmbMigration.Location = new System.Drawing.Point(415, 9);
            this.cmbMigration.Name = "cmbMigration";
            this.cmbMigration.Size = new System.Drawing.Size(196, 21);
            this.cmbMigration.TabIndex = 7;
            this.cmbMigration.ValueMember = "Value";
            // 
            // frmMigration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 451);
            this.Controls.Add(this.dtgwSourceTable);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.progressBarCopyResult);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMigration";
            this.Text = "Migrate";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwSourceTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.ComboBox cmbSourceTable;
        private System.Windows.Forms.CheckBox chckTurnOff;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ProgressBar progressBarCopyResult;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DataGridView dtgwSourceTable;
        private System.Windows.Forms.ComboBox cmbMigration;
        private System.Windows.Forms.Label lblMigrationName;
    }
}