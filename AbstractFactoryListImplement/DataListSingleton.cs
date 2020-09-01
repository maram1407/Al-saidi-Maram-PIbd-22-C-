﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryListImplement.Models;

namespace AbstractFactoryListImplement
{
    public class DataListSingleton
    {
        private static DataListSingleton instance;
        public List<Component> Components { get; set; }
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        public List<ProductComponent> ProductComponents { get; set; }
        public List<Client> Clients { get; set; }
        public List<MessageInfo> MessageInfoes { get; set; }
        public List<Implementer> Implementers { get; set; }
        private DataListSingleton()
        {
            Components = new List<Component>();
            Orders = new List<Order>();
            Products = new List<Product>();
            Clients = new List<Client>();
            ProductComponents = new List<ProductComponent>();
            Implementers = new List<Implementer>();
            MessageInfoes = new List<MessageInfo>();
        }
        public static DataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DataListSingleton();
            }
            return instance;
        }
    }
}