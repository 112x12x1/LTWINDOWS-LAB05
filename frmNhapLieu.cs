using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab5
{
    public partial class frmNhapLieu : Form
    {
        private TextBox txtSoDong = null!;
        private TextBox txtSoCot = null!;
        private Button btnKhoiTao = null!;
        private Label lblSoDong = null!;
        private Label lblSoCot = null!;

        public frmNhapLieu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblSoDong = new Label();
            this.lblSoCot = new Label();
            this.txtSoDong = new TextBox();
            this.txtSoCot = new TextBox();
            this.btnKhoiTao = new Button();
            this.SuspendLayout();

            this.lblSoDong.AutoSize = true;
            this.lblSoDong.Location = new Point(30, 35);
            this.lblSoDong.Name = "lblSoDong";
            this.lblSoDong.Size = new Size(63, 20);
            this.lblSoDong.Text = "Số dòng:";

            this.lblSoCot.AutoSize = true;
            this.lblSoCot.Location = new Point(30, 85);
            this.lblSoCot.Name = "lblSoCot";
            this.lblSoCot.Size = new Size(54, 20);
            this.lblSoCot.Text = "Số cột:";

            this.txtSoDong.Location = new Point(120, 32);
            this.txtSoDong.Name = "txtSoDong";
            this.txtSoDong.Size = new Size(150, 27);
            this.txtSoDong.Text = "1";

            this.txtSoCot.Location = new Point(120, 82);
            this.txtSoCot.Name = "txtSoCot";
            this.txtSoCot.Size = new Size(150, 27);
            this.txtSoCot.Text = "1";

            this.btnKhoiTao.Location = new Point(120, 135);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new Size(150, 35);
            this.btnKhoiTao.Text = "Khởi tạo form";
            this.btnKhoiTao.UseVisualStyleBackColor = true;
            this.btnKhoiTao.Click += new EventHandler(this.btnKhoiTao_Click);

            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(320, 200);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.txtSoCot);
            this.Controls.Add(this.txtSoDong);
            this.Controls.Add(this.lblSoCot);
            this.Controls.Add(this.lblSoDong);
            this.Name = "frmNhapLieu";
            this.Text = "Nhập liệu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnKhoiTao_Click(object? sender, EventArgs e)
        {
            int dong = 0, cot = 0;
            if (int.TryParse(txtSoDong.Text, out dong) && int.TryParse(txtSoCot.Text, out cot))
            {
                if (dong > 0 && cot > 0)
                {
                    frmXuat frm = new frmXuat(dong, cot);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Số dòng và số cột phải lớn hơn 0!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá trị số nguyên hợp lệ!");
            }
        }
    }
}