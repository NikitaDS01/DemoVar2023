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
    public partial class UpdateOrderPage : Form
    {
        private Order _order;
        private int _width;
        private int _height;
        public UpdateOrderPage(Order order)
        {
            _order = order;
            InitializeComponent();
            txtBoxIndex.Text = _order.Id.ToString();
            txtBoxDescriptionError.Text = _order.DescriptionError;

            var listUser = TemplateDatabase.GetListUser();
            var listExecutor = listUser.Where(user => user.Role == Role.Executor);
            listBoxUser.Items.AddRange(listExecutor.ToArray());

            _width = this.Width;
            _height = this.Height;
        }

        private void textBoxChanged(object sender, EventArgs e)
        {

        }

        private void listBoxChanged(object sender, EventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            User executer = (User)listBoxUser.SelectedItem;

            StatusOrder status = new StatusOrder();
            switch (listBoxStatus.Text)
            {
                case "Не выполнено": status = StatusOrder.NotComplited; break;
                case "В работе": status = StatusOrder.Worked; break;
                case "Выполнено": status = StatusOrder.Complited; break;
            }
            _order = new Order(_order.Id, _order.DateAdd, _order.Devise,
                _order.TypeError, txtBoxDescriptionError.Text,
                _order.User, status);
            TemplateDatabase.UpdateOrder(_order);

            var executerOrder = new ExecutorOrder(_order, executer, string.Empty);
            TemplateDatabase.AddExecturotOrder(executerOrder);

            this.Close();
        }

        private void UpdateOrderPage_SizeChanged(object sender, EventArgs e)
        {
            _width = this.Width;
            _height = this.Height;
        }
    }
}
