using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWork.Data;
using CourseWork.Properties;

namespace CourseWork.Service
{
    public partial class ViewService : Form
    {
        readonly IStorage _storage = new Storage();
        readonly Random _random = new Random();
        List<Data.Models.Direction> _list = new List<Data.Models.Direction>();
        List<Data.Models.Direction> _services = new List<Data.Models.Direction>();
        private OpenFileDialog _open;
        public ViewService()
        {
            InitializeComponent();
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
                var result = MessageBox.Show(@"Вы уверены", @"", MessageBoxButtons.OKCancel);
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            if (datagridViewServices.CurrentRow != null)
                            {
                                var index = datagridViewServices.CurrentRow.Index;
                                var idService = (string)datagridViewServices.Rows[index].Cells[0].Value;
                                var idDirection = 0;
                                foreach (var t in _services)
                                {
                                    if (t.NameOfDirection == (string)datagridViewServices.Rows[index].Cells[1].Value)
                                    {
                                        var massive = t.Id.Split('/');
                                        idDirection = Convert.ToInt32(massive[1]);
                                    }
                                }
                                _storage.DeleteService(idDirection, Convert.ToInt32(idService));
                                MessageBox.Show(@"Данные успешно удалены!");
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            datagridViewServices.Rows.Clear();
            View();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            var search = new SearchService();
            search.Show();
        }

        private void View()
        {
            try
            {
                datagridViewServices.Rows.Clear();
                _services = _storage.GetDirections();
                if (_services.Count > 0)
                {
                    foreach (var t in _services)
                    {
                        for (var k = 0; k < t.Services.Count; k++)
                        {
                            datagridViewServices.Rows.Add();
                            datagridViewServices.Rows[k].Cells[0].Value = Convert.ToInt32(t.Services[k].Id);
                            datagridViewServices.Rows[k].Cells[1].Value = t.NameOfDirection;
                            datagridViewServices.Rows[k].Cells[2].Value = t.Services[k].NameService;
                            datagridViewServices.Rows[k].Cells[3].Value = t.Services[k].Duration;
                            datagridViewServices.Rows[k].Cells[4].Value = t.Services[k].Cost;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(@"Список услуг пуст");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void datagridViewServices_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (datagridViewServices.CurrentRow == null) return;
            var index = datagridViewServices.CurrentRow.Index;
            var id = (string)datagridViewServices.Rows[index].Cells[0].Value;
            var directionName = (string)datagridViewServices.Rows[index].Cells[1].Value;
            var nameService = (string)datagridViewServices.Rows[index].Cells[2].Value;
            var edit = new EditService(id, directionName, nameService);
            edit.Show();
        }

        private void FileExtension_Click(object sender, EventArgs e)
        {
            try
            {
                var file = new FileExtension.FileExtension();
                _open = new OpenFileDialog { Filter = Resources.ViewService_FileExtension_Click____csv____txt____csv___txt };
                _open.ShowDialog();
                var currentservices = _storage.GetDirections();
                if (_open.FileName == "") return;
                if (_open.ShowDialog() != DialogResult.OK) return;
                _list = file.LoadingServices(_open.FileName);
                var array = _open.FileName.Split('.');
                if (array[1] == "csv" || array[1] == "txt")
                {
                    foreach (var t in currentservices)
                    {
                        for (var k = 0; k < _list.Count; k++)
                        {
                            if (t.NameOfDirection != _list[k].NameOfDirection) continue;
                            var value = _random.Next(1, 500);
                            for (var i = 0; i < t.Services.Count; i++)
                            {
                                if (value != Convert.ToInt32(t.Services[i].Id)) continue;
                                value = 0;
                                i--;
                            }
                            var service = new Data.Models.Service
                            {
                                NameService = _list[k].Services[0].NameService,
                                Id = value.ToString(),
                                Cost = Convert.ToInt32(_list[k].Services[0].Cost),
                                Duration = Convert.ToInt32(_list[k].Services[0].Duration)
                            };
                            var massive = t.Id.Split('/');
                            _storage.AddService(service, Convert.ToInt32(massive[1]));
                        }
                    }
                }
                if (array[1] == "json")
                {
                    foreach (var t in currentservices)
                    {
                        for (var k = 0; k < _list.Count; k++)
                        {
                            if (t.NameOfDirection != _list[k].NameOfDirection) continue;
                            for (var j = 0; j < _list[k].Services.Count; j++)
                            {
                                var value = _random.Next(1, 500);
                                for (var i = 0; i < t.Services.Count; i++)
                                {
                                    if (value != Convert.ToInt32(t.Services[i].Id)) continue;
                                    value = 0;
                                    i--;
                                }
                                var service = new Data.Models.Service
                                {
                                    NameService = _list[k].Services[j].NameService,
                                    Id = value.ToString(),
                                    Cost = Convert.ToInt32(_list[k].Services[j].Cost),
                                    Duration = Convert.ToInt32(_list[k].Services[j].Duration)
                                };
                                var massive = t.Id.Split('/');
                                _storage.AddService(service, Convert.ToInt32(massive[1]));
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
