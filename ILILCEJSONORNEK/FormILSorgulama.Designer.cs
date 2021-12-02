
namespace ILILCEJSONORNEK
{
    partial class FormILSorgulama
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
            this.lblILSecimi = new System.Windows.Forms.Label();
            this.comboBoxILSecimi = new System.Windows.Forms.ComboBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblILSecimi
            // 
            this.lblILSecimi.AutoSize = true;
            this.lblILSecimi.Location = new System.Drawing.Point(9, 4);
            this.lblILSecimi.Name = "lblILSecimi";
            this.lblILSecimi.Size = new System.Drawing.Size(60, 20);
            this.lblILSecimi.TabIndex = 0;
            this.lblILSecimi.Text = "İL ADI  :";
            // 
            // comboBoxILSecimi
            // 
            this.comboBoxILSecimi.FormattingEnabled = true;
            this.comboBoxILSecimi.Location = new System.Drawing.Point(75, 1);
            this.comboBoxILSecimi.Name = "comboBoxILSecimi";
            this.comboBoxILSecimi.Size = new System.Drawing.Size(228, 28);
            this.comboBoxILSecimi.TabIndex = 1;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(309, 0);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(53, 29);
            this.btnSec.TabIndex = 2;
            this.btnSec.Text = "SEÇ";
            this.btnSec.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(464, 394);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormILSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.comboBoxILSecimi);
            this.Controls.Add(this.lblILSecimi);
            this.Name = "FormILSorgulama";
            this.Text = "FormILSorgulama";
            this.Load += new System.EventHandler(this.FormILSorgulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblILSecimi;
        private System.Windows.Forms.ComboBox comboBoxILSecimi;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.ListView listView1;
    }
}