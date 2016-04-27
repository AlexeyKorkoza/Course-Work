using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWork.Data;
using CourseWork.Properties;

namespace CourseWork.Direction
{
    public partial class ViewDirection : Form
    {
        private List<Data.Models.Direction> _list = new List<Data.Models.Direction>();
        private OpenFileDialog _open;
        readonly IStorage _storage = new Storage();
        private Random _rnd = new Random();
        public ViewDirection()
        {
            InitializeComponent();
            DeleteDirection.Enabled = false;
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
                var direction = _storage.GetDirections();
                if (direction.Count > 0)
                {
                    DeleteDirection.Enabled = true;
                    for (var i = 0; i < direction.Count; i++)
                    {
                        datagridViewDirections.Rows.Add();
                        var massive = direction[i].Id.Split('/');
                        datagridViewDirections.Rows[i].Cells[0].Value = Convert.ToInt32(massive[1]);
                        datagridViewDirections.Rows[i].Cells[1].Value = direction[i].NameOfDirection;
                        datagridViewDirections.Rows[i].Cells[2].Value = direction[i].Description;
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

        private void datagridViewDirections_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var edit = new EditDirection();
            edit.Show();
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
                                var id = datagridViewDirections.Rows[index].Cells[0].Value.ToString();
                                _storage.DeleteDirection(id);
                                MessageBox.Show(@"Данные успешно удалены!");
                            }
                            else
                            {
                                MessageBox.Show(@"Выберите строку для удаления!");
                            }
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
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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

        private void AddDirectionsFromFile_Click(object sender, EventArgs e)
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
                _list = file.LoadingDirections(_open.FileName);
                foreach (var t in _list)
                {
                    var value = _rnd.Next(1, 512);
                    for (var k = 0; k < t.Services.Count; k++)
                    {
                        if (value != Convert.ToInt32(t.Services[k].Id)) continue;
                        value = 0;
                        k--;
                    }
                    var direction = new Data.Models.Direction
                    {
                        Id = "directions/",
                        NameOfDirection = t.NameOfDirection,
                        Description = t.Description,
                        Services = new List<Data.Models.Service>()
                        {
                            new Data.Models.Service()
                            {
                                Id = value.ToString(),
                                NameService = t.Services[0].NameService,
                                Cost = t.Services[0].Cost,
                                Duration = t.Services[0].Duration
                            }
                        }
                    };
                    _storage.AddDirection(direction);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
