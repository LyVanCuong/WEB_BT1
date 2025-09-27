using System;
using System.Windows.Forms;
using maytinhdongian; // DLL bạn đã tạo

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TextBox txtA;
        TextBox txtB;
        ComboBox cboOp;
        Button btnCalc;
        Label lblKQ;

        public Form1()
        {
            // Cấu hình form
            this.Text = "Máy tính WinForm Code";
            this.Width = 300;
            this.Height = 200;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Ô nhập số A
            txtA = new TextBox();
            txtA.Left = 20; txtA.Top = 20; txtA.Width = 80;
            this.Controls.Add(txtA);

            // Ô nhập số B
            txtB = new TextBox();
            txtB.Left = 150; txtB.Top = 20; txtB.Width = 80;
            this.Controls.Add(txtB);

            // Combo phép tính
            cboOp = new ComboBox();
            cboOp.Left = 110; cboOp.Top = 20; cboOp.Width = 30;
            cboOp.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cboOp.SelectedIndex = 0;
            this.Controls.Add(cboOp);

            // Nút tính
            btnCalc = new Button();
            btnCalc.Text = "Tính";
            btnCalc.Left = 20; btnCalc.Top = 60; btnCalc.Width = 210;
            btnCalc.Click += new EventHandler(btnCalc_Click);
            this.Controls.Add(btnCalc);

            // Label kết quả
            lblKQ = new Label();
            lblKQ.Left = 20; lblKQ.Top = 100; lblKQ.Width = 210;
            lblKQ.Text = "Kết quả:";
            this.Controls.Add(lblKQ);
        }

        void btnCalc_Click(object sender, EventArgs e)
        {
            double a, b;
            if (!double.TryParse(txtA.Text, out a) || !double.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Nhập số hợp lệ");
                return;
            }

            maytinh calc = new maytinh();
            calc.A = a;
            calc.B = b;
            calc.Operation = cboOp.Text;

            try
            {
                double kq = calc.Compute();
                lblKQ.Text = "Kết quả: " + kq;
            }
            catch (Exception ex)
            {
                lblKQ.Text = "Lỗi: " + ex.Message;
            }
        }
    }
}
