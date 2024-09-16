class Program
{
    static void Main()
    {
        IDE ide = new IDE();
        ide.Work();
    }
}


class IDE // OCP
{
    LangC c = new LangC();
    LangCSharp cs = new LangCSharp();
    LangJava java = new LangJava();

    public void Work() // DRY
    {
        Console.WriteLine(c.GetName());
        Console.WriteLine(c.GetUnit());
        Console.WriteLine(c.GetParadigm());
        Console.WriteLine("-----------------");
        Console.WriteLine(cs.GetName());
        Console.WriteLine(cs.GetUnit());
        Console.WriteLine(cs.GetParadigm());
        Console.WriteLine("-----------------");
        Console.WriteLine(java.GetName());
        Console.WriteLine(java.GetUnit());
        Console.WriteLine(java.GetParadigm());

    }
}
class LangCSharp
{
    public string GetName()
    {
        return "C# Language";
    }
    public string GetUnit()
    {
        return "Class";
    }
    public string GetParadigm()
    {
        return "Object Oriented";
    }
}
class LangJava
{
    public string GetName()
    {
        return "Java Language";
    }
    public string GetUnit()
    {
        return "Class";
    }
    public string GetParadigm()
    {
        return "Object Oriented";
    }
}
class LangC
{
    public string GetName()
    {
        return "C Language";
    }
    public string GetUnit()
    {
        return "Function";
    }
    public string GetParadigm()
    {
        return "Procedural Oriented";
    }
}