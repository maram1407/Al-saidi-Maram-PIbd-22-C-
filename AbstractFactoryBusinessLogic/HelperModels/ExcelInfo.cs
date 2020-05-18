using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryBusinessLogic.ViewModels;
using System.Linq;
namespace AbstractFactoryBusinessLogic.HelperModels
{
    class ExcelInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<IGrouping<DateTime, OrderViewModel>> Orders { get; set; }
        
    }
}
