using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CourseWork.Client;
using CourseWork.Direction;
using CourseWork.Input;
using Raven.Client.Document;

namespace CourseWork
{
    public partial class Main : Form
    {
        public Main()
        {
            try
            {
                InitializeComponent();
                CurrentDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
                CurrentDate.Text = CurrentDate.Text.Replace('.', '/');
                Center.Visible = false;
                Center.MouseDoubleClick += notifyIcon1_Click;
                Resize += Main_Resize;
                RefreshDg(CurrentDate.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var setting = new Settings();
            setting.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var client = new AddClient();
            client.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            var input = new InputOfAdmin();
            input.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var adddirection = new AddDirection();
            adddirection.Show();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized) return;
            ShowInTaskbar = false;
            Center.Visible = true;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
           Center.Visible = false;
           ShowInTaskbar = true;
           WindowState = FormWindowState.Normal;
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var massive = monthCalendar1.SelectionStart.ToString(CultureInfo.InvariantCulture).Split(' ');
            CurrentDate.Text = massive[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
             dataGridView1.Rows.Clear();
             RefreshDg(CurrentDate.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            RefreshDg(CurrentDate.Text);
        }

        private void RefreshDg(string currentdate)
        {
            try
            {
                var documentStore = new DocumentStore
                {
                    Url = "http://localhost:8080/",
                    DefaultDatabase = "Client"
                };
                documentStore.Initialize();
                using (var session = documentStore.OpenSession())
                {
                    var clients = session.Query<Models.Client>().Where(x => x.Date == currentdate).ToList();
                    for (var i = 0; i < clients.Count; i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = clients[i].Lastname;
                        dataGridView1.Rows[i].Cells[1].Value = clients[i].Name;
                        dataGridView1.Rows[i].Cells[2].Value = clients[i].MiddleName;
                        dataGridView1.Rows[i].Cells[3].Value = clients[i].AgeCategory;
                        dataGridView1.Rows[i].Cells[4].Value = clients[i].Date;
                        dataGridView1.Rows[i].Cells[5].Value = clients[i].Directions[0].NameOfDirection;
                        dataGridView1.Rows[i].Cells[6].Value = clients[i].Services[0].NameService;
                        dataGridView1.Rows[i].Cells[7].Value = clients[i].Services[0].Duration;
                        dataGridView1.Rows[i].Cells[8].Value = clients[i].Services[0].Cost;
                        dataGridView1.Rows[i].Cells[9].Value = clients[i].Services[0].Visit;
                        dataGridView1.Rows[i].Cells[10].Value = clients[i].Discounts[0].Code;
                        dataGridView1.Rows[i].Cells[11].Value = clients[i].Discounts[0].Size;
                    }
                    session.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
