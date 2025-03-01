using FactoryMethod.Concrete_Product;
using FactoryMethod.Creator;
using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete_Creator
{
    public class PanelHouseDeveloper : Developer
    {
        public PanelHouseDeveloper(string name) : base(name)
        {
        }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
}
