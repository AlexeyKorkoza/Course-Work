﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Raven.Client.Document;

namespace CourseWork.Service
{
    public partial class AddService : Form
    {
        private readonly List<Models.Direction> _direction;
        private readonly List<TextBox> _textBoxs;
        public AddService()
        {
            InitializeComponent();
            _textBoxs = new List<TextBox> {NameService,Duration,CostService};
            var documentStore = new DocumentStore
            {
                Url = "http://localhost:8080/",
                DefaultDatabase = "Center"
            };
            documentStore.Initialize();
            using (var session = documentStore.OpenSession())
            {
                _direction = session.Query<Models.Direction>().ToList();
                foreach (var t in _direction)
                {
                        if (!DirectionName.Items.Contains(t.NameOfDirection))
                        {
                            DirectionName.Items.Add(t.NameOfDirection);
                        }
                    }
                session.SaveChanges();
            }
            DirectionName.DropDownStyle = ComboBoxStyle.DropDownList;
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
                var description = string.Empty;
                foreach (var t in _direction)
                {
                    if (t.NameOfDirection == DirectionName.Text)
                    {
                        description = t.Description;
                    }
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
                        Description = description,
                        Services = new[]
                        {
                            new Models.Service()
                            {
                                NameService = NameService.Text,
                                Duration = Convert.ToInt32(Duration.Text),
                                Cost = Convert.ToInt32(CostService.Text),
                            }
                        }
                    };
                    session.Store(direction);
                    session.SaveChanges();
                }
                MessageBox.Show(@"Услуга была добавлена!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
