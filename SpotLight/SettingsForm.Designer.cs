﻿namespace SpotLight
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.GamePathLabel = new System.Windows.Forms.Label();
            this.GamePathTextBox = new System.Windows.Forms.TextBox();
            this.GamePathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GamePathLabel
            // 
            this.GamePathLabel.AutoSize = true;
            this.GamePathLabel.Location = new System.Drawing.Point(12, 15);
            this.GamePathLabel.Name = "GamePathLabel";
            this.GamePathLabel.Size = new System.Drawing.Size(83, 13);
            this.GamePathLabel.TabIndex = 0;
            this.GamePathLabel.Text = "Game Directory:";
            // 
            // GamePathTextBox
            // 
            this.GamePathTextBox.Location = new System.Drawing.Point(101, 12);
            this.GamePathTextBox.Name = "GamePathTextBox";
            this.GamePathTextBox.Size = new System.Drawing.Size(336, 20);
            this.GamePathTextBox.TabIndex = 1;
            this.GamePathTextBox.TextChanged += new System.EventHandler(this.GamePathTextBox_TextChanged);
            // 
            // GamePathButton
            // 
            this.GamePathButton.Location = new System.Drawing.Point(443, 12);
            this.GamePathButton.Name = "GamePathButton";
            this.GamePathButton.Size = new System.Drawing.Size(35, 20);
            this.GamePathButton.TabIndex = 2;
            this.GamePathButton.Text = "· · ·";
            this.GamePathButton.UseVisualStyleBackColor = true;
            this.GamePathButton.Click += new System.EventHandler(this.GamePathButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 209);
            this.Controls.Add(this.GamePathButton);
            this.Controls.Add(this.GamePathTextBox);
            this.Controls.Add(this.GamePathLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Spotlight - Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GamePathLabel;
        private System.Windows.Forms.TextBox GamePathTextBox;
        private System.Windows.Forms.Button GamePathButton;
    }
}