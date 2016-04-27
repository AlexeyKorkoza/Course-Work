using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWork.Data;
using CourseWork.Data.Models;
using CourseWork.Discounts;

namespace CourseWork.Client
{
    public partial class EditClient : Form
    {
        readonly IStorage _storage = new Storage();
        private readonly List<ComboBox> _listcombobox;
        private readonly List<TextBox> _textBoxs;
        private readonly List<RichTextBox> _richTextBoxs;
        private readonly IDiscount _discount = new Discounts.Discounts();
        readonly List<Discount> _discounts = new List<Discount>();
        private string _currentcode = string.Empty;
        private string Id { get; }
        public EditClient(string id)
        {
            InitializeComponent();
            Id = id;
            _textBoxs = new List<TextBox> { Lastname, NameOfClient, Middlename };
            _listcombobox = new List<ComboBox>
                {
                    AgeCategory,
                    DirectionName,
                    NameService,
                    Payment,
                    Decor,
                    Visit
                };
            _richTextBoxs = new List<RichTextBox> { DirectionDescription };
            foreach (var t in _listcombobox)
            {
                t.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            Code.DropDownStyle = ComboBoxStyle.DropDownList;
            _discounts = _discount.ReadDiscountses();
            for (var k = 0; k < _discounts.Count; k++)
            {
                Code.Items.Add(_discounts[k].Code);
            }
            var direction = _storage.GetDirections();
            foreach (var t in direction)
            {
                    if (!DirectionName.Items.Contains(t.NameOfDirection))
                    {
                        DirectionName.Items.Add(t.NameOfDirection);
                    }
            }
            for (var i = 0; i < direction.Count; i++)
            {
                if (DirectionName.Text == direction[i].NameOfDirection)
                {
                    for (var j = 0; j < direction[i].Services.Count; i++)
                    {
                        NameService.Items.Add(direction[i].Services[j].NameService);
                    }
                }
            }
            View();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                var sum = 0;
                if (Size.Text.Length != 0 && CostService.Text.Length != 0)
                {
                    var cost = Convert.ToInt32(CostService.Text);
                    var size = Convert.ToInt32(Size.Text);
                    sum = cost - size * cost / 100;
                    MessageBox.Show(@"С учетом скидки цена услуга будет равна:" + sum);
                }
                var code = 0;
                var sizeDiscount = 0;
                if (Size.Text.Length != 0 && Code.Text.Length != 0)
                {
                    code = Convert.ToInt32(Code.Text);
                    sizeDiscount = Convert.ToInt32(Size.Text);
                }
                if (CostService.Text != sum.ToString() && sum != 0)
                {
                    CostService.Text = string.Empty + sum;
                }
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
                clients.Discounts[0].Code = code;
                clients.Discounts[0].Size = sizeDiscount;
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
                if (Size.Text == "0")
                {
                    Size.Text = string.Empty;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private Data.Models.Direction _directionByName;
        private void DirectionName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var directionName = DirectionName.Text;
            NameService.Items.Clear();
            _directionByName = _storage.GetDirectionsDirectionName(directionName);
            foreach (var t in _directionByName.Services)
            {
                NameService.Items.Add(t.NameService);
            }
            var direction = _storage.GetDirections();
            foreach (var t in direction)
            {
                if (t.NameOfDirection != DirectionName.Text) continue;
                DirectionDescription.Text = string.Empty + t.Description;
                break;
            }
        }

        private void Code_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentcode = Code.Text;
            foreach (var t in _discounts)
            {
                if (_currentcode != t.Code.ToString()) continue;
                Size.Text = string.Empty + t.Size;
                break;
            }
        }

        private void NameService_SelectedIndexChanged(object sender, EventArgs e)
        {
            CostService.Text = string.Empty;
            Duration.Text = string.Empty;
            foreach (var t in _directionByName.Services)
            {
                if (NameService.Text != t.NameService) continue;
                CostService.Text = string.Empty + t.Cost;
                Duration.Text = string.Empty + t.Duration;
                break;
            }
        }
    }
}