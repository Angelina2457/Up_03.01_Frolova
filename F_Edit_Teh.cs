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

    public partial class F_Edit_Teh : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public F_Edit_Teh()
        {
            InitializeComponent();
        }
        public string get_cs()
        {
            return "Data Source=WIN-EI6FSTSMJHV;Initial Catalog=AIS_Org_teh;Integrated Security=True";
        }

        private void b_red_Click(object sender, EventArgs e)
        {
            F_Teh_adm f1 = (F_Teh_adm)this.Owner;

            int id = 0;
            //считывает выбранную строчку
            id = Convert.ToInt32(f1.dGV_teh.Rows[f1.dGV_teh.SelectedCells[0].RowIndex].Cells[0].Value);

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
            MessageBox.Show("Вы точно хотите изменить данные таблицы Сотрудники?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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

                    using (var cmd = new SqlCommand("UPDATE [Tehnica] SET [ID_Teh]=@ID_Teh, [Sotr_ID]=@FIO, [Mod_ID]=@name, [Cab_ID]=@number, [inventory]=@inventory, [data_preobretenia]=@data_preobretenia, [cena]=@cena, [srok_god]=@srok_god  WHERE ID_Teh = @ID_Teh ", connection))

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
                    FillDataGridViev();

                }
            }
            else
            {
                MessageBox.Show("Заполните все поля.", "Ошибка");
            }
            if (tb_ID_Teh.Text != null)
            {
                tb_ID_Teh.Clear();
            }
            if (tb_inv.Text != null)
            {
                tb_inv.Clear();
            }
            if (tb_data.Text != null)
            {
                tb_data.Clear();
            }

            if (tb_cena.Text != null)
            {
                tb_cena.Clear();
            }

            if (tb_srok.Text != null)
            {
                tb_srok.Clear();
            }
            

        }
        private void FillDataGridViev()
        {
            F_Teh_adm formeditfac = (F_Teh_adm)this.Owner;

            connection = new SqlConnection("Data Source=WIN-EI6FSTSMJHV;Initial Catalog=AIS_Org_teh;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("SELECT        Tehnica.ID_Teh, Sotrudnik.FIO, Model.name, Cabinet.number, Tehnica.inventory, Tehnica.data_preobretenia, Tehnica.cena, Tehnica.srok_god FROM Tehnica INNER JOIN Sotrudnik ON Tehnica.Sotr_ID = Sotrudnik.ID_Sotr INNER JOIN  Model ON Tehnica.Mod_ID = Model.ID_Mod INNER JOIN\r\n                         Cabinet ON Tehnica.Cab_ID = Cabinet.ID_Cab", connection);
            table = new DataTable();
            adapter.Fill(table);
            formeditfac.dGV_teh.DataSource = table;
            this.Close();
        }

        private void F_Edit_Teh_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIS_Org_Teh_full_DataSet.Cabinet". При необходимости она может быть перемещена или удалена.
            this.cabinetTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Cabinet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIS_Org_Teh_full_DataSet.Model". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Model);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIS_Org_Teh_full_DataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.aIS_Org_Teh_full_DataSet.Sotrudnik);
            connection = new SqlConnection(@"Data Source=WIN-EI6FSTSMJHV;Initial Catalog=AIS_Org_teh;Integrated Security=True");
            connection.Open();


            F_Teh_adm frm = (F_Teh_adm)Application.OpenForms["F_Teh_adm"];
            int row = frm.dGV_teh.CurrentRow.Index;
            tb_ID_Teh.Text = Convert.ToString(frm.dGV_teh[0, row].Value);
            cb_FIO.Text = Convert.ToString(frm.dGV_teh[1, row].Value);
            cb_Model.Text = Convert.ToString(frm.dGV_teh[2, row].Value);
            cb_Cabinet.Text = Convert.ToString(frm.dGV_teh[3, row].Value);
            tb_inv.Text = Convert.ToString(frm.dGV_teh[4, row].Value);
            tb_data.Text = Convert.ToString(frm.dGV_teh[5, row].Value);
            tb_cena.Text = Convert.ToString(frm.dGV_teh[6, row].Value);
            tb_srok.Text = Convert.ToString(frm.dGV_teh[7, row].Value);
            

        }

        private void b_otm_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Teh_adm main = new F_Teh_adm();
            main.ShowDialog();
            connection.Close();
        }
    }
}
