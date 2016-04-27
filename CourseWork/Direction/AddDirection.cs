using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork.Direction
{
    public partial class AddDirection : Form
    {
        private readonly List<TextBox> _textboxlist;
        IStorage _storage = new Storage();

        public AddDirection()
        {
            InitializeComponent();
            _textboxlist = new List<TextBox> {NameService, Duration, Cost};
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (DirectionName.Text.Length == 0)
                {
                    MessageBox.Show(@"Заполните название направления");
                    return;
                }
                if (Description.Text.Length == 0)
                {
                    MessageBox.Show(@"Заполните описание направления");
                    return;
                }
                if (_textboxlist.Any(t => t.Text.Length == 0))
                {
                    MessageBox.Show(@"Заполните все поля в блоке услуги!");
                }
                var directions = _storage.GetDirections();
                for (var k = 0; k < directions.Count; k++)
                {
                    if (directions[k].NameOfDirection == DirectionName.Text)
                    {
                        MessageBox.Show(@"Данное направление уже имеется");
                        return;
                    }
                }
                var direction = new Data.Models.Direction()
                {
                    Id = "directions/",
                    NameOfDirection = DirectionName.Text,
                    Description = Description.Text,
                    Services = new List<Data.Models.Service>()
                    {
                        new Data.Models.Service()
                        {
                            Id = 1.ToString(),
                            NameService = NameService.Text,
                            Duration = Convert.ToInt32(Duration.Text),
                            Cost = Convert.ToInt32(Cost.Text),
                        }
                    },
                };
                _storage.AddDirection(direction);
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

        private void Duration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
