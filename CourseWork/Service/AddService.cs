using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork.Service
{
    public partial class AddService : Form
    {
        readonly IStorage _storage = new Storage();
        private readonly List<Data.Models.Direction> _direction;
        private readonly List<TextBox> _textBoxs;
        readonly Random _random = new Random();
        public AddService()
        {
            try
            {
                InitializeComponent();
                _textBoxs = new List<TextBox> { NameService, Duration, CostService };
                _direction = _storage.GetDirections();
                foreach (var t in _direction)
                {
                    DirectionName.Items.Add(t.NameOfDirection);
                }
                DirectionName.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (DirectionName.Text.Length == 0)
                {
                    MessageBox.Show(@"Выберите направление");
                    return;
                }
                foreach (var t in _textBoxs)
                {
                    if (t.Text.Length != 0) continue;
                    MessageBox.Show(@"Не все поля были заполнены");
                    break;
                }
                var value = 0;
                var idDirection = 0;
                foreach (var t in _direction)
                {
                    if(t.NameOfDirection!=DirectionName.Text) continue;
                    var massive = t.Id.Split('/');
                    idDirection = Convert.ToInt32(massive[1]);
                    value = _random.Next(1, 500);
                    for (var k = 0; k < t.Services.Count; k++)
                    {
                        if (t.Services[k].NameService == NameService.Text)
                        {
                            MessageBox.Show(@"Данная услуга уже имеется");
                            return;
                        }
                        if (value != Convert.ToInt32(t.Services[k].Id)) continue;
                        value = _random.Next(1, 500);
                        k--;
                    }
                }
                 var service = new Data.Models.Service
                {
                    NameService = NameService.Text,
                    Id = value.ToString(),
                    Cost = Convert.ToInt32(CostService.Text),
                    Duration = Convert.ToInt32(Duration.Text)
                };
                _storage.AddService(service, idDirection);
                MessageBox.Show(@"Услуга была добавлена!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Duration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void CostService_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
