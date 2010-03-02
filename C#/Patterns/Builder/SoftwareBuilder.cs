class Software
{
    public string Name { get; set; }
    public string GraphicalInterface { get; set; }
    public string Database { get; set; }
    public string BuisnessLogic { get; set; }
}


abstract class SoftwareBuilder
{
    public Software Software { get; private set; }

    public SoftwareBuilder()
    {
        Software = new Software();
    }

    public abstract void BuildName();
    public abstract void BuildGraphicalInterface();
    public abstract void BuildDatabase();
    public abstract void BuildBusinessLogic();
}


class WinformsSoftwareBuilder : SoftwareBuilder
{

    public override void BuildName()
    {
        Software.Name = "Reporting  app";
    }

    public override void BuildGraphicalInterface()
    {
        Software.GraphicalInterface = "Winforms, ClickOnce";
    }

    public override void BuildDatabase()
    {
        Software.Database = "SQL Server 2005";
    }

    public override void BuildBusinessLogic()
    {
        Software.BuisnessLogic = "Complex";
    }
}


class WebSoftwareBuilder : SoftwareBuilder
{

    public override void BuildName()
    {
        Software.Name = "MX  app";
    }

    public override void BuildGraphicalInterface()
    {
        Software.GraphicalInterface = "Asp NET MVC";
    }

    public override void BuildDatabase()
    {
        Software.Database = "SQL Server 2008";
    }

    public override void BuildBusinessLogic()
    {
        Software.BuisnessLogic = "Data entry only";
    }
}


//director
class Programmer
{
    public SoftwareBuilder Builder { get; set; }
    public Software Software { get { return Builder.Software; } }

    public void BuildSoftware()
    {
        Builder.BuildName();
        Builder.BuildDatabase();
        Builder.BuildBusinessLogic();
        Builder.BuildGraphicalInterface();
    }
}