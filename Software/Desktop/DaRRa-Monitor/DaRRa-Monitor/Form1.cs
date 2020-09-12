/**
 * Design Competition MR HHN WS18/19
 * 
 * Copyright (c) Jean-Marcel Herzog
 *
 * MIT License
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this
 * software and associated documentation files (the "Software"), to deal in the Software 
 * without restriction, including without limitation the rights to use, copy, modify, merge,
 * publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
 * to whom the Software is furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
 * PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
 * FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
 * OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 * DEALINGS IN THE SOFTWARE.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaRRa_Monitor
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        char command = ' ';
        int val = -1;
        int id = -1;


        private void ShowData(object sender, EventArgs e)
        {
            switch (id)
            {
                case 1:
                    lbl_links.Text = val.ToString() + " cm";
                    break;
                case 2:
                    lbl_rechts.Text = val.ToString() + " cm";
                    break;
                case 3:
                    lbl_vorn.Text = val.ToString() + " cm";
                    break;
            }

        } //end of private void ShowData()

        private void com_received(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            string rx = serialPort1.ReadLine();
            string[] arr = null;
            arr = rx.Split('_');

            if(arr[0][0] == 'X') //Kennzeichnet den Start eines Kommandos
            {
                command = arr[0][1];

                id = Convert.ToInt32(arr[1]);
                val = Convert.ToInt32(arr[2]);
            }
            else
            {
                return;
            }

            if(command == 'B') //Sensor Kommando erkannt
            {
                this.Invoke(new EventHandler(ShowData));
            }

        } //end of private void com_received()

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if(cB_COMPorts.SelectedIndex >= 0)
            {
                //SerialPort Einstellungen
                serialPort1.DataBits = 8;
                serialPort1.PortName = cB_COMPorts.SelectedItem.ToString();
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.BaudRate = 9600;


                //Verbindung zum SerialPort herstellen
                try
                {
                    serialPort1.Open();

                    //GroupBoxen aktivieren
                    group_Sensoren.Enabled = true;
                    group_getriebemotor.Enabled = true;
                    group_dcmotor.Enabled = true;
                }catch(Exception ex)
                {
                    MessageBox.Show("COM Port konnte nicht geöffnet werden: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kein COM Port gewählt.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //end of private void btn_connect_click()

        private void btn_dcStart_Click(object sender, EventArgs e)
        {
            serialPort1.Write("L");
        }

        private void btn_dcStopp_Click(object sender, EventArgs e)
        {
            serialPort1.Write("S");
        }

        private void btn_syncVorw_Click(object sender, EventArgs e)
        {
            serialPort1.Write("G");
        }

        private void btn_syncRueck_Click(object sender, EventArgs e)
        {
            serialPort1.Write("H");
        }

        private void btn_syncStopp_Click(object sender, EventArgs e)
        {
            serialPort1.Write("I");
        }

        private void btn_linksVor_Click(object sender, EventArgs e)
        {
            serialPort1.Write("A");
        }

        private void btn_linksRueck_Click(object sender, EventArgs e)
        {
            serialPort1.Write("B");
        }

        private void btn_linksStopp_Click(object sender, EventArgs e)
        {
            serialPort1.Write("C");
        }

        private void btn_rechtsVor_Click(object sender, EventArgs e)
        {
            serialPort1.Write("D");
        }

        private void btn_rechtsRueck_Click(object sender, EventArgs e)
        {
            serialPort1.Write("E");
        }

        private void btn_rechtsStopp_Click(object sender, EventArgs e)
        {
            serialPort1.Write("F");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var sp = SerialPort.GetPortNames();

            foreach (string s in sp)
            {
                cB_COMPorts.Items.Add(s);
            }
        }

        private void btn_180links_Click(object sender, EventArgs e)
        {
            serialPort1.Write("Y");
        }

        private void btn_180rechts_Click(object sender, EventArgs e)
        {
            serialPort1.Write("Z");
        }
    }
}
