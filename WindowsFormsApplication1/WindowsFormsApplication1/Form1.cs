using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }
        private void frm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }
    }
}
