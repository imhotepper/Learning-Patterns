


class Pizza
{
    public string Denumire { get; set; }
    public string Compozitie { get; set; }
    public string Blat { get; set; }
}


abstract class PizzaBuilder
{
    public Pizza Pizza { get;protected set; }


    public PizzaBuilder()
    {
        Pizza = new Pizza();
    }

    public abstract void BuildDenumire();
    public abstract void BuildCompozitie();
    public abstract void BuildBlat();
}

class DiavoloPizzaBuilder : PizzaBuilder
{

    public override void BuildDenumire()
    {
        Pizza.Denumire = "Pizza Diavolo";
    }

    public override void BuildCompozitie()
    {
        Pizza.Compozitie = "Ceva extrem de picant";
    }

    public override void BuildBlat()
    {
        Pizza.Blat = "Super subtire";
    }
}

class HawaiianPizzaBuilder : PizzaBuilder
{

    public override void BuildDenumire()
    {
        Pizza.Denumire = "Pizza Hawaiian-a";
    }

    public override void BuildCompozitie()
    {
        Pizza.Compozitie = "Ananas si restul de componente";
    }

    public override void BuildBlat()
    {
        Pizza.Blat = "Blat normal";
    }
}

class Cook
{
    public PizzaBuilder Builder { get; set; }

    public Pizza Pizza { get { return Builder.Pizza; } }

    public void BuildPizza()
    {
        Builder.BuildDenumire();
        Builder.BuildBlat();
        Builder.BuildCompozitie();
    }
}