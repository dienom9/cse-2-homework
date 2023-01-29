using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.Display();
        Journal journal = new Journal();
        //journal.Display();


        System.Console.WriteLine("-- What would you like to do --");
        System.Console.WriteLine("1) Write a new entry");        
        System.Console.WriteLine("2) Edit an old entry");        
        System.Console.WriteLine("3) View an entry");        
        System.Console.WriteLine("4) Display Writing Prompts");        
        System.Console.WriteLine("5) End Program");
        string answer = Console.ReadLine();
        int AnswerInt;
        AnswerInt = Convert.ToInt32(answer);
        //Thank you to Arjun Thaker
        //System.Console.WriteLine(answer);
        if (AnswerInt == 1)
            System.Console.WriteLine("bruh");
        if (AnswerInt == 2)
            System.Console.WriteLine("HURRAY");
        if (AnswerInt == 3)
            journal.Display();
        if (AnswerInt == 4)
            System.Console.WriteLine("AAAAAAAAAAAAAAAAA");
        if (AnswerInt == 5)
            System.Environment.Exit(0);
        if (AnswerInt <= 0)
            System.Console.WriteLine("BARK BARK");
        if (AnswerInt >= 5)
            System.Console.WriteLine("BARK BARK");



        //Journal journal = new Journal();
        //journal.Display();
        



    }

}





class Menu
{
    public void Display()
    {
        System.Console.WriteLine("-- What would you like to do --");
        System.Console.WriteLine("1) Write a new entry");        
        System.Console.WriteLine("2) Edit an old entry");        
        System.Console.WriteLine("3) View an entry");        
        System.Console.WriteLine("4) End Program");        
        System.Console.WriteLine("--------------------------------");
        string answer = Console.ReadLine();
        int AnswerInt;
        AnswerInt = Convert.ToInt32(answer);
        //Thank you to Arjun Thaker
        //System.Console.WriteLine(answer);
        if (AnswerInt == 1)
            System.Console.WriteLine("bruh");
        if (AnswerInt == 2)
            System.Console.WriteLine("HURRAY");
        if (AnswerInt == 3)
            System.Console.WriteLine("gwa");
        if (AnswerInt == 4)
            System.Environment.Exit(0);
        if (AnswerInt <= 0)
            System.Console.WriteLine("BARK BARK");
        if (AnswerInt >= 5)
            System.Console.WriteLine("BARK BARK");


    }
}

class Journal
{
    public void Display()
    {
        string text = System.IO.File.ReadAllText(@"C:\Users\dieno\Downloads\Code\cse-2-homework\prove\Develop02\bruh.txt");

        
        System.Console.WriteLine("Contents of bruh.txt = {0}", text);

        
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\dieno\Downloads\Code\cse-2-homework\prove\Develop02\greg.txt");

        
        System.Console.WriteLine("Contents of greg.txt = ");
        foreach (string line in lines)
        {
            
            Console.WriteLine("\t" + line);
        }

        
        Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }
}
//Thank you to BillWagner, nschonni, jdmartinez36, gewarren, mairaw, Youssef1313, nemrism, yishengjin1413, nxtn, mjhoffman65, mikeblome, guardrex 
//for providing me with code to run a txt file


