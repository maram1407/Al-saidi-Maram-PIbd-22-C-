using System;
using System.Collections.Generic;
using System.Linq;
using AbstractFactoryDatabaseImplement.Implements;
using AbstractFactoryBusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AbstractFactoryBusinessLogic.BusinessLogics;
using AbstractFactoryBusinessLogic.BindingModel;
using AbstractFactoryBusinessLogic.ViewModels;
using AbstractFactoryRestApi.Models;

namespace AbstractFactoryRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IOrderLogic _order;
        private readonly IProductLogic _product;
        private readonly MainLogic _main;
        public MainController(IOrderLogic order, IProductLogic product, MainLogic main)
        {
            _order = order;
            _product = product;
            _main = main;
        }
        [HttpGet]
        public List<ProductModel> GetProductList() => _product.Read(null)?.Select(rec =>
       Convert(rec)).ToList();
        [HttpGet]
        public ProductModel GetProduct(int productId) => Convert(_product.Read(new
       ProductConcreteBindingModel
        { Id = productId })?[0]);
        [HttpGet]
        public List<OrderViewModel> GetOrders(int clientId) => _order.Read(new
       OrderBindingModel
        { ClientId = clientId });
        [HttpPost]
        public void CreateOrder(CreateOrderBindingModel model) =>
       _main.CreateOrder(model);
        private ProductModel Convert(ProductViewModel model)
        {
            if (model == null) return null;
            return new ProductModel
            {
                Id = model.Id,
                ProductName = model.ProductName,
                Price = model.Price
            };
        }
    }
}
