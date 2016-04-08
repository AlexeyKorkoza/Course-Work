﻿using System;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork.Client
{
    public partial class EditClient : Form
    {
        readonly IStorage _storage = new Storage();
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
                var clients = _storage.GetClientId(Id);
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
                clients.Services[0].Duration = Convert.ToInt32(Duration.Text);
                clients.Services[0].Cost = Convert.ToInt32(CostService.Text);
                clients.Visit = Visit.Text;
                clients.Discounts[0].Code = Convert.ToInt32(Code.Text);
                clients.Discounts[0].Size = Convert.ToInt32(Size.Text);
                _storage.UpdateClientId(clients);
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
                var clients = _storage.GetClientId(Id);
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
                Visit.Text = clients.Visit;
                Code.Text = clients.Discounts[0].Code.ToString();
                Size.Text = clients.Discounts[0].Size.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}