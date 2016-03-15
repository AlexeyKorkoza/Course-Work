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
            datagridViewClients.Rows.Clear();
            RefreshDg(CurrentDate.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            datagridViewClients.Rows.Clear();
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
                        datagridViewClients.Rows.Add();
                        var massive = clients[i].Id.Split('/');
                        datagridViewClients.Rows[i].Cells[0].Value = massive[1];
                        datagridViewClients.Rows[i].Cells[1].Value = clients[i].Lastname;
                        datagridViewClients.Rows[i].Cells[2].Value = clients[i].Name;
                        datagridViewClients.Rows[i].Cells[3].Value = clients[i].MiddleName;
                        datagridViewClients.Rows[i].Cells[4].Value = clients[i].AgeCategory;
                        datagridViewClients.Rows[i].Cells[5].Value = clients[i].Date;
                        datagridViewClients.Rows[i].Cells[6].Value = clients[i].Directions[0].NameOfDirection;
                        datagridViewClients.Rows[i].Cells[7].Value = clients[i].Services[0].NameService;
                        datagridViewClients.Rows[i].Cells[8].Value = clients[i].Services[0].Duration;
                        datagridViewClients.Rows[i].Cells[9].Value = clients[i].Services[0].Cost;
                        datagridViewClients.Rows[i].Cells[10].Value = clients[i].Services[0].Visit;
                        datagridViewClients.Rows[i].Cells[11].Value = clients[i].Discounts[0].Code;
                        datagridViewClients.Rows[i].Cells[12].Value = clients[i].Discounts[0].Size;
                    }
                    session.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show(@"Вы уверены", @"Да", MessageBoxButtons.OKCancel);
                switch (result)
                {
                    case DialogResult.OK:
                        {
                            if (datagridViewClients.CurrentRow != null)
                            {
                                var index = datagridViewClients.CurrentRow.Index;
                                var id = datagridViewClients.Rows[index].Cells[0].Value;
                                var documentStore = new DocumentStore
                                {
                                    Url = "http://localhost:8080/",
                                    DefaultDatabase = "Client"
                                };
                                documentStore.Initialize();
                                using (var session = documentStore.OpenSession())
                                {
                                    documentStore.DatabaseCommands.Delete("clients/" + id, null);
                                    session.SaveChanges();
                                }
                            }
                            MessageBox.Show(@"Данные успешно удалены!");
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            break;
                        }
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch
            {
                MessageBox.Show(@"Выберите строку для удаления");
            }
        }

        private void datagridViewClients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (datagridViewClients.CurrentRow == null) return;
            var index = datagridViewClients.CurrentRow.Index;
            var id = "clients/"+(string)datagridViewClients.Rows[index].Cells[0].Value;
            var editClient = new EditClient(id);
            editClient.Show();
        }
    }
}