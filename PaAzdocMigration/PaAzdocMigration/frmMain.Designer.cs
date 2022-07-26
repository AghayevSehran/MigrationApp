namespace PaAzdocMigration
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.migrationSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.migrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFromSourceToTargetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.migrationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1845, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.migrationSettingToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // migrationSettingToolStripMenuItem
            // 
            this.migrationSettingToolStripMenuItem.Name = "migrationSettingToolStripMenuItem";
            this.migrationSettingToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.migrationSettingToolStripMenuItem.Text = "Migration settings";
            // 
            // migrationToolStripMenuItem
            // 
            this.migrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyFromSourceToTargetToolStripMenuItem});
            this.migrationToolStripMenuItem.Name = "migrationToolStripMenuItem";
            this.migrationToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.migrationToolStripMenuItem.Text = "Migration";
            // 
            // copyFromSourceToTargetToolStripMenuItem
            // 
            this.copyFromSourceToTargetToolStripMenuItem.Name = "copyFromSourceToTargetToolStripMenuItem";
            this.copyFromSourceToTargetToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.copyFromSourceToTargetToolStripMenuItem.Text = "Copy from source to target";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1845, 720);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Migration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem migrationSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem migrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyFromSourceToTargetToolStripMenuItem;
    }
}

