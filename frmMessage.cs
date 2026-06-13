using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_Screen
{
    public partial class frmMessage : Form
    {
        public frmMessage(string Message, int Timer = 2000)
        {
            InitializeComponent();
            lblMessage.Text = Message;
            timMessage.Interval = Timer;
        }

        private void frmMessage_Load(object sender, EventArgs e)
        {
            lblMessage.Location = new Point((this.ClientSize.Width - lblMessage.Width) / 2, 80);
        }

        private void timMessage_Tick_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
