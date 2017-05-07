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

namespace RegApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void regNr_txt_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                string my_con = " datasource = localhost; port = 3306; username = root; password = Hig5udMz ";
                string query = "select * from test.reg where RegNr = '"+this.regNr_txt.Text+"'";
                MySqlConnection conDatabase = new MySqlConnection(my_con);
                MySqlCommand sqlCommand = new MySqlCommand(query, conDatabase);
                MySqlDataReader myReader;


                try
                {
                    conDatabase.Open();
                    myReader = sqlCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        clientID_txt.Text = "Client id: " + myReader.GetString("ClientID");
                        tel_txt.Text = "Tel: " + myReader.GetString("ClientNR");
                        date_txt.Text = "Datum: " + myReader.GetString("DateOfReg");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void regNr_txt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

                    

        
    }
}
