using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal_Elite.Forms
{
    public partial class FormValutazioni : Form
    {
        System.Data.DataTable dt = new System.Data.DataTable();
        DataTable table = new DataTable("tbl");
        public FormValutazioni()
        {
            InitializeComponent();
            
        }

        private void FormValutazioni_Load(object sender, EventArgs e)
        {
            
        }

        private void AddSubject_Click(object sender, EventArgs e)
        {
            lblName.Visible = true;
            txtName.Visible = true;
            SaveSubject.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SaveSubject_Click(object sender, EventArgs e)
        {

            if (label1.Visible == false)
            {
                label1.Visible = true;
                bunifuCircleProgressbar1.Visible = true;
                AddVote.Visible = true;
                label1.Text = txtName.Text;
            }
            else if(label2.Visible == false)
            {
                label2.Visible = true;
                bunifuCircleProgressbar2.Visible = true;
                button1.Visible = true;
            }
            else if (label3.Visible == false)
            {
                label3.Visible = true;
                bunifuCircleProgressbar3.Visible = true;
                button2.Visible = true;
            }
            else if (label4.Visible == false)
            {
                label4.Visible = true;
                bunifuCircleProgressbar4.Visible = true;
                button3.Visible = true;
            }
            else if (label5.Visible == false)
            {
                label5.Visible = true;
                bunifuCircleProgressbar5.Visible = true;
                button4.Visible = true;
            }
            else if (label6.Visible == false)
            {
                label6.Visible = true;
                bunifuCircleProgressbar6.Visible = true;
                button5.Visible = true;
            }
            else if (label7.Visible == false)
            {
                label7.Visible = true;
                bunifuCircleProgressbar7.Visible = true;
                button6.Visible = true;
            }
            else if (label8.Visible == false)
            {
                label8.Visible = true;
                bunifuCircleProgressbar8.Visible = true;
                button7.Visible = true;
            }
            else if (label9.Visible == false)
            {
                label9.Visible = true;
                bunifuCircleProgressbar9.Visible = true;
                button8.Visible = true;
            }
            else if (label10.Visible == false)
            {
                label10.Visible = true;
                bunifuCircleProgressbar10.Visible = true;
                button9.Visible = true;
            }

        }
    }
    
}
