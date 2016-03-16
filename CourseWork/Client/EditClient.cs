﻿using System;
using System.Windows.Forms;
using Raven.Client.Document;

namespace CourseWork.Client
{
    public partial class EditClient : Form
    {
        private string Id { get; set; }
        public EditClient(string id)
        {
            InitializeComponent();
            Id = id;
            View();
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
                    clients.Lastname = Lastname.Text;
                    clients.Name = NameOfClient.Text;
                    clients.MiddleName = Middlename.Text;
                    clients.Date = Date.Text;
                    clients.AgeCategory = AgeCategory.Text;
                    clients.Payment = Payment.Text;
                    clients.Decor = Decor.Text;
                    clients.Directions[0].NameOfDirection = DirectionName.Text;
                    clients.Directions[0].Description = DirectionDescription.Text;
                    clients.Services[0].NameService = NameService.Text;
                    clients.Services[0].Duration= Convert.ToInt32(Duration.Text);
                    clients.Services[0].Cost = Convert.ToInt32(CostService.Text);
                    clients.Services[0].Visit = Visit.Text;
                    clients.Discounts[0].Code = Convert.ToInt32(Code.Text);
                    clients.Discounts[0].DescriptionDiscount = DescriptionDiscount.Text;
                    clients.Discounts[0].Size = Convert.ToInt32(Size.Text);
                    session.Store(clients);
                    session.SaveChanges();
                }
                MessageBox.Show(@"Данные успешно обновлены!");
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
                    Lastname.Text = clients.Lastname;   
                    NameOfClient.Text = clients.Name;   
                    Middlename.Text = clients.MiddleName;   
                    Date.Text = clients.Date;   
                    AgeCategory.Text = clients.AgeCategory;   
                    Payment.Text = clients.Payment;   
                    Decor.Text = clients.Decor;   
                    DirectionName.Text = clients.Directions[0].NameOfDirection;   
                    DirectionDescription.Text = clients.Directions[0].Description;   
                    NameService.Text = clients.Services[0].NameService;
                    Duration.Text = clients.Services[0].Duration.ToString();
                    CostService.Text = clients.Services[0].Cost.ToString();
                    Visit.Text = clients.Services[0].Visit;
                    Code.Text = clients.Discounts[0].Code.ToString();
                    DescriptionDiscount.Text = clients.Discounts[0].DescriptionDiscount;
                    Size.Text = clients.Discounts[0].Size.ToString();
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