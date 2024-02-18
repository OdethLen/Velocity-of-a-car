namespace Velocity_of_a_car
{
    class Program
    {
        static void Main(string[] args)
        {

            Car Car1= new Car();
            Car1.Time = 20;
            Car1.Distance = 10;
            Console.WriteLine("Distance:" + Car1.Distance);
            Console.WriteLine("Distance:" + Car1.Time);
            Console.WriteLine("The speed of the car is:" + Car1.GetSpeed()+" m/s");

        }
    }
}