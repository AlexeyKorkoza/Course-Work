using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork.Direction
{
    public partial class SearchDirection : Form
    {
        IStorage _storage = new Storage();
        public SearchDirection()
        {
            InitializeComponent();
            DeleteDirection.Enabled = false;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (Functions.Text.Length == 0)
                {
                    MessageBox.Show(@"Выберите критерий для поиска!");
                    return;
                }
                if (SearchStr.Text.Length == 0)
                {
                    MessageBox.Show(@"Заполните строку для поиска!");
                    return;
                }
                var direction = _storage.GetDirections();
                if (Functions.Text == (string) Functions.Items[0])
                {
                    const string pattern = "[0-9]{1,}";
                    var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                    var match = regex.Match(SearchStr.Text);
                    if (!match.Success)
                    {
                        MessageBox.Show(@"ID должен состоять только из цифр");
                        return;
                    }
                    for (var i = 0; i < direction.Count; i++)
                    {
                        var massive = direction[i].Id.Split('/');
                        if (massive[1] != SearchStr.Text) continue;
                        datagridViewDirections.Rows.Add();
                        datagridViewDirections.Rows[i].Cells[0].Value = massive[1];
                        datagridViewDirections.Rows[i].Cells[1].Value = direction[i].NameOfDirection;
                        datagridViewDirections.Rows[i].Cells[2].Value = direction[i].Description;
                    }
                }
                if (Functions.Text == (string)Functions.Items[1])
                {
                    for (var i = 0; i < direction.Count; i++)
                    {
                        if (direction[i].NameOfDirection != SearchStr.Text) continue;
                        datagridViewDirections.Rows.Add();
                        var massive = direction[i].Id.Split('/');
                        datagridViewDirections.Rows[i].Cells[0].Value = massive[1];
                        datagridViewDirections.Rows[i].Cells[1].Value = direction[i].NameOfDirection;
                        datagridViewDirections.Rows[i].Cells[2].Value = direction[i].Description;
                    }
                }
                if (Functions.Text == (string) Functions.Items[2])
                {
                    for (var i = 0; i < direction.Count; i++)
                    {
                        if (direction[i].Description != SearchStr.Text) continue;
                        datagridViewDirections.Rows.Add();
                        var massive = direction[i].Id.Split('/');
                        datagridViewDirections.Rows[i].Cells[0].Value = massive[1];
                        datagridViewDirections.Rows[i].Cells[1].Value = direction[i].NameOfDirection;
                        datagridViewDirections.Rows[i].Cells[2].Value = direction[i].Description;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void DeleteDirection_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show(@"Вы уверены", @"Да", MessageBoxButtons.OKCancel);
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            if (datagridViewDirections.CurrentRow != null)
                            {
                                var index = datagridViewDirections.CurrentRow.Index;
                                var id = (string)datagridViewDirections.Rows[index].Cells[0].Value;
                                _storage.DeleteDirection(id);
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
    }
}
