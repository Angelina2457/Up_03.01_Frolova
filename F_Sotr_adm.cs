using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Org_Teh
{
    public partial class F_Sotr_adm : Form
    {
        private string id_sotr;
        private string fio;
        private string role;
        private string login;
        private string parol;
        private string phone;
        private string email;
        
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;

        public string Pass_ID_Sotr
        {
            get { return id_sotr; }
            set { id_sotr = value; }
        }

        public string Pass_Fio
        {
            get { return fio; }
            set { fio = value; }
        }

        public string Pass_Role
        {
            get { return role; }
            set { role = value; }
        }

        public string Pass_Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Pass_Parol
        {
            get { return parol; }
            set { parol = value; }
        }

        public string Pass_Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Pass_Email
        {
            get { return email; }
            set { email = value; }
        }
        public F_Sotr_adm()
        {
            InitializeComponent();
        }

        private void F_Sotr_adm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIS_Org_Teh_full_DataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Sotrudnik);
            this.Activated += new System.EventHandler(this.Form_Activated);
        }
        private void Form_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchet_personalaDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Sotrudnik);



            {
                connection = new SqlConnection(@"Data Source=WIN-EI6FSTSMJHV;Initial Catalog=AIS_Org_teh;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("SELECT ID_Sotr, FIO, role, login, parol, phone, email FROM dbo.Sotrudnik", connection);
                table = new DataTable();
                adapter.Fill(table);
                dGV_Sotr.RowHeadersVisible = false;
                dGV_Sotr.DataSource = table;
                dGV_Sotr.Columns[0].HeaderCell.Value = "№";
                dGV_Sotr.Columns[0].Width = 30;
                dGV_Sotr.Columns[1].HeaderCell.Value = "ФИО";
                dGV_Sotr.Columns[1].Width = 250;
                dGV_Sotr.Columns[2].HeaderCell.Value = "Должность";
                dGV_Sotr.Columns[2].Width = 130;
                dGV_Sotr.Columns[3].HeaderCell.Value = "Логин";
                dGV_Sotr.Columns[3].Width = 100;
                dGV_Sotr.Columns[4].HeaderCell.Value = "Пароль";
                dGV_Sotr.Columns[4].Width = 100;
                dGV_Sotr.Columns[5].HeaderCell.Value = "Телефон";
                dGV_Sotr.Columns[5].Width = 150;
                dGV_Sotr.Columns[6].HeaderCell.Value = "Почта";
                dGV_Sotr.Columns[6].Width = 150;

            }
        }

        private void TehToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Teh_adm a = new F_Teh_adm();
            a.ShowDialog();
        }

        private void ModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Model_adm a = new F_Model_adm();
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

        private void VidToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void b_dobav_Click(object sender, EventArgs e)
        {
            F_Add_Sotr faddsotr = new F_Add_Sotr();
            this.Hide();
            faddsotr.Owner = this;
            faddsotr.ShowDialog(this);
        }

        private void b_red_Click(object sender, EventArgs e)
        {
            F_Edit_sotr fedsotr = new F_Edit_sotr();
            this.Hide();
            fedsotr.Owner = this;
            fedsotr.ShowDialog(this);
        }
    }
}
