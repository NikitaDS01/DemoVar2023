using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoVar2023.Classes.Database.Enum;

namespace DemoVar2023.Classes.Database.Table
{
    public class Order
    {
        public int Id { get; private set; }
        public DateTime DateAdd { get; private set; }
        public string Devise { get; private set; }
        public string TypeError { get; private set; }
        public string DescriptionError { get; private set; }
        public string User { get; private set; }
        public StatusOrder Status { get; private set; }
        public Order(int id, DateTime dateAdd, string devise, string typeError, string descriptionError, string user, StatusOrder status)
        {
            Id = id;
            DateAdd = dateAdd;
            Devise = devise;
            TypeError = typeError;
            DescriptionError = descriptionError;
            User = user;
            Status = status;
        }
        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
