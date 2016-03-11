using System;
using System.Linq;
using System.Windows.Forms;
using CourseWork.Client;
using CourseWork.Direction;
using CourseWork.Input;
using CourseWork.Models;
using Raven.Client.Document;

namespace CourseWork
{
    public partial class Main : Form
    {
        public Main()
        {
          InitializeComponent();
          CurrentDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
          CurrentDate.Text = CurrentDate.Text.Replace('.', '/');
          Center.Visible = false;
          Center.MouseDoubleClick += notifyIcon1_Click;
          Resize += Main_Resize;
          var documentStore = new DocumentStore
          {
              Url = "http://localhost:8080/",
              DefaultDatabase = "Client"
          };
            documentStore.Initialize();
            using (var session = documentStore.OpenSession())
            {
                var clients = session.Query<Models.Client>().ToList();
                for (var i = 0; i < clients.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = clients[i].Lastname;
                    dataGridView1.Rows[i].Cells[1].Value = clients[i].Name;
                    dataGridView1.Rows[i].Cells[2].Value = clients[i].MiddleName;
                    dataGridView1.Rows[i].Cells[3].Value = clients[i].AgeCategory;
                    dataGridView1.Rows[i].Cells[4].Value = clients[i].Date;
                }
                var directions = session.Query<Models.Direction>().ToList();
                for (var i = 0; i < directions.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[5].Value = directions[i].NameOfDirection;
                }
                var services = session.Query<Service>().ToList();
                for (var i = 0; i < services.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[6].Value = services[i].NameService;
                    dataGridView1.Rows[i].Cells[7].Value = services[i].Duration;
                    dataGridView1.Rows[i].Cells[8].Value = services[i].Cost;
                    dataGridView1.Rows[i].Cells[9].Value = services[i].Visit;
                }
                var discount = session.Query<Discount>().ToList();
                for (var i = 0; i < discount.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[10].Value = discount[i].Code;
                    dataGridView1.Rows[i].Cells[11].Value = discount[i].Size;
                }
                session.SaveChanges();
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
    }
}
