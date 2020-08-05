using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Xml.Serialization;
using TextBox = System.Windows.Controls.TextBox;

namespace Journal_Elite.Forms
{
    public partial class Votes : Form
    {
        //Write to XML
        XmlSerializer xs;
        List<Titles> ls;


        static int i = 1;

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

        public Votes()
        {
            InitializeComponent();

            xs = new XmlSerializer(typeof(List<Titles>));
            ls = new List<Titles>();

            
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
            textBox1.Visible = true;
            
        }

        private void SaveSubject_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"titles.xml", FileMode.Create, FileAccess.Write);
            Titles sc = new Titles();
            sc.Name = txtName.Text;
            sc.Class = int.Parse(txtName.Text);
            ls.Add(sc);

            xs.Serialize(fs, ls);



            if (label1.Visible == false)
            {
                lblStart.Visible = false;
                label1.Visible = true;
                bunifuCircleProgressbar1.Visible = true;
                AddVote.Visible = true;
                label1.Text = txtName.Text;
                
            }
            else if(label2.Visible == false)
            {
                label2.Visible = true;
                bunifuCircleProgressbar3.Visible = true;
                button1.Visible = true;
                label2.Text = txtName.Text;
            }
            else if (label3.Visible == false)
            {
                label3.Visible = true;
                bunifuCircleProgressbar2.Visible = true;
                button2.Visible = true;
                label3.Text = txtName.Text;
            }
            else if (label4.Visible == false)
            {
                label4.Visible = true;
                bunifuCircleProgressbar4.Visible = true;
                button3.Visible = true;
                label4.Text = txtName.Text;
            }
            else if (label5.Visible == false)
            {
                label5.Visible = true;
                bunifuCircleProgressbar5.Visible = true;
                button4.Visible = true;
                label1.Text = txtName.Text;
            }
            else if (label6.Visible == false)
            {
                label6.Visible = true;
                bunifuCircleProgressbar6.Visible = true;
                button5.Visible = true;
                label6.Text = txtName.Text;
            }
            else if (label7.Visible == false)
            {
                label7.Visible = true;
                bunifuCircleProgressbar7.Visible = true;
                button6.Visible = true;
                label7.Text = txtName.Text;
            }
            else if (label8.Visible == false)
            {
                label8.Visible = true;
                bunifuCircleProgressbar8.Visible = true;
                button7.Visible = true;
                label8.Text = txtName.Text;
            }
            else if (label9.Visible == false)
            {
                label9.Visible = true;
                bunifuCircleProgressbar9.Visible = true;
                button8.Visible = true;
                label9.Text = txtName.Text;
            }
            else if (label10.Visible == false)
            {
                label10.Visible = true;
                bunifuCircleProgressbar10.Visible = true;
                button9.Visible = true;
                label10.Text = txtName.Text;
            }
            else if (label10.Visible == true)
            {
                MessageBox.Show("Hai raggiunto il numero massimo di materie disponibili!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox11.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox8.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox9.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Enter))
            {
                bunifuCircleProgressbar1.InitializeLifetimeService();
            }

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            subject2.ReadXml(@"subjects.xml");
            label2.Text = subject2.TableName;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            subject3.ReadXml(@"subjects.xml");
            label3.Text = subject3.TableName;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            subject4.ReadXml(@"subjects.xml");
            label4.Text = subject4.TableName;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            subject5.ReadXml(@"subjects.xml");
            label5.Text = subject5.TableName;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            subject6.ReadXml(@"subjects.xml");
            label6.Text = subject6.TableName;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            subject7.ReadXml(@"subjects.xml");
            label7.Text = subject7.TableName;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            subject8.ReadXml(@"subjects.xml");
            label8.Text = subject8.TableName;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            subject9.ReadXml(@"subjects.xml");
            label9.Text = subject9.TableName;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            subject10.ReadXml(@"subjects.xml");
            label10.Text = subject10.TableName;
        }

        private void load_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"titles.xml", FileMode.Open, FileAccess.Read);
            ls = (List<Titles>)xs.Deserialize(fs);
            dataGridView1.DataSource = ls;
        }
    }
    
}
