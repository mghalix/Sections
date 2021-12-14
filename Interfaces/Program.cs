using System;
using Testing;

namespace LearnInterfaces
{
    interface IAutomobile
    {
        string LicensePlate { get; }
        double Speed { get; }
        int Wheels { get; }
        void Honk();
    }
    class Sedan : IAutomobile
    {
        public string LicensePlate { get; }
        public double Speed { get; private set; }
        public int Wheels { get; }
        public void Honk()
        {
            Console.WriteLine("HONK!");
        }
        public Sedan(double speed)
        {
            this.Speed = speed;
            this.LicensePlate = Tools.GenerateLicensePlate();
            Wheels = 4;
        }
        public void SpeedUp()
        {
            Speed += 5;
        }
        public void SlowDown()
        {
            Speed -= 5;
        }
    }
    class Truck : IAutomobile
    {
        public string LicensePlate { get; }
        public double Speed { get; private set; }
        public int Wheels { get; }
        public double Weight { get; }
        public void Honk()
        {
            Console.WriteLine("HONK!");
        }
        public Truck(double speed, double weight)
        {
            this.Speed = speed;
            this.Weight = weight;
            this.LicensePlate = Tools.GenerateLicensePlate();
            if (Weight < 400)
                Wheels = 8;
            else
                Wheels = 12;
        }
        public void SpeedUp()
        {
            Speed += 5;
        }
        public void SlowDown()
        {
            Speed -= 5;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sedan s1 = new Sedan(60);
            Sedan s2 = new Sedan(70);
            Truck t = new Truck(45, 500);
            Console.WriteLine($"The First Sedan --->\tSpeed: {s1.Speed}/mph\tWheels: {s1.Wheels}\tLicensePlate: \"{s1.LicensePlate}\"");
            Console.WriteLine($"The Second Sedan --->\tSpeed: {s2.Speed}/mph\tWheels: {s2.Wheels}\tLicensePlate: \"{s2.LicensePlate}\"");
            Console.WriteLine($"The First Truck --->\tSpeed: {t.Speed}/mph\tWheels: {t.Wheels}\tLicensePlate: \"{t.LicensePlate}\"");

            Console.Read();
        }
    }

}
