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
    public partial class profile : Form
    {
        public int ID_main = 0;
        public profile(int ID_m, string mode, int ID)
        {
            InitializeComponent();
            if (mode == "chng")
            {
                name_box.Visible = false;
                manuf_box.Visible = false;
                del_btn.Visible = true;
            }
            else if (mode == "add")
            {
                name_lab.Visible = false;
                manuf_lab.Visible = false;
                del_btn.Visible = false;
                chng_btn.Text = "Добавить";
            }

            get_Boxes("select item_name from items;", name_box);
            get_Boxes("select manuf_name from manufactor;", manuf_box);

            get_Info(ID_m);
            ID_main = ID_m;
        }

        public void get_Boxes (string query, ComboBox box)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        box.Items.Add(rd.GetString(0));
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения" + Environment.NewLine + ex.Message);
            }
        }

        public void get_Info (int ID)
        {
            string query = "select it.item_name as 'Название товара', man.manuf_name as 'Производитель' from manufactor man join items it on man.id_manuf = it.id_manuf WHERE id_item = " + ID.ToString() + ";";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    name_lab.Text = rd.GetString(0);
                    manuf_lab.Text = rd.GetString(1);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных товара" + Environment.NewLine + ex.Message);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }


        public void doAction(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выполнения действия" + Environment.NewLine + ex.Message);
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                doAction("delete from items where id_item = " + ID_main + ";");
                Owner.Show();
                this.Close();
            }
        }

        private void chng_btn_Click(object sender, EventArgs e)
        {
            switch (chng_btn.Text)
            {
                case "Добавить":
                    doAction("insert into items (item_name, id_manuf) values ('"+name_box.Text+"',"+(manuf_box.SelectedIndex+1).ToString()+");");

                    chng_btn.Text = "Изменить";
                    name_lab.Visible = true;
                    manuf_lab.Visible = true;
                    del_btn.Visible = true;

                    name_box.Visible = false;
                    manuf_box.Visible = false;

                    string query = "select max(id_item) from items;";
                    MySqlConnection conn = DBUtils.GetDBConnection();
                    MySqlCommand cmDB = new MySqlCommand(query, conn);
                    try
                    {
                        conn.Open();
                        ID_main = Convert.ToInt32(cmDB.ExecuteScalar());
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавления данных" + Environment.NewLine + ex.Message);
                    }

                    get_Info(ID_main);
                    break;

                case "Изменить":
                    chng_btn.Text = "Сохранить";
                    name_lab.Visible = false; ;
                    manuf_lab.Visible = false;
                    del_btn.Visible = false;

                    name_box.Visible = true;
                    manuf_box.Visible = true;

                    name_lab.Text = name_box.Text;
                    manuf_lab.Text = manuf_box.Text;
                    break;
                case "Сохранить":
                    doAction("update items set item_name='"+name_box.Text+"',id_manuf="+(manuf_box.SelectedIndex+1).ToString()+"where id_item="+ID_main.ToString()+";");
                    chng_btn.Text = "Изменить";
                    name_lab.Visible = true;
                    manuf_lab.Visible = true;
                    del_btn.Visible = true;

                    name_box.Visible = false;
                    manuf_box.Visible = false;
                    break; ;
            }
        }
    }
}
