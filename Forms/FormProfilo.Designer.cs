namespace Journal_Elite.Forms
{
    partial class FormProfilo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfilo));
            this.btnWindowSize = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ChangePropic = new System.Windows.Forms.Button();
            this.ProPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWindowSize
            // 
            this.btnWindowSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWindowSize.FlatAppearance.BorderSize = 0;
            this.btnWindowSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowSize.ForeColor = System.Drawing.Color.White;
            this.btnWindowSize.Image = ((System.Drawing.Image)(resources.GetObject("btnWindowSize.Image")));
            this.btnWindowSize.Location = new System.Drawing.Point(12, 425);
            this.btnWindowSize.Name = "btnWindowSize";
            this.btnWindowSize.Size = new System.Drawing.Size(36, 37);
            this.btnWindowSize.TabIndex = 1;
            this.btnWindowSize.UseVisualStyleBackColor = true;
            this.btnWindowSize.Click += new System.EventHandler(this.Button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 16);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Nicola Preda";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(12, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 16);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "1^ Superiore";
            // 
            // ChangePropic
            // 
            this.ChangePropic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePropic.FlatAppearance.BorderSize = 0;
            this.ChangePropic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePropic.Image = ((System.Drawing.Image)(resources.GetObject("ChangePropic.Image")));
            this.ChangePropic.Location = new System.Drawing.Point(175, 12);
            this.ChangePropic.Name = "ChangePropic";
            this.ChangePropic.Size = new System.Drawing.Size(40, 37);
            this.ChangePropic.TabIndex = 5;
            this.ChangePropic.UseVisualStyleBackColor = true;
            this.ChangePropic.Click += new System.EventHandler(this.ChangePropic_Click);
            // 
            // ProPic
            // 
            this.ProPic.Location = new System.Drawing.Point(12, 12);
            this.ProPic.Name = "ProPic";
            this.ProPic.Size = new System.Drawing.Size(149, 127);
            this.ProPic.TabIndex = 6;
            this.ProPic.TabStop = false;
            this.ProPic.Click += new System.EventHandler(this.ProPic_Click);
            // 
            // FormProfilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(828, 474);
            this.Controls.Add(this.ProPic);
            this.Controls.Add(this.ChangePropic);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnWindowSize);
            this.Name = "FormProfilo";
            this.Text = "PROFILO";
            this.Load += new System.EventHandler(this.FormProfilo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnWindowSize;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ChangePropic;
        private System.Windows.Forms.PictureBox ProPic;
    }
}