﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;


namespace PlotterSoftware
{
    public partial class Form1 : Form
    {
        private SerialPort _serialPort;
        private CancellationTokenSource _cancellationTokenSource;
        private CancellationToken _cancellationToken;
        private bool _paused = false;


        private const float FEED_RATE_INPUT = 100;
        private const float FEED_RATE_DIAGONAL = 141.421f;
        private const float Z_FEED_RATE_INPUT = 50;
        private const float DISTANCE_XY = 0.025F;
        private const float DISTANCE_XY_DIAGONAL = 0.017F;
        private const float DISTANCE_Z = 0.2F;
        private const float CIRCLE_INCREMENT = 0.025F;
        


        public Form1()
        {
            InitializeComponent();
            UpdatePorts();
            UpdateFiles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawingArea.Paint += new System.Windows.Forms.PaintEventHandler(DrawingArea_Paint);
            this.Controls.Add(DrawingArea);
        }

        private Task InitGrbl()
        {
            if (SerialConsole.InvokeRequired)
            {
                SerialConsole.Invoke(new Action(() => SerialConsole.AppendText("Initializing Grbl\n")));
            }
            else
            {
                SerialConsole.AppendText("Initializing Grbl\n");
            }
            _serialPort.Write("\r\n\r\n");
            Task.Delay(2000);
            _serialPort.DiscardInBuffer();
            if (SerialConsole.InvokeRequired)
            {
                SerialConsole.Invoke(new Action(() => SerialConsole.AppendText("Grbl Initialized\n")));
            }
            else
            {
                SerialConsole.AppendText("Grbl Initialized\n");
            }
            return Task.CompletedTask;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdatePorts();
            UpdateFiles();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            SerialConsole.AppendText("Connecting to port: "+PortsSelection.Text+"\n");
            if(PortsSelection.Text != "")
                UpdateSerialPort();
            SerialConsole.AppendText("Connected to port: " + PortsSelection.Text + "\n");
        }

        private async void UpdateSerialPort()
        {
            if(_serialPort!= null && _serialPort.IsOpen)
            {
                _serialPort.Close();
            }

            SerialPort serialPort = new SerialPort();
            serialPort.PortName = PortsSelection.Text;
            serialPort.BaudRate = 115200;
            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;
            serialPort.Open();
            _serialPort = serialPort;

            await InitGrbl();


        }

        private void UpdatePorts()
        {
            PortsSelection.Items.Clear();

            PortsSelection.Items.AddRange(SerialPort.GetPortNames());
            if(PortsSelection.Items.Count > 0)
             PortsSelection.SelectedIndex = 0;
        }

        private void UpdateFiles()
        {
            FileToDraw.Items.Clear();
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string[] files = Directory.GetFiles(projectDirectory, "*.gcode");
            foreach( var file in files)
            {
                var fileNames = file.Split('\\');
                FileToDraw.Items.Add(fileNames.Last());
            }
        }

        private async void Start_Click(object sender, EventArgs e)
        {
            //await SendFile();
            string fileName = FileToDraw.Text;
            await Task.Run(() => SendFile(fileName));
        }

        private async Task SendFile(string fileName)
        {

            
            _cancellationTokenSource = new CancellationTokenSource();
            _cancellationToken = _cancellationTokenSource.Token;

            if (_serialPort == null || !_serialPort.IsOpen)
            {
                MessageBox.Show("Please connect to a port first");
                return;
            }

            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;


            

            if(fileName == "")
            {
                MessageBox.Show("Please select a file to draw");
                return;
            }

            FileStream fileStream = File.Open(projectDirectory + $"/{fileName}", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);


            var stream = await streamReader.ReadToEndAsync();
            StringReader StringReader = new StringReader(stream);
            string s= StringReader.ReadLine();
            fileStream.Close();

            while (s != null && s!="")
            {
                if(_cancellationToken.IsCancellationRequested)
                {
                    return;
                }
              

                if (SerialConsole.InvokeRequired)
                {
                    SerialConsole.Invoke(new Action(() => SerialConsole.AppendText("Sending: " + s + "\n")));
                }
                else
                {
                    SerialConsole.AppendText("Sending: " + s + "\n");
                }
                _serialPort.Write(s+"\n");
                string response = _serialPort.ReadLine();

                if (SerialConsole.InvokeRequired)
                {
                    SerialConsole.Invoke(new Action(() => SerialConsole.AppendText("Receiving: " + response + "\n")));
                }
                else
                {
                    SerialConsole.AppendText("Receiving: " + response + "\n");
                }
                s = StringReader.ReadLine();

            }
        }

