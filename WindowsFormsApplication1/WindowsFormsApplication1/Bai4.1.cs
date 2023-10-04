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
    public partial class frm4_1 : Form
    {
        public frm4_1()
        {
            InitializeComponent();

            List<string> lst = new List<string>();
        }
        private void frm4_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lst_Left.Items.Add(txtInput.Text);
            txtInput.Clear();
        }
        private void btnRight_Click(object sender, EventArgs e)
        {

                lst_Right.Items.Add(lst_Left.SelectedItem);

                lst_Left.Items.Remove(lst_Left.SelectedItem);
        }

        private void btnRightAll_Click(object sender, EventArgs e)
        {
                lst_Right.Items.AddRange(lst_Left.Items);

                lst_Left.Items.Clear();

        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
                lst_Left.Items.Add(lst_Right.SelectedItem);

                lst_Right.Items.Remove(lst_Right.SelectedItem);
        }

        private void btnLeftAll_Click(object sender, EventArgs e)
        {
                lst_Left.Items.AddRange(lst_Right.Items);

                lst_Right.Items.Clear();
        }

        private void frm4_1_Load(object sender, EventArgs e)
        {

        }



        public ListViewItem lst { get; set; }




    }
}
