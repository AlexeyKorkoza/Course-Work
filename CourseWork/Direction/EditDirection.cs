using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CourseWork.Data;
using Raven.Client.Document;

namespace CourseWork.Direction
{
    public partial class EditDirection : Form
    {
        private List<Data.Models.Direction> _direction;
        IStorage storage = new Storage();
        public EditDirection()
        {
            InitializeComponent();
            NewDirection.Enabled = false;
            View();
        }

        private void ChangeDirectionName_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangeDirectionName.Checked)
            {
                NewDirection.Enabled = true;
            }
            else
            {
                NewDirection.Enabled = false;
            }
        }

        private void View()
        {
            try
            {
                _direction = storage.GetDirections();
                foreach (var t in _direction)
                {
                    if (!DirectionName.Items.Contains(t.NameOfDirection))
                    {
                        DirectionName.Items.Add(t.NameOfDirection);
                    }
                }

                DirectionName.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void DirectionName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Description.Text = string.Empty;
                for (var i = 0; i < _direction.Count; i++)
                {
                    if (_direction[i].NameOfDirection == DirectionName.Text)
                    {
                        Description.Text = _direction[i].Description;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            View();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (DirectionName.Text.Length == 0)
                {
                    MessageBox.Show(@"Выберите направление для редактировании!");
                    return;
                }
                if (Description.Text.Length == 0)
                {
                    MessageBox.Show(@"Описание отсутствует!");
                    return;
                }
                if (ChangeDirectionName.Checked)
                {
                    if (NewDirection.Text.Length == 0)
                    {
                        MessageBox.Show(@"Введите название направления!");
                        return;
                    }
                }
                var direction = storage.GetDirectionsDirectionName(DirectionName.Text);
                foreach (var t in direction)
                {
                    if (ChangeDirectionName.Checked)
                    {
                        t.NameOfDirection = NewDirection.Text;
                    }
                    else
                    {
                        t.NameOfDirection = DirectionName.Text;
                    }
                    t.Description = Description.Text;
                }
                /*BUG!!!!*/
                storage.UpdateDirection(direction);

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
    }
}