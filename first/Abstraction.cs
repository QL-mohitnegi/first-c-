abstract class Vehicle
{
    protected int speed;
    public abstract void accelerate();
}

class Bike : Vehicle
{
    public Bike(int speed)
    {
        this.speed = speed;
    }
    public override void accelerate()
    {
        Console.WriteLine($"Bike running at a speed of {speed + 5}km/h");
    }
}
