using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;



namespace MetroUI
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            Thread t = new Thread(new ThreadStart(loading));
            t.Start();

            Thread.Sleep(10000); // 5s
            t.Abort();

            InitializeComponent();

        }


        void loading()
        {
            frmSplashScreen frm = new frmSplashScreen();
            Application.Run(frm);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] ports = { "Click me", "No", "yes" }; // SerialPort.GetPortNames();
            metroComboBox1.Items.AddRange(ports);
            metroComboBox1.SelectedIndex = 0;
            btnClose.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = false;
            btnClose.Enabled = true;

            try
            {
                serialPort1.PortName = metroComboBox1.Text;
                serialPort1.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {


            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine(txtMessege.Text + Environment.NewLine);
                    txtMessege.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = false;

            try
            {

                serialPort1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecieve_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    txtRecieve.Text = serialPort1.ReadExisting();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }
    }
}