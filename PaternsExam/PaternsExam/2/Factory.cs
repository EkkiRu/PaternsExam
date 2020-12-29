using System;
using System.Collections.Generic;
using System.Text;

namespace PaternsExam._2
{
    /*2. 
     * Вы автоматизируете автомойку
У вас есть боксы для легковых авто - 
    6 штук и джипов 4 штук. Всего боксов 10
Бокс имеет свой номер (Бокс1), 
    прикрепленного мойщика (Фамилия имя) 
    и категорию (А для легковых авто, Б-для джипов)
Нужно учесть, что количество боксов 
    неизменно, но боксы для джипов могут 
    принимать легковые авто*/


    public interface IBox
    {
        bool Service { get; set; }
        int Number { get; set; }
        string WasherFullName { get; set; }
        void Washing();
    }

    public class BoxA : IBox
    {
        public int Number { get; set; }
        public string WasherFullName { get; set; }
        public bool Service { get; set; }

        public void Washing()
        {
            Console.WriteLine("Моем моем чисто чисто");
        }
    }

    public class BoxB : IBox
    {
        public int Number { get; set; }
        public string WasherFullName { get; set; }
        public bool Service { get; set; }

        public void Washing()
        {
            Console.WriteLine("Моем моем чисто чисто");
        }
    }

    public interface IBoxFactory
    {
        IBox CreateBox();
    }

    public class BoxAFactory : IBoxFactory
    {
        public IBox CreateBox()
        {
            return new BoxA();
        }
    }

    public class BoxBFactory : IBoxFactory
    {
        public IBox CreateBox()
        {
            return new BoxB();

        }
    }

}
