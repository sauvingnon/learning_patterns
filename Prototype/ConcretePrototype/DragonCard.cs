using Prototype.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.ConcretePrototype
{
    public class DragonCard : Card
    {
        public override string? Name => "Дракон";

        public override int Points => 3;

        public override Card Clone()
        {
            return new DragonCard();
        }
    }
}
