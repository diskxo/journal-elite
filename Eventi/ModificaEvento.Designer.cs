namespace Journal_Elite.Forms
{
    partial class ModificaEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificaEvento));
            this.DeleteEvent = new System.Windows.Forms.Button();
            this.Nome = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Descrizione = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Location = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.Giorni = new System.Windows.Forms.TextBox();
            this.Ore = new System.Windows.Forms.TextBox();
            this.Email = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.EditEvent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteEvent
            // 
            this.DeleteEvent.FlatAppearance.BorderSize = 0;
            this.DeleteEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEvent.Image = ((System.Drawing.Image)(resources.GetObject("DeleteEvent.Image")));
            this.DeleteEvent.Location = new System.Drawing.Point(303, 224);
            this.DeleteEvent.Name = "DeleteEvent";
            this.DeleteEvent.Size = new System.Drawing.Size(41, 42);
            this.DeleteEvent.TabIndex = 0;
            this.DeleteEvent.UseVisualStyleBackColor = true;
            this.DeleteEvent.Click += new System.EventHandler(this.DeleteEvent_Click);
            // 
            // Nome
            // 
            this.Nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Nome.BorderColor = System.Drawing.Color.SeaGreen;
            this.Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nome.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.White;
            this.Nome.Location = new System.Drawing.Point(148, 12);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(100, 22);
            this.Nome.TabIndex = 2;
            this.Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nome.TextChanged += new System.EventHandler(this.Nome_TextChanged);
            // 
            // Descrizione
            // 
            this.Descrizione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Descrizione.BorderColor = System.Drawing.Color.SeaGreen;
            this.Descrizione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Descrizione.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descrizione.ForeColor = System.Drawing.Color.White;
            this.Descrizione.Location = new System.Drawing.Point(148, 55);
            this.Descrizione.Name = "Descrizione";
            this.Descrizione.Size = new System.Drawing.Size(100, 22);
            this.Descrizione.TabIndex = 3;
            this.Descrizione.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Location
            // 
            this.Location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Location.BorderColor = System.Drawing.Color.SeaGreen;
            this.Location.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Location.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location.ForeColor = System.Drawing.Color.White;
            this.Location.Location = new System.Drawing.Point(148, 82);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(100, 22);
            this.Location.TabIndex = 4;
            this.Location.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Giorni
            // 
            this.Giorni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Giorni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Giorni.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Giorni.ForeColor = System.Drawing.Color.White;
            this.Giorni.Location = new System.Drawing.Point(148, 108);
            this.Giorni.Name = "Giorni";
            this.Giorni.Size = new System.Drawing.Size(28, 22);
            this.Giorni.TabIndex = 5;
            this.Giorni.Text = "5";
            this.Giorni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Giorni.TextChanged += new System.EventHandler(this.Giorni_TextChanged);
            // 
            // Ore
            // 
            this.Ore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Ore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ore.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ore.ForeColor = System.Drawing.Color.White;
            this.Ore.Location = new System.Drawing.Point(220, 108);
            this.Ore.Name = "Ore";
            this.Ore.Size = new System.Drawing.Size(28, 22);
            this.Ore.TabIndex = 6;
            this.Ore.Text = "3";
            this.Ore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ore.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Email.BorderColor = System.Drawing.Color.Black;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(148, 142);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 22);
            this.Email.TabIndex = 7;
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditEvent
            // 
            this.EditEvent.FlatAppearance.BorderSize = 0;
            this.EditEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditEvent.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEvent.ForeColor = System.Drawing.Color.White;
            this.EditEvent.Image = ((System.Drawing.Image)(resources.GetObject("EditEvent.Image")));
            this.EditEvent.Location = new System.Drawing.Point(16, 222);
            this.EditEvent.Name = "EditEvent";
            this.EditEvent.Size = new System.Drawing.Size(39, 42);
            this.EditEvent.TabIndex = 8;
            this.EditEvent.UseVisualStyleBackColor = true;
            this.EditEvent.Click += new System.EventHandler(this.EditEvent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Modifica nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Modifica descrizione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Modifica luogo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Modifica Orario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email:";
            // 
            // ModificaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(356, 276);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditEvent);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Ore);
            this.Controls.Add(this.Giorni);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.Descrizione);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.DeleteEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificaEvento";
            this.Text = "Modifica Evento";
            this.Load += new System.EventHandler(this.ModificaEvento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteEvent;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Nome;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Descrizione;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Location;
        private System.Windows.Forms.TextBox Giorni;
        private System.Windows.Forms.TextBox Ore;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Email;
        private System.Windows.Forms.Button EditEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}