        private void SerialConsole_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (_serialPort == null || !_serialPort.IsOpen)
            {
                MessageBox.Show("Please connect to a port first");
                return;
            }

            if (_cancellationTokenSource == null)
            {
                _cancellationTokenSource = new CancellationTokenSource();
            }

            _cancellationTokenSource.Cancel();
            _serialPort.Write("!\n");
        }


        private void Pause_Resume_Click(object sender, EventArgs e)
        {
            if (_serialPort == null || !_serialPort.IsOpen)
            {
                MessageBox.Show("Please connect to a port first");
                return;
            }

            if (_cancellationTokenSource == null)
            {
                _cancellationTokenSource = new CancellationTokenSource();
            }

            if(_paused)
            {
                _serialPort.Write("~\n");
                _paused = false;
            }
            else
            {
                _serialPort.Write("!\n");
                _paused = true;
            }
           
        }


        private Task sendCommand(string message)
        {
            if (_serialPort == null || !_serialPort.IsOpen)
            {
                MessageBox.Show("Please connect to a port first");
                return Task.CompletedTask;
            }
            _serialPort.Write(message+ "\n");
            if (SerialConsole.InvokeRequired)
            {
                SerialConsole.Invoke(new Action(() => SerialConsole.AppendText("Sending: " + message + "\n")));
            }
            else
            {
                SerialConsole.AppendText("Sending: " + message + "\n");
            }
            var response = _serialPort.ReadLine();

            if (SerialConsole.InvokeRequired)
            {
                SerialConsole.Invoke(new Action(() => SerialConsole.AppendText("Receiving: "  + "\n")));
            }
            else
            {
                SerialConsole.AppendText("Receiving: "  + "\n");
            }
            return Task.CompletedTask;
        }

        private bool _moveLeft = false;
        private bool _moveRight = false;
        private bool _moveUp = false;
        private bool _moveDown = false;
        private bool _moveZUp = false;
        private bool _moveZDown = false;
        private bool _moveLU = false;
        private bool _moveRU = false;
        private bool _moveLD = false;
        private bool _moveRD = false;



        public static string GenerateMovementCommand(bool x_axis, bool y_axis, bool z_axis, float distance_x, float distance_y, float distance_z, float feedRate)
        {

            string toSend = "G1 ";

            if (x_axis && distance_x!=0)
            {
                toSend += $"X{distance_x} ";
            }

            if(y_axis && distance_y!=0)
            {
                toSend += $"Y{distance_y} ";
            }

            if(z_axis && distance_z!=0)
            {
                toSend += $"Z{distance_z} ";
            }

           

            toSend += $"F{feedRate}";

            return toSend;
        }


        #region LU
        private void LU_MouseDown(object sender, MouseEventArgs e)
        {
            _moveLU = true;
            Task.Run(async () =>
            {
                /*string command_x = GenerateMovementCommand(true, false, false, -DISTANCE_XY_DIAGONAL, 0, 0 ,FEED_RATE_DIAGONAL);
                string command_y = GenerateMovementCommand(false, true, false, 0, DISTANCE_XY_DIAGONAL, 0, FEED_RATE_DIAGONAL);*/
                string command = GenerateMovementCommand(true, true, false, -DISTANCE_XY_DIAGONAL, DISTANCE_XY_DIAGONAL, 0, FEED_RATE_DIAGONAL);
          
                while (_moveLU)
                {
                    await sendCommand("G21");
                    await sendCommand("G91");
                    await sendCommand(command);
                    /*await sendCommand(command_y);*/
                }
            });
        }

        private void LU_MouseUp(object sender, EventArgs e)
        {
            _moveLU = false; 
        }

        #endregion

