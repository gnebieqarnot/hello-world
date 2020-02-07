using System;

namespace helloWorld
{
    public class PrintName
    {
	public string GetHelloName(string name)
	{
	    return "Hello " + name;
	}

	public void PrintHelloName(string name)
	{
	    Console.WriteLine(GetHelloName(name));
	}
    }

    class Program
    {
        static void Main(string[] args)
        {
	    var print = new PrintName();
            Console.WriteLine("Hello World!");
	    foreach(string arg in args)
	    {
		print.PrintHelloName(arg);
	    }
        }
    }
}
