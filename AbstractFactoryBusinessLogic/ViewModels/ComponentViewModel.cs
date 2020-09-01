using System;
using System.Collections.Generic;
using AbstractFactoryBusinessLogic.Attributes;
using AbstractFactoryBusinessLogic.Enums;
namespace AbstractFactoryBusinessLogic.ViewModels
{
    public class ComponentViewModel : BaseViewModel
    {
        [Column(title: "Название омпонент", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ComponentName { get; set; }
        public override List<string> Properties() => new List<string>
        {
            "Id",
            "ComponentName"
        };
    }
}
