using System;
using System.Threading;

class Program 
{
    static void Main(string[] args)
    {
        Console.Clear();
        System.Console.WriteLine("Welcome to our relaxtion program");
        Menu menu = new Menu();
        Breathing breathing = new Breathing();
        Reflection reflection = new Reflection();
        Listed listing = new Listed();
        
        
        menu.Display();
        
    }
}


class Menu
{
    public void Display()
    {
        System.Console.WriteLine("----------Menu----------");
        System.Console.WriteLine("1.) Breathing Exercise");
        System.Console.WriteLine("2.) Reflection Activity");
        System.Console.WriteLine("3.) Listing Activity");
        System.Console.WriteLine("Please enter the number for which activity you would like to do");
        string activity = Console.ReadLine();
        Breathing breathing = new Breathing();
        Reflection reflection = new Reflection();
        Listed listing = new Listed();
        
        if (activity == "1")
            {
                breathing.Breathe();
            }
        if (activity == "2")
            {
                reflection.ReflectionActivity();
            }

        if (activity == "3")
            {
                listing.Listing();
            }
        else
        {
            return;
        }
    }
}


class Breathing 
{
    public async void Breathe()
    {
        System.Console.WriteLine("How long in seconds would you like to do this activity");
        string durated = Console.ReadLine();
        int duration = Convert.ToInt32(durated);
        int trueDuration = duration * 1000;
        
        await Task.Delay(trueDuration);
        
        //Timer t = new Timer(, null, 0, 1000);
        //Console.ReadLine();
        System.Console.WriteLine("Thank you for participating!");
        
        string hoh = "0";
        while (hoh == "0")
        {
        Console.Clear();
        Console.Write("Breathe in 5");

        Thread.Sleep(1000);

        Console.Write("\b \b"); 
        Console.Write("4"); 

        Thread.Sleep(1000);

        Console.Write("\b \b"); 
        Console.Write("3"); 

        Thread.Sleep(1000);

        Console.Write("\b \b"); 
        Console.Write("2"); 

        Thread.Sleep(1000);

        Console.Write("\b \b"); 
        Console.Write("1"); 

        Thread.Sleep(1000);

        Console.Write("\b \b"); 
        Console.Write("0");
        Console.Clear();
        //await Task.Delay(trueDuration);
        
        //System.Console.WriteLine("Thank you for participating!");
        }
        
    }

}

class Reflection
{
    public void ReflectionActivity()
    {

    }
}

class Listed
{
    public void Listing()
    {

    }
}
