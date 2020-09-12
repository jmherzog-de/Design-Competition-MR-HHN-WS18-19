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

namespace DaRRa_Monitor
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.group_getriebemotor = new System.Windows.Forms.GroupBox();
            this.btn_syncStopp = new System.Windows.Forms.Button();
            this.btn_syncRueck = new System.Windows.Forms.Button();
            this.btn_syncVorw = new System.Windows.Forms.Button();
            this.btn_rechtsStopp = new System.Windows.Forms.Button();
            this.btn_linksStopp = new System.Windows.Forms.Button();
            this.btn_rechtsRueck = new System.Windows.Forms.Button();
            this.btn_rechtsVor = new System.Windows.Forms.Button();
            this.btn_linksRueck = new System.Windows.Forms.Button();
            this.btn_linksVor = new System.Windows.Forms.Button();
            this.group_dcmotor = new System.Windows.Forms.GroupBox();
            this.btn_dcStopp = new System.Windows.Forms.Button();
            this.btn_dcStart = new System.Windows.Forms.Button();
            this.group_Sensoren = new System.Windows.Forms.GroupBox();
            this.lbl_links = new System.Windows.Forms.Label();
            this.lbl_rechts = new System.Windows.Forms.Label();
            this.lbl_vorn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.group_COMPort = new System.Windows.Forms.GroupBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.cB_COMPorts = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_180links = new System.Windows.Forms.Button();
            this.btn_180rechts = new System.Windows.Forms.Button();
            this.group_getriebemotor.SuspendLayout();
            this.group_dcmotor.SuspendLayout();
            this.group_Sensoren.SuspendLayout();
            this.group_COMPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_getriebemotor
            // 
            this.group_getriebemotor.Controls.Add(this.btn_180rechts);
            this.group_getriebemotor.Controls.Add(this.btn_180links);
            this.group_getriebemotor.Controls.Add(this.btn_syncStopp);
            this.group_getriebemotor.Controls.Add(this.btn_syncRueck);
            this.group_getriebemotor.Controls.Add(this.btn_syncVorw);
            this.group_getriebemotor.Controls.Add(this.btn_rechtsStopp);
            this.group_getriebemotor.Controls.Add(this.btn_linksStopp);
            this.group_getriebemotor.Controls.Add(this.btn_rechtsRueck);
            this.group_getriebemotor.Controls.Add(this.btn_rechtsVor);
            this.group_getriebemotor.Controls.Add(this.btn_linksRueck);
            this.group_getriebemotor.Controls.Add(this.btn_linksVor);
            this.group_getriebemotor.Enabled = false;
            this.group_getriebemotor.Location = new System.Drawing.Point(12, 210);
            this.group_getriebemotor.Name = "group_getriebemotor";
            this.group_getriebemotor.Size = new System.Drawing.Size(311, 216);
            this.group_getriebemotor.TabIndex = 7;
            this.group_getriebemotor.TabStop = false;
            this.group_getriebemotor.Text = "Getriebemotoren";
            // 
            // btn_syncStopp
            // 
            this.btn_syncStopp.Location = new System.Drawing.Point(6, 51);
            this.btn_syncStopp.Name = "btn_syncStopp";
            this.btn_syncStopp.Size = new System.Drawing.Size(293, 23);
            this.btn_syncStopp.TabIndex = 8;
            this.btn_syncStopp.Text = "Synchron Stopp";
            this.btn_syncStopp.UseVisualStyleBackColor = true;
            this.btn_syncStopp.Click += new System.EventHandler(this.btn_syncStopp_Click);
            // 
            // btn_syncRueck
            // 
            this.btn_syncRueck.Location = new System.Drawing.Point(159, 22);
            this.btn_syncRueck.Name = "btn_syncRueck";
            this.btn_syncRueck.Size = new System.Drawing.Size(140, 23);
            this.btn_syncRueck.TabIndex = 7;
            this.btn_syncRueck.Text = "Synchron rückwärts";
            this.btn_syncRueck.UseVisualStyleBackColor = true;
            this.btn_syncRueck.Click += new System.EventHandler(this.btn_syncRueck_Click);
            // 
            // btn_syncVorw
            // 
            this.btn_syncVorw.Location = new System.Drawing.Point(6, 22);
            this.btn_syncVorw.Name = "btn_syncVorw";
            this.btn_syncVorw.Size = new System.Drawing.Size(140, 23);
            this.btn_syncVorw.TabIndex = 6;
            this.btn_syncVorw.Text = "Synchron vorwärts";
            this.btn_syncVorw.UseVisualStyleBackColor = true;
            this.btn_syncVorw.Click += new System.EventHandler(this.btn_syncVorw_Click);
            // 
            // btn_rechtsStopp
            // 
            this.btn_rechtsStopp.Location = new System.Drawing.Point(172, 187);
            this.btn_rechtsStopp.Name = "btn_rechtsStopp";
            this.btn_rechtsStopp.Size = new System.Drawing.Size(118, 23);
            this.btn_rechtsStopp.TabIndex = 5;
            this.btn_rechtsStopp.Text = "Rechts Stopp";
            this.btn_rechtsStopp.UseVisualStyleBackColor = true;
            this.btn_rechtsStopp.Click += new System.EventHandler(this.btn_rechtsStopp_Click);
            // 
            // btn_linksStopp
            // 
            this.btn_linksStopp.Location = new System.Drawing.Point(9, 187);
            this.btn_linksStopp.Name = "btn_linksStopp";
            this.btn_linksStopp.Size = new System.Drawing.Size(118, 23);
            this.btn_linksStopp.TabIndex = 4;
            this.btn_linksStopp.Text = "Links Stopp";
            this.btn_linksStopp.UseVisualStyleBackColor = true;
            this.btn_linksStopp.Click += new System.EventHandler(this.btn_linksStopp_Click);
            // 
            // btn_rechtsRueck
            // 
            this.btn_rechtsRueck.Location = new System.Drawing.Point(172, 158);
            this.btn_rechtsRueck.Name = "btn_rechtsRueck";
            this.btn_rechtsRueck.Size = new System.Drawing.Size(118, 23);
            this.btn_rechtsRueck.TabIndex = 3;
            this.btn_rechtsRueck.Text = "Rechts rückwärts";
            this.btn_rechtsRueck.UseVisualStyleBackColor = true;
            this.btn_rechtsRueck.Click += new System.EventHandler(this.btn_rechtsRueck_Click);
            // 
            // btn_rechtsVor
            // 
            this.btn_rechtsVor.Location = new System.Drawing.Point(172, 131);
            this.btn_rechtsVor.Name = "btn_rechtsVor";
            this.btn_rechtsVor.Size = new System.Drawing.Size(118, 23);
            this.btn_rechtsVor.TabIndex = 2;
            this.btn_rechtsVor.Text = "Rechts vorwärts";
            this.btn_rechtsVor.UseVisualStyleBackColor = true;
            this.btn_rechtsVor.Click += new System.EventHandler(this.btn_rechtsVor_Click);
            // 
            // btn_linksRueck
            // 
            this.btn_linksRueck.Location = new System.Drawing.Point(9, 160);
            this.btn_linksRueck.Name = "btn_linksRueck";
            this.btn_linksRueck.Size = new System.Drawing.Size(118, 23);
            this.btn_linksRueck.TabIndex = 1;
            this.btn_linksRueck.Text = "Links rückwärts";
            this.btn_linksRueck.UseVisualStyleBackColor = true;
            this.btn_linksRueck.Click += new System.EventHandler(this.btn_linksRueck_Click);
            // 
            // btn_linksVor
            // 
            this.btn_linksVor.Location = new System.Drawing.Point(9, 131);
            this.btn_linksVor.Name = "btn_linksVor";
            this.btn_linksVor.Size = new System.Drawing.Size(118, 23);
            this.btn_linksVor.TabIndex = 0;
            this.btn_linksVor.Text = "Links vorwärts";
            this.btn_linksVor.UseVisualStyleBackColor = true;
            this.btn_linksVor.Click += new System.EventHandler(this.btn_linksVor_Click);
            // 
            // group_dcmotor
            // 
            this.group_dcmotor.Controls.Add(this.btn_dcStopp);
            this.group_dcmotor.Controls.Add(this.btn_dcStart);
            this.group_dcmotor.Enabled = false;
            this.group_dcmotor.Location = new System.Drawing.Point(12, 145);
            this.group_dcmotor.Name = "group_dcmotor";
            this.group_dcmotor.Size = new System.Drawing.Size(311, 59);
            this.group_dcmotor.TabIndex = 6;
            this.group_dcmotor.TabStop = false;
            this.group_dcmotor.Text = "DC-Motor";
            // 
            // btn_dcStopp
            // 
            this.btn_dcStopp.Location = new System.Drawing.Point(108, 19);
            this.btn_dcStopp.Name = "btn_dcStopp";
            this.btn_dcStopp.Size = new System.Drawing.Size(92, 23);
            this.btn_dcStopp.TabIndex = 1;
            this.btn_dcStopp.Text = "Stopp";
            this.btn_dcStopp.UseVisualStyleBackColor = true;
            this.btn_dcStopp.Click += new System.EventHandler(this.btn_dcStopp_Click);
            // 
            // btn_dcStart
            // 
            this.btn_dcStart.Location = new System.Drawing.Point(10, 19);
            this.btn_dcStart.Name = "btn_dcStart";
            this.btn_dcStart.Size = new System.Drawing.Size(92, 23);
            this.btn_dcStart.TabIndex = 0;
            this.btn_dcStart.Text = "Start";
            this.btn_dcStart.UseVisualStyleBackColor = true;
            this.btn_dcStart.Click += new System.EventHandler(this.btn_dcStart_Click);
            // 
            // group_Sensoren
            // 
            this.group_Sensoren.Controls.Add(this.lbl_links);
            this.group_Sensoren.Controls.Add(this.lbl_rechts);
            this.group_Sensoren.Controls.Add(this.lbl_vorn);
            this.group_Sensoren.Controls.Add(this.label3);
            this.group_Sensoren.Controls.Add(this.label2);
            this.group_Sensoren.Controls.Add(this.label1);
            this.group_Sensoren.Enabled = false;
            this.group_Sensoren.Location = new System.Drawing.Point(12, 71);
            this.group_Sensoren.Name = "group_Sensoren";
            this.group_Sensoren.Size = new System.Drawing.Size(311, 68);
            this.group_Sensoren.TabIndex = 5;
            this.group_Sensoren.TabStop = false;
            this.group_Sensoren.Text = "Sensoren";
            // 
            // lbl_links
            // 
            this.lbl_links.AutoSize = true;
            this.lbl_links.Location = new System.Drawing.Point(134, 32);
            this.lbl_links.Name = "lbl_links";
            this.lbl_links.Size = new System.Drawing.Size(33, 16);
            this.lbl_links.TabIndex = 5;
            this.lbl_links.Text = "- cm";
            // 
            // lbl_rechts
            // 
            this.lbl_rechts.AutoSize = true;
            this.lbl_rechts.Location = new System.Drawing.Point(236, 32);
            this.lbl_rechts.Name = "lbl_rechts";
            this.lbl_rechts.Size = new System.Drawing.Size(33, 16);
            this.lbl_rechts.TabIndex = 4;
            this.lbl_rechts.Text = "- cm";
            // 
            // lbl_vorn
            // 
            this.lbl_vorn.AutoSize = true;
            this.lbl_vorn.Location = new System.Drawing.Point(45, 32);
            this.lbl_vorn.Name = "lbl_vorn";
            this.lbl_vorn.Size = new System.Drawing.Size(33, 16);
            this.lbl_vorn.TabIndex = 3;
            this.lbl_vorn.Text = "- cm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Links:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rechts:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorn:";
            // 
            // group_COMPort
            // 
            this.group_COMPort.Controls.Add(this.btn_connect);
            this.group_COMPort.Controls.Add(this.cB_COMPorts);
            this.group_COMPort.Location = new System.Drawing.Point(12, 12);
            this.group_COMPort.Name = "group_COMPort";
            this.group_COMPort.Size = new System.Drawing.Size(311, 53);
            this.group_COMPort.TabIndex = 4;
            this.group_COMPort.TabStop = false;
            this.group_COMPort.Text = "COM-Port";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(156, 17);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(101, 23);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "verbinden";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // cB_COMPorts
            // 
            this.cB_COMPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_COMPorts.FormattingEnabled = true;
            this.cB_COMPorts.Location = new System.Drawing.Point(6, 19);
            this.cB_COMPorts.Name = "cB_COMPorts";
            this.cB_COMPorts.Size = new System.Drawing.Size(144, 24);
            this.cB_COMPorts.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.com_received);
            // 
            // btn_180links
            // 
            this.btn_180links.Location = new System.Drawing.Point(10, 102);
            this.btn_180links.Name = "btn_180links";
            this.btn_180links.Size = new System.Drawing.Size(117, 23);
            this.btn_180links.TabIndex = 9;
            this.btn_180links.Text = "180 - links";
            this.btn_180links.UseVisualStyleBackColor = true;
            this.btn_180links.Click += new System.EventHandler(this.btn_180links_Click);
            // 
            // btn_180rechts
            // 
            this.btn_180rechts.Location = new System.Drawing.Point(172, 102);
            this.btn_180rechts.Name = "btn_180rechts";
            this.btn_180rechts.Size = new System.Drawing.Size(118, 23);
            this.btn_180rechts.TabIndex = 10;
            this.btn_180rechts.Text = "180 - rechts";
            this.btn_180rechts.UseVisualStyleBackColor = true;
            this.btn_180rechts.Click += new System.EventHandler(this.btn_180rechts_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 438);
            this.Controls.Add(this.group_getriebemotor);
            this.Controls.Add(this.group_dcmotor);
            this.Controls.Add(this.group_Sensoren);
            this.Controls.Add(this.group_COMPort);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DaRRa-Monitor Version 1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.group_getriebemotor.ResumeLayout(false);
            this.group_dcmotor.ResumeLayout(false);
            this.group_Sensoren.ResumeLayout(false);
            this.group_Sensoren.PerformLayout();
            this.group_COMPort.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_getriebemotor;
        private System.Windows.Forms.Button btn_syncStopp;
        private System.Windows.Forms.Button btn_syncRueck;
        private System.Windows.Forms.Button btn_syncVorw;
        private System.Windows.Forms.Button btn_rechtsStopp;
        private System.Windows.Forms.Button btn_linksStopp;
        private System.Windows.Forms.Button btn_rechtsRueck;
        private System.Windows.Forms.Button btn_linksRueck;
        private System.Windows.Forms.Button btn_linksVor;
        private System.Windows.Forms.GroupBox group_dcmotor;
        private System.Windows.Forms.Button btn_dcStopp;
        private System.Windows.Forms.Button btn_dcStart;
        private System.Windows.Forms.GroupBox group_Sensoren;
        private System.Windows.Forms.Label lbl_links;
        private System.Windows.Forms.Label lbl_rechts;
        private System.Windows.Forms.Label lbl_vorn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox group_COMPort;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ComboBox cB_COMPorts;
        private System.Windows.Forms.Button btn_rechtsVor;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_180rechts;
        private System.Windows.Forms.Button btn_180links;
    }
}

