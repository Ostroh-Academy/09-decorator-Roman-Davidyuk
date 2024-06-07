using System;

public interface ICar
{
    void Assemble();
}

public class BasicCar : ICar
{
    public void Assemble()
    {
        Console.WriteLine("Assembling basic car.");
    }
}

public class CarDecorator : ICar
{
    protected ICar _car;

    public CarDecorator(ICar car)
    {
        _car = car;
    }

    public virtual void Assemble()
    {
        _car.Assemble();
    }
}

public class SportsCar : CarDecorator
{
    public SportsCar(ICar car) : base(car)
    {
    }

    public override void Assemble()
    {
        base.Assemble();
        Console.WriteLine("Adding features of a sports car.");
    }
}

public class LuxuryCar : CarDecorator
{
    public LuxuryCar(ICar car) : base(car)
    {
    }

    public override void Assemble()
    {
        base.Assemble();
        Console.WriteLine("Adding features of a luxury car.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ICar basicCar = new BasicCar();
        ICar sportsCar = new SportsCar(basicCar);
        ICar luxurySportsCar = new LuxuryCar(sportsCar);
        luxurySportsCar.Assemble();
    }
}
