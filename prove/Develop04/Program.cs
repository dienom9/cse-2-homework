using System;
using System.Threading;
using System.Diagnostics;
using System.Timers;
class Program 
{

    static void Main(string[] args)
    {
        
        Console.Clear();
        System.Console.WriteLine("Welcome to our relaxation program");
        Thread.Sleep(5000);
        Menu menu = new Menu();
        
        
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
        System.Console.WriteLine("4.) Close Program");
        System.Console.WriteLine("Please enter the number for which activity you would like to do");
        string activity = Console.ReadLine();
        Breathing breathing = new Breathing();
        Reflection reflection = new Reflection();
        List listing = new List();
        Menu menu = new Menu();

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
        if (activity == "4")
            {
                Console.Clear();
                Console.Write("Thank you for participating!");
            }

        else
            {
                Console.Write("Try using another input!");
                Console.Clear();
                menu.Display();
            }
    }
}
   
    




class Breathing 
{
    public void Breathe()
    {
        
        System.Console.WriteLine("How long in seconds would you like to do this activity");
        string durated = Console.ReadLine();
        int duration = Convert.ToInt32(durated);
        Menu menu = new Menu();
        Console.Clear();
        System.Console.WriteLine("Get ready, the activity will start in 5 seconds");
        Thread.Sleep(5000);
        //System.System.Console.WriteLine("Thank you for participating!");
        int countdown = 6;
        while (duration >= 0)
        {
        
            while (countdown != 1)
            {
                Console.Clear();
                Console.Write("Breathe in " + --countdown);
                
                Thread.Sleep(1000);
                --duration;
                if (duration <= 0)
                {
                    Console.Clear();
                    Console.Write("Thank you for participating!");
                    Thread.Sleep(5000);
                    Console.Clear();
                    menu.Display();

                }
            }
            
            
            
            ++countdown;
            ++countdown;
            ++countdown;
            ++countdown;
            ++countdown;
            while (countdown != 1)
            {
                Console.Clear();
                Console.Write("Breathe out " + --countdown);
                
                Thread.Sleep(1000);
                --duration;
                
                if (duration <= 0)
                {
                    
                    Console.Write("Thank you for participating!");
                    Thread.Sleep(5000);
                    Console.Clear();
                    menu.Display();
                    
                }
            }

            ++countdown;
            ++countdown;
            ++countdown;
            ++countdown;
            ++countdown;
            
        }
        Console.Clear();
        Console.Write("Thank you for participating!");
        menu.Display();
    }

}

class List
{
    public void Listing()
    {
        System.Console.WriteLine("How long in seconds would you like to do this activity");
        string durated = Console.ReadLine();
        int duration = Convert.ToInt32(durated);
        Menu menu = new Menu();
        
        Console.Clear();
        System.Console.WriteLine("Get ready, the activity will start in 5 seconds");
        Thread.Sleep(5000);
        Console.Clear();
        Random rnd = new Random();
        int rand = rnd.Next(5);
        int grub = 0;
        if (rand == 0)
        {
            Console.Clear();
            Console.Write("Who are some people you appreciate?");
            Console.WriteLine("");
            while (duration >= 0)
            {
                Console.ReadLine();
                --duration;
                ++grub;
            }
            Console.Clear();
            Console.WriteLine("You wrote " + grub + " things!");
            System.Console.WriteLine("Thank you for participating!");
            Console.Clear();
            Thread.Sleep(5000);
        }
        if (rand == 1)
        {
            Console.Clear();
            Console.Write("What are personal strengths of yours?");
            Console.WriteLine("");
            while (duration >= 0)
            {
                Console.ReadLine();
                --duration;
                ++grub;
            }
            Console.Clear();
            Console.WriteLine("You wrote " + grub + " things!");
            System.Console.WriteLine("Thank you for participating!");
            Thread.Sleep(5000);
            Console.Clear();
            menu.Display();
        }
        if (rand == 2)
        {
            Console.Clear();
            Console.Write("Who are people you have helped this week?");
            Console.WriteLine("");
            while (duration >= 0)
            {
                Console.ReadLine();
                --duration;
                ++grub;
            }
            Console.Clear();
            Console.WriteLine("You wrote " + grub + " things!");
            System.Console.WriteLine("Thank you for participating!");
            Thread.Sleep(5000);
            Console.Clear();
            menu.Display();

        }
        if (rand == 3)
        {
            Console.Clear();
            Console.Write("When have you felt the holy ghost this month?");
            Console.WriteLine("");
            while (duration >= 0)
            {
                Console.ReadLine();
                --duration;
                ++grub;
            }
            Console.Clear();
            Console.Write("You wrote " + grub + " things!");
            System.Console.WriteLine("Thank you for participating!");
            Thread.Sleep(5000);
            Console.Clear();
            menu.Display();
        }
        if (rand == 4)
        {
            Console.Clear();
            Console.Write("Who are some of your personal heroes?");
            Console.WriteLine("");
            while (duration >= 0)
            {
                Console.ReadLine();
                --duration;
                ++grub;
            }
            Console.Clear();
            Console.Write("You wrote " + grub + " things!");
            System.Console.WriteLine("Thank you for participating!");
            Thread.Sleep(5000);
            Console.Clear();
            menu.Display();
        }
    }
}


