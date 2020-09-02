using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryBusinessLogic.Enums;
namespace AbstractFactoryBusinessLogic.ViewModels
{
   public class ReportOrdersViewModel
    {
        public DateTime DateCreate { get; set; }
        public string ProductName { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
        public OrderStatus Status { get; set; }
    }
}
