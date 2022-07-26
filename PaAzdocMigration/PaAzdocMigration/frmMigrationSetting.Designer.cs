namespace PaAzdocMigration
{
    partial class frmMigrationSetting
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchSourceTableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTargetColumn = new System.Windows.Forms.Button();
            this.btnSourceColumn = new System.Windows.Forms.Button();
            this.btnTargetTables = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSourceTable = new System.Windows.Forms.Label();
            this.txtSourceTable = new System.Windows.Forms.TextBox();
            this.lblTargetTable = new System.Windows.Forms.Label();
            this.txtTargetTable = new System.Windows.Forms.TextBox();
            this.lblSourceColumn = new System.Windows.Forms.Label();
            this.txtSourceColumn = new System.Windows.Forms.TextBox();
            this.lblTargetColumn = new System.Windows.Forms.Label();
            this.txtTargetColumn = new System.Windows.Forms.TextBox();
            this.lblOrderIndex = new System.Windows.Forms.Label();
            this.numOrderIndex = new System.Windows.Forms.NumericUpDown();
            this.btnSourceTables = new System.Windows.Forms.Button();
            this.dgwMigrationSettings = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolTipStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMigrationName = new System.Windows.Forms.Label();
            this.txtMigrationName = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMigrationSettings)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.tabControl1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1263, 222);
            this.pnlTop.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1261, 220);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.txtSearchSourceTableName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1253, 161);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(429, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchSourceTableName
            // 
            this.txtSearchSourceTableName.Location = new System.Drawing.Point(142, 16);
            this.txtSearchSourceTableName.Name = "txtSearchSourceTableName";
            this.txtSearchSourceTableName.Size = new System.Drawing.Size(263, 22);
            this.txtSearchSourceTableName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source table name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnTargetColumn);
            this.tabPage2.Controls.Add(this.btnSourceColumn);
            this.tabPage2.Controls.Add(this.btnTargetTables);
            this.tabPage2.Controls.Add(this.btnAddNew);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnEdit);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.btnSourceTables);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1253, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTargetColumn
            // 
            this.btnTargetColumn.Location = new System.Drawing.Point(602, 90);
            this.btnTargetColumn.Name = "btnTargetColumn";
            this.btnTargetColumn.Size = new System.Drawing.Size(113, 23);
            this.btnTargetColumn.TabIndex = 16;
            this.btnTargetColumn.Text = "Target column";
            this.btnTargetColumn.UseVisualStyleBackColor = true;
            // 
            // btnSourceColumn
            // 
            this.btnSourceColumn.Location = new System.Drawing.Point(602, 62);
            this.btnSourceColumn.Name = "btnSourceColumn";
            this.btnSourceColumn.Size = new System.Drawing.Size(113, 23);
            this.btnSourceColumn.TabIndex = 15;
            this.btnSourceColumn.Text = "Source column";
            this.btnSourceColumn.UseVisualStyleBackColor = true;
            // 
            // btnTargetTables
            // 
            this.btnTargetTables.Location = new System.Drawing.Point(602, 34);
            this.btnTargetTables.Name = "btnTargetTables";
            this.btnTargetTables.Size = new System.Drawing.Size(113, 23);
            this.btnTargetTables.TabIndex = 14;
            this.btnTargetTables.Text = "Target";
            this.btnTargetTables.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(794, 138);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(91, 22);
            this.btnAddNew.TabIndex = 13;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(899, 138);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 22);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(698, 138);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 22);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(602, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 22);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Yadda saxla";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblSourceTable);
            this.flowLayoutPanel1.Controls.Add(this.txtSourceTable);
            this.flowLayoutPanel1.Controls.Add(this.lblTargetTable);
            this.flowLayoutPanel1.Controls.Add(this.txtTargetTable);
            this.flowLayoutPanel1.Controls.Add(this.lblSourceColumn);
            this.flowLayoutPanel1.Controls.Add(this.txtSourceColumn);
            this.flowLayoutPanel1.Controls.Add(this.lblTargetColumn);
            this.flowLayoutPanel1.Controls.Add(this.txtTargetColumn);
            this.flowLayoutPanel1.Controls.Add(this.lblOrderIndex);
            this.flowLayoutPanel1.Controls.Add(this.numOrderIndex);
            this.flowLayoutPanel1.Controls.Add(this.lblMigrationName);
            this.flowLayoutPanel1.Controls.Add(this.txtMigrationName);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(593, 188);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblSourceTable
            // 
            this.lblSourceTable.AutoSize = true;
            this.lblSourceTable.Location = new System.Drawing.Point(3, 0);
            this.lblSourceTable.Name = "lblSourceTable";
            this.lblSourceTable.Size = new System.Drawing.Size(83, 16);
            this.lblSourceTable.TabIndex = 0;
            this.lblSourceTable.Text = "Source table";
            // 
            // txtSourceTable
            // 
            this.txtSourceTable.Location = new System.Drawing.Point(92, 3);
            this.txtSourceTable.Name = "txtSourceTable";
            this.txtSourceTable.Size = new System.Drawing.Size(492, 22);
            this.txtSourceTable.TabIndex = 1;
            // 
            // lblTargetTable
            // 
            this.lblTargetTable.AutoSize = true;
            this.lblTargetTable.Location = new System.Drawing.Point(3, 28);
            this.lblTargetTable.Name = "lblTargetTable";
            this.lblTargetTable.Size = new System.Drawing.Size(80, 16);
            this.lblTargetTable.TabIndex = 2;
            this.lblTargetTable.Text = "Target table";
            // 
            // txtTargetTable
            // 
            this.txtTargetTable.Location = new System.Drawing.Point(89, 31);
            this.txtTargetTable.Name = "txtTargetTable";
            this.txtTargetTable.Size = new System.Drawing.Size(495, 22);
            this.txtTargetTable.TabIndex = 3;
            // 
            // lblSourceColumn
            // 
            this.lblSourceColumn.AutoSize = true;
            this.lblSourceColumn.Location = new System.Drawing.Point(3, 56);
            this.lblSourceColumn.Name = "lblSourceColumn";
            this.lblSourceColumn.Size = new System.Drawing.Size(96, 16);
            this.lblSourceColumn.TabIndex = 4;
            this.lblSourceColumn.Text = "Source column";
            // 
            // txtSourceColumn
            // 
            this.txtSourceColumn.Location = new System.Drawing.Point(105, 59);
            this.txtSourceColumn.Name = "txtSourceColumn";
            this.txtSourceColumn.Size = new System.Drawing.Size(479, 22);
            this.txtSourceColumn.TabIndex = 5;
            // 
            // lblTargetColumn
            // 
            this.lblTargetColumn.AutoSize = true;
            this.lblTargetColumn.Location = new System.Drawing.Point(3, 84);
            this.lblTargetColumn.Name = "lblTargetColumn";
            this.lblTargetColumn.Size = new System.Drawing.Size(93, 16);
            this.lblTargetColumn.TabIndex = 6;
            this.lblTargetColumn.Text = "Target column";
            // 
            // txtTargetColumn
            // 
            this.txtTargetColumn.Location = new System.Drawing.Point(102, 87);
            this.txtTargetColumn.Name = "txtTargetColumn";
            this.txtTargetColumn.Size = new System.Drawing.Size(482, 22);
            this.txtTargetColumn.TabIndex = 7;
            // 
            // lblOrderIndex
            // 
            this.lblOrderIndex.AutoSize = true;
            this.lblOrderIndex.Location = new System.Drawing.Point(3, 112);
            this.lblOrderIndex.Name = "lblOrderIndex";
            this.lblOrderIndex.Size = new System.Drawing.Size(44, 16);
            this.lblOrderIndex.TabIndex = 8;
            this.lblOrderIndex.Text = "Order ";
            // 
            // numOrderIndex
            // 
            this.numOrderIndex.Location = new System.Drawing.Point(53, 115);
            this.numOrderIndex.Name = "numOrderIndex";
            this.numOrderIndex.Size = new System.Drawing.Size(531, 22);
            this.numOrderIndex.TabIndex = 9;
            // 
            // btnSourceTables
            // 
            this.btnSourceTables.Location = new System.Drawing.Point(602, 6);
            this.btnSourceTables.Name = "btnSourceTables";
            this.btnSourceTables.Size = new System.Drawing.Size(113, 23);
            this.btnSourceTables.TabIndex = 10;
            this.btnSourceTables.Text = "Source tables";
            this.btnSourceTables.UseVisualStyleBackColor = true;
            // 
            // dgwMigrationSettings
            // 
            this.dgwMigrationSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMigrationSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwMigrationSettings.Location = new System.Drawing.Point(0, 222);
            this.dgwMigrationSettings.Name = "dgwMigrationSettings";
            this.dgwMigrationSettings.RowTemplate.Height = 24;
            this.dgwMigrationSettings.Size = new System.Drawing.Size(1263, 282);
            this.dgwMigrationSettings.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTipStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 482);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1263, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolTipStatus
            // 
            this.toolTipStatus.Name = "toolTipStatus";
            this.toolTipStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // lblMigrationName
            // 
            this.lblMigrationName.AutoSize = true;
            this.lblMigrationName.Location = new System.Drawing.Point(3, 140);
            this.lblMigrationName.Name = "lblMigrationName";
            this.lblMigrationName.Size = new System.Drawing.Size(99, 16);
            this.lblMigrationName.TabIndex = 10;
            this.lblMigrationName.Text = "Migration name";
            // 
            // txtMigrationName
            // 
            this.txtMigrationName.Location = new System.Drawing.Point(108, 143);
            this.txtMigrationName.Name = "txtMigrationName";
            this.txtMigrationName.Size = new System.Drawing.Size(476, 22);
            this.txtMigrationName.TabIndex = 11;
            // 
            // frmMigrationSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 504);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgwMigrationSettings);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmMigrationSetting";
            this.Text = "Migration Setting";
            this.pnlTop.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMigrationSettings)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchSourceTableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblSourceTable;
        private System.Windows.Forms.TextBox txtSourceTable;
        private System.Windows.Forms.Label lblTargetTable;
        private System.Windows.Forms.TextBox txtTargetTable;
        private System.Windows.Forms.Label lblSourceColumn;
        private System.Windows.Forms.TextBox txtSourceColumn;
        private System.Windows.Forms.Label lblTargetColumn;
        private System.Windows.Forms.TextBox txtTargetColumn;
        private System.Windows.Forms.Label lblOrderIndex;
        private System.Windows.Forms.NumericUpDown numOrderIndex;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgwMigrationSettings;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolTipStatus;
        private System.Windows.Forms.Button btnTargetColumn;
        private System.Windows.Forms.Button btnSourceColumn;
        private System.Windows.Forms.Button btnTargetTables;
        private System.Windows.Forms.Button btnSourceTables;
        private System.Windows.Forms.Label lblMigrationName;
        private System.Windows.Forms.TextBox txtMigrationName;
    }
}