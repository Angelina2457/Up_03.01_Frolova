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
    public partial class F_Model_adm : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public F_Model_adm()
        {
            InitializeComponent();
        }

        private void F_Model_adm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIS_Org_Teh_full_DataSet.Model". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Model);
            this.Activated += new System.EventHandler(this.Form_Activated);
        }
        private void Form_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchet_personalaDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Model);

            {
                connection = new SqlConnection(@"Data Source=WIN-EI6FSTSMJHV;Initial Catalog=AIS_Org_teh;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("SELECT        Model.ID_Mod, Proizvoditel.name, Tip_teh.name, Model.name\r\nFROM            Model INNER JOIN\r\n                         Proizvoditel ON Model.Proizv_ID = Proizvoditel.ID_Proizv INNER JOIN\r\n                         Tip_teh ON Model.Tip_ID = Tip_teh.ID_Tip", connection);
                table = new DataTable();
                adapter.Fill(table);
                dGV_model.RowHeadersVisible = false;
                dGV_model.DataSource = table;
                dGV_model.Columns[0].HeaderCell.Value = "№";
                dGV_model.Columns[0].Width = 30;
                dGV_model.Columns[1].HeaderCell.Value = "Производитель";
                dGV_model.Columns[1].Width = 150;
                dGV_model.Columns[2].HeaderCell.Value = "Тип";
                dGV_model.Columns[2].Width = 80;
                dGV_model.Columns[3].HeaderCell.Value = "Название модели";
                dGV_model.Columns[3].Width = 150;

            }
        }

        private void SotrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Sotr_adm a = new F_Sotr_adm();
            a.ShowDialog();
        }

        private void TehToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Teh_adm a = new F_Teh_adm();
            a.ShowDialog();
        }

        private void ParametrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Teh_param_adm a = new F_Teh_param_adm();
            a.ShowDialog();
        }

        private void SpParamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Param_adm a = new F_Param_adm();
            a.ShowDialog();
        }

        private void VidТехникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Tip_teh_adm a = new F_Tip_teh_adm();
            a.ShowDialog();
        }

        private void ProizvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Proizv_adm a = new F_Proizv_adm();
            a.ShowDialog();
        }
    }
}
