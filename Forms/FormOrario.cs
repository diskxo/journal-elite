using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Journal_Elite.Forms
{
  public partial class FormOrario : Form
  {
    System.Data.DataTable dt = new System.Data.DataTable();
    DataTable table = new DataTable("tbl");
    public FormOrario()
    {
      InitializeComponent();
    }





    private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void FormOrario_Load(object sender, EventArgs e)
    {
      dt.ReadXml(@"Orario.xml");
      bunifuCustomDataGrid1.DataSource = dt;



    }


    private void timer1_Tick(object sender, EventArgs e)
    {
      dt.WriteXml(@"Orario.xml", XmlWriteMode.WriteSchema);

    }

    private void btnExport_Click_1(object sender, EventArgs e)
    {

    }
  }
}
