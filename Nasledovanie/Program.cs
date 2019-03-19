using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Id = 2;
            manager.Name = "Sasha";
            manager.Company = "Legrand";

            Console.WriteLine("Is = {0};\nName = {1};\nCompany = {2}", manager.Id, manager.Name, manager.Company);

            Car1 car = new Car1();
            car.Move();

            Team team1 = new Team();
            team1.teamName = "Сорес";

            //Ассоциация
            Player Alex = new Player();
            Alex.team = team1;

            Console.WriteLine("Алекс играет в команде {0}", Alex.team.teamName);
        }
    }
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Manager : User
    {
        public string Company { get; set; }
    }

    public interface IMovable
    {
        void Move();
    }
    public class Car1 : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Машина едет");
        }
    }

    //Ассоциация
    class Team
    {
        public string teamName { get; set; }
    }
    class Player
    {
        public Team team { get; set; }
    }

    //Композиция
    public class ElectricEngine { }
    public class Car
    {
        ElectricEngine engine;
        public Car()
        {
            engine = new ElectricEngine();
        }
    }
}
