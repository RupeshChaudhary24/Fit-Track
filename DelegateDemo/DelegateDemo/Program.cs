using static System.Console;
public delegate void GreetingHandler(string name);
public class Greeting
{
    public static void Hello(string name)
    {
        WriteLine("Hello" + name);

    }
    public static void GoodBye(string name)
    {
        WriteLine("GoodBye," + name);

    }
    public static void Main()
    {
        GreetingHandler firstDel = new GreetingHandler(Hello);
        GreetingHandler secondDel = new GreetingHandler(GoodBye);
        GreetingHandler superDel=firstDel+secondDel;

        GreetMethod(firstDel, "Bob");
        GreetMethod(secondDel, "Alice");

        WriteLine("-----------");
        GreetMethod(superDel, "Giri");
    }
    public static void GreetMethod(GreetingHandler greetingHandler,string name)
    {
        WriteLine("The greeting is:");
            greetingHandler(name);
    }
}