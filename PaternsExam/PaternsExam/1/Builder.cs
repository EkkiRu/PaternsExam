using System;
using System.Collections.Generic;
using System.Text;

namespace PaternsExam._1
{
    /*1. Вы автоматизируете работу цеха по 
     * производству пельменей
Видов пельменей пока 3 
    (купеческие, баварские, студенческие), 
    но все они состоят из 
	мяса
	теста
	соли
	специи
Нужно учесть, что количество видов пельменей 
    может со временем увеличиться и ингридиентов 
    тоже*/
    public class Bavarian : DumplingBuilder
    {
        public override void AddDough()
        {
            Sculpting.Dough = new Dough() { Name = "Золотое тесто" };
        }

        public override void AddMeat()
        {
            Sculpting.Meat = new Meat() { Name = "Золотое мясо" };
        }

        public override void AddSalt()
        {
            Sculpting.Salt = new Salt() { Name = "Золотая соль" };
        }

        public override void AddSpice()
        {
            Sculpting.Spice = new Spice() { Name = "Золотые специи" };
        }
    }

    public class student : DumplingBuilder
    {
        public override void AddDough()
        {
            Sculpting.Dough = new Dough() { Name = "Обычное тесто" };
        }

        public override void AddMeat()
        {
            Sculpting.Meat = new Meat() { Name = "Обычное мясо" };
        }

        public override void AddSalt()
        {
            Sculpting.Salt = new Salt() { Name = "Обычная соль" };
        }

        public override void AddSpice()
        {
            Sculpting.Spice = new Spice() { Name = "Обычные специи" };
        }
    }

    public class Merchant : DumplingBuilder
    {
        public override void AddDough()
        {
            Sculpting.Dough = new Dough() { Name = "Алмазное тесто" };
        }

        public override void AddMeat()
        {
            Sculpting.Meat = new Meat() { Name = "Алмазное мясо" };
        }

        public override void AddSalt()
        {
            Sculpting.Salt = new Salt() { Name = "Алмазная соль" };
        }

        public override void AddSpice()
        {
            Sculpting.Spice = new Spice() { Name = "Алмазные специи" };
        }
    }

    public class Cook
    {
        public Sculpting Make(DumplingBuilder dumplingBuilder)
        {
            dumplingBuilder.CreateSculpting();
            dumplingBuilder.AddDough();
            dumplingBuilder.AddMeat();
            dumplingBuilder.AddSalt();
            dumplingBuilder.AddSpice();
            return dumplingBuilder.Sculpting;
        }
    }

    public abstract class DumplingBuilder : Cook
    {
        public Sculpting Sculpting { get; set; }
        public void CreateSculpting()
        {
            Sculpting = new Sculpting();
        }
        public abstract void AddMeat();
        public abstract void AddDough();
        public abstract void AddSalt();
        public abstract void AddSpice();

    }

    public class Sculpting
    {
        public Meat Meat { get; set; }
        public Dough Dough { get; set; }
        public Salt Salt { get; set; }
        public Spice Spice { get; set; }

        public override string ToString()
        {
            return $"Meat:{Meat.Name}\n Dough:{Dough.Name}\n Salt:{Salt.Name}\n Spice:{Spice.Name}\n";
        }
    }

    public class Meat
    {
        public string Name { get; set; }
    }

    public class Dough
    {
        public string Name { get; set; }
    }
    
    public class Salt
    {
        public string Name { get; set; }
    }

    public class Spice
    {
        public string Name { get; set; }
    }

}
