using DemoVar2023.Classes.Database.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVar2023.Classes.Database
{
    public static class TemplateDatabase
    {
        private static List<Order> _listOrderTest = new List<Order>
        {
            new Order(1, new DateTime(2022,1,4), "Пульт", "Поломка", 
                "Пульт сломался пополам", "Иван Иванович", Enum.StatusOrder.Waiting),
            new Order(2, new DateTime(2022,2,5), "Стиральная машина", "Протечка", 
                "Течёт", "Иван Васильевич", Enum.StatusOrder.Waiting),
            new Order(3, new DateTime(2022,1,23), "Стиральная машина", "Поломка",
                "Разломался пополам", "Татьяна Ивановна", Enum.StatusOrder.NotComplited),
            new Order(4, new DateTime(2022,1,15), "Телевизор", "Поломка",
                "Телевизор показывает черный экран", "Виктория Ивановна", Enum.StatusOrder.Worked),
            new Order(5, new DateTime(2022,2,1), "Холодильник", "Протечка",
                "Течёт антифриз", "Никита Сергеевич", Enum.StatusOrder.Complited),
        };
        private static List<User> _listUserTest = new List<User>
        {
            new User("test", "test", Enum.Role.Editor),
            new User("admin", "1111", Enum.Role.Editor),
            new User("lexa", "test", Enum.Role.Executor),
            new User("nikita", "test", Enum.Role.Executor),
            new User("dmirtiy", "test", Enum.Role.Executor),
            new User("alexand", "test", Enum.Role.Executor)
        };
        private static List<ExecutorOrder> _listExecutorOrders = new List<ExecutorOrder>
        {
            new ExecutorOrder(_listOrderTest[2], _listUserTest[3],""),
            new ExecutorOrder(_listOrderTest[3], _listUserTest[5],""),
            new ExecutorOrder(_listOrderTest[4], _listUserTest[4],"Почему антифриз?"),
        };
        public static void AddOrder(Order order)
            => _listOrderTest.Add(order);
        public static void AddExecturotOrder(ExecutorOrder order)
            => _listExecutorOrders.Add(order);

        public static void UpdateOrder(Order orderIn)
        {
            var orders = _listOrderTest.Where(ord => ord.Id == orderIn.Id);
            Order order = orders.First();
            _listOrderTest.Remove(order);

            AddOrder(orderIn);
        }
        public static void UpdateExecutorOrder(Order orderIn, User userIn, string commentIn)
        {
            var orders = _listExecutorOrders.Where(exOrd => exOrd.Order.Id == orderIn.Id);
            ExecutorOrder order = orders.First();
            _listExecutorOrders.Remove(order);

            AddExecturotOrder(new ExecutorOrder(orderIn, userIn, commentIn));
        }

        public static List<Order> GetListOrder()
            => _listOrderTest;
        public static List<User> GetListUser()
            => _listUserTest;
        public static List<ExecutorOrder> GetListExecutorOrder()
            => _listExecutorOrders;
    }
}
