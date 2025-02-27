using Builder.Builders.Interfaces;
using Builder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    public class Director
    {
        private IDeveloper developer;

        public Director(IDeveloper developer) => this.developer = developer;

        public void SetDeveloper(IDeveloper developer) => this.developer = developer;

        public Phone MountOnlyPhone()
        {
            developer.CreateBox();
            developer.CreateDisplay();
            return developer.GetPhone();
        }
        public Phone MountFullPhone()
        {
            developer.CreateBox();
            developer.CreateDisplay();
            developer.SystemInstall();
            return developer.GetPhone();
        }
    }
}
