using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_Screen
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool ShowPassword = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtUserName.Text == "Admin" && txtPassword.Text == "1234")
                {
                    Form frmMessage = new frmMessage("Login Successfully");
                    frmMessage.ShowDialog();
                }

                else
                {
                    Form frmMessage = new frmMessage("The password you entered is incorrect");
                    frmMessage.ShowDialog();
                }

            }

            catch (Exception ex)
            {

                Form frmMessage = new frmMessage(ex.Message);
                frmMessage.ShowDialog();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Image img = Properties.Resources.entrance__1_;
            btnLogin.Image = new Bitmap(img, new Size(24, 24));
        }

        private void pEyeIcon_Click_1(object sender, EventArgs e)
        {
            if (!ShowPassword)
            {
                txtPassword.UseSystemPasswordChar = false;
                pEyeIcon.Image = Properties.Resources.Eye_show;
                ShowPassword = true;
            }

            else
            {
                txtPassword.UseSystemPasswordChar = true;
                pEyeIcon.Image = Properties.Resources.eye_hide;
                ShowPassword = false;
            }
        }
    }
}
