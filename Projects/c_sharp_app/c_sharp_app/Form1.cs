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
    public partial class login_Form : Form
    {
        public login_Form()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                string my_connection = "datasource=localhost;port=3306;username=root;password=Hig5udMz";
                MySqlConnection my_Conn = new MySqlConnection(my_connection);

                MySqlCommand SelectCommand = new MySqlCommand("select * from test.userinfo where userName='" + this.username_txt.Text + "' and password='" + this.password_txt.Text + "' ;", my_Conn);
                MySqlDataReader my_reader;
                
                my_Conn.Open();
                my_reader = SelectCommand.ExecuteReader();
                int count = 0;

                while (my_reader.Read())
                {
                    count++;
                }

                if (count == 1)
                {
                    MessageBox.Show("Username and password is correct, Wellcome");
                    this.Hide();
                    Form2 form = new Form2();
                    form.ShowDialog();
                }

                else if (count > 1)
                {
                    MessageBox.Show("access denied");
                }
                else
                {
                    username_txt.Clear();
                    password_txt.Clear();
                    MessageBox.Show("Username or password is not correct");
                }
             
                my_Conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        
    }
}
