using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal_Elite.Forms
{
  public partial class FormProfilo : Form
  {

    public FormProfilo()
    {
      InitializeComponent();
      LoadTheme();
    }
    private void LoadTheme()
    {


      foreach (Control btns in this.Controls)
      {
        if (btns.GetType() == typeof(System.Windows.Forms.Button))
        {
          System.Windows.Forms.Button btn = (System.Windows.Forms.Button)btns;

          btn.ForeColor = Color.White;

        }
      }


    }
    private void FormProfilo_Load(object sender, EventArgs e)
    {
      LoadTheme();
    }



    private void ChangePropic_Click(object sender, EventArgs e)
    {
      
    }

    private void ProPic_Click(object sender, EventArgs e)
    {
            //Upload a ProPic
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ProPic.Image = new Bitmap(open.FileName);
                File.Copy(ProPic.Text, Path.Combine("C:/Journal Elite/ProfilePic/", Path.GetFileName("propic")), true);


                MessageBox.Show("Immagine profilo aggiornata con successo!");
            }



      this.ProPic.MaximumSize = new System.Drawing.Size(128, 128);
      

      //Save ProPic


    }

        private void creadits_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Creato da diskxo_" + "\n" + " Aprire il sito web?", "Creaditi", MessageBoxButtons.YesNo , MessageBoxIcon.Asterisk
            ) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("http://www.phoenixpixel.it");
            }
        }
    }
}
