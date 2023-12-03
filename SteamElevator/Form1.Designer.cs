namespace SteamElevator
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
            statusText = new Label();
            refreshButton = new Button();
            quitButton = new Button();
            startElevButton = new Button();
            startNormButton = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // statusText
            // 
            statusText.AutoSize = true;
            statusText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusText.Location = new Point(19, 16);
            statusText.Name = "statusText";
            statusText.Size = new Size(222, 21);
            statusText.TabIndex = 0;
            statusText.Text = "Seeing if Steam is running...";
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(368, 16);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(112, 23);
            refreshButton.TabIndex = 1;
            refreshButton.Text = "Refresh Status";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // quitButton
            // 
            quitButton.Enabled = false;
            quitButton.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quitButton.Location = new Point(19, 51);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(222, 82);
            quitButton.TabIndex = 2;
            quitButton.Text = "Quit Steam";
            quitButton.UseVisualStyleBackColor = true;
            quitButton.Click += quitButton_Click;
            // 
            // startElevButton
            // 
            startElevButton.Enabled = false;
            startElevButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startElevButton.Location = new Point(247, 51);
            startElevButton.Name = "startElevButton";
            startElevButton.Size = new Size(242, 37);
            startElevButton.TabIndex = 3;
            startElevButton.Text = "Start Steam Elevated";
            startElevButton.UseVisualStyleBackColor = true;
            startElevButton.Click += startElevButton_Click;
            // 
            // startNormButton
            // 
            startNormButton.Enabled = false;
            startNormButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startNormButton.Location = new Point(247, 96);
            startNormButton.Name = "startNormButton";
            startNormButton.Size = new Size(242, 37);
            startNormButton.TabIndex = 4;
            startNormButton.Text = "Start Steam Normally";
            startNormButton.UseVisualStyleBackColor = true;
            startNormButton.Click += startNormButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 145);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 5;
            label1.Text = "Steam Elevator by LittleBit";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(280, 145);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(85, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "About this app";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 173);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(startNormButton);
            Controls.Add(startElevButton);
            Controls.Add(quitButton);
            Controls.Add(refreshButton);
            Controls.Add(statusText);
            Name = "Form1";
            Text = "Steam Elevator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label statusText;
        private Button refreshButton;
        private Button quitButton;
        private Button startElevButton;
        private Button startNormButton;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}
