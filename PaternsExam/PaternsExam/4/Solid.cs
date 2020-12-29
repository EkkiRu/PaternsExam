using System;
using System.Collections.Generic;
using System.Text;

namespace PaternsExam._4
{
    /*SOLID. Есть такие сущности автомобилей: 
	Автомобиль - базовая сущность
		Легковые
			Минивэны
			Джипы
			Седаны
		Грузовые
		Автобусы
	Эти сущности должны иметь методы, 
	отображающие свою марку авто, 
	стоимость и цвет. Также иметь 
	такие методы как Drive(ездить), 
	Repair(ремонтироваться - на СТО 
	или самостоятельно или у официалов)
	
	Создать правильное наследование 
	и реализацию методов, согласно 
	принципам SOLID. */

    public abstract class Car
    {
        string Brand { get; set; }
        double Cost { get; set; }
        string Colour { get; set; }
    }

    public interface ICar
    {
        void Drive();
        void Repair();
    }

    public class Minivans : Car, ICar
    {
        public string Brand { get; set; }
        public double Cost { get; set; }
        public string Colour { get; set; }

        public void Drive()
        {
            Console.WriteLine("Издает звук характерной минивену");
        }

        public void Repair()
        {
            Console.WriteLine("Использвует только авторский автодилер");
        }
    }

    public class Jeeps : Car, ICar
    {
        public string Brand { get; set; }
        public double Cost { get; set; }
        public string Colour { get; set; }

        public void Drive()
        {
            Console.WriteLine("Издает звук характерной джипу");
        }

        public void Repair()
        {
            Console.WriteLine("Использвует только авторский автодилер");
        }
    }


    public class Sedans : Car, ICar
    {
        public string Brand { get; set; }
        public double Cost { get; set; }
        public string Colour { get; set; }

        public void Drive()
        {
            Console.WriteLine("Издает звук характерной сидану");
        }

        public void Repair()
        {
            Console.WriteLine("Использвует только авторский автодилер");
        }
    }


    public class Freight : Car, ICar
    {
        public string Brand { get; set; }
        public double Cost { get; set; }
        public string Colour { get; set; }

        public void Drive()
        {
            Console.WriteLine("Издает звук характерной грузовым");
        }

        public void Repair()
        {
            Console.WriteLine("Чинится только сам");
        }
    }
    public class Buses : Car, ICar
    {

        public string Brand { get; set; }
        public double Cost { get; set; }
        public string Colour { get; set; }

        public void Drive()
        {
            Console.WriteLine("Издает звук характерный автобусам");
        }

        public void Repair()
        {
            Console.WriteLine("Чинится у официалов");
        }
    }



}
