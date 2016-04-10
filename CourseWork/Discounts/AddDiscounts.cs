using System;
using System.Windows.Forms;

namespace CourseWork.Discounts
{
    public partial class AddDiscounts : Form
    {
        private readonly IDiscount _discount = new Discounts();
        public AddDiscounts()
        {
            InitializeComponent();
            textBox1.MaxLength = 8;
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
                if (textBox2.Text.Length == 0)
                {
                    MessageBox.Show(@"Введите размер скидки");
                    return;
                }
                if (!_discount.Check(Convert.ToInt32(textBox1.Text)))
                {
                    MessageBox.Show(@"Данная скидка уже имеется");
                    return;
                }
                _discount.Add(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
                MessageBox.Show(@"Новая скидка была успешно добавлена");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
     }
}
