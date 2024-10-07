using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Org_Teh
{
    public partial class F_Param_adm : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public F_Param_adm()
        {
            InitializeComponent();
        }

        private void F_Param_adm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIS_Org_Teh_full_DataSet.Parameter". При необходимости она может быть перемещена или удалена.
            this.parameterTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Parameter);
            this.Activated += new System.EventHandler(this.Form_Activated);
        }
        private void Form_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchet_personalaDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.parameterTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Parameter);

            {
                connection = new SqlConnection(@"Data Source=WIN-EI6FSTSMJHV;Initial Catalog=AIS_Org_teh;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("SELECT ID_param, name FROM dbo.Parameter", connection);
                table = new DataTable();
                adapter.Fill(table);
                dGV_Param.RowHeadersVisible = false;
                dGV_Param.DataSource = table;
                dGV_Param.Columns[0].HeaderCell.Value = "№";
                dGV_Param.Columns[0].Width = 30;
                dGV_Param.Columns[1].HeaderCell.Value = "Название";
                dGV_Param.Columns[1].Width = 250;

            }
        }
    }
}
