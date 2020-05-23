using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_16
{
    public partial class CalculateForm : Form
    {
        public CalculateForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_CheckedChanged(object sender, EventArgs e)
        {
            txtKetqua.Text = checkInt(txtInput1.Text, txtInput2.Text).ToString();
        }

        private double ketQuaCong(double input1,double input2)
        {
            return input1 + input2;
        }
        private double ketQuaTru(double input1, double input2)
        {
            return input1 - input2;
        }
        private double ketQuaNhan(double input1, double input2)
        {
            return input1 * input2;
        }
        private double ketQuaChia(double input1, double input2)
        {
            return input1/input2;
        }

        private double checkInt(string text1, string text2)
        {
            try
            {
                double input1 = double.Parse(txtInput1.Text);
                double input2 = double.Parse(txtInput2.Text);
                if (btnCong.Checked)
                {
                   return ketQuaCong(input1, input2);
                }else if (btnTru.Checked)
                {
                    return ketQuaTru(input1, input2);
                }
                else if (btnNhan.Checked)
                {
                    return ketQuaNhan(input1, input2);
                }
                else
                {
                    return ketQuaChia(input1, input2);
                }
            }
            catch
            {
                string message = "Nhap so nguyen ban nhe!";
                string title = "Error Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    txtInput1.Text = null;
                    txtInput2.Text = null;
                    txtKetqua.Text = null;
                }
            }
            return 0;
        }

        private void btnTru_CheckedChanged(object sender, EventArgs e)
        {
            txtKetqua.Text = checkInt(txtInput1.Text, txtInput2.Text).ToString();
        }

        private void btnNhan_CheckedChanged(object sender, EventArgs e)
        {
            txtKetqua.Text = checkInt(txtInput1.Text, txtInput2.Text).ToString();
        }

        private void btnChia_CheckedChanged(object sender, EventArgs e)
        {
            txtKetqua.Text = checkInt(txtInput1.Text, txtInput2.Text).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CalculateForm_Load(object sender, EventArgs e)
        {

        }

        private void CalculateForm_Enter(object sender, EventArgs e)
        {
            btnTru_CheckedChanged(sender, e);
        }
    }
}
