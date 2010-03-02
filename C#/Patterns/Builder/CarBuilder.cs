
class Car
{
    public string Name { get; set; }
    public string Engine { get; set; }
    public string Shape { get; set; }
}

abstract class CarBuilder
{
    public Car Car { get; private set; }

    public CarBuilder()
    {
        Car = new Car();
    }

    public abstract void BuildName();
    public abstract void BuildEngine();
    public abstract void BuildShape();
}

class OpelBuilder : CarBuilder
{

    public override void BuildName()
    {
        Car.Name = "Opel Corsa";
    }

    public override void BuildEngine()
    {
        Car.Engine = "CDTI 1.3";
    }

    public override void BuildShape()
    {
        Car.Shape = "Berlina";
    }
}
//Director
class CarFactory
{
    
    public CarBuilder Builder { get; set; }

    public Car Car { get { return Builder.Car; } }

    public void BuildCar()
    {
        Builder.BuildName();
        Builder.BuildEngine();
        Builder.BuildShape();
    }
}