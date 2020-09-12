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

namespace DaRRa_Interface
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public SerialPort sp;

        private void button1_Click(object sender, EventArgs e)
        {
            

            Application.Exit();
            
        }

        private void btn_verbinden_Click(object sender, EventArgs e)
        {
            if(cB_ports.SelectedIndex >= 0)
            {
                sp.DataBits = 8;
                sp.PortName = cB_ports.SelectedItem.ToString();
                sp.Parity = Parity.None;
                sp.StopBits = StopBits.One;
                sp.ReadTimeout = 20;
                sp.WriteTimeout = 20;
                sp.BaudRate = Convert.ToInt32(cB_baudrate.SelectedItem.ToString());

                try
                {
                    sp.Open();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show("COM Port konnte nicht geöffnet werden: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kein COM Port gewählt.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var sp = SerialPort.GetPortNames();
            foreach (string s in sp)
            {
                cB_ports.Items.Add(s);
            }
        }
    }
}
