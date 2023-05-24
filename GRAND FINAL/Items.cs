using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GRAND_FINAL
{
    public partial class Main : Form
    {
        public int ID = 0;
        public Main()
        {
            InitializeComponent();
            get_Info("select * from items");
        }

        public void get_Info(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                sda.Fill(dt);
                dgv.DataSource = (dt);
                dgv.ClearSelection();
                dgv.Columns[0].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вывода данных" + Environment.NewLine + ex.Message);
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                profile win = new profile(Convert.ToInt32(dgv[0, dgv.CurrentRow.Index].Value.ToString()), "chng", ID);
                win.Owner = this;
                this.Hide();
                win.Show();
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            profile win = new profile(0, "add", ID);
            win.Owner = this;
            this.Hide();
            win.Show();
        }

        private void ref_btn_Click(object sender, EventArgs e)
        {
            get_Info("select * from items");

        }
    }
}
