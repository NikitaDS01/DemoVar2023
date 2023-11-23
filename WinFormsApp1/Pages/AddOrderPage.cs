using DemoVar2023.Classes.Database;
using DemoVar2023.Classes.Database.Enum;
using DemoVar2023.Classes.Database.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoVar2023.Pages
{
    public partial class AddOrderPage : Form
    {
        private int _width;
        private int _height;
        public AddOrderPage()
        {
            InitializeComponent();
            _width = this.Width;
            _height = this.Height;
        }

        private void textBoxChanged(object sender, EventArgs e)
        {
            ButtonChange();
        }

        private void listBoxChanged(object sender, EventArgs e)
        {
            ButtonChange();
        }
        private void ButtonChange()
        {
            if (txtBoxDevise.Text == string.Empty)
            {
                btnAddOrder.Enabled = false;
                return;
            }
            if (txtBoxDescriptionError.Text == string.Empty)
            {
                btnAddOrder.Enabled = false;
                return;
            }
            if (txtBoxTypeError.Text == string.Empty)
            {
                btnAddOrder.Enabled = false;
                return;
            }
            if (txtBoxUser.Text == string.Empty)
            {
                btnAddOrder.Enabled = false;
                return;
            }
            if (listBoxStatus.Text == string.Empty)
            {
                btnAddOrder.Enabled = false;
                return;
            }
            btnAddOrder.Enabled = true;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            int id = TemplateDatabase.GetListOrder().Count + 1;
            StatusOrder status = new StatusOrder();
            switch (listBoxStatus.Text)
            {
                case "В ожидание": status = StatusOrder.Waiting; break;
                case "В работе": status = StatusOrder.Worked; break;
                case "Выполнено": status = StatusOrder.Complited; break;
            }
            var newOrder = new Order(id, DateTime.Now, txtBoxDevise.Text,
                txtBoxTypeError.Text, txtBoxDescriptionError.Text,
                txtBoxUser.Text, status);
            TemplateDatabase.AddOrder(newOrder);
            this.Close();
        }

        private void AddOrderPage_SizeChanged(object sender, EventArgs e)
        {
            this.Width = _width;
            this.Height = _height;
        }
    }
}