class Reflection
{
    public void ReflectionActivity()
    {

        System.Console.WriteLine("How long in seconds would you like to do this activity");
        string durated = Console.ReadLine();
        int duration = Convert.ToInt32(durated);
        Menu menu = new Menu();
        
        Console.Clear();
        System.Console.WriteLine("Get ready, the activity will start in 5 seconds");
        Thread.Sleep(5000);
        Console.Clear();
        Random rnd = new Random();
        int rand = rnd.Next(4);
        int bruh = 10;
        if (rand == 0)
        {
            Console.Write("Think of a time when you stood up for someone else.");
            
            
            while (bruh >= 0)
            {
            Thread.Sleep(1000);
            --duration;
            --bruh;
            if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
            }
            while (bruh <= 10)
            {
                ++bruh;
            }
            while (duration >= 0)
            {
                Console.Clear();
                Console.Write("Was this experience meaningful to you");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                    while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("Have you ever done anything like this before?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("How did you get started?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                
            }
            while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("How did you feel when it was complete?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("What made this time different than other times when you were not as successful?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("What is your favorite thing about this experience?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("What could you learn from this experience?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("What could you learn about yourself from this experience?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("How could you keep this experience in mind in the future?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
        }
            }
        
        if (rand == 1)
        {
            Console.Clear();
            Console.Write("Think of a time when you did something really difficult.");
            
            while (bruh >= 0)
            {
            Thread.Sleep(1000);
            --duration;
            --bruh;
            if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
            }
            while (bruh <= 10)
            {
                ++bruh;
            }
            while (duration >= 0)
            {
                Console.Clear();
                Console.Write("Was this experience meaningful to you");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
            }
                    while (bruh <= 10)
                
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("Have you ever done anything like this before?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("How did you get started?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                
                }
            while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("How did you feel when it was complete?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("What made this time different than other times when you were not as successful?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("What is your favorite thing about this experience?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("What could you learn from this experience?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("What could you learn about yourself from this experience?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("How could you keep this experience in mind in the future?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }


                }
        
        if (rand == 2)
        {
            Console.Clear();
            Console.Write("Think of a time when you helped someone in need.");
            
            while (bruh >= 0)
            {
            Thread.Sleep(1000);
            --duration;
            --bruh;
            if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
            }
            while (bruh <= 10)
            {
                ++bruh;
            }
            while (duration >= 0)
            {
                Console.Clear();
                Console.Write("Was this experience meaningful to you");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                    while (bruh <= 10)
                
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("Have you ever done anything like this before?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("How did you get started?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                
            }
            while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("How did you feel when it was complete?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("What made this time different than other times when you were not as successful?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("What is your favorite thing about this experience?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("What could you learn from this experience?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("What could you learn about yourself from this experience?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("How could you keep this experience in mind in the future?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                }

        }
        if (rand == 3)
        {
            Console.Clear();
            Console.Write("Think of a time when you did something truly selfless.");
            while (bruh >= 0)
            {
            Thread.Sleep(1000);
            --duration;
            --bruh;
            if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
            }
            while (bruh <= 10)
            {
                ++bruh;
            }
            while (duration >= 0)
            {
                Console.Clear();
                Console.Write("Was this experience meaningful to you");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                    while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("Have you ever done anything like this before?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("How did you get started?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                
            }
            while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("How did you feel when it was complete?");
                while (bruh >=0)
                {
                    
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("What made this time different than other times when you were not as successful?");
                while (bruh >=0)
                {
                    
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("What is your favorite thing about this experience?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("What could you learn from this experience?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("What could you learn about yourself from this experience?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                while (bruh <= 10)
            {
                ++bruh;
            }
            Console.Clear();
                Console.Write("How could you keep this experience in mind in the future?");
                while (bruh >=0)
                {
                    Thread.Sleep(1000);
                    --duration;
                    --bruh;
                    if (duration <= 0)
                    {
                        Console.Clear();
                        Console.Write("Thank you for participating");
                        Thread.Sleep(5000);
                        Console.Clear();
                        menu.Display();
                    }
                }
                }
        }
    }
}       
        
        
