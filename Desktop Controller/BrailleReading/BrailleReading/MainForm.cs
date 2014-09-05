using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace BrailleReading
{
    public partial class MainForm : Form
    {
        private SerialPort _arduino;
        private int DURATION = 1000; //milliseconds
        private int INTERVAL = 500; //milliseconds

        public MainForm()
        {
            InitializeComponent();           

            // initialize arduino communication
            _arduino = new SerialPort("COM3", 9600);
            _arduino.DataReceived += _arduino_DataReceived;
            
            try 
            {
                _arduino.Open();
            } 
            catch 
            {
			    MessageBox.Show("Could not connect to arduino board. Please check the connection.");
                Application.Exit();
            }
        }

        private void _arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
		
            try 
            {
                string data = _arduino.ReadLine();
                //this.Dispatcher.Invoke();
                this.Invoke(new Action(() => { this.lbReceived.Text = data.Remove(data.Length - 4); }));
                return;
            } 
            catch (Exception ex) 
            {
                MessageBox.Show("Could not read data" + ex.StackTrace);
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            DURATION = (int)numUDDuration.Value;
            INTERVAL = (int)numUDInterval.Value;

            string sentence = tbSentence.Text.ToLower();
            foreach (char c in sentence)
            {
                sendChar(c);
                Thread.Sleep(DURATION);
                sendChar(' ');
                Thread.Sleep(INTERVAL);
            }
            
        }

        private void sendChar(char c)
        {
            switch (c)
            {
                case 'a': _arduino.Write(numUDLeftIndex.Value+";0;0;0;0;0;\n"); break;
                case 'b': _arduino.Write(numUDLeftIndex.Value + ";" + numUDLeftMiddle.Value + ";0;0;0;0;\n"); break;
                case 'c': _arduino.Write(numUDLeftIndex.Value + ";0;0;" + numUDRightIndex.Value + ";0;0;\n"); break;
                case 'd': _arduino.Write(numUDLeftIndex.Value + ";0;0;" + numUDRightIndex.Value + ";" + numUDRightMiddle.Value + ";0;\n"); break;
                case 'e': _arduino.Write(numUDLeftIndex.Value + ";0;0;0;" + numUDRightMiddle.Value + ";0;\n"); break;
                case 'f': _arduino.Write(numUDLeftIndex.Value + ";" + numUDLeftMiddle.Value + ";0;" + numUDRightIndex.Value + ";0;0;\n"); break;
                case 'g': _arduino.Write(numUDLeftIndex.Value + ";" + numUDLeftMiddle.Value + ";0;" + numUDRightIndex.Value + ";" + numUDRightMiddle.Value + ";0;\n"); break;
                case 'h': _arduino.Write(numUDLeftIndex.Value + ";" + numUDLeftMiddle.Value + ";0;0;" + numUDRightMiddle.Value + ";0;\n"); break;
                case 'i': _arduino.Write("0;" + numUDLeftMiddle.Value + ";0;" + numUDRightIndex.Value + ";0;0;\n"); break;
                case 'j': _arduino.Write("0;" + numUDLeftMiddle.Value + ";0;" + numUDRightIndex.Value + ";" + numUDRightMiddle.Value + ";0;\n"); break;
                case 'k': _arduino.Write(numUDLeftIndex.Value + ";0;" + numUDLeftRing.Value + ";0;0;0;\n"); break;
                case 'l': _arduino.Write(numUDLeftIndex.Value + ";" + numUDLeftMiddle.Value + ";" + numUDLeftRing.Value + ";0;0;0;\n"); break;
                case 'm': _arduino.Write(numUDLeftIndex.Value + ";0;" + numUDLeftRing.Value + ";" + numUDRightIndex.Value + ";0;0;\n"); break;
                case 'n': _arduino.Write(numUDLeftIndex.Value + ";0;" + numUDLeftRing.Value + ";" + numUDRightIndex.Value + ";" + numUDRightMiddle.Value + ";0;\n"); break;
                case 'o': _arduino.Write(numUDLeftIndex.Value + ";0;" + numUDLeftRing.Value + ";0;" + numUDRightMiddle.Value + ";0;\n"); break;
                case 'p': _arduino.Write(numUDLeftIndex.Value + ";" + numUDLeftMiddle.Value + ";" + numUDLeftRing.Value + ";" + numUDRightIndex.Value + ";0;0;\n"); break;
                case 'q': _arduino.Write(numUDLeftIndex.Value + ";" + numUDLeftMiddle.Value + ";" + numUDLeftRing.Value + ";" + numUDRightIndex.Value + ";" + numUDRightMiddle.Value + ";0;\n"); break;
                case 'r': _arduino.Write(numUDLeftIndex.Value + ";" + numUDLeftMiddle.Value + ";" + numUDLeftRing.Value + ";0;" + numUDRightMiddle.Value + ";0;\n"); break;
                case 's': _arduino.Write("0;" + numUDLeftMiddle.Value + ";" + numUDLeftRing.Value + ";" + numUDRightIndex.Value + ";0;0;\n"); break;
                case 't': _arduino.Write("0;" + numUDLeftMiddle.Value + ";" + numUDLeftRing.Value + ";" + numUDRightIndex.Value + ";" + numUDRightMiddle.Value + ";0;\n"); break;
                case 'u': _arduino.Write(numUDLeftIndex.Value + ";0;" + numUDLeftRing.Value + ";0;0;" + numUDRightRing.Value + ";\n"); break;
                case 'v': _arduino.Write(numUDLeftIndex.Value + ";" + numUDLeftMiddle.Value + ";" + numUDLeftRing.Value + ";0;0;" + numUDRightRing.Value + ";\n"); break;
                case 'w': _arduino.Write("0;" + numUDLeftMiddle.Value + ";0;" + numUDRightIndex.Value + ";" + numUDRightMiddle.Value + ";" + numUDRightRing.Value + ";\n"); break;
                case 'x': _arduino.Write(numUDLeftIndex.Value + ";0;" + numUDLeftRing.Value + ";" + numUDRightIndex.Value + ";0;" + numUDRightRing.Value + ";\n"); break;
                case 'y': _arduino.Write(numUDLeftIndex.Value + ";0;" + numUDLeftRing.Value + ";" + numUDRightIndex.Value + ";" + numUDRightMiddle.Value + ";" + numUDRightRing.Value + ";\n"); break;
                case 'z': _arduino.Write(numUDLeftIndex.Value + ";0;" + numUDLeftRing.Value + ";0;" + numUDRightMiddle.Value + ";" + numUDRightRing.Value + ";\n"); break;
                case ' ': _arduino.Write("0;0;0;0;0;0;\n"); break; // ?
            }
        }

        // send message accordingly to selected fingers
        private void btSendFingers_Click(object sender, EventArgs e)
        {
            string message = "";

            if (cbLeftIndex.Checked) message += numUDLeftIndex.Value; else message += "0";
            message += ";";
            if (cbLeftMiddle.Checked) message += numUDLeftMiddle.Value; else message += "0";
            message += ";";
            if (cbLeftRing.Checked) message += numUDLeftRing.Value; else message += "0";
            message += ";";
            if (cbRightIndex.Checked) message += numUDRightIndex.Value; else message += "0";
            message += ";";
            if (cbRightMiddle.Checked) message += numUDRightMiddle.Value; else message += "0";
            message += ";";
            if (cbRightRing.Checked) message += numUDRightRing.Value; else message += "0";
            message += ";";
            message += "\n";

            _arduino.Write(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _arduino.Write("0;0;0;0;0;0;\n");
        }
    }
}
