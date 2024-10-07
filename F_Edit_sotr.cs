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
    public partial class F_Edit_sotr : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public F_Edit_sotr()
        {
            InitializeComponent();
        }
        public string get_cs()
        {
            return "Data Source=WIN-EI6FSTSMJHV;Initial Catalog=AIS_Org_teh;Integrated Security=True";
        }

        private void b_red_Click(object sender, EventArgs e)
        {
            F_Sotr_adm f1 = (F_Sotr_adm)this.Owner;

            int id = 0;
            //считывает выбранную строчку
            id = Convert.ToInt32(f1.dGV_Sotr.Rows[f1.dGV_Sotr.SelectedCells[0].RowIndex].Cells[0].Value);
            f1.Pass_ID_Sotr = tb_ID_Sotr.Text;
            f1.Pass_Fio = tb_FIO.Text;
            f1.Pass_Role = tb_role.Text;
            f1.Pass_Login = tb_login.Text;
            f1.Pass_Parol = tb_parol.Text;
            f1.Pass_Phone = tb_teleph.Text;
            f1.Pass_Email = tb_mail.Text;
            f1.Show();
            this.Close();
            MessageBox.Show("Вы точно хотите изменить данные таблицы Сотрудники?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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

                    using (var cmd = new SqlCommand("UPDATE [Sotrudnik] SET [ID_Sotr]=@ID_Sotr, [FIO]=@FIO, [role]=@role, [login]=@login, [parol]=@parol, [phone]=@phone, [email]=@email WHERE ID_Sotr = @ID_Sotr ", connection))

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
                    FillDataGridViev();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля.", "Ошибка");
            }
            if (tb_ID_Sotr.Text != null)
            {
                tb_ID_Sotr.Clear();
            }
            if (tb_FIO.Text != null)
            {
                tb_FIO.Clear();
            }
            if (tb_role.Text != null)
            {
                tb_role.Clear();
            }

            if (tb_login.Text != null)
            {
                tb_login.Clear();
            }
            if (tb_parol.Text != null)
            {
                tb_parol.Clear();
            }
            if (tb_teleph.Text != null)
            {
                tb_teleph.Clear();
            }
            if (tb_mail.Text != null)
            {
                tb_mail.Clear();
            }
        }
        private void FillDataGridViev()
        {
            F_Sotr_adm formedit = (F_Sotr_adm)this.Owner;

            connection = new SqlConnection("Data Source=WIN-EI6FSTSMJHV;Initial Catalog=AIS_Org_teh;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("SELECT ID_Sotr, FIO, role, login, parol, phone, email FROM dbo.Sotrudnik", connection);
            table = new DataTable();
            adapter.Fill(table);
            formedit.dGV_Sotr.DataSource = table;
            this.Close();
        }

        private void F_Edit_sotr_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=WIN-EI6FSTSMJHV;Initial Catalog=AIS_Org_teh;Integrated Security=True");
            connection.Open();


            F_Sotr_adm frm = (F_Sotr_adm)Application.OpenForms["F_Sotr_adm"];
            int row = frm.dGV_Sotr.CurrentRow.Index;
            tb_ID_Sotr.Text = Convert.ToString(frm.dGV_Sotr[0, row].Value);
            tb_FIO.Text = Convert.ToString(frm.dGV_Sotr[1, row].Value);
            tb_role.Text = Convert.ToString(frm.dGV_Sotr[2, row].Value);
            tb_login.Text = Convert.ToString(frm.dGV_Sotr[3, row].Value);
            tb_parol.Text = Convert.ToString(frm.dGV_Sotr[4, row].Value);
            tb_teleph.Text = Convert.ToString(frm.dGV_Sotr[5, row].Value);
            tb_mail.Text = Convert.ToString(frm.dGV_Sotr[6, row].Value);
        }
    }
}

