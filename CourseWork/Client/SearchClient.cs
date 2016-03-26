using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork.Client
{
    public partial class SearchClient : Form
    {
        IStorage _storage = new Storage();
        public SearchClient()
        {
            InitializeComponent();
            Functions.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                var clients = _storage.GetAllClients();
                if (Functions.Text == (string)Functions.Items[0])
                {
                    const string pattern = "[0-9]{1,}";
                    var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                    var match = regex.Match(SearchStr.Text);
                    if (!match.Success)
                    {
                        MessageBox.Show(@"ID должен состоять только из цифр");
                        return;
                    }
                    var k = 0;
                    foreach (var t in clients)
                    {
                        var massive = t.Id.Split('/');
                        if (massive[1] == SearchStr.Text)
                        {
                            datagridViewClients.Rows.Add();
                            datagridViewClients.Rows[k].Cells[0].Value = massive[1];
                            datagridViewClients.Rows[k].Cells[1].Value = t.Lastname;
                            datagridViewClients.Rows[k].Cells[2].Value = t.Name;
                            datagridViewClients.Rows[k].Cells[3].Value = t.MiddleName;
                            datagridViewClients.Rows[k].Cells[5].Value = t.AgeCategory;
                            datagridViewClients.Rows[k].Cells[4].Value = t.Date;
                            datagridViewClients.Rows[k].Cells[6].Value = t.Payment;
                            datagridViewClients.Rows[k].Cells[7].Value = t.Decor;
                            datagridViewClients.Rows[k].Cells[8].Value = t.Directions[0].NameOfDirection;
                            datagridViewClients.Rows[k].Cells[9].Value = t.Services[0].NameService;
                            datagridViewClients.Rows[k].Cells[10].Value = t.Services[0].Duration;
                            datagridViewClients.Rows[k].Cells[11].Value = t.Services[0].Cost;
                            datagridViewClients.Rows[k].Cells[12].Value = t.Visit;
                            datagridViewClients.Rows[k].Cells[13].Value = t.Discounts[0].Code;
                            datagridViewClients.Rows[k].Cells[14].Value = t.Discounts[0].Size;
                            k++;
                        }
                    }
                }
                if (Functions.Text == (string)Functions.Items[1])
                {
                    var k = 0;
                    foreach (var t in clients)
                    {
                        var massive = t.Id.Split('/');
                        if (t.Lastname == SearchStr.Text)
                        {
                            datagridViewClients.Rows.Add();
                            datagridViewClients.Rows[k].Cells[0].Value = massive[1];
                            datagridViewClients.Rows[k].Cells[1].Value = t.Lastname;
                            datagridViewClients.Rows[k].Cells[2].Value = t.Name;
                            datagridViewClients.Rows[k].Cells[3].Value = t.MiddleName;
                            datagridViewClients.Rows[k].Cells[5].Value = t.AgeCategory;
                            datagridViewClients.Rows[k].Cells[4].Value = t.Date;
                            datagridViewClients.Rows[k].Cells[6].Value = t.Payment;
                            datagridViewClients.Rows[k].Cells[7].Value = t.Decor;
                            datagridViewClients.Rows[k].Cells[8].Value = t.Directions[0].NameOfDirection;
                            datagridViewClients.Rows[k].Cells[9].Value = t.Services[0].NameService;
                            datagridViewClients.Rows[k].Cells[10].Value = t.Services[0].Duration;
                            datagridViewClients.Rows[k].Cells[11].Value = t.Services[0].Cost;
                            datagridViewClients.Rows[k].Cells[12].Value = t.Visit;
                            datagridViewClients.Rows[k].Cells[13].Value = t.Discounts[0].Code;
                            datagridViewClients.Rows[k].Cells[14].Value = t.Discounts[0].Size;
                            k++;
                        }
                    }
                }
                if (Functions.Text == (string)Functions.Items[2])
                {
                    var k = 0;
                    foreach (var t in clients)
                    {
                        var massive = t.Id.Split('/');
                        if (t.Name == SearchStr.Text)
                        {
                            datagridViewClients.Rows.Add();
                            datagridViewClients.Rows[k].Cells[0].Value = massive[1];
                            datagridViewClients.Rows[k].Cells[1].Value = t.Lastname;
                            datagridViewClients.Rows[k].Cells[2].Value = t.Name;
                            datagridViewClients.Rows[k].Cells[3].Value = t.MiddleName;
                            datagridViewClients.Rows[k].Cells[5].Value = t.AgeCategory;
                            datagridViewClients.Rows[k].Cells[4].Value = t.Date;
                            datagridViewClients.Rows[k].Cells[6].Value = t.Payment;
                            datagridViewClients.Rows[k].Cells[7].Value = t.Decor;
                            datagridViewClients.Rows[k].Cells[8].Value = t.Directions[0].NameOfDirection;
                            datagridViewClients.Rows[k].Cells[9].Value = t.Services[0].NameService;
                            datagridViewClients.Rows[k].Cells[10].Value = t.Services[0].Duration;
                            datagridViewClients.Rows[k].Cells[11].Value = t.Services[0].Cost;
                            datagridViewClients.Rows[k].Cells[12].Value = t.Visit;
                            datagridViewClients.Rows[k].Cells[13].Value = t.Discounts[0].Code;
                            datagridViewClients.Rows[k].Cells[14].Value = t.Discounts[0].Size;
                            k++;
                        }
                    }
                }
                if (Functions.Text == (string)Functions.Items[3])
                {
                    const string pattern = "[0-9]{1,2}/[0-9]{1,2}/[0-9]{1,4}";
                    var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                    var match = regex.Match(SearchStr.Text);
                    if (!match.Success)
                    {
                        MessageBox.Show(@"Дата некорректная!");
                        return;
                    }
                    var k = 0;
                    foreach (var t in clients)
                    {
                        var massive = t.Id.Split('/');
                        if (t.Date == SearchStr.Text)
                        {
                            datagridViewClients.Rows.Add();
                            datagridViewClients.Rows[k].Cells[0].Value = massive[1];
                            datagridViewClients.Rows[k].Cells[1].Value = t.Lastname;
                            datagridViewClients.Rows[k].Cells[2].Value = t.Name;
                            datagridViewClients.Rows[k].Cells[3].Value = t.MiddleName;
                            datagridViewClients.Rows[k].Cells[5].Value = t.AgeCategory;
                            datagridViewClients.Rows[k].Cells[4].Value = t.Date;
                            datagridViewClients.Rows[k].Cells[6].Value = t.Payment;
                            datagridViewClients.Rows[k].Cells[7].Value = t.Decor;
                            datagridViewClients.Rows[k].Cells[8].Value = t.Directions[0].NameOfDirection;
                            datagridViewClients.Rows[k].Cells[9].Value = t.Services[0].NameService;
                            datagridViewClients.Rows[k].Cells[10].Value = t.Services[0].Duration;
                            datagridViewClients.Rows[k].Cells[11].Value = t.Services[0].Cost;
                            datagridViewClients.Rows[k].Cells[12].Value = t.Visit;
                            datagridViewClients.Rows[k].Cells[13].Value = t.Discounts[0].Code;
                            datagridViewClients.Rows[k].Cells[14].Value = t.Discounts[0].Size;
                            k++;
                        }
                    }
                }
                if (Functions.Text == (string)Functions.Items[4])
                {
                    var k = 0;
                    foreach (var t in clients)
                    {
                        var massive = t.Id.Split('/');
                        if (t.Directions[0].NameOfDirection == SearchStr.Text)
                        {
                            datagridViewClients.Rows.Add();
                            datagridViewClients.Rows[k].Cells[0].Value = massive[1];
                            datagridViewClients.Rows[k].Cells[1].Value = t.Lastname;
                            datagridViewClients.Rows[k].Cells[2].Value = t.Name;
                            datagridViewClients.Rows[k].Cells[3].Value = t.MiddleName;
                            datagridViewClients.Rows[k].Cells[5].Value = t.AgeCategory;
                            datagridViewClients.Rows[k].Cells[4].Value = t.Date;
                            datagridViewClients.Rows[k].Cells[6].Value = t.Payment;
                            datagridViewClients.Rows[k].Cells[7].Value = t.Decor;
                            datagridViewClients.Rows[k].Cells[8].Value = t.Directions[0].NameOfDirection;
                            datagridViewClients.Rows[k].Cells[9].Value = t.Services[0].NameService;
                            datagridViewClients.Rows[k].Cells[10].Value = t.Services[0].Duration;
                            datagridViewClients.Rows[k].Cells[11].Value = t.Services[0].Cost;
                            datagridViewClients.Rows[k].Cells[12].Value = t.Visit;
                            datagridViewClients.Rows[k].Cells[13].Value = t.Discounts[0].Code;
                            datagridViewClients.Rows[k].Cells[14].Value = t.Discounts[0].Size;
                            k++;
                        }
                    }
                }
                if (Functions.Text == (string)Functions.Items[5])
                {
                    var k = 0;
                    foreach (var t in clients)
                    {
                        var massive = t.Id.Split('/');
                        if (t.Services[0].NameService == SearchStr.Text)
                        {
                            datagridViewClients.Rows.Add();
                            datagridViewClients.Rows[k].Cells[0].Value = massive[1];
                            datagridViewClients.Rows[k].Cells[1].Value = t.Lastname;
                            datagridViewClients.Rows[k].Cells[2].Value = t.Name;
                            datagridViewClients.Rows[k].Cells[3].Value = t.MiddleName;
                            datagridViewClients.Rows[k].Cells[5].Value = t.AgeCategory;
                            datagridViewClients.Rows[k].Cells[4].Value = t.Date;
                            datagridViewClients.Rows[k].Cells[6].Value = t.Payment;
                            datagridViewClients.Rows[k].Cells[7].Value = t.Decor;
                            datagridViewClients.Rows[k].Cells[8].Value = t.Directions[0].NameOfDirection;
                            datagridViewClients.Rows[k].Cells[9].Value = t.Services[0].NameService;
                            datagridViewClients.Rows[k].Cells[10].Value = t.Services[0].Duration;
                            datagridViewClients.Rows[k].Cells[11].Value = t.Services[0].Cost;
                            datagridViewClients.Rows[k].Cells[12].Value = t.Visit;
                            datagridViewClients.Rows[k].Cells[13].Value = t.Discounts[0].Code;
                            datagridViewClients.Rows[k].Cells[14].Value = t.Discounts[0].Size;
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

        private void Functions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Functions.Text == (string)Functions.Items[3])
            {
                SearchStr.Text = DateTime.Now.ToString("MM/dd/yyyy");
                SearchStr.Text = SearchStr.Text.Replace('.', '/');
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var massive = monthCalendar1.SelectionStart.ToString(CultureInfo.InvariantCulture).Split(' ');
            SearchStr.Text = massive[0];
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (!monthCalendar1.Visible)
            {
                monthCalendar1.Show();
                monthCalendar1.Visible = true;
            }
            else
            {
                monthCalendar1.Visible = false;
            }
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
                            if (datagridViewClients.CurrentRow != null)
                            {
                                var index = datagridViewClients.CurrentRow.Index;
                                var id = (string)datagridViewClients.Rows[index].Cells[0].Value;
                                _storage.DeleteClient(id);
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

        private void datagridViewClients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (datagridViewClients.CurrentRow == null) return;
            var index = datagridViewClients.CurrentRow.Index;
            var id = (string)datagridViewClients.Rows[index].Cells[0].Value;
            var editClient = new EditClient(id);
            editClient.Show();
        }
    }
}
