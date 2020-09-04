using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryBusinessLogic.BindingModel;
using AbstractFactoryBusinessLogic.ViewModels;

namespace AbstractFactoryBusinessLogic.Interfaces
{
    public interface IProductLogic
    {
        List<ProductViewModel> Read(ProductConcreteBindingModel model);
        void CreateOrUpdate(ProductConcreteBindingModel model);
        void Delete(ProductConcreteBindingModel model);
    }
}
