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
using System.Windows.Forms.DataVisualization.Charting;

namespace DaRRa_Interface
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        Series series_links = new Series("links");
        Series series_rechts = new Series("rechts");
        Series series_vorne = new Series("vorne");

        //char command = ' ';
        public int val = -1;
        public int id = -1;
        public string state = "-";
        public string min_dist_front = "-";
        public string drehzeit = "-";
        public string min_dist_side = "-";

        public SerialPort serialPort;

        public string COM_PORT;
        
        private void Interface_Load(object sender, EventArgs e)
        {
            serialPort1 = serialPort;
           
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            
            cB_modus.SelectedItem = "Manuell";

            series_links.Points.DataBindXY(new[] {0 }, new[] {0});
            series_links.ChartType = SeriesChartType.Spline;
            series_links.Color = Color.Red;
            chart_links.ChartAreas[0].AxisX.Interval = 100;
            chart_links.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart_links.Series.Add(series_links);


            series_rechts.Points.DataBindXY(new[] { 0 }, new[] { 0 });
            series_rechts.ChartType = SeriesChartType.Spline;
            series_rechts.Color = Color.Red;
            chart_rechts.ChartAreas[0].AxisX.Interval = 100;
            chart_links.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart_rechts.Series.Add(series_rechts);

            series_vorne.Points.DataBindXY(new[] { 0 }, new[] { 0 });
            series_vorne.ChartType = SeriesChartType.Spline;
            series_vorne.Color = Color.Red;
            chart_vorne.ChartAreas[0].AxisX.Interval = 100;
            chart_links.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart_vorne.Series.Add(series_vorne);
        }

       
      

        private void btn_start_Click(object sender, EventArgs e)
        {
            serialPort1.Write("J");

            gB_manuell_gear_left.Enabled = false;
            gB_manuell_gear_right.Enabled = false;
            gB_manuell_rotate.Enabled = false;
            gB_manuell_pullout.Enabled = false;
            gB_sync_gear.Enabled = false;
            cB_modus.Enabled = false;
        }

        private void btn_stopp_Click(object sender, EventArgs e)
        {
            serialPort1.Write("Q");
            lbl_task.Text = "-";
            cB_modus.Text = "Manuell";
            gB_manuell_gear_left.Enabled = true;
            gB_manuell_gear_right.Enabled = true;
            gB_manuell_rotate.Enabled = true;
            gB_manuell_pullout.Enabled = true;
            gB_sync_gear.Enabled = true;
            cB_modus.Enabled = true;
        }

        public void ShowData()
        {
            switch (id)
            {
                case 1:
                    lbl_distRechts.Text = val.ToString() + " cm";
                    series_rechts.Points.Add(val);
                break;

                case 2:
                    lbl_distLinks.Text = val.ToString() + " cm";
                    series_links.Points.Add(val);
                break;

                case 3:
                    lbl_distVorne.Text = val.ToString() + " cm";
                    series_vorne.Points.Add(val);
                    break;
               case 4:
                    lbl_drehzeit.Text = drehzeit;
                    lbl_dist_vorne.Text = min_dist_front;
                    lbl_distside.Text = min_dist_side;
                    break;

                case 5:
                   
                   if(state.StartsWith("0"))
                    {
                        lbl_task.Text = "Initialisierung";
                    }
                   else if (state.StartsWith("1"))
                    {
                        lbl_task.Text = "Einrichtung";
                    }
                   else if (state.StartsWith("2"))
                    {
                        lbl_task.Text = "Vorwärts Bewegung";
                    }
                   else if (state.StartsWith("3"))
                    {
                        lbl_task.Text = "Rückwärts Bewegung";
                    }
                   else if (state.StartsWith("4"))
                    {
                        lbl_task.Text = "Drehung links";
                    }
                   else if (state.StartsWith("5"))
                    {
                        lbl_task.Text = "Drehung rechts";
                    }

                    break;
            }

            
        }

        private void btn_Gear_Left_forward_Click(object sender, EventArgs e)
        {
            serialPort1.Write("A");
        }

        private void btn_gear_left_backward_Click(object sender, EventArgs e)
        {
            serialPort1.Write("B");
        }

        private void btn_gear_left_stopp_Click(object sender, EventArgs e)
        {
            serialPort1.Write("C");
        }

        private void btn_gear_right_forward_Click(object sender, EventArgs e)
        {
            serialPort1.Write("D");
        }

        private void btn_gear_right_backward_Click(object sender, EventArgs e)
        {
            serialPort1.Write("E");
        }

        private void btn_gear_right_stopp_Click(object sender, EventArgs e)
        {
            serialPort1.Write("F");
        }

        private void btn_sync_forward_Click(object sender, EventArgs e)
        {
            serialPort1.Write("G");
        }

        private void btn_sync_backward_Click(object sender, EventArgs e)
        {
            serialPort1.Write("H");
        }

        private void btn_sync_stopp_Click(object sender, EventArgs e)
        {
            serialPort1.Write("I");
        }

        private void btn_180_left_Click(object sender, EventArgs e)
        {
            serialPort1.Write("Y");
        }

        private void btn_180_right_Click(object sender, EventArgs e)
        {
            serialPort1.Write("Z");
        }

        private void cB_modus_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cB_modus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_modus.SelectedItem.ToString() == "Automatik")
            {
                serialPort1.Write("+");
                gB_manuell_gear_left.Enabled = false;
                gB_manuell_gear_right.Enabled = false;
                gB_manuell_pullout.Enabled = false;
                gB_manuell_rotate.Enabled = false;
                gB_sync_gear.Enabled = false;

                btn_start.Enabled = true;
                btn_stopp.Enabled = true;
            }
            else
            {
                serialPort1.Write("-");
                gB_manuell_gear_left.Enabled = true;
                gB_manuell_gear_right.Enabled = true;
                gB_manuell_pullout.Enabled = true;
                gB_manuell_rotate.Enabled = true;
                gB_sync_gear.Enabled = true;
            }
        }

        private void btn_drehzeitClick(object sender, EventArgs e)
        {
            
                serialPort1.Write("_V_1_" + tb_drehzeit.Text + "_");
            
            
            tB_log.Text += "Drehzeit wurde auf " + tb_drehzeit.Text + " ms geändert.";
            tb_drehzeit.Clear();
        }

        private void btn_distanzFront_Click(object sender, EventArgs e)
        {
           serialPort.Write("_V_2_" + tb_distanceFront.Text + "_");

            tB_log.Text += "Min. Abstand vorne wurde auf " + tb_distanceFront.Text + " cm geändert.";
            tb_distanceFront.Clear();
        }

        private void btn_distanzSide_Click(object sender, EventArgs e)
        {
           
            serialPort1.WriteLine("_V_3_" + tb_distanceSide.Text + "_");
            
            tB_log.Text += "Min. Abstand links/rechts wurde auf " + tb_drehzeit.Text + " cm geändert.";
            tb_distanceSide.Clear();
        }
    }
}