        #region RU
        private void RU_MouseDown(object sender, MouseEventArgs e)
        {
            _moveRU = true;
            Task.Run(async () =>
            {
                /*string command_x = GenerateMovementCommand(true, false, false, DISTANCE_XY_DIAGONAL, 0, 0, FEED_RATE_INPUT);
                string command_y = GenerateMovementCommand(false, true, false, 0, DISTANCE_XY_DIAGONAL, 0, FEED_RATE_INPUT);*/
                

                string command = GenerateMovementCommand(true, true, false, DISTANCE_XY_DIAGONAL, DISTANCE_XY_DIAGONAL, 0, FEED_RATE_DIAGONAL);
                while (_moveRU)
                {
                    await sendCommand("G21");
                    await sendCommand("G91");
                    /*await sendCommand(command_x);
                    await sendCommand(command_y);*/

                    await sendCommand(command);
                }
            });
        }

        private void RU_MouseUp(object sender, MouseEventArgs e)
        {
            _moveRU = false;
        }


        #endregion

        #region LD
        private void LD_MouseDown(object sender, MouseEventArgs e)
        {
           _moveLD = true;
            Task.Run( async () =>
            {
                
               /* string command_x = GenerateMovementCommand(true, false, false, -DISTANCE_XY_DIAGONAL, 0, 0, FEED_RATE_INPUT);
                string command_y = GenerateMovementCommand(false, true, false, 0, -DISTANCE_XY_DIAGONAL, 0, FEED_RATE_INPUT);*/
                
                string command = GenerateMovementCommand(true, true, false, -DISTANCE_XY_DIAGONAL, -DISTANCE_XY_DIAGONAL, 0, FEED_RATE_DIAGONAL);
                while (_moveLD)
                {
                    await sendCommand("G21");
                    await sendCommand("G91");
                    /*await sendCommand(command_x);
                    await sendCommand(command_y);*/

                    await sendCommand(command);
                }
            });
        }
        
        
        private void LD_MouseUp(object sender, MouseEventArgs e)
        {
            _moveLD = false;
        }

        #endregion

        #region RD
        private void RD_MouseDown(object sender, MouseEventArgs e)
        {
            _moveRD = true;
            Task.Run( async () =>
            {

                /*string command_x = GenerateMovementCommand(true, false, false, DISTANCE_XY_DIAGONAL, 0, 0, FEED_RATE_INPUT);
                string command_y = GenerateMovementCommand(false, true, false, 0, -DISTANCE_XY_DIAGONAL, 0, FEED_RATE_INPUT);*/

                string command = GenerateMovementCommand(true, true, false, DISTANCE_XY_DIAGONAL, -DISTANCE_XY_DIAGONAL, 0, FEED_RATE_DIAGONAL);
                while (_moveRD)
                {
                    await sendCommand("G21");
                    await sendCommand("G91");
                    /*await sendCommand(command_x);
                    await sendCommand(command_y);*/

                    await sendCommand(command);
                }
            });
        }

        private void RD_MouseUp(object sender, MouseEventArgs e)
        {
            _moveRD = false;
        }
        #endregion

        #region left

        private void Left_MouseDown(object sender, MouseEventArgs e)
        {
            _moveLeft = true;
            Task.Run( async () =>
            {
                string command = GenerateMovementCommand(true, false, false, -DISTANCE_XY, 0, 0, FEED_RATE_INPUT);

                while (_moveLeft)
                {

                    await sendCommand("G21");
                    await sendCommand("G91");
                    await sendCommand(command);
     
                }
            });
        }

        private void Left_MouseUp(object sender, MouseEventArgs e)
        {
            _moveLeft = false;
        }
        #endregion

        #region down
        private void Right_MouseDown(object sender, MouseEventArgs e)
        {
            _moveRight = true;
            Task.Run( async () =>
            {
                string command = GenerateMovementCommand(true, false, false, DISTANCE_XY, 0, 0, FEED_RATE_INPUT);

                while (_moveRight)
                {
                    await sendCommand("G21");
                    await sendCommand("G91");
                    await sendCommand(command);
                  
                }
            });
        }

        private void Right_MouseUp(object sender, MouseEventArgs e)
        {
            _moveRight = false;
        }
        #endregion

