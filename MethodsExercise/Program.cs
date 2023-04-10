namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Hi I am Zach, what is your name?");
            var UserName = Console.ReadLine();
            
        Console.WriteLine($"I see {UserName}, it's no Zach but still a nice name. What is your favorite animal?");
            var FavAnimal = Console.ReadLine();

            Console.WriteLine($"{FavAnimal}? I'm sorry but there was only one correct answser there but let \n" +
                $"us continue. What is your favorite color?");
            var FavColor = Console.ReadLine();

            Console.WriteLine($"Okay {FavColor} is a good choice, we finally agree on something! Now now, what \n" +
                $"is your favorite band?");
            var FavBand = Console.ReadLine();

            Console.WriteLine($"Oh boy, right when I was starting to like you... So your name is {UserName}, \n" +
                $"your favorite color is {FavColor}, sloths are your all time favorite animal, and your \n" +
                $"favorite band is {FavBand}. Is this correct?");
            var YesNo = Console.ReadLine();

            Console.WriteLine($"Okay! I'm glad to see that your favorite animal is a sloth!");





        }
    }
}
