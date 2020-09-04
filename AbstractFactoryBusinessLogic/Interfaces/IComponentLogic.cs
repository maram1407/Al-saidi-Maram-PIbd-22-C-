using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryBusinessLogic.BindingModel;
using AbstractFactoryBusinessLogic.ViewModels;

namespace AbstractFactoryBusinessLogic.Interfaces
{
    public interface IComponentLogic
    {
        List<ComponentViewModel> Read(ComponentBindingModel model);
        void CreateOrUpdate(ComponentBindingModel model);
        void Delete(ComponentBindingModel model);
    }
}
