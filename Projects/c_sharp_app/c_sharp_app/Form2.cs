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

namespace c_sharp_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            fillCombo();

            timer1.Start();
        }


        void fillCombo()
        {
            string my_connection = "datasource=localhost;port=3306;username=root;password=Hig5udMz";
            string query = "select * from test.userinfo;";

            MySqlConnection con_database = new MySqlConnection(my_connection);
            MySqlCommand cmd_database = new MySqlCommand(query, con_database);

            MySqlDataReader my_reader;

            try
            {
                con_database.Open();
                my_reader = cmd_database.ExecuteReader();

                while (my_reader.Read())
                {
                    string uID = my_reader.GetString("userID");
                    comboBox1.Items.Add(uID);
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {

            string my_connection = "datasource=localhost;port=3306;username=root;password=Hig5udMz";
            string query = "insert into test.userinfo (userID, userName, password, userAge, country) values ('" + this.userID_txt.Text + "','" + this.userName_txt.Text + "','" + this.password_txt.Text + "','" + this.userAge_txt.Text + "','" + this.country_txt.Text +"')";

            MySqlConnection con_database = new MySqlConnection(my_connection);
            MySqlCommand cmd_database = new MySqlCommand(query, con_database);
 
            MySqlDataReader my_reader;

            try
            {
                con_database.Open();
                my_reader = cmd_database.ExecuteReader();
                MessageBox.Show("New user data inserted successfuly");

                comboBox1.Items.Add(this.userID_txt.Text);

                while (my_reader.Read())
                {

                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string my_connection = "datasource=localhost;port=3306;username=root;password=Hig5udMz";
            string query = "delete from test.userinfo where userID='" + this.userID_txt.Text + "';";

            MySqlConnection con_database = new MySqlConnection(my_connection);
            MySqlCommand cmd_database = new MySqlCommand(query, con_database);

            MySqlDataReader my_reader;

            try
            {
                con_database.Open();
                my_reader = cmd_database.ExecuteReader();
                userID_txt.Text = userName_txt.Text = password_txt.Text = userAge_txt.Text = country_txt.Text = comboBox1.Text ="";
                MessageBox.Show("User data is deleted successfuly");

                comboBox1.Items.Clear();
                fillCombo();

                while (my_reader.Read())
                {

                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string my_connection = "datasource=localhost;port=3306;username=root;password=Hig5udMz";
            string query = "select * from test.userinfo where userID='"+comboBox1.Text+"';";

            MySqlConnection con_database = new MySqlConnection(my_connection);
            MySqlCommand cmd_database = new MySqlCommand(query, con_database);

            MySqlDataReader my_reader;

            try
            {
                con_database.Open();
                my_reader = cmd_database.ExecuteReader();

                while (my_reader.Read())
                {
                    string str = my_reader.GetString("userID");
                    userID_txt.Text = str;

                    str = my_reader.GetString("userName");
                    userName_txt.Text = str;
                    password_txt.Text = "*********";

                    str = my_reader.GetString("userAge");
                    userAge_txt.Text = str;

                    str = my_reader.GetString("country");
                    country_txt.Text = str;

                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time_lbl.Text = dateTime.ToString();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
           
        }

        private void loadTable_btn_Click(object sender, EventArgs e)
        {
            string my_connection = "datasource=localhost;port=3306;username=root;password=Hig5udMz";
            string query = "select * from test.userinfo";

            MySqlConnection con_database = new MySqlConnection(my_connection);
            MySqlCommand cmd_database = new MySqlCommand(query, con_database);

          

            try
            {
                MySqlDataAdapter mda = new MySqlDataAdapter();
                mda.SelectCommand = cmd_database;
                DataTable dt = new DataTable();
                mda.Fill(dt);

                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                mda.Update(dt);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string my_connection = "datasource=localhost;port=3306;username=root;password=Hig5udMz";
            string query = "update test.userinfo set userName ='" + this.userName_txt.Text + "',password ='" + this.password_txt.Text + "',userAge = '" + this.userAge_txt.Text + "',country = '" + this.country_txt.Text +"' where userID = '"+this.userID_txt.Text+"'";
            MySqlConnection con_database = new MySqlConnection(my_connection);
            MySqlCommand cmd_database = new MySqlCommand(query, con_database);

            MySqlDataReader my_reader;

            try
            {
                con_database.Open();
                my_reader = cmd_database.ExecuteReader();
                MessageBox.Show("New user data updated successfuly");

         //       comboBox1.Items.Add(this.userID_txt.Text);

                while (my_reader.Read())
                {

                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

      
    }
}
