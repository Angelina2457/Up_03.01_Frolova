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
    public partial class F_Add_Sotr : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public F_Add_Sotr()
        {
            InitializeComponent();
        }
        public string get_cs()
        {
            return "Data Source=WIN-EI6FSTSMJHV;Initial Catalog=AIS_Org_teh;Integrated Security=True";
        }
        private void FillDataGridViev()
        {
            F_Sotr_adm formadd = (F_Sotr_adm)this.Owner;

            connection = new SqlConnection("Data Source=WIN-EI6FSTSMJHV;Initial Catalog=AIS_Org_teh;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("SELECT ID_Sotr, FIO, role, login, parol, phone, email FROM dbo.Sotrudnik", connection);
            table = new DataTable();
            adapter.Fill(table);
            formadd.dGV_Sotr.DataSource = table;
            this.Close();
        }

        private void b_dob_Click(object sender, EventArgs e)
        {
            F_Sotr_adm f1 = (F_Sotr_adm)this.Owner;
            f1.Pass_ID_Sotr = tb_ID_Sotr.Text;
            f1.Pass_Fio = tb_FIO.Text;
            f1.Pass_Role = tb_role.Text;
            f1.Pass_Login = tb_login.Text;
            f1.Pass_Parol = tb_parol.Text;
            f1.Pass_Phone = tb_teleph.Text;
            f1.Pass_Email = tb_mail.Text;

            f1.Show();
            this.Close();
            MessageBox.Show("Вы точно хотите добавить данные в таблицу Сотрудники?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tb_ID_Sotr.Text) && !string.IsNullOrWhiteSpace(tb_ID_Sotr.Text) &&
               !string.IsNullOrEmpty(tb_FIO.Text) && !string.IsNullOrWhiteSpace(tb_FIO.Text) &&
               !string.IsNullOrEmpty(tb_role.Text) && !string.IsNullOrWhiteSpace(tb_role.Text) &&
               !string.IsNullOrEmpty(tb_login.Text) && !string.IsNullOrWhiteSpace(tb_login.Text) &&
               !string.IsNullOrEmpty(tb_parol.Text) && !string.IsNullOrWhiteSpace(tb_parol.Text) &&
               !string.IsNullOrEmpty(tb_teleph.Text) && !string.IsNullOrWhiteSpace(tb_teleph.Text) &&
               !string.IsNullOrEmpty(tb_mail.Text) && !string.IsNullOrWhiteSpace(tb_mail.Text))

            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("INSERT INTO [Sotrudnik] (ID_Sotr, FIO, role, login, parol, phone, email) VALUES (@ID_Sotr, @FIO, @role, @login, @parol, @phone, @email)", connection))

                    {
                        cmd.Parameters.AddWithValue("ID_Sotr", tb_ID_Sotr.Text);
                        cmd.Parameters.AddWithValue("FIO", tb_FIO.Text);
                        cmd.Parameters.AddWithValue("role", tb_role.Text);
                        cmd.Parameters.AddWithValue("login", tb_login.Text);
                        cmd.Parameters.AddWithValue("parol", tb_parol.Text);
                        cmd.Parameters.AddWithValue("phone", tb_teleph.Text);
                        cmd.Parameters.AddWithValue("email", tb_mail.Text);

                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    tb_ID_Sotr.Clear();
                    tb_FIO.Clear();
                    tb_role.Clear();
                    tb_login.Clear();
                    tb_parol.Clear();
                    tb_teleph.Clear();
                    tb_mail.Clear();

                    FillDataGridViev();
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!!!", "Предупреждение");
            }
            
        }
    }
}
    

