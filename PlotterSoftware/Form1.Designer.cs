namespace PlotterSoftware
{
    partial class Form1
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
            this.PortsSelection = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.SerialConsole = new System.Windows.Forms.RichTextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Pause_Resume = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.ZUp = new System.Windows.Forms.Button();
            this.ZDown = new System.Windows.Forms.Button();
            this.FileToDraw = new System.Windows.Forms.ComboBox();
            this.DrawingArea = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LU = new System.Windows.Forms.Button();
            this.LD = new System.Windows.Forms.Button();
            this.RU = new System.Windows.Forms.Button();
            this.RD = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CircleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PortsSelection
            // 
            this.PortsSelection.FormattingEnabled = true;
            this.PortsSelection.Location = new System.Drawing.Point(47, 32);
            this.PortsSelection.Name = "PortsSelection";
            this.PortsSelection.Size = new System.Drawing.Size(121, 24);
            this.PortsSelection.TabIndex = 0;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(47, 62);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(159, 23);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(441, 32);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(441, 140);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // SerialConsole
            // 
            this.SerialConsole.Location = new System.Drawing.Point(47, 140);
            this.SerialConsole.Name = "SerialConsole";
            this.SerialConsole.Size = new System.Drawing.Size(261, 278);
            this.SerialConsole.TabIndex = 4;
            this.SerialConsole.Text = "";
            this.SerialConsole.TextChanged += new System.EventHandler(this.SerialConsole_TextChanged);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(314, 345);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(98, 73);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Pause_Resume
            // 
            this.Pause_Resume.Location = new System.Drawing.Point(441, 345);
            this.Pause_Resume.Name = "Pause_Resume";
            this.Pause_Resume.Size = new System.Drawing.Size(98, 73);
            this.Pause_Resume.TabIndex = 6;
            this.Pause_Resume.Text = "Pause/Resume";
            this.Pause_Resume.UseVisualStyleBackColor = true;
            this.Pause_Resume.Click += new System.EventHandler(this.Pause_Resume_Click);
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(134, 446);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(81, 66);
            this.Up.TabIndex = 7;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = false;
            this.Up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Up_MouseDown);
            this.Up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Up_MouseUp);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(134, 590);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(81, 66);
            this.Down.TabIndex = 8;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = false;
            this.Down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Down_MouseDown);
            this.Down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Down_MouseUp);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(47, 518);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(81, 66);
            this.Left.TabIndex = 9;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = false;
            this.Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Left_MouseDown);
            this.Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Left_MouseUp);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(227, 518);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(81, 66);
            this.Right.TabIndex = 10;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = false;
            this.Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Right_MouseDown);
            this.Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Right_MouseUp);
            // 
            // ZUp
            // 
            this.ZUp.Location = new System.Drawing.Point(336, 446);
            this.ZUp.Name = "ZUp";
            this.ZUp.Size = new System.Drawing.Size(81, 66);
            this.ZUp.TabIndex = 11;
            this.ZUp.Text = "Z+";
            this.ZUp.UseVisualStyleBackColor = false;
            this.ZUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ZUp_MouseDown);
            this.ZUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ZUp_MouseUp);
            // 
            // ZDown
            // 
            this.ZDown.Location = new System.Drawing.Point(336, 518);
            this.ZDown.Name = "ZDown";
            this.ZDown.Size = new System.Drawing.Size(81, 66);
            this.ZDown.TabIndex = 12;
            this.ZDown.Text = "Z-";
            this.ZDown.UseVisualStyleBackColor = false;
            this.ZDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ZDown_MouseDown);
            this.ZDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ZDown_MouseUp);
            // 
            // FileToDraw
            // 
            this.FileToDraw.FormattingEnabled = true;
            this.FileToDraw.Location = new System.Drawing.Point(314, 140);
            this.FileToDraw.Name = "FileToDraw";
            this.FileToDraw.Size = new System.Drawing.Size(121, 24);
            this.FileToDraw.TabIndex = 13;
            // 
            // DrawingArea
            // 
            this.DrawingArea.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DrawingArea.Location = new System.Drawing.Point(678, 83);
            this.DrawingArea.Name = "DrawingArea";
            this.DrawingArea.Size = new System.Drawing.Size(440, 440);
            this.DrawingArea.TabIndex = 14;
            this.DrawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingArea_Paint);
            this.DrawingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseDown);
            this.DrawingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseUp);
            // 
            // LU
            // 
            this.LU.Location = new System.Drawing.Point(47, 446);
            this.LU.Name = "LU";
            this.LU.Size = new System.Drawing.Size(81, 66);
            this.LU.TabIndex = 15;
            this.LU.Text = "LU";
            this.LU.UseVisualStyleBackColor = false;
            this.LU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LU_MouseDown);
            this.LU.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LU_MouseUp);
            // 
            // LD
            // 
            this.LD.Location = new System.Drawing.Point(47, 590);
            this.LD.Name = "LD";
            this.LD.Size = new System.Drawing.Size(81, 66);
            this.LD.TabIndex = 16;
            this.LD.Text = "LD";
            this.LD.UseVisualStyleBackColor = false;
            this.LD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LD_MouseDown);
            this.LD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LD_MouseUp);
            // 
            // RU
            // 
            this.RU.Location = new System.Drawing.Point(227, 446);
            this.RU.Name = "RU";
            this.RU.Size = new System.Drawing.Size(81, 66);
            this.RU.TabIndex = 17;
            this.RU.Text = "RU";
            this.RU.UseVisualStyleBackColor = false;
            this.RU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RU_MouseDown);
            this.RU.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RU_MouseUp);
            // 
            // RD
            // 
            this.RD.Location = new System.Drawing.Point(227, 590);
            this.RD.Name = "RD";
            this.RD.Size = new System.Drawing.Size(81, 66);
            this.RD.TabIndex = 18;
            this.RD.Text = "RD";
            this.RD.UseVisualStyleBackColor = false;
            this.RD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RD_MouseDown);
            this.RD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RD_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(678, 540);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 19;
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(805, 538);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(116, 23);
            this.CircleButton.TabIndex = 20;
            this.CircleButton.Text = "Draw a circle";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_OnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 717);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RD);
            this.Controls.Add(this.RU);
            this.Controls.Add(this.LD);
            this.Controls.Add(this.LU);
            this.Controls.Add(this.DrawingArea);
            this.Controls.Add(this.FileToDraw);
            this.Controls.Add(this.ZDown);
            this.Controls.Add(this.ZUp);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.Pause_Resume);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.SerialConsole);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PortsSelection);
            this.Name = "Form1";
            this.Text = "p";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortsSelection;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.RichTextBox SerialConsole;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Pause_Resume;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button ZUp;
        private System.Windows.Forms.Button ZDown;
        private System.Windows.Forms.ComboBox FileToDraw;
        private System.Windows.Forms.Panel DrawingArea;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button LU;
        private System.Windows.Forms.Button LD;
        private System.Windows.Forms.Button RU;
        private System.Windows.Forms.Button RD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CircleButton;
    }
}

