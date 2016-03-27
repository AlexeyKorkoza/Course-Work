using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork.Service
{
    public partial class EditService : Form
    {
        private string _id;
        private string _directionName;
        private string _nameService;
        private Data.Models.Direction _currentService;
        IStorage storage = new Storage();
        public EditService(string id,string directionName,string nameService)
        {
            InitializeComponent();
            _id = id;
            _directionName = directionName;
            _nameService = nameService;
            NewNameService.BackColor = Color.White;
            View();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                var pattern = "[A-Za-zА-Яа-я]";
                var regex = new Regex(pattern, RegexOptions.IgnoreCase);
                var match = regex.Match(NewNameService.Text);
                if (!match.Success)
                {
                    MessageBox.Show(@"Некорректное заполнение поля!");
                    return;
                }
                pattern = "[0-9]{1,}";
                regex = new Regex(pattern, RegexOptions.IgnoreCase);
                match = regex.Match(Duration.Text);
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
                for (int k = 0; k < _currentService.Services.Length; k++)
                {
                    if (_currentService.Services[k].Id == _id)
                    {
                        if (changeNameService.Checked)
                        {
                            _currentService.Services[k].NameService = NewNameService.Text;
                        }
                        else
                        {
                            _currentService.Services[k].NameService = NameService.Text;
                        }
                        _currentService.Services[k].Cost = Convert.ToInt32(CostService.Text);
                        _currentService.Services[k].Duration = Convert.ToInt32(Duration.Text);
                        storage.UpdateDirection(_currentService);
                    }
                }
                MessageBox.Show(@"Услуга успешно редактирована");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void View()
        {
            try
            {
                _currentService = storage.GetDirectionsDirectionName(_directionName);
                foreach (var t in _currentService.Services)
                {
                    if (t.NameService != _nameService) continue;
                    NameService.Text = t.NameService;
                    CostService.Text = t.Cost.ToString();
                    Duration.Text = t.Duration.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void changeNameService_CheckedChanged(object sender, EventArgs e)
        {
            if (changeNameService.Checked)
            {
                NewNameService.Enabled = true;
            }
            else
            {
                NewNameService.Enabled = false;
            }
        }
    }
}