        #region up
        private void Up_MouseDown(object sender, MouseEventArgs e)
        {
            _moveUp = true;
            Task.Run(async () =>
            {
                string command = GenerateMovementCommand(false, true, false, 0, DISTANCE_XY, 0, FEED_RATE_INPUT);

                while (_moveUp)
                {
                    await sendCommand("G21");
                    await sendCommand("G91");
                    await sendCommand(command);
                   
                }
            });
        }

        
        private void Up_MouseUp(object sender, MouseEventArgs e)
        {
            _moveUp = false;
        }
        #endregion

        #region down
        private void Down_MouseDown(object sender, MouseEventArgs e)
        {
            _moveDown = true;
            Task.Run( async() =>
            {
                string command = GenerateMovementCommand(false, true, false, 0, -DISTANCE_XY, 0, FEED_RATE_INPUT);

                while (_moveDown)
                {
                    await sendCommand("G21");
                    await sendCommand("G91");
                    await sendCommand(command);
                }
            });
        }

        private void Down_MouseUp(object sender, MouseEventArgs e)
        {
            _moveDown = false;
        }

        #endregion

        #region zDown

        private void ZDown_MouseDown(object sender, MouseEventArgs e)
        {
            _moveZDown =true;
            Task.Run( async () =>
            {
                string command = GenerateMovementCommand(false,  false, true, 0, 0, -DISTANCE_Z, FEED_RATE_INPUT);

                while (_moveZDown)
                {
                    await sendCommand("G21");
                    await sendCommand("G91");
                    await sendCommand(command);
              
                }
            });
        }

        private void ZDown_MouseUp(object sender, MouseEventArgs e)
        {
            _moveZDown = false;
        }

        #endregion
  
        #region zUp

        private void ZUp_MouseDown(object sender, MouseEventArgs e)
        {
            _moveZUp = true;
            Task.Run(async () =>
            {
                string command = GenerateMovementCommand(false, false, true, 0, 0, DISTANCE_Z, Z_FEED_RATE_INPUT);

                while (_moveZUp)
                {

                    await sendCommand("G21");
                    await sendCommand("G91");
                    await sendCommand(command);
                    
                }
            });
        }

        private void ZUp_MouseUp(object sender, MouseEventArgs e)
        {
            _moveZUp = false;
        }

        #endregion

        #region Drawing
        struct Line
        {
            public PointF Start { get; set; }
            public PointF End { get; set; }
        }

        private Point ptStart, ptEnd;
        
