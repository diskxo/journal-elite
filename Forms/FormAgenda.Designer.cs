namespace Journal_Elite.Forms
{
    partial class FormAgenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.ClassroomEvents = new System.Windows.Forms.LinkLabel();
            this.CompitiTitle = new System.Windows.Forms.Label();
            this.TimerClassroom = new System.Windows.Forms.Timer(this.components);
            this.lblHomework = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(14)))), ((int)(((byte)(22)))));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 36);
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
            this.ClassroomEvents.Location = new System.Drawing.Point(39, 70);
            this.ClassroomEvents.Name = "ClassroomEvents";
            this.ClassroomEvents.Size = new System.Drawing.Size(149, 19);
            this.ClassroomEvents.TabIndex = 2;
            this.ClassroomEvents.TabStop = true;
            this.ClassroomEvents.Text = "Caricamento in corso...";
            this.ClassroomEvents.VisitedLinkColor = System.Drawing.Color.White;
            this.ClassroomEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClassroomEvents_LinkClicked);
            // 
            // CompitiTitle
            // 
            this.CompitiTitle.AutoSize = true;
            this.CompitiTitle.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompitiTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(14)))), ((int)(((byte)(22)))));
            this.CompitiTitle.Location = new System.Drawing.Point(332, 23);
            this.CompitiTitle.Name = "CompitiTitle";
            this.CompitiTitle.Size = new System.Drawing.Size(290, 36);
            this.CompitiTitle.TabIndex = 3;
            this.CompitiTitle.Text = "Compiti in scadenza";
            this.CompitiTitle.Click += new System.EventHandler(this.CompitiTitle_Click);
            // 
            // TimerClassroom
            // 
            this.TimerClassroom.Enabled = true;
            this.TimerClassroom.Interval = 1990;
            this.TimerClassroom.Tick += new System.EventHandler(this.TimerClassroom_Tick);
            // 
            // lblHomework
            // 
            this.lblHomework.ActiveLinkColor = System.Drawing.Color.White;
            this.lblHomework.AutoSize = true;
            this.lblHomework.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomework.ForeColor = System.Drawing.Color.White;
            this.lblHomework.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblHomework.LinkColor = System.Drawing.Color.White;
            this.lblHomework.Location = new System.Drawing.Point(334, 70);
            this.lblHomework.Name = "lblHomework";
            this.lblHomework.Size = new System.Drawing.Size(149, 19);
            this.lblHomework.TabIndex = 4;
            this.lblHomework.TabStop = true;
            this.lblHomework.Text = "Caricamento in corso...";
            this.lblHomework.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.lblHomework);
            this.Controls.Add(this.CompitiTitle);
            this.Controls.Add(this.ClassroomEvents);
            this.Controls.Add(this.label1);
            this.Name = "FormAgenda";
            this.Text = "COMPITI";
            this.Load += new System.EventHandler(this.FormAgenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ClassroomEvents;
        private System.Windows.Forms.Label CompitiTitle;
        private System.Windows.Forms.Timer TimerClassroom;
        private System.Windows.Forms.LinkLabel lblHomework;
    }
}