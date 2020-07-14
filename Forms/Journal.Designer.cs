namespace Journal_Elite.Forms
{
    partial class Journal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Journal));
            this.label1 = new System.Windows.Forms.Label();
            this.ClassroomEvents = new System.Windows.Forms.LinkLabel();
            this.TimerClassroom = new System.Windows.Forms.Timer(this.components);
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.Events6_button = new System.Windows.Forms.Button();
            this.Events5_button = new System.Windows.Forms.Button();
            this.Events4_button = new System.Windows.Forms.Button();
            this.Events3_button = new System.Windows.Forms.Button();
            this.Events2_button = new System.Windows.Forms.Button();
            this.Events1_button = new System.Windows.Forms.Button();
            this.Events_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(704, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Corsi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClassroomEvents
            // 
            this.ClassroomEvents.ActiveLinkColor = System.Drawing.Color.White;
            this.ClassroomEvents.AutoSize = true;
            this.ClassroomEvents.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassroomEvents.ForeColor = System.Drawing.Color.White;
            this.ClassroomEvents.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ClassroomEvents.LinkColor = System.Drawing.Color.White;
            this.ClassroomEvents.Location = new System.Drawing.Point(705, 73);
            this.ClassroomEvents.Name = "ClassroomEvents";
            this.ClassroomEvents.Size = new System.Drawing.Size(149, 19);
            this.ClassroomEvents.TabIndex = 2;
            this.ClassroomEvents.TabStop = true;
            this.ClassroomEvents.Text = "Caricamento in corso...";
            this.ClassroomEvents.VisitedLinkColor = System.Drawing.Color.White;
            this.ClassroomEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClassroomEvents_LinkClicked);
            // 
            // TimerClassroom
            // 
            this.TimerClassroom.Enabled = true;
            this.TimerClassroom.Interval = 100000;
            this.TimerClassroom.Tick += new System.EventHandler(this.TimerClassroom_Tick);
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Calendar.CalendarDimensions = new System.Drawing.Size(1, 4);
            this.Calendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.Calendar.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.ForeColor = System.Drawing.Color.White;
            this.Calendar.Location = new System.Drawing.Point(18, 7);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 19;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.FlatAppearance.BorderSize = 0;
            this.btnCreateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEvent.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEvent.ForeColor = System.Drawing.Color.White;
            this.btnCreateEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateEvent.Image")));
            this.btnCreateEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateEvent.Location = new System.Drawing.Point(18, 619);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(228, 45);
            this.btnCreateEvent.TabIndex = 18;
            this.btnCreateEvent.Text = "Aggiungi evento";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // Events6_button
            // 
            this.Events6_button.AutoSize = true;
            this.Events6_button.FlatAppearance.BorderSize = 0;
            this.Events6_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Events6_button.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Events6_button.ForeColor = System.Drawing.Color.White;
            this.Events6_button.Location = new System.Drawing.Point(306, 255);
            this.Events6_button.Name = "Events6_button";
            this.Events6_button.Size = new System.Drawing.Size(220, 33);
            this.Events6_button.TabIndex = 26;
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
            this.Events5_button.Location = new System.Drawing.Point(306, 216);
            this.Events5_button.Name = "Events5_button";
            this.Events5_button.Size = new System.Drawing.Size(220, 33);
            this.Events5_button.TabIndex = 25;
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
            this.Events4_button.Location = new System.Drawing.Point(306, 177);
            this.Events4_button.Name = "Events4_button";
            this.Events4_button.Size = new System.Drawing.Size(220, 33);
            this.Events4_button.TabIndex = 24;
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
            this.Events3_button.Location = new System.Drawing.Point(306, 138);
            this.Events3_button.Name = "Events3_button";
            this.Events3_button.Size = new System.Drawing.Size(220, 33);
            this.Events3_button.TabIndex = 23;
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
            this.Events2_button.Location = new System.Drawing.Point(306, 138);
            this.Events2_button.Name = "Events2_button";
            this.Events2_button.Size = new System.Drawing.Size(220, 33);
            this.Events2_button.TabIndex = 22;
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
            this.Events1_button.Location = new System.Drawing.Point(306, 138);
            this.Events1_button.Name = "Events1_button";
            this.Events1_button.Size = new System.Drawing.Size(220, 33);
            this.Events1_button.TabIndex = 21;
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
            this.Events_button.Location = new System.Drawing.Point(306, 64);
            this.Events_button.Name = "Events_button";
            this.Events_button.Size = new System.Drawing.Size(244, 52);
            this.Events_button.TabIndex = 20;
            this.Events_button.Text = "Nessun evento imminente \r\nin Google Calendar";
            this.Events_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Events_button.UseVisualStyleBackColor = true;
            this.Events_button.Click += new System.EventHandler(this.Events_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(310, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Eventi imminenti";
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1041, 684);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.Events_button);
            this.Controls.Add(this.Events6_button);
            this.Controls.Add(this.Events5_button);
            this.Controls.Add(this.Events4_button);
            this.Controls.Add(this.Events3_button);
            this.Controls.Add(this.Events2_button);
            this.Controls.Add(this.Events1_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClassroomEvents);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAgenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FormAgenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ClassroomEvents;
        private System.Windows.Forms.Timer TimerClassroom;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Button Events6_button;
        private System.Windows.Forms.Button Events5_button;
        private System.Windows.Forms.Button Events4_button;
        private System.Windows.Forms.Button Events3_button;
        private System.Windows.Forms.Button Events2_button;
        private System.Windows.Forms.Button Events1_button;
        private System.Windows.Forms.Button Events_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar Calendar;
    }
}