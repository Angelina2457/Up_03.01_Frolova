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
    public partial class F_Add_Teh : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public F_Add_Teh()
        {
            InitializeComponent();
        }
        public string get_cs()
        {
            return "Data Source=WIN-EI6FSTSMJHV;Initial Catalog=AIS_Org_teh;Integrated Security=True";
        }
        private void FillDataGridViev()
        {
            F_Teh_adm formadd = (F_Teh_adm)this.Owner;

            connection = new SqlConnection("Data Source=WIN-EI6FSTSMJHV;Initial Catalog=AIS_Org_teh;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("SELECT        Tehnica.ID_Teh, Sotrudnik.FIO, Model.name, Cabinet.number, Tehnica.inventory, Tehnica.data_preobretenia, Tehnica.cena, Tehnica.srok_god FROM Tehnica INNER JOIN Sotrudnik ON Tehnica.Sotr_ID = Sotrudnik.ID_Sotr INNER JOIN  Model ON Tehnica.Mod_ID = Model.ID_Mod INNER JOIN\r\n                         Cabinet ON Tehnica.Cab_ID = Cabinet.ID_Cab", connection);
            table = new DataTable();
            adapter.Fill(table);
            formadd.dGV_teh.DataSource = table;
            this.Close();
        }

        private void b_dob_Click(object sender, EventArgs e)
        {
            F_Teh_adm f1 = (F_Teh_adm)this.Owner;
            f1.Pass_ID_Teh = tb_ID_Teh.Text;
            f1.Pass_Sotr_ID = cb_FIO.Text;
            f1.Pass_Mod_ID = cb_Model.Text;
            f1.Pass_Cab_ID = cb_Cabinet.Text;
            f1.Pass_Inventory = tb_inv.Text;
            f1.Pass_Data = tb_data.Text;
            f1.Pass_Cena = tb_cena.Text;
            f1.Pass_Srok = tb_srok.Text;
            
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите добавить данные в таблицу Сотрудники?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tb_ID_Teh.Text) && !string.IsNullOrWhiteSpace(tb_ID_Teh.Text) &&
               !string.IsNullOrEmpty(cb_FIO.Text) && !string.IsNullOrWhiteSpace(cb_FIO.Text) &&
               !string.IsNullOrEmpty(cb_Model.Text) && !string.IsNullOrWhiteSpace(cb_Model.Text) &&
               !string.IsNullOrEmpty(cb_Cabinet.Text) && !string.IsNullOrWhiteSpace(cb_Cabinet.Text) &&
               !string.IsNullOrEmpty(tb_inv.Text) && !string.IsNullOrWhiteSpace(tb_inv.Text) &&
               !string.IsNullOrEmpty(tb_data.Text) && !string.IsNullOrWhiteSpace(tb_data.Text) &&
               !string.IsNullOrEmpty(tb_cena.Text) && !string.IsNullOrWhiteSpace(tb_cena.Text) &&
               !string.IsNullOrEmpty(tb_srok.Text) && !string.IsNullOrWhiteSpace(tb_srok.Text)) 

            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("INSERT INTO [Tehnica] (ID_Teh, Sotr_ID, Mod_ID, Cab_ID, inventory, data_preobretenia, cena, srok_god) VALUES (@ID_Teh, @FIO, @name, @number, @inventory, @data_preobretenia, @cena, @srok_god)", connection))

                    {
                        cmd.Parameters.AddWithValue("ID_Teh", tb_ID_Teh.Text);
                        cmd.Parameters.AddWithValue("FIO", cb_FIO.SelectedValue);
                        cmd.Parameters.AddWithValue("name", cb_Model.SelectedValue);
                        cmd.Parameters.AddWithValue("number", cb_Cabinet.SelectedValue);
                        cmd.Parameters.AddWithValue("inventory", tb_inv.Text);
                        cmd.Parameters.AddWithValue("data_preobretenia", tb_data.Text);
                        cmd.Parameters.AddWithValue("cena", tb_cena.Text);
                        cmd.Parameters.AddWithValue("srok_god", tb_srok.Text);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    tb_ID_Teh.Clear();
                    tb_inv.Clear();
                    tb_data.Clear();
                    tb_cena.Clear();
                    tb_srok.Clear();

                    FillDataGridViev();

                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!!!", "Предупреждение");
            }

        }

        private void F_Add_Teh_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIS_Org_Teh_full_DataSet.Cabinet". При необходимости она может быть перемещена или удалена.
            this.cabinetTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Cabinet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIS_Org_Teh_full_DataSet.Model". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Model);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIS_Org_Teh_full_DataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Sotrudnik);

        }
    }
}
