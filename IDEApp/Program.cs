﻿class Program
{
    static void Main()
    {
        IDE ide = new IDE();
        LangJava java = new LangJava();
        //ide.languages.Add(java);

        LangC langC = new LangC();
        ide.languages.Add(langC);

        LangCSharp langCSharp = new LangCSharp();
        ide.languages.Add(langCSharp);

        LangTypescript langTypescript = new LangTypescript();
        ide.languages.Add(langTypescript);

        ide.Work();
    }
}


interface ILanguage
{
    // What?
    string GetName();
    string GetUnit();
    string GetParadigm();
}

class IDE // OCP
{
    // n languages only
    public List<ILanguage> languages = new List<ILanguage>();


    // Program to contract/abstractions not to concreate classes
    // loose coupled and high cohesion

    //LangC c = new LangC();
    //LangCSharp cs = new LangCSharp();
    //LangJava java = new LangJava();

    public void Work() // DRY
    {
        foreach (ILanguage language in languages)
        {
            Console.WriteLine(language.GetName());
            Console.WriteLine(language.GetUnit());
            Console.WriteLine(language.GetParadigm());
            Console.WriteLine("-----------------");
        }

        //Console.WriteLine(cs.GetName());
        //Console.WriteLine(cs.GetUnit());
        //Console.WriteLine(cs.GetParadigm());
        //Console.WriteLine("-----------------");
        //Console.WriteLine(java.GetName());
        //Console.WriteLine(java.GetUnit());
        //Console.WriteLine(java.GetParadigm());

    }


}
class LangCSharp : ILanguage
{

    // How
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
class LangJava : ILanguage
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
class LangC : ILanguage
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
class LangTypescript : ILanguage
{
    public string GetName()
    {
        return "Typescript Language";
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
