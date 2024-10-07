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
    public partial class F_Vhoda : Form
    {
        public F_Vhoda()
        {
            InitializeComponent();
        }

        private void b_vhod_Click(object sender, EventArgs e)
        {
            string Dolgnost;
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=WIN-EI6FSTSMJHV;Initial Catalog=AIS_Org_teh;Integrated Security=True"))
            {
                sqlcon.Open();

                SqlCommand command = new SqlCommand("SELECT [role] FROM Sotrudnik WHERE login = @Login and parol = @Parol", sqlcon);
                command.Parameters.AddWithValue("@Login", tb_log.Text);
                command.Parameters.AddWithValue("@Parol",
tb_parol.Text);
                Dolgnost = (string)command.ExecuteScalar();
            }

            if (Dolgnost == "Администратор")
            {
                this.Hide();
                F_Teh_adm admf = new F_Teh_adm();
                admf.Show();
            }
            else if (Dolgnost == "Сотрудник" | Dolgnost == "Директор")
            {
                this.Hide();
                F_Teh admf = new F_Teh();
                admf.Show();
            }

            else
            {
                MessageBox.Show("Неверный логин или пароль", "Предупреждение");
            }
        }
    }
    
}
