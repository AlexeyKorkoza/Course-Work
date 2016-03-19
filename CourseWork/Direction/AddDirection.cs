using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CourseWork.Models;
using Raven.Client.Document;

namespace CourseWork.Direction
{
    public partial class AddDirection : Form
    {
        private readonly List<TextBox> _textboxlist;
        public AddDirection()
        {
            InitializeComponent();
            _textboxlist  = new List<TextBox>{NameService,Duration,Cost};
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
                const string pattern = "[0-9]{1,}";
                var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                var match = regex.Match(Duration.Text);
                if (!match.Success)
                {
                    MessageBox.Show(@"В поле цена вводятся только цифры!");
                    return;
                }
                match = regex.Match(Cost.Text);
                if (!match.Success)
                {
                    MessageBox.Show(@"В поле продолжительность вводятся только цифры!");
                    return;
                }
                var documentStore = new DocumentStore
                {
                    Url = "http://localhost:8080/",
                    DefaultDatabase = "Center"
                };
                documentStore.Initialize();
                using (var session = documentStore.OpenSession())
                {
                    var direction = new Models.Direction()
                    {
                        NameOfDirection = DirectionName.Text,
                        Description = Description.Text,
                        Services = new[]
                        {
                            new Models.Service()
                            {
                                NameService = NameService.Text,
                                Duration = Convert.ToInt32(Duration.Text),
                                Cost = Convert.ToInt32(Cost.Text),
                            }
                        },
                    };
                    session.Store(direction);
                    session.SaveChanges();
                }
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

    }
}
