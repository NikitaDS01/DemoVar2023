using DemoVar2023.Classes.Database;
using DemoVar2023.Classes.Database.Enum;
using DemoVar2023.Classes.Database.Table;
using DemoVar2023.Classes.Programm;
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
    public partial class OrderListPage : Form
    {
        private int _width;
        private int _height;
        public OrderListPage()
        {
            InitializeComponent();
            DataGridUpdate();
            RoleUpdate();

            _width = this.Width;
            _height = this.Height;
        }
        private void RoleUpdate()
        {
            Role role = CurrentUser.GetUser().Role;
            if (role != Role.Editor)
                return;

            btnAddOrder.Visible = true;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrderPage page = new AddOrderPage();
            this.Hide();
            page.ShowDialog();
            this.Show();
            DataGridUpdate();
        }
        private void DataGridUpdate()
        {
            dataViewOrder.DataSource = typeof(List<Order>);
            var listOrder = TemplateDatabase.GetListOrder();
            dataViewOrder.DataSource = listOrder;

            int countComplited = TemplateDatabase.GetListOrder().
                Where(ord => ord.Status == StatusOrder.Complited).Count();
            lblCountComplited.Text = $"Выполнено заявок:{countComplited}";
        }

        private void dataViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            Order order = (Order)dataViewOrder.CurrentRow.DataBoundItem;
            var role = CurrentUser.GetUser().Role;
            if (role == Role.Editor)
                ShowUpdateOrder(order);
            if (role == Role.Executor)
                ShowCommentOrder(order);
        }
        private void ShowUpdateOrder(Order orderIn)
        {
            UpdateOrderPage page = new UpdateOrderPage(orderIn);
            this.Hide();
            page.ShowDialog();
            this.Show();
            DataGridUpdate();
        }
        private void ShowCommentOrder(Order orderIn)
        {
            AddCommentPage page = new AddCommentPage(orderIn);
            this.Hide();
            page.ShowDialog();
            this.Show();
            DataGridUpdate();
        }
        private void OrderListPage_SizeChanged(object sender, EventArgs e)
        {
            this.Width = _width;
            this.Height = _height;
        }
    }
}
