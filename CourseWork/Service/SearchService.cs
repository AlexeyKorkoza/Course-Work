using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork.Service
{
    public partial class SearchService : Form
    {
        private readonly IStorage _storage = new Storage();
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
                if (Functions.Text == (string)Functions.Items[0])
                {
                    var match = regex.Match(SearchStr.Text);
                    if (!match.Success)
                    {
                        MessageBox.Show(@"ID должен состоять только из цифр");
                        return;
                    }
                    var k = 0;
                    for(var j = 0; j < services.Count;j++)
                    {
                        for (var i = 0; i < services[j].Services.Count; i++)
                        {
                            if (services[j].Services[i].Id == SearchStr.Text)
                            {
                                datagridViewServices.Rows.Add();
                                datagridViewServices.Rows[k].Cells[0].Value = services[j].Services[i].Id;
                                datagridViewServices.Rows[k].Cells[1].Value = services[j].NameOfDirection;
                                datagridViewServices.Rows[k].Cells[2].Value = services[j].Services[i].NameService;
                                datagridViewServices.Rows[k].Cells[3].Value = services[j].Services[i].Duration;
                                datagridViewServices.Rows[k].Cells[4].Value = services[j].Services[i].Cost;
                                k++;
                            }
                        }
                    }
                }
                if (Functions.Text == (string)Functions.Items[1])
                {
                    var k = 0;
                    for (var j = 0; j < services.Count; j++)
                    {
                        for (var i = 0; i < services[j].Services.Count; i++)
                        {
                            if (services[j].Services[i].NameService == SearchStr.Text)
                            {
                                datagridViewServices.Rows.Add();
                                datagridViewServices.Rows[k].Cells[0].Value = services[j].Services[i].Id;
                                datagridViewServices.Rows[k].Cells[1].Value = services[j].NameOfDirection;
                                datagridViewServices.Rows[k].Cells[2].Value = services[j].Services[i].NameService;
                                datagridViewServices.Rows[k].Cells[3].Value = services[j].Services[i].Duration;
                                datagridViewServices.Rows[k].Cells[4].Value = services[j].Services[i].Cost;
                                k++;
                            }
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
                    for (var j = 0; j < services.Count; j++)
                    {
                        for (var i = 0; i < services[j].Services.Count; i++)
                        {
                            if (services[j].Services[i].Duration == Convert.ToInt32(SearchStr.Text))
                            {
                                datagridViewServices.Rows.Add();
                                datagridViewServices.Rows[k].Cells[0].Value = services[j].Services[i].Id;
                                datagridViewServices.Rows[k].Cells[1].Value = services[j].NameOfDirection;
                                datagridViewServices.Rows[k].Cells[2].Value = services[j].Services[i].NameService;
                                datagridViewServices.Rows[k].Cells[3].Value = services[j].Services[i].Duration;
                                datagridViewServices.Rows[k].Cells[4].Value = services[j].Services[i].Cost;
                                k++;
                            }
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
                    for (var j = 0; j < services.Count; j++)
                    {
                        for (var i = 0; i < services[j].Services.Count; i++)
                        {
                            if (services[j].Services[i].Cost == Convert.ToInt32(SearchStr.Text))
                            {
                                datagridViewServices.Rows.Add();
                                datagridViewServices.Rows[k].Cells[0].Value = services[j].Services[i].Id;
                                datagridViewServices.Rows[k].Cells[1].Value = services[j].NameOfDirection;
                                datagridViewServices.Rows[k].Cells[2].Value = services[j].Services[i].NameService;
                                datagridViewServices.Rows[k].Cells[3].Value = services[j].Services[i].Duration;
                                datagridViewServices.Rows[k].Cells[4].Value = services[j].Services[i].Cost;
                                k++;
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

        private void datagridViewServices_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (datagridViewServices.CurrentRow == null) return;
            var index = datagridViewServices.CurrentRow.Index;
            var id = "directions/" + (string)datagridViewServices.Rows[index].Cells[0].Value;
            var directionName = (string)datagridViewServices.Rows[index].Cells[1].Value;
            var nameService = (string)datagridViewServices.Rows[index].Cells[2].Value;
            var edit = new EditService(id, directionName, nameService);
            edit.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datagridViewServices.Rows.Clear();
        }
    }
}
