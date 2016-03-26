using System;
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
            /*BUG*/
            if (Functions.Text == (string)Functions.Items[0])
            {
                var direction = _storage.GetDirectionsDirectionName(SearchStr.Text);
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
            else
            {
                var direction = _storage.GetDirectionsDirectionName(SearchStr.Text);
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
