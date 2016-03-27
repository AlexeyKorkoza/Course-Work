using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork.Service
{
    public partial class SearchService : Form
    {
        IStorage _storage = new Storage();
        public SearchService()
        {
            InitializeComponent();
            Functions.DropDownStyle = ComboBoxStyle.DropDownList;
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
                var services = _storage.GetDirections();
                const string pattern = "[0-9]{1,}";
                var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                if (Functions.Text == (string) Functions.Items[0])
                {
                    var match = regex.Match(SearchStr.Text);
                    if (!match.Success)
                    {
                        MessageBox.Show(@"ID должен состоять только из цифр");
                        return;
                    }
                    var k = 0;
                    foreach (var t in services)
                    {
                        var massive = t.Id.Split('/');
                        if (massive[1] == SearchStr.Text)
                        {
                            datagridViewServices.Rows.Add();
                            datagridViewServices.Rows[k].Cells[0].Value = massive[1];
                            datagridViewServices.Rows[k].Cells[1].Value = t.NameOfDirection;
                            datagridViewServices.Rows[k].Cells[2].Value = t.Services[0].NameService;
                            datagridViewServices.Rows[k].Cells[3].Value = t.Services[0].Duration;
                            datagridViewServices.Rows[k].Cells[4].Value = t.Services[0].Cost;
                            k++;
                        }
                    }
                }
                if (Functions.Text == (string)Functions.Items[1])
                {
                    var k = 0;
                    foreach (var t in services)
                    {
                        var massive = t.Id.Split('/');
                        if (massive[1] == SearchStr.Text)
                        {
                            datagridViewServices.Rows.Add();
                            datagridViewServices.Rows[k].Cells[0].Value = massive[1];
                            datagridViewServices.Rows[k].Cells[1].Value = t.NameOfDirection;
                            datagridViewServices.Rows[k].Cells[2].Value = t.Services[0].NameService;
                            datagridViewServices.Rows[k].Cells[3].Value = t.Services[0].Duration;
                            datagridViewServices.Rows[k].Cells[4].Value = t.Services[0].Cost;
                            k++;
                        }
                    }
                }
                if (Functions.Text == (string)Functions.Items[2])
                {
                    var match = regex.Match(SearchStr.Text);
                    if (!match.Success)
                    {
                        MessageBox.Show(@"Продолжительность указывается в виде числового значения");
                        return;
                    }
                    var k = 0;
                    foreach (var t in services)
                    {
                        var massive = t.Id.Split('/');
                        if (t.Services[0].Duration == Convert.ToInt32(SearchStr.Text))
                        {
                            datagridViewServices.Rows.Add();
                            datagridViewServices.Rows[k].Cells[0].Value = massive[1];
                            datagridViewServices.Rows[k].Cells[1].Value = t.NameOfDirection;
                            datagridViewServices.Rows[k].Cells[2].Value = t.Services[0].NameService;
                            datagridViewServices.Rows[k].Cells[3].Value = t.Services[0].Duration;
                            datagridViewServices.Rows[k].Cells[4].Value = t.Services[0].Cost;
                            k++;
                        }
                    }
                }
                if (Functions.Text == (string)Functions.Items[3])
                {
                    var match = regex.Match(SearchStr.Text);
                    if (!match.Success)
                    {
                        MessageBox.Show(@"Цена указывается числовым значением");
                        return;
                    }
                    var k = 0;
                    foreach (var t in services)
                    {
                        var massive = t.Id.Split('/');
                        if (t.Services[0].Cost == Convert.ToInt32(SearchStr.Text))
                        {
                            datagridViewServices.Rows.Add();
                            datagridViewServices.Rows[k].Cells[0].Value = massive[1];
                            datagridViewServices.Rows[k].Cells[1].Value = t.NameOfDirection;
                            datagridViewServices.Rows[k].Cells[2].Value = t.Services[0].NameService;
                            datagridViewServices.Rows[k].Cells[3].Value = t.Services[0].Duration;
                            datagridViewServices.Rows[k].Cells[4].Value = t.Services[0].Cost;
                            k++;
                        }
                    }
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
            var id = "directions/" + (string)datagridViewServices.Rows[index].Cells[0].Value;
            var directionName = (string)datagridViewServices.Rows[index].Cells[1].Value;
            var nameService = (string)datagridViewServices.Rows[index].Cells[2].Value;
            var edit = new EditService(id,directionName,nameService);
            edit.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
