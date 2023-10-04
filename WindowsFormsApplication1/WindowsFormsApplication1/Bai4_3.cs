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
    public partial class frm4_3 : Form
    {
        public frm4_3()
        {
            InitializeComponent();
        }

        private void frm4_3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void TreeView_Load(object sender, EventArgs e)
        {
            string[] pb = { "Giám đốc", "Tổ chức hành chính", "Kế Hoạch", "Kế Toán" };

            foreach (string s in pb)
            {
                TreeView.Nodes.Add(s);
                cbb_PhongBan.Items.Add(s);
            }
            cbb_PhongBan.SelectedIndex = 0;
        }

        private void btnAdd_PB_Click(object sender, EventArgs e)
        {
            if (kiemtra(txtInput_PhongBan.Text))
            {
                TreeView.Nodes.Add(txtInput_PhongBan.Text);
                cbb_PhongBan.Items.Add(txtInput_PhongBan.Text);
            }
            else
                MessageBox.Show("Phòng ban đã tồn tại!");
            txtInput_PhongBan.Text = "";
            txtInput_PhongBan.Focus();
        }

        private bool kiemtra(string s)
        {
            foreach (TreeView.Text)
            {
                if(string.Compare(TreeView.Text, s) < 0){
                    return true;
                    break;
                }
                    
                else return false;
            }

        }
    }
}
