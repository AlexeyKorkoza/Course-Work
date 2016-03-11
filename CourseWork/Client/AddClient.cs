﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CourseWork.Models;
using Raven.Client.Document;

namespace CourseWork.Client
{
    public partial class AddClient : Form
    {
        private readonly List<ComboBox> _listcombobox;
        private readonly List<TextBox>  _textBoxs;
        private readonly List<RichTextBox> _richTextBoxs; 
           
        public AddClient()
        {
            InitializeComponent();
            Date.Text = DateTime.Now.ToString("MM/dd/yyyy");
            Date.Text = Date.Text.Replace('.', '/');
            Date.BackColor = Color.White;
            _textBoxs = new List<TextBox> { Lastname, NameOfClient, Middlename };
            //DirectionName, NameService, Duration, CostService,Code,Size
            _listcombobox = new List<ComboBox> { AgeCategory, Payment, Decor,  Visit};
            _richTextBoxs = new List<RichTextBox>{DescriptionDiscount,DirectionDescription};
            foreach (var t in _listcombobox)
            {
                t.DropDownStyle = ComboBoxStyle.DropDownList;
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
                    MessageBox.Show(@"Все поля должн быть заполнены!");
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
                var documentStore = new DocumentStore
                {
                    Url = "http://localhost:8080/",
                    DefaultDatabase = "Client"
                };
                documentStore.Initialize();
                using (var session = documentStore.OpenSession())
                {
                    session.Store(new Models.Client
                    {
                        Lastname = Lastname.Text,
                        Name = NameOfClient.Text,
                        MiddleName = Middlename.Text,
                        Date = Date.Text,
                        AgeCategory = AgeCategory.Text
                    });
                    session.Store(new Models.Direction
                    {
                        NameOfDirection = NameService.Text,
                        Description = DirectionDescription.Text
                    });
                    session.Store(new Service
                    {
                        NameService = NameService.Text,
                        Duration = Convert.ToInt32(Duration.Text),
                        Cost = Convert.ToInt32(CostService.Text),
                        Visit = Visit.Text
                    });
                    session.Store(new Discount
                    {
                        Code = Convert.ToInt32(Code.Text),
                        DescriptionDiscount = DescriptionDiscount.Text,
                        Size = Convert.ToInt32(Size.Text)
                    });
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
    }
}
