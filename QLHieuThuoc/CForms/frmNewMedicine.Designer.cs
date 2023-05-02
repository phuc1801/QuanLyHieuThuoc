namespace QLHieuThuoc
{
    partial class frmNewMedicine
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ibtnsearchf3 = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ibtnbin = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xem Thuốc";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 367);
            this.dataGridView1.TabIndex = 1;
            // 
            // ibtnsearchf3
            // 
            this.ibtnsearchf3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ibtnsearchf3.FlatAppearance.BorderSize = 0;
            this.ibtnsearchf3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnsearchf3.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ibtnsearchf3.IconColor = System.Drawing.Color.LightBlue;
            this.ibtnsearchf3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnsearchf3.IconSize = 30;
            this.ibtnsearchf3.Location = new System.Drawing.Point(427, 18);
            this.ibtnsearchf3.Name = "ibtnsearchf3";
            this.ibtnsearchf3.Size = new System.Drawing.Size(97, 37);
            this.ibtnsearchf3.TabIndex = 2;
            this.ibtnsearchf3.Text = "Search";
            this.ibtnsearchf3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnsearchf3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(545, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 29);
            this.textBox1.TabIndex = 3;
            // 
            // ibtnbin
            // 
            this.ibtnbin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ibtnbin.FlatAppearance.BorderSize = 0;
            this.ibtnbin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnbin.ForeColor = System.Drawing.Color.White;
            this.ibtnbin.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnbin.IconColor = System.Drawing.Color.LightBlue;
            this.ibtnbin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnbin.IconSize = 30;
            this.ibtnbin.Location = new System.Drawing.Point(674, 544);
            this.ibtnbin.Name = "ibtnbin";
            this.ibtnbin.Size = new System.Drawing.Size(101, 37);
            this.ibtnbin.TabIndex = 9;
            this.ibtnbin.Text = "Xóa";
            this.ibtnbin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnbin.UseVisualStyleBackColor = false;
            // 
            // frmNewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 617);
            this.Controls.Add(this.ibtnbin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ibtnsearchf3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmNewMedicine";
            this.Text = "frmNewMedicine";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton ibtnsearchf3;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton ibtnbin;
    }
}