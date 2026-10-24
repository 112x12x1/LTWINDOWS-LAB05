using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab5
{
    public partial class frmXuat : Form
    {
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int SoDong { get; set; }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int SoCot { get; set; }

        private int h = 35;
        private int margin = 5;

        public frmXuat(int dong = 1, int cot = 1)
        {
            InitializeComponent();
            this.SoDong = dong;
            this.SoCot = cot;

            TaoMaTrangButton();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "frmXuat";
            this.Text = "frmXuat";
            this.ResumeLayout(false);
        }

        private void TaoMaTrangButton()
        {
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Button btn = new Button();
                    btn.Width = h;
                    btn.Height = h;
                    btn.Text = (i * SoCot + j + 1).ToString();
                    btn.Left = margin * (j + 1) + h * j;
                    btn.Top = margin * (i + 1) + h * i;
                    
                    btn.Click += new EventHandler(btn_Click);
                    btn.MouseHover += new EventHandler(HoChuotLenButton);
                    btn.Tag = string.Format("Dòng {0} cột {1}", i, j);
                    
                    this.Controls.Add(btn);
                }
            }

            this.ClientSize = new Size(SoCot * (h + margin) + margin, SoDong * (h + margin) + margin);
        }

        private void HoChuotLenButton(object? sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag != null)
            {
                this.Text = btn.Tag.ToString();
            }
        }

        private void btn_Click(object? sender, EventArgs e)
        {
            
        }
    }
}