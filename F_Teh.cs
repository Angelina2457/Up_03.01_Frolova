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
    public partial class F_Teh : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public F_Teh()
        {
            InitializeComponent();
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

        private void F_Teh_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIS_Org_Teh_full_DataSet.Tehnica". При необходимости она может быть перемещена или удалена.
            this.tehnicaTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Tehnica);
            this.Activated += new System.EventHandler(this.Form_Activated);
        }

        private void ZayavToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Zayavki a = new F_Zayavki();
            a.ShowDialog();
        }
    }
}
