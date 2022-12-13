using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Transport
        {
            protected double speed;
        }
        class Car: Transport
        {
            string model;

            public Car(double Speed, string Model)
            {
                this.speed = Speed;
                this.model = Model;
                Console.WriteLine($"Модель {model} движется с максимальной скоростью {speed}.");
            }
        }
        class Airplane: Transport
        {
            string model;
            
            public Airplane(double Speed, string Model)
            {
                this.speed = Speed;
                this.model = Model;
                Console.WriteLine($"Модель {model} движется с максимальной скоростью {speed}.");
            }
        }
        class Helicopter : Airplane
        {
            string model;

            public Helicopter(double speed, string Model)
            {
                base.speed = speed;
                this.model = Model;
                Console.WriteLine($"Модель {model} движется с максимальной скоростью {speed}.");
            }

        }
        public static void Main(string[] args)
        {
            //
            Car bmw = new Car(375.0, "BMW M6 G-Power Hurricane CS Ultimate");
            Car mercedes = new Car(318.0, "Mercedes");
            Airplane qwe = new Airplane(500.0, "йцу");
            Console.ReadKey();
        }
    }
}
