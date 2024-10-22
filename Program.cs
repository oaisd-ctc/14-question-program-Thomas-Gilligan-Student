using System;

class Program {

    static String name;
    static String age;
    static String eyeColor;
    static String hairColor;
    static String shoeSize;
    static String favoriteColor;
    static String favoriteTVorMovie;
    static String favoriteTeacher;
    static String favoriteClass;
    static String favoriteHoliday;
    static String favoriteSeason;
    static String dreamJob;
    static String numberOfSiblings;
    static int ageIn5Years;

    public static void Main(string[] args) {

        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        CalculateAgeIn5Years(age);
        AskNumberOfSiblings();
        DisplaySummaryMessage();

    }

    public static void AskName(){
        Console.WriteLine("What is your full name?");
        name = Console.ReadLine() ?? "?";
    }

    public static void AskAge(){
        Console.WriteLine("How old are you?");
        age = Console.ReadLine() ?? "?";
    }

    public static void AskEyeColor(){
        Console.WriteLine("What is your eye color");
        eyeColor = Console.ReadLine() ?? "?";
    }

    public static void AskHairColor(){
        Console.WriteLine("What is your hair color?");
        hairColor = Console.ReadLine() ?? "?";
    }

    public static void AskShoeSize(){
        Console.WriteLine("What is your shoe size?");
        shoeSize = Console.ReadLine() ?? "?";
    }

    public static void AskFavoriteColor(){
        Console.WriteLine("What is your favorite color?");
        favoriteColor = Console.ReadLine() ?? "?";
    }

    public static void AskFavoriteTvShow(){
        Console.WriteLine("What is your favorite TV show/movie?");
        favoriteTVorMovie = Console.ReadLine() ?? "?";
    }

    public static void AskFavoriteTeacher(){
        Console.WriteLine("Who is your favorite teacher?");
        favoriteTeacher = Console.ReadLine() ?? "?";
    }

    public static void AskFavoriteClass(){
        Console.WriteLine("What is your favorite class?");
        favoriteClass = Console.ReadLine() ?? "?";
    }

    public static void AskFavoriteHoliday(){
        Console.WriteLine("What is your favorite holiday?");
        favoriteHoliday = Console.ReadLine() ?? "?";
    }

    public static void AskFavoriteSeason(){
        Console.WriteLine("What is your favorite season?");
        favoriteSeason = Console.ReadLine() ?? "?";
    }

    public static void AskDreamJob(){
        Console.WriteLine("What is your dream job?");
        dreamJob = Console.ReadLine() ?? "?";
    }

    public static void CalculateAgeIn5Years(String age){
        ageIn5Years = int.Parse(age) + 5;
        
    }

    public static void AskNumberOfSiblings(){
        Console.WriteLine("How many siblings do you have?");
        numberOfSiblings = Console.ReadLine() ?? "?";
    }

    public static void DisplaySummaryMessage(){
        Console.WriteLine($"My friend's name is {name}. {name} is {age} years old. {name}'s eye color is {eyeColor} and their hair color is {hairColor}. {name}'s shoe size is {shoeSize}. {name}'s favourite color is {favoriteColor}, favourite movie/TV show is {favoriteTVorMovie}, favourite teacher is {favoriteTeacher}, favourite class is {favoriteClass}, favourite holiday is {favoriteHoliday}, and favourite season is {favoriteSeason}. Their dream job is to be a(n) {dreamJob}. In 5 years, they will be {age + 5} years old. {name} has {numberOfSiblings} siblings.");
    }
}