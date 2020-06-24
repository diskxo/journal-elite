namespace Journal_Elite.Forms
{
    partial class FormCalendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalendario));
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerCalendar = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.Events6_button = new System.Windows.Forms.Button();
            this.Events5_button = new System.Windows.Forms.Button();
            this.Events4_button = new System.Windows.Forms.Button();
            this.Events3_button = new System.Windows.Forms.Button();
            this.Events2_button = new System.Windows.Forms.Button();
            this.Events1_button = new System.Windows.Forms.Button();
            this.Events_button = new System.Windows.Forms.Button();
            this.RefreshDate = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelCalendar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateEvent.FlatAppearance.BorderSize = 0;
            this.btnCreateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateEvent.Image")));
            this.btnCreateEvent.Location = new System.Drawing.Point(785, 472);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(58, 45);
            this.btnCreateEvent.TabIndex = 2;
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(500, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eventi imminenti";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TimerCalendar
            // 
            this.TimerCalendar.Interval = 10000;
            this.TimerCalendar.Tick += new System.EventHandler(this.TimerCalendar_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelCalendar);
            this.panel1.Controls.Add(this.Events6_button);
            this.panel1.Controls.Add(this.btnCreateEvent);
            this.panel1.Controls.Add(this.Events5_button);
            this.panel1.Controls.Add(this.Events4_button);
            this.panel1.Controls.Add(this.Events3_button);
            this.panel1.Controls.Add(this.Events2_button);
            this.panel1.Controls.Add(this.Events1_button);
            this.panel1.Controls.Add(this.Events_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 529);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelCalendar
            // 
            this.panelCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelCalendar.Controls.Add(this.panelHeader);
            this.panelCalendar.Location = new System.Drawing.Point(12, 10);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(482, 507);
            this.panelCalendar.TabIndex = 16;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelHeader.Controls.Add(this.lblDate);
            this.panelHeader.Controls.Add(this.lblDay);
            this.panelHeader.Controls.Add(this.lblTime);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(482, 55);
            this.panelHeader.TabIndex = 16;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(265, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(204, 31);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "1 Gennaio 1970";
            this.lblDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(5, 31);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(38, 19);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "Time";
            // 
            // lblDay
            // 
            this.lblDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDay.AutoSize = true;
            this.lblDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDay.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Location = new System.Drawing.Point(3, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(96, 31);
            this.lblDay.TabIndex = 14;
            this.lblDay.Text = "sabato";
            this.lblDay.Click += new System.EventHandler(this.lblDay_Click);
            // 
            // Events6_button
            // 
            this.Events6_button.AutoSize = true;
            this.Events6_button.FlatAppearance.BorderSize = 0;
            this.Events6_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Events6_button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Events6_button.ForeColor = System.Drawing.Color.White;
            this.Events6_button.Location = new System.Drawing.Point(505, 317);
            this.Events6_button.Name = "Events6_button";
            this.Events6_button.Size = new System.Drawing.Size(220, 33);
            this.Events6_button.TabIndex = 12;
            this.Events6_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Events6_button.UseVisualStyleBackColor = true;
            this.Events6_button.Click += new System.EventHandler(this.Events6_button_Click);
            // 
            // Events5_button
            // 
            this.Events5_button.AutoSize = true;
            this.Events5_button.FlatAppearance.BorderSize = 0;
            this.Events5_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Events5_button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Events5_button.ForeColor = System.Drawing.Color.White;
            this.Events5_button.Location = new System.Drawing.Point(505, 278);
            this.Events5_button.Name = "Events5_button";
            this.Events5_button.Size = new System.Drawing.Size(220, 33);
            this.Events5_button.TabIndex = 11;
            this.Events5_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Events5_button.UseVisualStyleBackColor = true;
            this.Events5_button.Click += new System.EventHandler(this.Events5_button_Click);
            // 
            // Events4_button
            // 
            this.Events4_button.AutoSize = true;
            this.Events4_button.FlatAppearance.BorderSize = 0;
            this.Events4_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Events4_button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Events4_button.ForeColor = System.Drawing.Color.White;
            this.Events4_button.Location = new System.Drawing.Point(505, 239);
            this.Events4_button.Name = "Events4_button";
            this.Events4_button.Size = new System.Drawing.Size(220, 33);
            this.Events4_button.TabIndex = 10;
            this.Events4_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Events4_button.UseVisualStyleBackColor = true;
            this.Events4_button.Click += new System.EventHandler(this.Events4_button_Click);
            // 
            // Events3_button
            // 
            this.Events3_button.AutoSize = true;
            this.Events3_button.FlatAppearance.BorderSize = 0;
            this.Events3_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Events3_button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Events3_button.ForeColor = System.Drawing.Color.White;
            this.Events3_button.Location = new System.Drawing.Point(505, 200);
            this.Events3_button.Name = "Events3_button";
            this.Events3_button.Size = new System.Drawing.Size(220, 33);
            this.Events3_button.TabIndex = 9;
            this.Events3_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Events3_button.UseVisualStyleBackColor = true;
            this.Events3_button.Click += new System.EventHandler(this.Events3_button_Click);
            // 
            // Events2_button
            // 
            this.Events2_button.AutoSize = true;
            this.Events2_button.FlatAppearance.BorderSize = 0;
            this.Events2_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Events2_button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Events2_button.ForeColor = System.Drawing.Color.White;
            this.Events2_button.Location = new System.Drawing.Point(505, 161);
            this.Events2_button.Name = "Events2_button";
            this.Events2_button.Size = new System.Drawing.Size(220, 33);
            this.Events2_button.TabIndex = 8;
            this.Events2_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Events2_button.UseVisualStyleBackColor = true;
            this.Events2_button.Click += new System.EventHandler(this.Events2_button_Click);
            // 
            // Events1_button
            // 
            this.Events1_button.AutoSize = true;
            this.Events1_button.FlatAppearance.BorderSize = 0;
            this.Events1_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Events1_button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Events1_button.ForeColor = System.Drawing.Color.White;
            this.Events1_button.Location = new System.Drawing.Point(505, 122);
            this.Events1_button.Name = "Events1_button";
            this.Events1_button.Size = new System.Drawing.Size(220, 33);
            this.Events1_button.TabIndex = 7;
            this.Events1_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Events1_button.UseVisualStyleBackColor = true;
            this.Events1_button.Click += new System.EventHandler(this.Events1_button_Click);
            // 
            // Events_button
            // 
            this.Events_button.AutoSize = true;
            this.Events_button.FlatAppearance.BorderSize = 0;
            this.Events_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Events_button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Events_button.ForeColor = System.Drawing.Color.White;
            this.Events_button.Location = new System.Drawing.Point(505, 51);
            this.Events_button.Name = "Events_button";
            this.Events_button.Size = new System.Drawing.Size(244, 52);
            this.Events_button.TabIndex = 6;
            this.Events_button.Text = "Nessun evento imminente \r\nin Google Calendar";
            this.Events_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Events_button.UseVisualStyleBackColor = true;
            this.Events_button.Click += new System.EventHandler(this.ClassroomEvents_button_Click);
            // 
            // RefreshDate
            // 
            this.RefreshDate.Enabled = true;
            this.RefreshDate.Interval = 1000;
            this.RefreshDate.Tick += new System.EventHandler(this.RefreshDate_Tick);
            // 
            // FormCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(846, 529);
            this.Controls.Add(this.panel1);
            this.Name = "FormCalendario";
            this.Text = "Calendario";
            this.Load += new System.EventHandler(this.FormCalendario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCalendar.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimerCalendar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Events_button;
        private System.Windows.Forms.Button Events6_button;
        private System.Windows.Forms.Button Events5_button;
        private System.Windows.Forms.Button Events4_button;
        private System.Windows.Forms.Button Events3_button;
        private System.Windows.Forms.Button Events2_button;
        private System.Windows.Forms.Button Events1_button;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer RefreshDate;
        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.Panel panelHeader;
    }
}