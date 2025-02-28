using Builder.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders.Interfaces
{
    /// <summary>
    /// Интерфейс для создания различных частей объекта
    /// </summary>
    public interface IDeveloper
    {
        /// <summary>
        /// Создание дисплея
        /// </summary>
        void CreateDisplay();
        /// <summary>
        /// Создание корпуса
        /// </summary>
        void CreateBox();
        /// <summary>
        /// Установка ОС
        /// </summary>
        void SystemInstall();
        Phone GetPhone();
    }
}
