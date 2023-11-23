using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVar2023.Classes.Database.Table
{
    public class ExecutorOrder
    {
        public Order Order { get; private set; }
        public User Executor { get; private set; }
        public string Comment { get; private set; }
        public ExecutorOrder(Order order, User executor, string comment)
        {
            Order = order;
            Executor = executor;
            Comment = comment;
        }
    }
}
