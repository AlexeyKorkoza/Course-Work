using System;
using System.Windows.Forms;
using CourseWork.Properties;

namespace CourseWork.Discounts
{
    public partial class ViewDiscounts : Form
    {
        private readonly IDiscount _discount = new Discounts();
        private OpenFileDialog _open;
        public ViewDiscounts()
        {
            InitializeComponent();
            Delete.Enabled = false;
            View();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void View()
        {
            try
            {
                var list = _discount.ReadDiscountses();
                if (list.Count > 0)
                {
                    Delete.Enabled = true;
                    for (var k = 0; k < list.Count; k++)
                    {
                        dataGridViewDiscounts.Rows.Add();
                        dataGridViewDiscounts.Rows[k].Cells[0].Value = list[k].Code;
                        dataGridViewDiscounts.Rows[k].Cells[1].Value = list[k].Size;
                    }
                }
                else
                {
                    Delete.Enabled = false;
                    MessageBox.Show(@"Список скидок пустой!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataGridViewDiscounts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridViewDiscounts.CurrentRow == null) return;
            var index = dataGridViewDiscounts.CurrentRow.Index;
            var code = (int)dataGridViewDiscounts.Rows[index].Cells[0].Value;
            var size = (int)dataGridViewDiscounts.Rows[index].Cells[1].Value;
            var edit = new EditDiscounts(code,size);
            edit.Show();
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

        private void Add_Click(object sender, EventArgs e)
        {
            var add = new AddDiscounts();
            add.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            var search = new SearchDiscounts();
            search.Show();
        }

        private void AddFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                var file = new FileExtension.FileExtension();
                _open = new OpenFileDialog
                {
                    Filter = Resources.ViewService_FileExtension_Click____csv____txt____csv___txt
                };
                _open.ShowDialog();
                if (_open.FileName == "") return;
                if (_open.ShowDialog() != DialogResult.OK) return;
                var list = file.LoadingDiscountses(_open.FileName);
                _discount.Write(list);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            dataGridViewDiscounts.Rows.Clear();
            View();
        }
    }
}
