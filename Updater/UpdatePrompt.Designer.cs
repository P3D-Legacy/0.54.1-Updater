namespace Updater
{
    partial class UpdatePrompt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNewVersion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "New version detected.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Newest Version: ";
            // 
            // lblNewVersion
            // 
            this.lblNewVersion.AutoSize = true;
            this.lblNewVersion.Location = new System.Drawing.Point(132, 74);
            this.lblNewVersion.Name = "lblNewVersion";
            this.lblNewVersion.Size = new System.Drawing.Size(46, 17);
            this.lblNewVersion.TabIndex = 3;
            this.lblNewVersion.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Would you like to update the game?";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(164, 135);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 5;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(245, 135);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 6;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Indev 0.54.1a";
            // 
            // UpdatePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 172);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNewVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Check";
            this.Load += new System.EventHandler(this.UpdatePrompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNewVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label label5;
    }
}