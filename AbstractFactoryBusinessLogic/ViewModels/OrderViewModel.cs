using AbstractFactoryBusinessLogic.Enums;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AbstractFactoryBusinessLogic.ViewModels
{
    /// Заказ 
    [DataContract]
    public class OrderViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        [DisplayName("Клиент")]
        public string ClientFIO { get; set; }

        [DisplayName("Изделие")] public string ProductName { get; set; }

        [DisplayName("Количество")] public int Count { get; set; }

        [DisplayName("Сумма")] public decimal Sum { get; set; }

        [DisplayName("Статус")] public OrderStatus Status { get; set; }

        [DisplayName("Дата создания")] public DateTime DateCreate { get; set; }

        [DisplayName("Дата выполнения")] public DateTime? DateImplement { get; set; }
    }
}
