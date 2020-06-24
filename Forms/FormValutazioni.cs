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
        System.Data.DataTable subject1 = new System.Data.DataTable("subject1");
        DataTable table1 = new DataTable("subject1");

        System.Data.DataTable subject2 = new System.Data.DataTable("subject2");
        DataTable table2 = new DataTable("subject2");

        System.Data.DataTable subject3 = new System.Data.DataTable("subject3");
        DataTable table3 = new DataTable("subject3");

        System.Data.DataTable subject4 = new System.Data.DataTable("subject4");
        DataTable table4 = new DataTable("subject4");

        System.Data.DataTable subject5 = new System.Data.DataTable("subject5");
        DataTable table5 = new DataTable("subject5");

        System.Data.DataTable subject6 = new System.Data.DataTable("subject6");
        DataTable table6 = new DataTable("subject6");

        System.Data.DataTable subject7 = new System.Data.DataTable("subject7");
        DataTable table7 = new DataTable("subject7");

        System.Data.DataTable subject8 = new System.Data.DataTable("subject8");
        DataTable table8 = new DataTable("subject8");

        System.Data.DataTable subject9 = new System.Data.DataTable("subject9");
        DataTable table9 = new DataTable("subject9");

        System.Data.DataTable subject10 = new System.Data.DataTable("subject10");
        DataTable table10 = new DataTable("subject10");

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

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (label1.Visible == false)
            {
                subject1.WriteXml(@"subjects.xml", XmlWriteMode.WriteSchema);
            }
            else if (label2.Visible == false)
            {
                subject2.WriteXml(@"subjects.xml", XmlWriteMode.WriteSchema);
            }
            else if (label3.Visible == false)
            {
                subject3.WriteXml(@"subjects.xml", XmlWriteMode.WriteSchema);
            }
            else if (label4.Visible == false)
            {
                subject4.WriteXml(@"subjects.xml", XmlWriteMode.WriteSchema);
            }
            else if (label5.Visible == false)
            {
                subject5.WriteXml(@"subjects.xml", XmlWriteMode.WriteSchema);
            }
            else if (label6.Visible == false)
            {
                subject6.WriteXml(@"subjects.xml", XmlWriteMode.WriteSchema);
            }
            else if (label7.Visible == false)
            {
                subject7.WriteXml(@"subjects.xml", XmlWriteMode.WriteSchema);
            }
            else if (label8.Visible == false)
            {
                subject8.WriteXml(@"subjects.xml", XmlWriteMode.WriteSchema);
            }
            else if (label9.Visible == false)
            {
                subject9.WriteXml(@"subjects.xml", XmlWriteMode.WriteSchema);
            }
            else if (label10.Visible == false)
            {
                subject10.WriteXml(@"subjects.xml", XmlWriteMode.WriteSchema);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            subject1.ReadXml(@"subjects.xml");
            label1.Text = subject1.TableName;
        }
    }
    
}
