﻿using System;
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
    public partial class frm4_2 : Form
    {
        public frm4_2()
        {
            InitializeComponent();
        }

        private void frm4_2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cbb_DanToc.Items.Clear();
            string[] dt = { "Kinh", "Hoa", "K'Me", "H'Mong", "Khac" };
            foreach (string s in dt)
            {
                cbb_DanToc.Items.Add(s);
            }
        }

        private void frm4_2_Load(object sender, EventArgs e)
        {

        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            string s = "Dân tộc được chọn: ";
            if (cbb_DanToc.SelectedIndex >= 0)
                lb_KQ.Text = s + cbb_DanToc.SelectedItem.ToString();
            else
                lb_KQ.Text = "Bạn chưa chọn dân tộc";
        }

        private void cbb_DanToc_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Dân tộc được chọn: " + cbb_DanToc.SelectedItem.ToString());
        }




    }
}
