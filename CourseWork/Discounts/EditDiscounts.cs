using System;
using System.Windows.Forms;

namespace CourseWork.Discounts
{
    public partial class EditDiscounts : Form
    {
        private readonly IDiscount _discount = new Discounts();
        public EditDiscounts(int code, int size)
        {
            InitializeComponent();
            changeCode.Checked = false;
            textBox2.Enabled = false;
            textBox1.Text = code.ToString();
            textBox3.Text = size.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length == 0)
                {
                    MessageBox.Show(@"Введите код скидки");
                    return;
                }
                if (textBox3.Text.Length == 0)
                {
                    MessageBox.Show(@"Введите размер скидки");
                    return;
                }
                if (changeCode.Checked)
                {
                    if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show(@"Введите новый код скидки");
                        return;
                    }
                    if (!_discount.Check(Convert.ToInt32(textBox2.Text)))
                    {
                        MessageBox.Show(@"Данная скидка уже имеется");
                        return;
                    }
                }
                _discount.Update(textBox2.Text,Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox3.Text));
                MessageBox.Show(@"Скидка была успешно обновлена");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void changeCode_CheckedChanged(object sender, EventArgs e)
        {
            if (changeCode.Checked)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }
        }
    }
}
