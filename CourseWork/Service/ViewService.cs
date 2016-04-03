using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWork.Data;
using CourseWork.Properties;

namespace CourseWork.Service
{
    public partial class ViewService : Form
    {
        IStorage _storage = new Storage();
        List<Data.Models.Direction> _list = new List<Data.Models.Direction>();
        List<Data.Models.Direction> services = new List<Data.Models.Direction>();
        OpenFileDialog _open;
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
                var result = MessageBox.Show(@"Вы уверены", @"Да", MessageBoxButtons.OKCancel);
                    switch (result)
                    {
                        case DialogResult.OK:
                            {
                                if (datagridViewServices.CurrentRow != null)
                                {
                                    var index = datagridViewServices.CurrentRow.Index;
                                    var idService = (string) datagridViewServices.Rows[index].Cells[0].Value;
                                    var idDirection = 0;
                                    foreach (var t in services)
                                    {
                                        if (t.NameOfDirection == (string) datagridViewServices.Rows[index].Cells[1].Value)
                                        {
                                            var massive = t.Id.Split('/');
                                            idDirection = Convert.ToInt32(massive[1]);
                                        }
                                    }
                                    _storage.DeleteService(idDirection,Convert.ToInt32(idService));
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
            catch(Exception exception)
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
                services = _storage.GetDirections();
                if (services.Count > 0)
                {
                    foreach (var t in services)
                    {
                        for(var k = 0; k < t.Services.Length;k++)
                        {
                            datagridViewServices.Rows.Add();
                            datagridViewServices.Rows[k].Cells[0].Value = t.Services[k].Id;
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
            var edit = new EditService(id,directionName,nameService);
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
                foreach (var t in currentservices)
                {
                    for (var k = 0; k < _list.Count; k++)
                    {
                        if (t.NameOfDirection != _list[k].NameOfDirection) continue;
                        var idService = t.Services.Length + k;
                        if (idService == 0)
                        {
                            idService = 1;
                        }
                        else
                        {
                            idService++;
                        }
                        var service = new Data.Models.Service
                        {
                            NameService = _list[k].Services[0].NameService,
                            Id = idService.ToString(),
                            Cost = Convert.ToInt32(_list[k].Services[0].Cost),
                            Duration = Convert.ToInt32(_list[k].Services[0].Duration)
                        };
                        var massive = t.Id.Split('/');
                        _storage.AddService(service, Convert.ToInt32(massive[1]));
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
