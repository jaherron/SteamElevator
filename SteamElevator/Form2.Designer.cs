﻿namespace SteamElevator
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 15);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 0;
            label1.Text = "Steam Elevator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 52);
            label2.Name = "label2";
            label2.Size = new Size(432, 21);
            label2.TabIndex = 1;
            label2.Text = "A tool for easily restarting Steam in elevated or normal mode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 86);
            label3.Name = "label3";
            label3.Size = new Size(377, 15);
            label3.TabIndex = 2;
            label3.Text = "Created by LittleBit | littlebitstudios.com | littlebit@littlebitstudios.com";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 108);
            label4.Name = "label4";
            label4.Size = new Size(377, 15);
            label4.TabIndex = 3;
            label4.Text = "Licensed under the MIT License. Steam is owned by Valve Corporation.";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 139);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "About This App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}