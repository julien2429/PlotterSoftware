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
            this.StarButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileDialog = new System.Windows.Forms.Button();
            this.UpdateSettings = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortsSelection
            // 
            this.PortsSelection.FormattingEnabled = true;
            this.PortsSelection.Location = new System.Drawing.Point(47, 83);
            this.PortsSelection.Name = "PortsSelection";
            this.PortsSelection.Size = new System.Drawing.Size(139, 24);
            this.PortsSelection.TabIndex = 0;
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.DarkCyan;
            this.ConnectButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.ConnectButton.Location = new System.Drawing.Point(212, 55);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(96, 65);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Teal;
            this.RefreshButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RefreshButton.Location = new System.Drawing.Point(314, 55);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(98, 65);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Lime;
            this.Start.Location = new System.Drawing.Point(314, 345);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(98, 73);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // SerialConsole
            // 
            this.SerialConsole.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SerialConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialConsole.ForeColor = System.Drawing.Color.Black;
            this.SerialConsole.Location = new System.Drawing.Point(47, 140);
            this.SerialConsole.Name = "SerialConsole";
            this.SerialConsole.Size = new System.Drawing.Size(261, 278);
            this.SerialConsole.TabIndex = 4;
            this.SerialConsole.Text = "";
            this.SerialConsole.TextChanged += new System.EventHandler(this.SerialConsole_TextChanged);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.IndianRed;
            this.Stop.Location = new System.Drawing.Point(416, 345);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(98, 73);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Pause_Resume
            // 
            this.Pause_Resume.BackColor = System.Drawing.Color.SandyBrown;
            this.Pause_Resume.Location = new System.Drawing.Point(520, 345);
            this.Pause_Resume.Name = "Pause_Resume";
            this.Pause_Resume.Size = new System.Drawing.Size(132, 73);
            this.Pause_Resume.TabIndex = 6;
            this.Pause_Resume.Text = "Pause/Resume";
            this.Pause_Resume.UseVisualStyleBackColor = false;
            this.Pause_Resume.Click += new System.EventHandler(this.Pause_Resume_Click);
            // 
            // Up
            // 
            this.Up.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.Down.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.Left.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.Right.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.ZUp.BackColor = System.Drawing.Color.DarkGray;
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
            this.ZDown.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.FileToDraw.Location = new System.Drawing.Point(416, 163);
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
            this.LU.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.LD.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.RU.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.RD.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.textBox1.Location = new System.Drawing.Point(678, 553);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 19;
            // 
            // CircleButton
            // 
            this.CircleButton.BackColor = System.Drawing.Color.Plum;
            this.CircleButton.Location = new System.Drawing.Point(855, 532);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(86, 44);
            this.CircleButton.TabIndex = 20;
            this.CircleButton.Text = "Draw a circle";
            this.CircleButton.UseVisualStyleBackColor = false;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_OnClick);
            // 
            // StarButton
            // 
            this.StarButton.BackColor = System.Drawing.Color.Plum;
            this.StarButton.Location = new System.Drawing.Point(947, 532);
            this.StarButton.Name = "StarButton";
            this.StarButton.Size = new System.Drawing.Size(88, 44);
            this.StarButton.TabIndex = 21;
            this.StarButton.Text = "Draw a star";
            this.StarButton.UseVisualStyleBackColor = false;
            this.StarButton.Click += new System.EventHandler(this.StarButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FileDialog
            // 
            this.FileDialog.BackColor = System.Drawing.Color.CornflowerBlue;
            this.FileDialog.ForeColor = System.Drawing.Color.DarkBlue;
            this.FileDialog.Location = new System.Drawing.Point(416, 193);
            this.FileDialog.Name = "FileDialog";
            this.FileDialog.Size = new System.Drawing.Size(121, 65);
            this.FileDialog.TabIndex = 22;
            this.FileDialog.Text = "Open GCODE file";
            this.FileDialog.UseVisualStyleBackColor = false;
            this.FileDialog.Click += new System.EventHandler(this.FileDialog_Click);
            // 
            // UpdateSettings
            // 
            this.UpdateSettings.Location = new System.Drawing.Point(1047, 650);
            this.UpdateSettings.Name = "UpdateSettings";
            this.UpdateSettings.Size = new System.Drawing.Size(85, 54);
            this.UpdateSettings.TabIndex = 23;
            this.UpdateSettings.Text = "Update Settings";
            this.UpdateSettings.UseVisualStyleBackColor = true;
            this.UpdateSettings.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(658, 686);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 25;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(908, 622);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 26;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(908, 650);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Z_Distance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "XY_Distance";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "XY Feed Rate";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "XY Diag Feed Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "XY_Diag_Distance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Z Feed Rate";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(908, 683);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(511, 590);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 133);
            this.panel1.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(45, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Select a port";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(412, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Select a default file";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(674, 530);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Select a size for:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1266, 717);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.UpdateSettings);
            this.Controls.Add(this.FileDialog);
            this.Controls.Add(this.StarButton);
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
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "p";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button StarButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button FileDialog;
        private System.Windows.Forms.Button UpdateSettings;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

