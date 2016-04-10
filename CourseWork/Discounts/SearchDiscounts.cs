using System;
using System.Windows.Forms;

namespace CourseWork.Discounts
{
    public partial class SearchDiscounts : Form
    {
        private readonly IDiscount _discount = new Discounts();
        public SearchDiscounts()
        {
            InitializeComponent();
            Delete.Enabled = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox1.MaxLength = 8;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show(@"Вы уверены", @"Да", MessageBoxButtons.OKCancel);
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            if (dataGridViewDiscounts.CurrentRow != null)
                            {
                                var index = dataGridViewDiscounts.CurrentRow.Index;
                                var code = (int)dataGridViewDiscounts.Rows[index].Cells[0].Value;
                                _discount.Delete(code);
                            }
                            MessageBox.Show(@"Данные успешно удалены!");
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            break;
                        }
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch
            {
                MessageBox.Show(@"Выберите строку для удаления");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Delete.Enabled = false;
            dataGridViewDiscounts.Rows.Clear();
        }

        private void dataGridViewDiscounts_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (dataGridViewDiscounts.CurrentRow == null) return;
            var index = dataGridViewDiscounts.CurrentRow.Index;
            var code = (int)dataGridViewDiscounts.Rows[index].Cells[0].Value;
            var size = (int)dataGridViewDiscounts.Rows[index].Cells[1].Value;
            var edit = new EditDiscounts(code, size);
            edit.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text.Length == 0)
                {
                    MessageBox.Show(@"Выберите критерий для поиска!");
                    return;
                }
                if (textBox1.Text.Length == 0)
                {
                    MessageBox.Show(@"Заполните строку для поиска!");
                    return;
                }
                var list = _discount.ReadDiscountses();
                if (comboBox1.Text == (string) comboBox1.Items[0])
                {
                    var k = 0;
                    for (var i = 0; i < list.Count; i++)
                    {
                        if (list[i].Code == Convert.ToInt32(textBox1.Text))
                        {
                            Delete.Enabled = true;
                            dataGridViewDiscounts.Rows.Add();
                            dataGridViewDiscounts.Rows[k].Cells[0].Value = list[i].Code;
                            dataGridViewDiscounts.Rows[k].Cells[1].Value = list[i].Size;
                            k++;
                        }
                    }
                    if (k == 0)
                    {
                        MessageBox.Show(@"Ничего не найдено");
                    }
                }
                if (comboBox1.Text == (string)comboBox1.Items[1])
                {
                    var k = 0;
                    for (var i = 0; i < list.Count; i++)
                    {
                        if (list[i].Size == Convert.ToInt32(textBox1.Text))
                        {
                            Delete.Enabled = true;
                            dataGridViewDiscounts.Rows.Add();
                            dataGridViewDiscounts.Rows[k].Cells[0].Value = list[i].Code;
                            dataGridViewDiscounts.Rows[k].Cells[1].Value = list[i].Size;
                            k++;
                        }
                    }
                    if (k == 0)
                    {
                        MessageBox.Show(@"Ничего не найдено");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
