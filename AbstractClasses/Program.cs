class AbstractClasses
{
    static void Main(string[] args)
    {
        // abstract classes = modifier that indicates missing components or incomplete implementation

        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();

        Console.ReadKey();
    }

    abstract class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
        public int maxSpeed = 500;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
        public int maxSpeed = 25;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
        public int maxSpeed = 300;
    }
}