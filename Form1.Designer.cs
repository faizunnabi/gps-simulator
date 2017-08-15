namespace GpsSimulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.strt_bt = new System.Windows.Forms.Button();
            this.stop_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.send_bt = new System.Windows.Forms.Button();
            this.setting_bt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // strt_bt
            // 
            this.strt_bt.Location = new System.Drawing.Point(14, 32);
            this.strt_bt.Name = "strt_bt";
            this.strt_bt.Size = new System.Drawing.Size(139, 50);
            this.strt_bt.TabIndex = 0;
            this.strt_bt.Text = "Start";
            this.strt_bt.UseVisualStyleBackColor = true;
            this.strt_bt.Click += new System.EventHandler(this.strt_bt_Click);
            // 
            // stop_bt
            // 
            this.stop_bt.Location = new System.Drawing.Point(14, 116);
            this.stop_bt.Name = "stop_bt";
            this.stop_bt.Size = new System.Drawing.Size(139, 50);
            this.stop_bt.TabIndex = 1;
            this.stop_bt.Text = "Stop";
            this.stop_bt.UseVisualStyleBackColor = true;
            this.stop_bt.Click += new System.EventHandler(this.stop_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(82, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "GPS Simulator";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SOS",
            "POWER CUT",
            "ACC ON",
            "ACC OFF",
            "GEO-FENCE IN",
            "GEO-FENCE OUT"});
            this.comboBox1.Location = new System.Drawing.Point(18, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Select alarm";
            // 
            // send_bt
            // 
            this.send_bt.Location = new System.Drawing.Point(18, 115);
            this.send_bt.Name = "send_bt";
            this.send_bt.Size = new System.Drawing.Size(139, 50);
            this.send_bt.TabIndex = 4;
            this.send_bt.Text = "Send";
            this.send_bt.UseVisualStyleBackColor = true;
            // 
            // setting_bt
            // 
            this.setting_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("setting_bt.BackgroundImage")));
            this.setting_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.setting_bt.Cursor = System.Windows.Forms.Cursors.Default;
            this.setting_bt.FlatAppearance.BorderSize = 0;
            this.setting_bt.Location = new System.Drawing.Point(382, 22);
            this.setting_bt.Name = "setting_bt";
            this.setting_bt.Size = new System.Drawing.Size(38, 35);
            this.setting_bt.TabIndex = 5;
            this.setting_bt.UseVisualStyleBackColor = true;
            this.setting_bt.Click += new System.EventHandler(this.setting_bt_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.send_bt);
            this.panel1.Location = new System.Drawing.Point(24, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 186);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.strt_bt);
            this.panel2.Controls.Add(this.stop_bt);
            this.panel2.Location = new System.Drawing.Point(243, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 186);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 424);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Send Alarms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 423);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Operation";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(87, 646);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            this.status.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 646);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Status : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "IMEI :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(173, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Unknown";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(432, 675);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.setting_bt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPS Simulator";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button strt_bt;
        private System.Windows.Forms.Button stop_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button send_bt;
        private System.Windows.Forms.Button setting_bt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

