namespace Journal_Elite
{
    partial class Home
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnProfilo = new System.Windows.Forms.Button();
            this.btnValutazioni = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnOrario = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.ptbxLogo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.ClassroomEvents = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.CalendarEvents = new System.Windows.Forms.LinkLabel();
            this.lblGoogleCalendarTitle = new System.Windows.Forms.Label();
            this.GetEvents = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnProfilo);
            this.panelMenu.Controls.Add(this.btnValutazioni);
            this.panelMenu.Controls.Add(this.btnCalendario);
            this.panelMenu.Controls.Add(this.btnOrario);
            this.panelMenu.Controls.Add(this.btnAgenda);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 660);
            this.panelMenu.TabIndex = 0;
            // 
            // btnProfilo
            // 
            this.btnProfilo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfilo.FlatAppearance.BorderSize = 0;
            this.btnProfilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfilo.Image = ((System.Drawing.Image)(resources.GetObject("btnProfilo.Image")));
            this.btnProfilo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfilo.Location = new System.Drawing.Point(0, 393);
            this.btnProfilo.Name = "btnProfilo";
            this.btnProfilo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProfilo.Size = new System.Drawing.Size(220, 84);
            this.btnProfilo.TabIndex = 5;
            this.btnProfilo.Text = "  Opzioni";
            this.btnProfilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfilo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfilo.UseVisualStyleBackColor = true;
            this.btnProfilo.Click += new System.EventHandler(this.btnProfilo_Click);
            // 
            // btnValutazioni
            // 
            this.btnValutazioni.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnValutazioni.FlatAppearance.BorderSize = 0;
            this.btnValutazioni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValutazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValutazioni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnValutazioni.Image = ((System.Drawing.Image)(resources.GetObject("btnValutazioni.Image")));
            this.btnValutazioni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValutazioni.Location = new System.Drawing.Point(0, 309);
            this.btnValutazioni.Name = "btnValutazioni";
            this.btnValutazioni.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnValutazioni.Size = new System.Drawing.Size(220, 84);
            this.btnValutazioni.TabIndex = 4;
            this.btnValutazioni.Text = "  Valutazioni";
            this.btnValutazioni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValutazioni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValutazioni.UseVisualStyleBackColor = true;
            this.btnValutazioni.Click += new System.EventHandler(this.btnValutazioni_Click);
            // 
            // btnCalendario
            // 
            this.btnCalendario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendario.FlatAppearance.BorderSize = 0;
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalendario.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendario.Image")));
            this.btnCalendario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendario.Location = new System.Drawing.Point(0, 225);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCalendario.Size = new System.Drawing.Size(220, 84);
            this.btnCalendario.TabIndex = 3;
            this.btnCalendario.Text = "  Calendario";
            this.btnCalendario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // btnOrario
            // 
            this.btnOrario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrario.FlatAppearance.BorderSize = 0;
            this.btnOrario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrario.Image = ((System.Drawing.Image)(resources.GetObject("btnOrario.Image")));
            this.btnOrario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrario.Location = new System.Drawing.Point(0, 141);
            this.btnOrario.Name = "btnOrario";
            this.btnOrario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOrario.Size = new System.Drawing.Size(220, 84);
            this.btnOrario.TabIndex = 2;
            this.btnOrario.Text = "  Orario";
            this.btnOrario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrario.UseVisualStyleBackColor = true;
            this.btnOrario.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgenda.FlatAppearance.BorderSize = 0;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btnAgenda.Image")));
            this.btnAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgenda.Location = new System.Drawing.Point(0, 57);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAgenda.Size = new System.Drawing.Size(220, 84);
            this.btnAgenda.TabIndex = 1;
            this.btnAgenda.Text = "  Compiti";
            this.btnAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.ptbxLogo);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 57);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // ptbxLogo
            // 
            this.ptbxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbxLogo.FlatAppearance.BorderSize = 0;
            this.ptbxLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ptbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbxLogo.Image")));
            this.ptbxLogo.Location = new System.Drawing.Point(12, 4);
            this.ptbxLogo.Name = "ptbxLogo";
            this.ptbxLogo.Size = new System.Drawing.Size(48, 47);
            this.ptbxLogo.TabIndex = 6;
            this.ptbxLogo.UseVisualStyleBackColor = true;
            this.ptbxLogo.Click += new System.EventHandler(this.ptbxLogo_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(66, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Journal Elite";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(969, 57);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(901, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(22, 22);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Visible = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(923, -2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 22);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(947, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(420, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Panoramica";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelDesktopPanel.Controls.Add(this.ClassroomEvents);
            this.panelDesktopPanel.Controls.Add(this.label2);
            this.panelDesktopPanel.Controls.Add(this.CalendarEvents);
            this.panelDesktopPanel.Controls.Add(this.lblGoogleCalendarTitle);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(220, 57);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(969, 603);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // ClassroomEvents
            // 
            this.ClassroomEvents.ActiveLinkColor = System.Drawing.Color.White;
            this.ClassroomEvents.AutoSize = true;
            this.ClassroomEvents.DisabledLinkColor = System.Drawing.Color.White;
            this.ClassroomEvents.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassroomEvents.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ClassroomEvents.LinkColor = System.Drawing.Color.White;
            this.ClassroomEvents.Location = new System.Drawing.Point(461, 65);
            this.ClassroomEvents.Name = "ClassroomEvents";
            this.ClassroomEvents.Size = new System.Drawing.Size(182, 19);
            this.ClassroomEvents.TabIndex = 5;
            this.ClassroomEvents.TabStop = true;
            this.ClassroomEvents.Text = "Caricamento corsi in corso...";
            this.ClassroomEvents.VisitedLinkColor = System.Drawing.Color.White;
            this.ClassroomEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClassroomEvents_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(460, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Corsi di Google Classroom";
            // 
            // CalendarEvents
            // 
            this.CalendarEvents.ActiveLinkColor = System.Drawing.Color.White;
            this.CalendarEvents.AutoSize = true;
            this.CalendarEvents.DisabledLinkColor = System.Drawing.Color.White;
            this.CalendarEvents.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarEvents.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.CalendarEvents.LinkColor = System.Drawing.Color.White;
            this.CalendarEvents.Location = new System.Drawing.Point(43, 65);
            this.CalendarEvents.Name = "CalendarEvents";
            this.CalendarEvents.Size = new System.Drawing.Size(190, 19);
            this.CalendarEvents.TabIndex = 3;
            this.CalendarEvents.TabStop = true;
            this.CalendarEvents.Text = "Caricamento eventi in corso...";
            this.CalendarEvents.VisitedLinkColor = System.Drawing.Color.White;
            this.CalendarEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CalendarEvents_LinkClicked);
            // 
            // lblGoogleCalendarTitle
            // 
            this.lblGoogleCalendarTitle.AutoSize = true;
            this.lblGoogleCalendarTitle.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoogleCalendarTitle.ForeColor = System.Drawing.Color.White;
            this.lblGoogleCalendarTitle.Location = new System.Drawing.Point(42, 25);
            this.lblGoogleCalendarTitle.Name = "lblGoogleCalendarTitle";
            this.lblGoogleCalendarTitle.Size = new System.Drawing.Size(192, 28);
            this.lblGoogleCalendarTitle.TabIndex = 2;
            this.lblGoogleCalendarTitle.Text = "Eventi imminenti";
            this.lblGoogleCalendarTitle.Click += new System.EventHandler(this.lblGoogleCalendarTitle_Click);
            // 
            // GetEvents
            // 
            this.GetEvents.Enabled = true;
            this.GetEvents.Interval = 10000;
            this.GetEvents.Tick += new System.EventHandler(this.GetEvents_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 660);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Journal Elite";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            this.panelDesktopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnValutazioni;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Button btnOrario;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnProfilo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer GetEvents;
        private System.Windows.Forms.Label lblGoogleCalendarTitle;
        private System.Windows.Forms.LinkLabel CalendarEvents;
        private System.Windows.Forms.LinkLabel ClassroomEvents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ptbxLogo;
    }
}

