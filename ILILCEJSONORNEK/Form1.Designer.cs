
namespace ILILCEJSONORNEK
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ILSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ILCEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıLCESorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ILToolStripMenuItem,
            this.ILCEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ILToolStripMenuItem
            // 
            this.ILToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ILSorgulamaToolStripMenuItem});
            this.ILToolStripMenuItem.Name = "ILToolStripMenuItem";
            this.ILToolStripMenuItem.Size = new System.Drawing.Size(34, 24);
            this.ILToolStripMenuItem.Text = "IL";
            // 
            // ILSorgulamaToolStripMenuItem
            // 
            this.ILSorgulamaToolStripMenuItem.Name = "ILSorgulamaToolStripMenuItem";
            this.ILSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.ILSorgulamaToolStripMenuItem.Text = "ILSorgulama";
            this.ILSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.ILSorgulamaToolStripMenuItem_Click);
            // 
            // ILCEToolStripMenuItem
            // 
            this.ILCEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ıLCESorgulamaToolStripMenuItem});
            this.ILCEToolStripMenuItem.Name = "ILCEToolStripMenuItem";
            this.ILCEToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.ILCEToolStripMenuItem.Text = "ILCE";
            // 
            // ıLCESorgulamaToolStripMenuItem
            // 
            this.ıLCESorgulamaToolStripMenuItem.Name = "ıLCESorgulamaToolStripMenuItem";
            this.ıLCESorgulamaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ıLCESorgulamaToolStripMenuItem.Text = "ILCESorgulama";
            this.ıLCESorgulamaToolStripMenuItem.Click += new System.EventHandler(this.ıLCESorgulamaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ILToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ILSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ILCEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıLCESorgulamaToolStripMenuItem;
    }
}

