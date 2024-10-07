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
    public partial class F_Teh_param_adm : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public F_Teh_param_adm()
        {
            InitializeComponent();
        }

        private void F_Teh_param_adm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIS_Org_Teh_full_DataSet.Teh_parameter". При необходимости она может быть перемещена или удалена.
            this.teh_parameterTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Teh_parameter);
            this.Activated += new System.EventHandler(this.Form_Activated);
        }
        private void Form_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchet_personalaDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.teh_parameterTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Teh_parameter);

            {
                connection = new SqlConnection(@"Data Source=WIN-EI6FSTSMJHV;Initial Catalog=AIS_Org_teh;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("SELECT        Teh_parameter.ID_Teh_par, Parameter.name, Model.name, Teh_parameter.value\r\nFROM            Teh_parameter INNER JOIN\r\n                         Parameter ON Teh_parameter.Param_ID = Parameter.ID_param INNER JOIN\r\n                         Model ON Teh_parameter.Mod_ID = Model.ID_Mod", connection);
                table = new DataTable();
                adapter.Fill(table);
                dGV_teh_p.RowHeadersVisible = false;
                dGV_teh_p.DataSource = table;
                dGV_teh_p.Columns[0].HeaderCell.Value = "№";
                dGV_teh_p.Columns[0].Width = 30;
                dGV_teh_p.Columns[1].HeaderCell.Value = "Параметр";
                dGV_teh_p.Columns[1].Width = 150;
                dGV_teh_p.Columns[2].HeaderCell.Value = "Модель";
                dGV_teh_p.Columns[2].Width = 100;
                dGV_teh_p.Columns[3].HeaderCell.Value = "Описание";
                dGV_teh_p.Columns[3].Width = 150;

            }
        }
    }
}
