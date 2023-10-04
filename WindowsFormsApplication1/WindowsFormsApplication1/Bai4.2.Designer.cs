namespace WindowsFormsApplication1
{
    partial class frm4_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbb_DanToc = new System.Windows.Forms.ComboBox();
            this.lbDanToc = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lb_KQ = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbb_DanToc
            // 
            this.cbb_DanToc.FormattingEnabled = true;
            this.cbb_DanToc.Location = new System.Drawing.Point(103, 113);
            this.cbb_DanToc.Name = "cbb_DanToc";
            this.cbb_DanToc.Size = new System.Drawing.Size(144, 21);
            this.cbb_DanToc.TabIndex = 0;
            this.cbb_DanToc.SelectedIndexChanged += new System.EventHandler(this.cbb_DanToc_SelectedIndexChanged);
            // 
            // lbDanToc
            // 
            this.lbDanToc.AutoSize = true;
            this.lbDanToc.Location = new System.Drawing.Point(30, 113);
            this.lbDanToc.Name = "lbDanToc";
            this.lbDanToc.Size = new System.Drawing.Size(49, 13);
            this.lbDanToc.TabIndex = 1;
            this.lbDanToc.Text = "Dân Tộc";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(81, 164);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(128, 24);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Hiển Thị";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lb_KQ
            // 
            this.lb_KQ.AutoSize = true;
            this.lb_KQ.Location = new System.Drawing.Point(139, 220);
            this.lb_KQ.Name = "lb_KQ";
            this.lb_KQ.Size = new System.Drawing.Size(0, 13);
            this.lb_KQ.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(43, 44);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(140, 34);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load dữ liệu Combobox";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frm4_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lb_KQ);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lbDanToc);
            this.Controls.Add(this.cbb_DanToc);
            this.Name = "frm4_2";
            this.Text = "Bai4";
            this.Load += new System.EventHandler(this.frm4_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_DanToc;
        private System.Windows.Forms.Label lbDanToc;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lb_KQ;
        private System.Windows.Forms.Button btnLoad;
    }
}