using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Raven.Client.Document;

namespace CourseWork.Client
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
            Date.BackColor = Color.White;
            var list = new List<ComboBox> {AgeCategory, Payment, Decor};
            for (int i = 0; i < list.Count; i++)
            {
                list[i].DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            foreach (Control control in Client.Controls)
            {
                if ((!(control is TextBox)) || (control.Text.Trim() != "")) continue;
                MessageBox.Show(@"Поле должно быть заполнено!");
                control.BackColor = Color.Yellow;
                return;
            }
            var list = new List<TextBox> {Lastname, NameOfClient,Middlename};
            foreach (var t in list)
            {
                const string pattern = "[A-Za-zА-Яа-я]";
                var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                var match = regex.Match(t.Text);
                if (match.Success) continue;
                MessageBox.Show(@"Некорректное заполнение поля!");
                break;
            }
            var documentStore = new DocumentStore
            {
                Url = "http://localhost:8080/",
                DefaultDatabase = "Client"
            };

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Lastname_TextChanged(object sender, EventArgs e)
        {
            Lastname.BackColor = Color.White;
        }

        //private void Name_TextChanged(object sender, EventArgs e)
        //{
        //    Name.BackColor = Color.White;
        //}

        private void Middlename_TextChanged(object sender, EventArgs e)
        {
            Middlename.BackColor = Color.White;
        }

        private void Date_TextChanged(object sender, EventArgs e)
        {
            Date.BackColor = Color.White;
        }
    }
}
