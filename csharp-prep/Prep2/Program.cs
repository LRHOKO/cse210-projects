using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);
       
        string letter = "";

        if (gradeInt >= 90)
        {
            letter = "A";
        } 
         else if (gradeInt >= 80)
        {
            letter = "B";
        } 
         else if (gradeInt >= 70)
        {
            letter = "C";
        } 
          else if (gradeInt >= 60)
        {
            letter = "D";
        } 
        else 
        {
            letter = "F";
        } 

        int lastDigit = Math.Abs(gradeInt) % 10;
        string  gradeModifiers = "";

        if (lastDigit >= 7 && letter != "A" && letter != "F")
        {
            gradeModifiers = "+";
        }

        else if (lastDigit < 3 && letter != "F")
        {
            gradeModifiers = "-";
        
        }

        Console.WriteLine($"Your grade is {letter}{gradeModifiers}");

        if (gradeInt >= 70)
        {
            Console.WriteLine("Congratulations!");
        }
        
        else 
        {
            Console.WriteLine("You'll do better next time.");
        }
    }
}