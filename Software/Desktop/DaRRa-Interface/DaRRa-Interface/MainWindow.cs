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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaRRa_Interface
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Interface interfaceForm = new Interface();
        char command = ' ';
        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.StartPosition = FormStartPosition.CenterParent;
            loginForm.sp = serialPort;
            var result = loginForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                
                interfaceForm.MdiParent = this;
                interfaceForm.StartPosition = FormStartPosition.CenterScreen;
                interfaceForm.serialPort = serialPort;
                interfaceForm.Show();
            }
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {

                string rx = serialPort.ReadLine();
                string[] arr = rx.Split('_');

                if (arr[0][0] == 'X') //Kennzeichnet den Start eines Kommandos
                {
                    command = arr[0][1];

                }
                

                if (command == 'B') //Sensor Kommando erkannt
                {
                    if(Convert.ToInt32(arr[2]) == interfaceForm.val)
                    {
                        return;
                    }
                    interfaceForm.id = Convert.ToInt32(arr[1]);
                    interfaceForm.val = Convert.ToInt32(arr[2]);

                    if (this.InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(interfaceForm.ShowData));
                    }



                }
                else if (command == 'P') //Parameter einlesen
                {
                    interfaceForm.id = 4;
                    

                    if (arr[1].ToString() == "1")
                    {
                        if(interfaceForm.drehzeit != arr[1].ToString())
                        {
                            interfaceForm.drehzeit = arr[2].ToString();
                        }
                        else
                        {
                            return;
                        }
                        
                    }
                    else if (arr[1].ToString() == "2")
                    {
                        if(interfaceForm.min_dist_front != arr[2].ToString())
                        {
                            interfaceForm.min_dist_front = arr[2].ToString();
                        }
                        else
                        {
                            return;
                        }
                        
                    }
                    else if (arr[1].ToString() == "3")
                    {
                        if(interfaceForm.min_dist_side != arr[2].ToString())
                        {
                            interfaceForm.min_dist_side = arr[2].ToString();
                        }
                        else
                        {
                            return;
                        }
                        
                    }

                    if (this.InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(interfaceForm.ShowData));
                    }
                        
                    
                }else if(command == 'S') //State einlesen
                {
                    interfaceForm.id = 5;

                   
                    if(interfaceForm.state != arr[2].ToString())
                    {
                        interfaceForm.state = arr[2].ToString();
                    }
                    else
                    {
                        return;
                    }

                    if (this.InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(interfaceForm.ShowData));
                    }
                }


            }
            catch(Exception ex) { }
            



        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Dispose();
            }
        }

        private void MainWindow_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }
    }
}
