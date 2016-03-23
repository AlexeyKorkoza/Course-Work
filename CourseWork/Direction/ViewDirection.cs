using System;
using System.Windows.Forms;
using CourseWork.Data;
using CourseWork.Service;

namespace CourseWork.Direction
{
    public partial class ViewDirection : Form
    {
        IStorage storage = new Storage();
        public ViewDirection()
        {
            InitializeComponent();
            View();
        }

        private void AddDirection_Click(object sender, EventArgs e)
        {
            var add = new AddDirection();
            add.Show();
        }

        private void View()
        {
            try
            {
                var direction = storage.GetDirections();
                if (direction.Count > 0)
                {
                    for (var i = 0; i < direction.Count; i++)
                    {
                        datagridViewDirections.Rows.Add();
                        var massive = direction[i].Id.Split('/');
                        datagridViewDirections.Rows[i].Cells[0].Value = massive[1];
                        datagridViewDirections.Rows[i].Cells[1].Value = direction[i].NameOfDirection;
                        datagridViewDirections.Rows[i].Cells[2].Value = direction[i].Description;
                        datagridViewDirections.Rows[i].Cells[3].Value = direction[i].Services[0].NameService;
                        datagridViewDirections.Rows[i].Cells[4].Value = direction[i].Services[0].Duration;
                        datagridViewDirections.Rows[i].Cells[5].Value = direction[i].Services[0].Cost;
                    }
                }
                else
                {
                    MessageBox.Show(@"Список направлений пуст");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            datagridViewDirections.Rows.Clear();
            View();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var add = new AddService();
            add.Show();
        }
        private void DeleteService_Click(object sender, EventArgs e)
        {
            try
            {
                var index = datagridViewDirections.CurrentRow.Index;
                if (index > -1)
                {
                    var result = MessageBox.Show(@"Вы уверены", @"Да", MessageBoxButtons.OKCancel);
                    switch (result)
                    {
                        case DialogResult.OK:
                        {
                            if (datagridViewDirections.CurrentRow != null)
                            {
                                var id = (int) datagridViewDirections.Rows[index].Cells[0].Value;
                                storage.DeleteDirection(id);
                            }
                            MessageBox.Show(@"Услуга успешна удалена!");
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
                else
                {
                    MessageBox.Show(@"Выберите направления для удаления");
                }
            }
            catch
            {
                MessageBox.Show(@"Выберите строку для удаления");
            }
        }

        private void datagridViewDirections_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var edit = new EditDirection();
            edit.Show();
        }

        private void DeleteDirection_Click(object sender, EventArgs e)
        {
            var del = new DeleteDirection();
            del.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            var search = new SearchDirection();
            search.Show();
        }
    }
}
