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
        public FormValutazioni()
        {
            InitializeComponent();
            
        }

        private void FormValutazioni_Load(object sender, EventArgs e)
        {
            
        }

        private void AddSubject_Click(object sender, EventArgs e)
        {
            AddSubjectForm f2 = new AddSubjectForm();
            f2.Show();
        }
    }
    
}