        private List<Line> lines= new List<Line>();
        private void DrawingArea_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
                ptStart = e.Location;
        }

        private void DrawingArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ptEnd = e.Location;
                var line = new Line() { Start = ptStart, End = ptEnd };
                lines.Add(line);
                DrawingArea.Invalidate();
                SendLineToDraw(line);
            }
                
        }

        private void DrawingArea_Paint(object sender, PaintEventArgs e)
        {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Red, 3);
                foreach (var line in lines)
                    g.DrawLine(pen, line.Start, line.End);
        }


        private async void SendLineToDraw(Line line)
        {
            // Define the drawing area dimensions and real-world area dimensions
            /*float width = DrawingArea.Width;
            float height = DrawingArea.Height;*/

            float width = 440;
            float height = 440;
            float realWidth = 300.0f;
            float realHeight = 300.0f;

            // Translate the start and end points from screen to real-world coordinates
            PointF translatedStart = new PointF(
                (int)(line.Start.X * 1.0f * realWidth / width),
                (int)(line.Start.Y * 1.0f * realHeight / height)
            );
            PointF translatedEnd = new PointF(
                (int)(line.End.X * 1.0f * realWidth / width),
                (int)(line.End.Y * 1.0f * realHeight / height)
            );




            await sendCommand("G21");
            //await sendCommand("G92 X0 Y0 Z0"); // SETS THE ORIGIN TO 0 0 0
            await sendCommand("G91");
            await sendCommand("G1 Z-1 F500");

            var newLine = new Line();

            newLine.Start = translatedStart;
            newLine.End   = translatedEnd;

            var lines = GetLineGCode(newLine);
            foreach (var l in lines)
            {
                await sendCommand(l);
            }

            await sendCommand("G1 Z1 F500");
        }

        private List< (float, float) > GetFirstEigthQuadrant(int r)
        {

            int x = r, y = 0;

            int P = 1 - r;

            List<(float, float)> commands =  new List<(float, float)>();

            
            while (x > y)
            {
                y++;
                float y_val = 1.0f;
                float x_val = 0.0f;
                if(P <= 0)
                {
                    P = P + 2 * y + 1;
                }
                else
                {
                    x--;
                    x_val = -1;
                    P = P + 2 * y - 2 * x + 1;
                }

                if (x < y)
                    break;

                commands.Add((x_val / 5.0f, y_val / 5.0f));
               
            }

            return commands;    


        }


        private async void DrawCircle(int radius)
        {

            await sendCommand("G21");
           // await sendCommand("G92 X0 Y0 Z0");
            await sendCommand("G91");
            await sendCommand("G1 Z-1 F500");

            var commands = GetFirstEigthQuadrant(radius);

            foreach (var command in commands)
            {
                
                var commandString = GenerateMovementCommand(true, true, false, command.Item1, command.Item2, 0, FEED_RATE_INPUT);
                await sendCommand(commandString);
            }

            List<(float, float)> reversedCommands = new List<(float, float)>();

            foreach (var command in commands)
            {
                reversedCommands.Insert(0,(-command.Item2,-command.Item1));
            }

            foreach (var command in reversedCommands)
            {
                var commandString = GenerateMovementCommand(true, true, false, command.Item1, command.Item2, 0, FEED_RATE_INPUT);
                await sendCommand(commandString);
            }

            var thirdAndFourthQuadrant = new List<(float, float)>();
            thirdAndFourthQuadrant.AddRange(commands);
            thirdAndFourthQuadrant.AddRange(reversedCommands);
            thirdAndFourthQuadrant.Reverse();
            thirdAndFourthQuadrant= thirdAndFourthQuadrant.Select(x => (x.Item1, -x.Item2)).ToList();

            foreach (var command in thirdAndFourthQuadrant)
            {
                var commandString = GenerateMovementCommand(true, true, false, command.Item1, command.Item2, 0, FEED_RATE_INPUT);
                await sendCommand(commandString);
            }


            var fifthSixthSeventhEigthQuadrant = new List<(float, float)>();
            fifthSixthSeventhEigthQuadrant.AddRange(commands);
            fifthSixthSeventhEigthQuadrant.AddRange(reversedCommands);
            fifthSixthSeventhEigthQuadrant.AddRange(thirdAndFourthQuadrant);
            fifthSixthSeventhEigthQuadrant.Reverse();
            fifthSixthSeventhEigthQuadrant = fifthSixthSeventhEigthQuadrant.Select(x => (-x.Item1, x.Item2)).ToList();

            foreach (var command in fifthSixthSeventhEigthQuadrant)
            {
                var commandString = GenerateMovementCommand(true, true, false, command.Item1, command.Item2, 0, FEED_RATE_INPUT);
                await sendCommand(commandString);
            }


            await sendCommand("G1 Z1 F500");

        }

        private void CircleButton_OnClick(object sender, EventArgs e)
        {
            DrawCircle(10);
        }

        private static List<string> GetLineGCode(Line line, int stepSize = 1)
        {
            List<string> gCodeCommands = new List<string>();


            float x1 = line.Start.X * 10;
            float y1 = line.Start.Y * 10;
            float x0 = line.End.X * 10;
            float y0 = line.End.Y * 10;

            float dx = Math.Abs(x1 - x0);
            float dy = -Math.Abs(y1 - y0);

            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;

            float err = dx + dy;

            
           


            while (x0 != x1 || y0 != y1)
            {
                float e2 = 2 * err;
                float xStep = 0.0f;
                float yStep = 0.0f;
                if (e2 >= dy)
                {
                    err += dy;
                    x0 += sx;
                    xStep = sx;
                    string command = GenerateMovementCommand(true, false, false, xStep/ 100.0f, 0, 0, FEED_RATE_INPUT);
                    gCodeCommands.Add(command);
                }

                if (e2 <= dx)
                {
                    err += dx;
                    y0 += sy;
                    yStep = sy;
                    string command = GenerateMovementCommand(false, true, false, 0, yStep / 100.0f, 0, FEED_RATE_INPUT);
                    gCodeCommands.Add(command);
                }

                
            }

            return gCodeCommands;
        }




        #endregion
    }
}