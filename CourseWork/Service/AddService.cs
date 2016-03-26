using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork.Service
{
    public partial class AddService : Form
    {
        IStorage _storage = new Storage();
        private readonly List<Data.Models.Direction> _direction;
        private readonly List<TextBox> _textBoxs;
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
                const string pattern = "[0-9]{1,}";
                var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                var match = regex.Match(Duration.Text);
                if (!match.Success)
                {
                    MessageBox.Show(@"Некорректное заполнение поля!");
                    return;
                }
                match = regex.Match(CostService.Text);
                if (!match.Success)
                {
                    MessageBox.Show(@"Некорректное заполнение поля!");
                    return;
                }
                foreach (var t in _textBoxs)
                {
                    if (t.Text.Length != 0) continue;
                    MessageBox.Show(@"Не все поля были заполнены");
                    break;
                }
                var id = 0;
                foreach (var t in _direction)
                {
                    if (t.NameOfDirection == DirectionName.Text)
                    {
                        var massive = t.Id.Split('/');
                        id = Convert.ToInt32(massive[1]);
                    }
                }
                var service = new Data.Models.Service
                {
                    NameService = NameService.Text,
                    Id = _direction[0].Services.Length.ToString(),
                    Cost = Convert.ToInt32(CostService.Text),
                    Duration = Convert.ToInt32(Duration.Text)
                };
                _storage.AddService(service, id);
                MessageBox.Show(@"Услуга была добавлена!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
