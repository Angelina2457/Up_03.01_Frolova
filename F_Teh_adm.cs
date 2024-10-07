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
    public partial class F_Teh_adm : Form
    {
        private string id_teh;
        private string sotr_id;
        private string mod_id;
        private string cab_id;
        private string inventory;
        private string data_pr;
        private string cena;
        private string srok;
        
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;

        public string Pass_ID_Teh
        {
            get { return id_teh; }
            set { id_teh = value; }
        }

        public string Pass_Sotr_ID
        {
            get { return sotr_id; }
            set { sotr_id = value; }
        }

        public string Pass_Mod_ID
        {
            get { return mod_id; }
            set { mod_id = value; }
        }

        public string Pass_Cab_ID
        {
            get { return cab_id; }
            set { cab_id = value; }
        }
        public string Pass_Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }

        public string Pass_Data
        {
            get { return data_pr; }
            set { data_pr = value; }
        }

        public string Pass_Cena
        {
            get { return cena; }
            set { cena = value; }
        }
        public string Pass_Srok
        {
            get { return srok; }
            set { srok = value; }
        }
        
        public F_Teh_adm()
        {
            InitializeComponent();
        }

        private void F_Teh_adm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIS_Org_Teh_full_DataSet.Tehnica". При необходимости она может быть перемещена или удалена.
            this.tehnicaTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Tehnica);
            this.Activated += new System.EventHandler(this.Form_Activated);
        }
        private void Form_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchet_personalaDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.tehnicaTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Tehnica);



            {
                connection = new SqlConnection(@"Data Source=WIN-EI6FSTSMJHV;Initial Catalog=AIS_Org_teh;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("SELECT        Tehnica.ID_Teh, Sotrudnik.FIO, Model.name, Cabinet.number, Tehnica.inventory, Tehnica.data_preobretenia, Tehnica.cena, Tehnica.srok_god FROM Tehnica INNER JOIN Sotrudnik ON Tehnica.Sotr_ID = Sotrudnik.ID_Sotr INNER JOIN  Model ON Tehnica.Mod_ID = Model.ID_Mod INNER JOIN\r\n                         Cabinet ON Tehnica.Cab_ID = Cabinet.ID_Cab", connection);
                table = new DataTable();
                adapter.Fill(table);
                dGV_teh.RowHeadersVisible = false;
                dGV_teh.DataSource = table;
                dGV_teh.Columns[0].HeaderCell.Value = "№";
                dGV_teh.Columns[0].Width = 30;
                dGV_teh.Columns[1].HeaderCell.Value = "ФИО";
                dGV_teh.Columns[1].Width = 250;
                dGV_teh.Columns[2].HeaderCell.Value = "Модель";
                dGV_teh.Columns[2].Width = 130;
                dGV_teh.Columns[3].HeaderCell.Value = "Кабинет";
                dGV_teh.Columns[3].Width = 70;
                dGV_teh.Columns[4].HeaderCell.Value = "Инвентарный номер";
                dGV_teh.Columns[4].Width = 120;
                dGV_teh.Columns[5].HeaderCell.Value = "Дата приобретения";
                dGV_teh.Columns[5].Width = 150;
                dGV_teh.Columns[6].HeaderCell.Value = "Цена";
                dGV_teh.Columns[6].Width = 150;
                dGV_teh.Columns[7].HeaderCell.Value = "Срок годности";
                dGV_teh.Columns[7].Width = 70;
                
            }
        }

        private void VihodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Vhoda a = new F_Vhoda();
            a.ShowDialog();
            
        }

        private void SotrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Sotr_adm a = new F_Sotr_adm();
            a.ShowDialog();
        }

        private void b_dobav_Click(object sender, EventArgs e)
        {
            F_Add_Teh faddteh = new F_Add_Teh();
            this.Hide();
            faddteh.Owner = this;
            faddteh.ShowDialog(this);
        }

        private void b_red_Click(object sender, EventArgs e)
        {
            F_Edit_Teh fedteh = new F_Edit_Teh();
            this.Hide();
            fedteh.Owner = this;
            fedteh.ShowDialog(this);
        }

        private void b_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand mycommand = new SqlCommand($"DELETE FROM Tehnica WHERE ID_Teh = N'{tb_del.Text}'", connection);
                MessageBox.Show("Удалено записей: " + mycommand.ExecuteNonQuery().ToString());
                table.Clear();
                adapter.Fill(table);
                dGV_teh.DataSource = table;
            }
        }

        private void dGV_teh_MouseClick(object sender, MouseEventArgs e)
        {
            tb_del.Text = dGV_teh.CurrentRow.Cells[0].Value.ToString();
        }

        private void ModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Model_adm a = new F_Model_adm();
            a.ShowDialog();
        }

        private void ParametrToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            F_Param_adm a = new F_Param_adm();
            a.ShowDialog();
        }

        private void SpParamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Teh_param_adm a = new F_Teh_param_adm();
            a.ShowDialog();
        }

        private void ParametrToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void производителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Proizv_adm a = new F_Proizv_adm();
            a.ShowDialog();
        }

        private void ZayavToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Zayavki_adm a = new F_Zayavki_adm();
            a.ShowDialog();
        }
    }
}
