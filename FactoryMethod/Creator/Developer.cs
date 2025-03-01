using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creator
{
    public abstract class Developer
    {
        public string Name { get; set; }
        public Developer(string name)
        {
            this.Name = name;
        }
        public abstract House Create();
    }
}
