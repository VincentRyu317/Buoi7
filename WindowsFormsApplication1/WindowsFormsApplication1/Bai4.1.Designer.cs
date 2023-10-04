namespace WindowsFormsApplication1
{
    partial class frm4_1
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
            this.btnRight = new System.Windows.Forms.Button();
            this.btnRightAll = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btfLeftAll = new System.Windows.Forms.Button();
            this.lst_Left = new System.Windows.Forms.ListBox();
            this.lst_Right = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(137, 92);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnRightAll
            // 
            this.btnRightAll.Location = new System.Drawing.Point(137, 138);
            this.btnRightAll.Name = "btnRightAll";
            this.btnRightAll.Size = new System.Drawing.Size(75, 23);
            this.btnRightAll.TabIndex = 3;
            this.btnRightAll.Text = ">>";
            this.btnRightAll.UseVisualStyleBackColor = true;
            this.btnRightAll.Click += new System.EventHandler(this.btnRightAll_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(137, 180);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btfLeftAll
            // 
            this.btfLeftAll.Location = new System.Drawing.Point(137, 218);
            this.btfLeftAll.Name = "btnLeftAll";
            this.btfLeftAll.Size = new System.Drawing.Size(75, 23);
            this.btfLeftAll.TabIndex = 5;
            this.btfLeftAll.Text = "<<";
            this.btfLeftAll.UseVisualStyleBackColor = true;
            this.btfLeftAll.Click += new System.EventHandler(this.btnLeftAll_Click);
            // 
            // lst_Left
            // 
            this.lst_Left.FormattingEnabled = true;
            this.lst_Left.Location = new System.Drawing.Point(27, 92);
            this.lst_Left.Name = "lst_Left";
            this.lst_Left.Size = new System.Drawing.Size(89, 147);
            this.lst_Left.TabIndex = 6;
            // 
            // lst_Right
            // 
            this.lst_Right.FormattingEnabled = true;
            this.lst_Right.Location = new System.Drawing.Point(228, 94);
            this.lst_Right.Name = "lst_Right";
            this.lst_Right.Size = new System.Drawing.Size(96, 147);
            this.lst_Right.TabIndex = 7;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(27, 35);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(148, 20);
            this.txtInput.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(228, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frm4_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 280);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lst_Right);
            this.Controls.Add(this.lst_Left);
            this.Controls.Add(this.btfLeftAll);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRightAll);
            this.Controls.Add(this.btnRight);
            this.Name = "frm4_1";
            this.Text = "Bai4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm4_1_FormClosing);
            this.Load += new System.EventHandler(this.frm4_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnRightAll;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btfLeftAll;
        private System.Windows.Forms.ListBox lst_Left;
        private System.Windows.Forms.ListBox lst_Right;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAdd;

    }
}