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
    public partial class F_Zayavki_adm : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public F_Zayavki_adm()
        {
            InitializeComponent();
        }

        private void F_Zayavki_adm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIS_Org_Teh_full_DataSet.Zayavki". При необходимости она может быть перемещена или удалена.
            this.zayavkiTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Zayavki);
            this.Activated += new System.EventHandler(this.Form_Activated);
        }
        private void Form_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchet_personalaDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.zayavkiTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Zayavki);



            {
                connection = new SqlConnection(@"Data Source=WIN-EI6FSTSMJHV;Initial Catalog=AIS_Org_teh;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("SELECT        Zayavki.ID_Req, Sotrudnik.FIO, Tehnica.inventory, Zayavki.tip_req, Zayavki.date, Zayavki.status\r\nFROM            Zayavki INNER JOIN\r\n                         Sotrudnik ON Zayavki.Sotr_ID = Sotrudnik.ID_Sotr INNER JOIN\r\n                         Tehnica ON Zayavki.Teh_ID = Tehnica.ID_Teh AND Sotrudnik.ID_Sotr = Tehnica.Sotr_ID", connection);
                table = new DataTable();
                adapter.Fill(table);
                dGV_teh.RowHeadersVisible = false;
                dGV_teh.DataSource = table;
                dGV_teh.Columns[0].HeaderCell.Value = "№";
                dGV_teh.Columns[0].Width = 30;
                dGV_teh.Columns[1].HeaderCell.Value = "Заявитель";
                dGV_teh.Columns[1].Width = 250;
                dGV_teh.Columns[2].HeaderCell.Value = "Инвентарный номер";
                dGV_teh.Columns[2].Width = 100;
                dGV_teh.Columns[3].HeaderCell.Value = "Тип заявки";
                dGV_teh.Columns[3].Width = 150;
                dGV_teh.Columns[4].HeaderCell.Value = "Дата заявки";
                dGV_teh.Columns[4].Width = 120;
                dGV_teh.Columns[5].HeaderCell.Value = "Статус";
                dGV_teh.Columns[5].Width = 150;
                

            }
        }
    }
}
