using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CourseWork.Data;
using CourseWork.Data.Models;

namespace CourseWork.Client
{
    public partial class AddClient : Form
    {
        private readonly List<ComboBox> _listcombobox;
        private readonly List<TextBox> _textBoxs;
        private readonly List<RichTextBox> _richTextBoxs;
        readonly IStorage _storage = new Storage();
        public AddClient()
        {
            try
            {
                InitializeComponent();
                Date.Text = DateTime.Now.ToString("MM/dd/yyyy");
                Date.Text = Date.Text.Replace('.', '/');
                Date.BackColor = Color.White;
                _textBoxs = new List<TextBox> { Lastname, NameOfClient, Middlename };
                //  Code,Size
                _listcombobox = new List<ComboBox>
                {
                    AgeCategory,
                    DirectionName,
                    NameService,
                    Payment,
                    Decor,
                    Duration,
                    CostService,
                    Visit
                };
                _richTextBoxs = new List<RichTextBox> { DirectionDescription };
                foreach (var t in _listcombobox)
                {
                    t.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                var direction = _storage.GetDirections();
                if (direction.Count > 0)
                {
                    foreach (var t in direction)
                    {
                        if (!DirectionName.Items.Contains(t.NameOfDirection))
                        {
                            DirectionName.Items.Add(t.NameOfDirection);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(@"Добавление клиента невозможно");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var massive = monthCalendar1.SelectionStart.ToString(CultureInfo.InvariantCulture).Split(' ');
            Date.Text = massive[0];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in Client.Controls)
                {
                    if ((!(control is TextBox)) || (control.Text.Trim() != "")) continue;
                    MessageBox.Show(@"Поле должно быть заполнено!");
                    control.BackColor = Color.Yellow;
                    return;
                }
                foreach (var t in _listcombobox)
                {
                    if (t.Text.Length != 0) continue;
                    MessageBox.Show(@"Все поля должны быть заполнены!");
                    break;
                }
                foreach (var t in _textBoxs)
                {
                    const string pattern = "[A-Za-zА-Яа-я]";
                    var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                    var match = regex.Match(t.Text);
                    if (match.Success) continue;
                    MessageBox.Show(@"Некорректное заполнение поля!");
                    break;
                }
                foreach (var t in _richTextBoxs)
                {
                    if (t.TextLength != 0) continue;
                    MessageBox.Show(@"Описание не должно быть пустым!");
                    break;
                }
                var client = new Data.Models.Client()
                   {
                       Id = "clients/",
                       Lastname = Lastname.Text,
                       Name = NameOfClient.Text,
                       MiddleName = Middlename.Text,
                       Date = Date.Text,
                       AgeCategory = AgeCategory.Text,
                       Decor = Decor.Text,
                       Visit = Visit.Text,
                       Payment = Payment.Text,
                       Directions = new List<Data.Models.Direction>()
                        {
                            new Data.Models.Direction()
                            {
                                Id = 0.ToString(),
                                NameOfDirection = DirectionName.Text,
                                Description = DirectionDescription.Text
                            }
                        },
                       Services = new List<Data.Models.Service>()
                        {
                            new Data.Models.Service()
                            {
                                Id = 0.ToString(),
                                NameService = NameService.Text,
                                Duration = Convert.ToInt32(Duration.Text),
                                Cost = Convert.ToInt32(CostService.Text),
                            }
                        },
                       Discounts = new List<Discount>()
                        {
                            new Discount()
                            {
                                Code = Convert.ToInt32(Code.Text),
                                Size = Convert.ToInt32(Size.Text)
                            }
                        }
                   };
                _storage.AddClient(client);
                MessageBox.Show(@"Данные добавлены");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Lastname_TextChanged(object sender, EventArgs e)
        {
            Lastname.BackColor = Color.White;
        }

        private void Middlename_TextChanged(object sender, EventArgs e)
        {
            Middlename.BackColor = Color.White;
        }

        private void Date_TextChanged(object sender, EventArgs e)
        {
            Date.BackColor = Color.White;
        }

        private void NameOfClient_TextChanged(object sender, EventArgs e)
        {
            NameOfClient.BackColor = Color.White;
        }

        private Data.Models.Direction _directionByName;
        private void DirectionName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var directionName = DirectionName.Text;
            NameService.Items.Clear();
            CostService.Items.Clear();
            Duration.Items.Clear();
            _directionByName = _storage.GetDirectionsDirectionName(directionName);
            foreach (var t1 in _directionByName.Services)
                {
                    NameService.Items.Add(t1.NameService);
                }
        }

        private void NameService_SelectedIndexChanged(object sender, EventArgs e)
        {
            CostService.Items.Clear();
            Duration.Items.Clear();
            foreach (var t in _directionByName.Services)
                {
                    if (NameService.Text != t.NameService) continue;
                    CostService.Items.Add(t.Cost);
                    Duration.Items.Add(t.Duration);
                    break;
                }
            }
        }
    }