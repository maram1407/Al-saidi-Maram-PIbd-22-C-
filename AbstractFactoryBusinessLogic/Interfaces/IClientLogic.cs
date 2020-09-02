using System;
using AbstractFactoryBusinessLogic.BindingModel;
using AbstractFactoryBusinessLogic.ViewModels;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryBusinessLogic.Interfaces
{
    public interface IClientLogic
    {
        List<ClientViewModel> Read(ClientBindingModel model);

        void CreateOrUpdate(ClientBindingModel model);

        void Delete(ClientBindingModel model);
    }
}
