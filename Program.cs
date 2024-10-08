using System;

class Program {
    public static void Main(string[] args) {

        Console.Clear();
        Console.WriteLine("What is your full name?");
        string name = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("How old are you?");
        int age = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("What is your eye color");
        string eyeColor = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("What is your hair color?");
        string hairColor = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("What is your shoe size?");
        float shoeSize = float.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("What is your favorite color?");
        string favColor = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("What is your favorite TV show/movie?");
        string favFilm = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Who is your favorite teacher?");
        string favTeacher = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("What is your favorite class?");
        string favClass = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("What is your favorite holiday?");
        string favHoliday = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("What is your favorite season?");
        string favSeason = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("What is your dream job?");
        string dreamJob = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("How many siblings do you have?");
        int numOfSiblings = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine($"My friend's name is {name}. {name} is {age} years old. {name}'s eye color is {eyeColor} and their hair color is {hairColor}. {name}'s shoe size is {shoeSize}. {name}'s favourite color is {favColor}, favourite movie/TV show is {favFilm}, favourite teacher is {favTeacher}, favourite class is {favClass}, favourite holiday is {favHoliday}, and favourite season is {favSeason}. Their dream job is {dreamJob}. In 5 years, they will be {age + 5} years old. {name} has {numOfSiblings} siblings.");

    }
}