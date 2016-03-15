using System;
using System.Windows.Forms;
using Raven.Client.Document;

namespace CourseWork.Client
{
    public partial class EditClient : Form
    {
        public string Id { get; private set; }
        public EditClient(string id)
        {
            InitializeComponent();
            Id = id;
            View();
        }

        public void View()
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
                    var clients = session.Load<Models.Client>(Id);
                    datagridViewClients.Rows.Add();
                    if (clients != null)
                    {
                        var massive = clients.Id.Split('/');
                        datagridViewClients.Rows[0].Cells[0].Value = massive[1]; 
                        datagridViewClients.Rows[0].Cells[1].Value = clients.Lastname;
                        datagridViewClients.Rows[0].Cells[2].Value = clients.Name;
                        datagridViewClients.Rows[0].Cells[3].Value = clients.MiddleName;
                        datagridViewClients.Rows[0].Cells[5].Value = clients.AgeCategory;
                        datagridViewClients.Rows[0].Cells[4].Value = clients.Date;
                        foreach (var course in clients.Directions)
                        {
                            datagridViewClients.Rows[0].Cells[6].Value = course.NameOfDirection;
                        }
                        foreach (var course in clients.Services)
                        {
                            datagridViewClients.Rows[0].Cells[7].Value = course.NameService;
                            datagridViewClients.Rows[0].Cells[8].Value = course.Duration;
                            datagridViewClients.Rows[0].Cells[9].Value = course.Cost;
                            datagridViewClients.Rows[0].Cells[10].Value = course.Visit;
                        }
                        foreach (var course in clients.Discounts)
                        {
                            datagridViewClients.Rows[0].Cells[11].Value = course.Code;
                            datagridViewClients.Rows[0].Cells[12].Value = course.Size;
                        }
                    }
                    session.SaveChanges();
                }
                MessageBox.Show(@"Данные успешно добавлены!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
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
                    var clients = session.Load<Models.Client>(Id);
                    if (clients != null)
                    {
                        clients.Lastname = (string)datagridViewClients.Rows[0].Cells[1].Value;
                        clients.Name = (string)datagridViewClients.Rows[0].Cells[2].Value;
                        clients.MiddleName = (string)datagridViewClients.Rows[0].Cells[3].Value;
                        clients.Date = (string)datagridViewClients.Rows[0].Cells[4].Value;
                        clients.AgeCategory = (string)datagridViewClients.Rows[0].Cells[5].Value;
                        clients.Directions[0].NameOfDirection = (string)datagridViewClients.Rows[0].Cells[6].Value;
                        clients.Services[0].NameService = (string)datagridViewClients.Rows[0].Cells[7].Value;
                        clients.Services[0].Duration = (int)datagridViewClients.Rows[0].Cells[8].Value;
                        clients.Services[0].Cost = (int)datagridViewClients.Rows[0].Cells[9].Value;
                        clients.Services[0].Visit = (string)datagridViewClients.Rows[0].Cells[10].Value;
                        clients.Discounts[0].Code = (int)datagridViewClients.Rows[0].Cells[11].Value;
                        clients.Discounts[0].Size = (int)datagridViewClients.Rows[0].Cells[12].Value;
                        session.Store(clients);
                    }
                    session.SaveChanges();

                }
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
    }
}