using System;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork.Service
{
    public partial class ViewService : Form
    {
        IStorage _storage = new Storage();
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
                                    var id = (int) datagridViewServices.Rows[index].Cells[0].Value;
                                    _storage.DeleteService(id);
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
                var services = _storage.GetDirections();
                if (services.Count > 0)
                {
                    for (var i = 0; i < services.Count; i++)
                    {
                        foreach (var t in services[i].Services)
                        {
                            datagridViewServices.Rows.Add();
                            datagridViewServices.Rows[i].Cells[0].Value = t.Id;
                            datagridViewServices.Rows[i].Cells[1].Value = services[i].NameOfDirection;
                            datagridViewServices.Rows[i].Cells[2].Value = t.NameService;
                            datagridViewServices.Rows[i].Cells[3].Value = t.Duration;
                            datagridViewServices.Rows[i].Cells[4].Value = t.Cost;
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
    }
}
