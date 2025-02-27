using Builder.Builders.Interfaces;
using Builder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders.Implementations
{
    public class IPhoneDeveloper : IDeveloper
    {
        private Phone phone;
        public IPhoneDeveloper() => phone = new Phone();
        public void CreateBox() => phone.AppendData("Произведен корпус Iphone\n");

        public void CreateDisplay() => phone.AppendData("Произведен дисплей Iphone\n");

        public void SystemInstall() => phone.AppendData("Установлена система Iphone\n");

        public Phone GetPhone() => phone;
    }
}
