namespace DaRRa_Interface
{
    partial class Interface
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_task = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tB_log = new System.Windows.Forms.RichTextBox();
            this.btn_stopp = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.chart_rechts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_vorne = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_links = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_distRechts = new System.Windows.Forms.Label();
            this.lbl_distVorne = new System.Windows.Forms.Label();
            this.lbl_distLinks = new System.Windows.Forms.Label();
            this.tabPage_manuelleSteuerung = new System.Windows.Forms.TabPage();
            this.gB_manuell_rotate = new System.Windows.Forms.GroupBox();
            this.btn_90_right = new System.Windows.Forms.Button();
            this.btn_90_left = new System.Windows.Forms.Button();
            this.btn_180_right = new System.Windows.Forms.Button();
            this.btn_180_left = new System.Windows.Forms.Button();
            this.gB_sync_gear = new System.Windows.Forms.GroupBox();
            this.btn_sync_stopp = new System.Windows.Forms.Button();
            this.btn_sync_backward = new System.Windows.Forms.Button();
            this.btn_sync_forward = new System.Windows.Forms.Button();
            this.gB_manuell_pullout = new System.Windows.Forms.GroupBox();
            this.btn_pullout_stopp = new System.Windows.Forms.Button();
            this.btn_pullout_start = new System.Windows.Forms.Button();
            this.gB_manuell_gear_right = new System.Windows.Forms.GroupBox();
            this.btn_gear_right_stopp = new System.Windows.Forms.Button();
            this.btn_gear_right_backward = new System.Windows.Forms.Button();
            this.btn_gear_right_forward = new System.Windows.Forms.Button();
            this.gB_manuell_gear_left = new System.Windows.Forms.GroupBox();
            this.btn_gear_left_stopp = new System.Windows.Forms.Button();
            this.btn_gear_left_backward = new System.Windows.Forms.Button();
            this.btn_Gear_Left_forward = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_distanzSide = new System.Windows.Forms.Button();
            this.tb_distanceSide = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_distanzFront = new System.Windows.Forms.Button();
            this.tb_distanceFront = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btn_drehzeit = new System.Windows.Forms.Button();
            this.tb_drehzeit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cB_modus = new System.Windows.Forms.ToolStripComboBox();
            this.lbl_drehzeit = new System.Windows.Forms.Label();
            this.lbl_dist_vorne = new System.Windows.Forms.Label();
            this.lbl_distside = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_rechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_vorne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_links)).BeginInit();
            this.tabPage_manuelleSteuerung.SuspendLayout();
            this.gB_manuell_rotate.SuspendLayout();
            this.gB_sync_gear.SuspendLayout();
            this.gB_manuell_pullout.SuspendLayout();
            this.gB_manuell_gear_right.SuspendLayout();
            this.gB_manuell_gear_left.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage_manuelleSteuerung);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1198, 539);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lbl_task);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btn_stopp);
            this.tabPage1.Controls.Add(this.btn_start);
            this.tabPage1.Controls.Add(this.chart_rechts);
            this.tabPage1.Controls.Add(this.chart_vorne);
            this.tabPage1.Controls.Add(this.chart_links);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lbl_distRechts);
            this.tabPage1.Controls.Add(this.lbl_distVorne);
            this.tabPage1.Controls.Add(this.lbl_distLinks);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1190, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(559, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Task: ";
            // 
            // lbl_task
            // 
            this.lbl_task.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_task.AutoSize = true;
            this.lbl_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_task.Location = new System.Drawing.Point(660, 278);
            this.lbl_task.Name = "lbl_task";
            this.lbl_task.Size = new System.Drawing.Size(23, 31);
            this.lbl_task.TabIndex = 13;
            this.lbl_task.Text = "-";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.tB_log);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 293);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // tB_log
            // 
            this.tB_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_log.Cursor = System.Windows.Forms.Cursors.No;
            this.tB_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tB_log.Location = new System.Drawing.Point(3, 34);
            this.tB_log.Name = "tB_log";
            this.tB_log.Size = new System.Drawing.Size(494, 256);
            this.tB_log.TabIndex = 0;
            this.tB_log.Text = "";
            // 
            // btn_stopp
            // 
            this.btn_stopp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stopp.Enabled = false;
            this.btn_stopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stopp.Location = new System.Drawing.Point(944, 379);
            this.btn_stopp.Name = "btn_stopp";
            this.btn_stopp.Size = new System.Drawing.Size(240, 125);
            this.btn_stopp.TabIndex = 15;
            this.btn_stopp.Text = "Stopp";
            this.btn_stopp.UseVisualStyleBackColor = true;
            this.btn_stopp.Click += new System.EventHandler(this.btn_stopp_Click);
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.Enabled = false;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(518, 379);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(420, 125);
            this.btn_start.TabIndex = 14;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // chart_rechts
            // 
            this.chart_rechts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_rechts.BackColor = System.Drawing.Color.Gainsboro;
            chartArea4.Name = "ChartArea1";
            this.chart_rechts.ChartAreas.Add(chartArea4);
            this.chart_rechts.Location = new System.Drawing.Point(808, 69);
            this.chart_rechts.Name = "chart_rechts";
            this.chart_rechts.Size = new System.Drawing.Size(376, 136);
            this.chart_rechts.TabIndex = 11;
            this.chart_rechts.Text = "chart3";
            // 
            // chart_vorne
            // 
            this.chart_vorne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_vorne.BackColor = System.Drawing.Color.Gainsboro;
            chartArea5.Name = "ChartArea1";
            this.chart_vorne.ChartAreas.Add(chartArea5);
            this.chart_vorne.Location = new System.Drawing.Point(407, 69);
            this.chart_vorne.Name = "chart_vorne";
            this.chart_vorne.Size = new System.Drawing.Size(376, 136);
            this.chart_vorne.TabIndex = 10;
            this.chart_vorne.Text = "chart2";
            // 
            // chart_links
            // 
            this.chart_links.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_links.BackColor = System.Drawing.Color.Gainsboro;
            chartArea6.Name = "ChartArea1";
            this.chart_links.ChartAreas.Add(chartArea6);
            this.chart_links.Location = new System.Drawing.Point(6, 69);
            this.chart_links.Name = "chart_links";
            this.chart_links.Size = new System.Drawing.Size(376, 136);
            this.chart_links.TabIndex = 9;
            this.chart_links.Text = "chart1";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(802, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Distanz rechts:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Distanz vorne:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Distanz links:";
            // 
            // lbl_distRechts
            // 
            this.lbl_distRechts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_distRechts.AutoSize = true;
            this.lbl_distRechts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_distRechts.Location = new System.Drawing.Point(1057, 35);
            this.lbl_distRechts.Name = "lbl_distRechts";
            this.lbl_distRechts.Size = new System.Drawing.Size(76, 31);
            this.lbl_distRechts.TabIndex = 5;
            this.lbl_distRechts.Text = "0 cm";
            // 
            // lbl_distVorne
            // 
            this.lbl_distVorne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_distVorne.AutoSize = true;
            this.lbl_distVorne.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_distVorne.Location = new System.Drawing.Point(640, 35);
            this.lbl_distVorne.Name = "lbl_distVorne";
            this.lbl_distVorne.Size = new System.Drawing.Size(76, 31);
            this.lbl_distVorne.TabIndex = 4;
            this.lbl_distVorne.Text = "0 cm";
            // 
            // lbl_distLinks
            // 
            this.lbl_distLinks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_distLinks.AutoSize = true;
            this.lbl_distLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_distLinks.Location = new System.Drawing.Point(222, 35);
            this.lbl_distLinks.Name = "lbl_distLinks";
            this.lbl_distLinks.Size = new System.Drawing.Size(76, 31);
            this.lbl_distLinks.TabIndex = 3;
            this.lbl_distLinks.Text = "0 cm";
            // 
            // tabPage_manuelleSteuerung
            // 
            this.tabPage_manuelleSteuerung.Controls.Add(this.gB_manuell_rotate);
            this.tabPage_manuelleSteuerung.Controls.Add(this.gB_sync_gear);
            this.tabPage_manuelleSteuerung.Controls.Add(this.gB_manuell_pullout);
            this.tabPage_manuelleSteuerung.Controls.Add(this.gB_manuell_gear_right);
            this.tabPage_manuelleSteuerung.Controls.Add(this.gB_manuell_gear_left);
            this.tabPage_manuelleSteuerung.Location = new System.Drawing.Point(4, 25);
            this.tabPage_manuelleSteuerung.Name = "tabPage_manuelleSteuerung";
            this.tabPage_manuelleSteuerung.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_manuelleSteuerung.Size = new System.Drawing.Size(1190, 510);
            this.tabPage_manuelleSteuerung.TabIndex = 1;
            this.tabPage_manuelleSteuerung.Text = "Manuelle Steuerung";
            this.tabPage_manuelleSteuerung.UseVisualStyleBackColor = true;
            // 
            // gB_manuell_rotate
            // 
            this.gB_manuell_rotate.Controls.Add(this.btn_90_right);
            this.gB_manuell_rotate.Controls.Add(this.btn_90_left);
            this.gB_manuell_rotate.Controls.Add(this.btn_180_right);
            this.gB_manuell_rotate.Controls.Add(this.btn_180_left);
            this.gB_manuell_rotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB_manuell_rotate.Location = new System.Drawing.Point(402, 171);
            this.gB_manuell_rotate.Name = "gB_manuell_rotate";
            this.gB_manuell_rotate.Size = new System.Drawing.Size(381, 143);
            this.gB_manuell_rotate.TabIndex = 12;
            this.gB_manuell_rotate.TabStop = false;
            this.gB_manuell_rotate.Text = "Drehbewegung";
            // 
            // btn_90_right
            // 
            this.btn_90_right.Enabled = false;
            this.btn_90_right.Location = new System.Drawing.Point(185, 85);
            this.btn_90_right.Name = "btn_90_right";
            this.btn_90_right.Size = new System.Drawing.Size(157, 42);
            this.btn_90_right.TabIndex = 12;
            this.btn_90_right.Text = "90 rechts";
            this.btn_90_right.UseVisualStyleBackColor = true;
            // 
            // btn_90_left
            // 
            this.btn_90_left.Enabled = false;
            this.btn_90_left.Location = new System.Drawing.Point(23, 85);
            this.btn_90_left.Name = "btn_90_left";
            this.btn_90_left.Size = new System.Drawing.Size(157, 42);
            this.btn_90_left.TabIndex = 11;
            this.btn_90_left.Text = "90 links";
            this.btn_90_left.UseVisualStyleBackColor = true;
            // 
            // btn_180_right
            // 
            this.btn_180_right.Location = new System.Drawing.Point(186, 37);
            this.btn_180_right.Name = "btn_180_right";
            this.btn_180_right.Size = new System.Drawing.Size(156, 42);
            this.btn_180_right.TabIndex = 10;
            this.btn_180_right.Text = "180 rechts";
            this.btn_180_right.UseVisualStyleBackColor = true;
            this.btn_180_right.Click += new System.EventHandler(this.btn_180_right_Click);
            // 
            // btn_180_left
            // 
            this.btn_180_left.Location = new System.Drawing.Point(23, 37);
            this.btn_180_left.Name = "btn_180_left";
            this.btn_180_left.Size = new System.Drawing.Size(157, 42);
            this.btn_180_left.TabIndex = 9;
            this.btn_180_left.Text = "180 links";
            this.btn_180_left.UseVisualStyleBackColor = true;
            this.btn_180_left.Click += new System.EventHandler(this.btn_180_left_Click);
            // 
            // gB_sync_gear
            // 
            this.gB_sync_gear.Controls.Add(this.btn_sync_stopp);
            this.gB_sync_gear.Controls.Add(this.btn_sync_backward);
            this.gB_sync_gear.Controls.Add(this.btn_sync_forward);
            this.gB_sync_gear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB_sync_gear.Location = new System.Drawing.Point(15, 171);
            this.gB_sync_gear.Name = "gB_sync_gear";
            this.gB_sync_gear.Size = new System.Drawing.Size(381, 143);
            this.gB_sync_gear.TabIndex = 1;
            this.gB_sync_gear.TabStop = false;
            this.gB_sync_gear.Text = "Synchronlauf";
            // 
            // btn_sync_stopp
            // 
            this.btn_sync_stopp.Location = new System.Drawing.Point(23, 85);
            this.btn_sync_stopp.Name = "btn_sync_stopp";
            this.btn_sync_stopp.Size = new System.Drawing.Size(319, 42);
            this.btn_sync_stopp.TabIndex = 11;
            this.btn_sync_stopp.Text = "Stopp";
            this.btn_sync_stopp.UseVisualStyleBackColor = true;
            this.btn_sync_stopp.Click += new System.EventHandler(this.btn_sync_stopp_Click);
            // 
            // btn_sync_backward
            // 
            this.btn_sync_backward.Location = new System.Drawing.Point(186, 37);
            this.btn_sync_backward.Name = "btn_sync_backward";
            this.btn_sync_backward.Size = new System.Drawing.Size(156, 42);
            this.btn_sync_backward.TabIndex = 10;
            this.btn_sync_backward.Text = "Rückwärts";
            this.btn_sync_backward.UseVisualStyleBackColor = true;
            this.btn_sync_backward.Click += new System.EventHandler(this.btn_sync_backward_Click);
            // 
            // btn_sync_forward
            // 
            this.btn_sync_forward.Location = new System.Drawing.Point(23, 37);
            this.btn_sync_forward.Name = "btn_sync_forward";
            this.btn_sync_forward.Size = new System.Drawing.Size(157, 42);
            this.btn_sync_forward.TabIndex = 9;
            this.btn_sync_forward.Text = "Vorwärts";
            this.btn_sync_forward.UseVisualStyleBackColor = true;
            this.btn_sync_forward.Click += new System.EventHandler(this.btn_sync_forward_Click);
            // 
            // gB_manuell_pullout
            // 
            this.gB_manuell_pullout.Controls.Add(this.btn_pullout_stopp);
            this.gB_manuell_pullout.Controls.Add(this.btn_pullout_start);
            this.gB_manuell_pullout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB_manuell_pullout.Location = new System.Drawing.Point(799, 22);
            this.gB_manuell_pullout.Name = "gB_manuell_pullout";
            this.gB_manuell_pullout.Size = new System.Drawing.Size(385, 143);
            this.gB_manuell_pullout.TabIndex = 2;
            this.gB_manuell_pullout.TabStop = false;
            this.gB_manuell_pullout.Text = "Auswurfrad";
            // 
            // btn_pullout_stopp
            // 
            this.btn_pullout_stopp.Location = new System.Drawing.Point(196, 60);
            this.btn_pullout_stopp.Name = "btn_pullout_stopp";
            this.btn_pullout_stopp.Size = new System.Drawing.Size(146, 42);
            this.btn_pullout_stopp.TabIndex = 7;
            this.btn_pullout_stopp.Text = "Stopp";
            this.btn_pullout_stopp.UseVisualStyleBackColor = true;
            // 
            // btn_pullout_start
            // 
            this.btn_pullout_start.Location = new System.Drawing.Point(44, 60);
            this.btn_pullout_start.Name = "btn_pullout_start";
            this.btn_pullout_start.Size = new System.Drawing.Size(146, 42);
            this.btn_pullout_start.TabIndex = 6;
            this.btn_pullout_start.Text = "Start";
            this.btn_pullout_start.UseVisualStyleBackColor = true;
            // 
            // gB_manuell_gear_right
            // 
            this.gB_manuell_gear_right.Controls.Add(this.btn_gear_right_stopp);
            this.gB_manuell_gear_right.Controls.Add(this.btn_gear_right_backward);
            this.gB_manuell_gear_right.Controls.Add(this.btn_gear_right_forward);
            this.gB_manuell_gear_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB_manuell_gear_right.Location = new System.Drawing.Point(402, 22);
            this.gB_manuell_gear_right.Name = "gB_manuell_gear_right";
            this.gB_manuell_gear_right.Size = new System.Drawing.Size(391, 143);
            this.gB_manuell_gear_right.TabIndex = 1;
            this.gB_manuell_gear_right.TabStop = false;
            this.gB_manuell_gear_right.Text = "Getriebemotor rechts";
            // 
            // btn_gear_right_stopp
            // 
            this.btn_gear_right_stopp.Location = new System.Drawing.Point(40, 86);
            this.btn_gear_right_stopp.Name = "btn_gear_right_stopp";
            this.btn_gear_right_stopp.Size = new System.Drawing.Size(319, 42);
            this.btn_gear_right_stopp.TabIndex = 5;
            this.btn_gear_right_stopp.Text = "Stopp";
            this.btn_gear_right_stopp.UseVisualStyleBackColor = true;
            this.btn_gear_right_stopp.Click += new System.EventHandler(this.btn_gear_right_stopp_Click);
            // 
            // btn_gear_right_backward
            // 
            this.btn_gear_right_backward.Location = new System.Drawing.Point(203, 38);
            this.btn_gear_right_backward.Name = "btn_gear_right_backward";
            this.btn_gear_right_backward.Size = new System.Drawing.Size(156, 42);
            this.btn_gear_right_backward.TabIndex = 4;
            this.btn_gear_right_backward.Text = "Rückwärts";
            this.btn_gear_right_backward.UseVisualStyleBackColor = true;
            this.btn_gear_right_backward.Click += new System.EventHandler(this.btn_gear_right_backward_Click);
            // 
            // btn_gear_right_forward
            // 
            this.btn_gear_right_forward.Location = new System.Drawing.Point(40, 38);
            this.btn_gear_right_forward.Name = "btn_gear_right_forward";
            this.btn_gear_right_forward.Size = new System.Drawing.Size(157, 42);
            this.btn_gear_right_forward.TabIndex = 3;
            this.btn_gear_right_forward.Text = "Vorwärts";
            this.btn_gear_right_forward.UseVisualStyleBackColor = true;
            this.btn_gear_right_forward.Click += new System.EventHandler(this.btn_gear_right_forward_Click);
            // 
            // gB_manuell_gear_left
            // 
            this.gB_manuell_gear_left.Controls.Add(this.btn_gear_left_stopp);
            this.gB_manuell_gear_left.Controls.Add(this.btn_gear_left_backward);
            this.gB_manuell_gear_left.Controls.Add(this.btn_Gear_Left_forward);
            this.gB_manuell_gear_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gB_manuell_gear_left.Location = new System.Drawing.Point(15, 22);
            this.gB_manuell_gear_left.Name = "gB_manuell_gear_left";
            this.gB_manuell_gear_left.Size = new System.Drawing.Size(381, 143);
            this.gB_manuell_gear_left.TabIndex = 0;
            this.gB_manuell_gear_left.TabStop = false;
            this.gB_manuell_gear_left.Text = "Getriebemotor links";
            // 
            // btn_gear_left_stopp
            // 
            this.btn_gear_left_stopp.Location = new System.Drawing.Point(23, 86);
            this.btn_gear_left_stopp.Name = "btn_gear_left_stopp";
            this.btn_gear_left_stopp.Size = new System.Drawing.Size(319, 42);
            this.btn_gear_left_stopp.TabIndex = 8;
            this.btn_gear_left_stopp.Text = "Stopp";
            this.btn_gear_left_stopp.UseVisualStyleBackColor = true;
            this.btn_gear_left_stopp.Click += new System.EventHandler(this.btn_gear_left_stopp_Click);
            // 
            // btn_gear_left_backward
            // 
            this.btn_gear_left_backward.Location = new System.Drawing.Point(186, 38);
            this.btn_gear_left_backward.Name = "btn_gear_left_backward";
            this.btn_gear_left_backward.Size = new System.Drawing.Size(156, 42);
            this.btn_gear_left_backward.TabIndex = 7;
            this.btn_gear_left_backward.Text = "Rückwärts";
            this.btn_gear_left_backward.UseVisualStyleBackColor = true;
            this.btn_gear_left_backward.Click += new System.EventHandler(this.btn_gear_left_backward_Click);
            // 
            // btn_Gear_Left_forward
            // 
            this.btn_Gear_Left_forward.Location = new System.Drawing.Point(23, 38);
            this.btn_Gear_Left_forward.Name = "btn_Gear_Left_forward";
            this.btn_Gear_Left_forward.Size = new System.Drawing.Size(157, 42);
            this.btn_Gear_Left_forward.TabIndex = 6;
            this.btn_Gear_Left_forward.Text = "Vorwärts";
            this.btn_Gear_Left_forward.UseVisualStyleBackColor = true;
            this.btn_Gear_Left_forward.Click += new System.EventHandler(this.btn_Gear_Left_forward_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1190, 510);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Einstellungen";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_distside);
            this.groupBox2.Controls.Add(this.btn_distanzSide);
            this.groupBox2.Controls.Add(this.tb_distanceSide);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(477, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 169);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Min. Distanz links/rechts";
            // 
            // btn_distanzSide
            // 
            this.btn_distanzSide.Location = new System.Drawing.Point(6, 127);
            this.btn_distanzSide.Name = "btn_distanzSide";
            this.btn_distanzSide.Size = new System.Drawing.Size(176, 36);
            this.btn_distanzSide.TabIndex = 2;
            this.btn_distanzSide.Text = "übernehmen";
            this.btn_distanzSide.UseVisualStyleBackColor = true;
            this.btn_distanzSide.Click += new System.EventHandler(this.btn_distanzSide_Click);
            // 
            // tb_distanceSide
            // 
            this.tb_distanceSide.Location = new System.Drawing.Point(6, 83);
            this.tb_distanceSide.Name = "tb_distanceSide";
            this.tb_distanceSide.Size = new System.Drawing.Size(130, 38);
            this.tb_distanceSide.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "cm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_dist_vorne);
            this.groupBox1.Controls.Add(this.btn_distanzFront);
            this.groupBox1.Controls.Add(this.tb_distanceFront);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(211, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Min. Distanz vorne";
            // 
            // btn_distanzFront
            // 
            this.btn_distanzFront.Location = new System.Drawing.Point(6, 127);
            this.btn_distanzFront.Name = "btn_distanzFront";
            this.btn_distanzFront.Size = new System.Drawing.Size(176, 36);
            this.btn_distanzFront.TabIndex = 2;
            this.btn_distanzFront.Text = "übernehmen";
            this.btn_distanzFront.UseVisualStyleBackColor = true;
            this.btn_distanzFront.Click += new System.EventHandler(this.btn_distanzFront_Click);
            // 
            // tb_distanceFront
            // 
            this.tb_distanceFront.Location = new System.Drawing.Point(0, 86);
            this.tb_distanceFront.Name = "tb_distanceFront";
            this.tb_distanceFront.Size = new System.Drawing.Size(130, 38);
            this.tb_distanceFront.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "cm";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lbl_drehzeit);
            this.groupBox8.Controls.Add(this.btn_drehzeit);
            this.groupBox8.Controls.Add(this.tb_drehzeit);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(6, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(199, 169);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Drehzeit";
            // 
            // btn_drehzeit
            // 
            this.btn_drehzeit.Location = new System.Drawing.Point(6, 127);
            this.btn_drehzeit.Name = "btn_drehzeit";
            this.btn_drehzeit.Size = new System.Drawing.Size(176, 36);
            this.btn_drehzeit.TabIndex = 2;
            this.btn_drehzeit.Text = "übernehmen";
            this.btn_drehzeit.UseVisualStyleBackColor = true;
            this.btn_drehzeit.Click += new System.EventHandler(this.btn_drehzeitClick);
            // 
            // tb_drehzeit
            // 
            this.tb_drehzeit.Location = new System.Drawing.Point(6, 83);
            this.tb_drehzeit.Name = "tb_drehzeit";
            this.tb_drehzeit.Size = new System.Drawing.Size(130, 38);
            this.tb_drehzeit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "ms";
           
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cB_modus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1222, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "Betriebsmodus";
            // 
            // cB_modus
            // 
            this.cB_modus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_modus.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cB_modus.Items.AddRange(new object[] {
            "Manuell",
            "Automatik"});
            this.cB_modus.Name = "cB_modus";
            this.cB_modus.Size = new System.Drawing.Size(121, 25);
            this.cB_modus.SelectedIndexChanged += new System.EventHandler(this.cB_modus_SelectedIndexChanged);
            this.cB_modus.TextChanged += new System.EventHandler(this.cB_modus_TextChanged);
            // 
            // lbl_drehzeit
            // 
            this.lbl_drehzeit.AutoSize = true;
            this.lbl_drehzeit.Location = new System.Drawing.Point(6, 49);
            this.lbl_drehzeit.Name = "lbl_drehzeit";
            this.lbl_drehzeit.Size = new System.Drawing.Size(23, 31);
            this.lbl_drehzeit.TabIndex = 3;
            this.lbl_drehzeit.Text = "-";
            // 
            // lbl_dist_vorne
            // 
            this.lbl_dist_vorne.AutoSize = true;
            this.lbl_dist_vorne.Location = new System.Drawing.Point(6, 49);
            this.lbl_dist_vorne.Name = "lbl_dist_vorne";
            this.lbl_dist_vorne.Size = new System.Drawing.Size(23, 31);
            this.lbl_dist_vorne.TabIndex = 4;
            this.lbl_dist_vorne.Text = "-";
            // 
            // lbl_distside
            // 
            this.lbl_distside.AutoSize = true;
            this.lbl_distside.Location = new System.Drawing.Point(6, 49);
            this.lbl_distside.Name = "lbl_distside";
            this.lbl_distside.Size = new System.Drawing.Size(23, 31);
            this.lbl_distside.TabIndex = 5;
            this.lbl_distside.Text = "-";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 579);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Interface";
            this.Text = "Interface";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_rechts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_vorne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_links)).EndInit();
            this.tabPage_manuelleSteuerung.ResumeLayout(false);
            this.gB_manuell_rotate.ResumeLayout(false);
            this.gB_sync_gear.ResumeLayout(false);
            this.gB_manuell_pullout.ResumeLayout(false);
            this.gB_manuell_gear_right.ResumeLayout(false);
            this.gB_manuell_gear_left.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage_manuelleSteuerung;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbl_distRechts;
        private System.Windows.Forms.Label lbl_distVorne;
        private System.Windows.Forms.Label lbl_distLinks;
        private System.Windows.Forms.Label lbl_task;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_rechts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_vorne;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_links;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_stopp;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.GroupBox gB_sync_gear;
        private System.Windows.Forms.GroupBox gB_manuell_pullout;
        private System.Windows.Forms.GroupBox gB_manuell_gear_right;
        private System.Windows.Forms.GroupBox gB_manuell_gear_left;
        private System.Windows.Forms.Button btn_pullout_stopp;
        private System.Windows.Forms.Button btn_pullout_start;
        private System.Windows.Forms.Button btn_gear_right_stopp;
        private System.Windows.Forms.Button btn_gear_right_backward;
        private System.Windows.Forms.Button btn_gear_right_forward;
        private System.Windows.Forms.Button btn_gear_left_stopp;
        private System.Windows.Forms.Button btn_gear_left_backward;
        private System.Windows.Forms.Button btn_Gear_Left_forward;
        private System.Windows.Forms.GroupBox gB_manuell_rotate;
        private System.Windows.Forms.Button btn_90_right;
        private System.Windows.Forms.Button btn_90_left;
        private System.Windows.Forms.Button btn_180_right;
        private System.Windows.Forms.Button btn_180_left;
        private System.Windows.Forms.Button btn_sync_stopp;
        private System.Windows.Forms.Button btn_sync_backward;
        private System.Windows.Forms.Button btn_sync_forward;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btn_drehzeit;
        private System.Windows.Forms.TextBox tb_drehzeit;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cB_modus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_distanzSide;
        private System.Windows.Forms.TextBox tb_distanceSide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_distanzFront;
        private System.Windows.Forms.TextBox tb_distanceFront;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox tB_log;
        private System.Windows.Forms.Label lbl_distside;
        private System.Windows.Forms.Label lbl_dist_vorne;
        private System.Windows.Forms.Label lbl_drehzeit;
    }
}