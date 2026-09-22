namespace Topic_5._1___Simple_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int people = 20, cats = 20, dogs = 15, age = 0;
            string dinosaur, magicWord;
            /*
            Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats: " + cats);
            if (people < cats)
            {
                Console.WriteLine("Too many cats! The world is doomed!");
            }
            if (people > cats)
            {
                Console.WriteLine("Not many cats! The world is saved!");
            }
            if (people < dogs)
            {
                Console.WriteLine("The world is drooled on!");
            }
            if (people > dogs)
            {
                Console.WriteLine("The world is dry!");
            }
            Console.WriteLine("Press ENTER to continue. ");
            Console.ReadLine();
            Console.Clear();
            dogs += 5; // Add 5 to dogs. What does dogs equal now?
            Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats: " + cats);
            if (people >= dogs)
            { 
                Console.WriteLine("People are greater than or equal to dogs.");
            }
            if (people <= dogs)
            {
                Console.WriteLine("People are less than or equal to dogs.");
            }
            if (people == dogs)
            {
                Console.WriteLine("People are dogs.");
            }
            //What the if statement does to the code below it is that it runs it if the statement after the if is true
            //The squiggly brackets are to connect if statements
            Console.WriteLine("");
            Console.WriteLine("What famous dinosaur has three large horns?");
            dinosaur = Console.ReadLine();
            if (dinosaur.ToLower() == "triceratops")
                Console.WriteLine("You are correct!");
            */
            Console.WriteLine("");
            Console.WriteLine("What's the magic word?");
            magicWord = Console.ReadLine();
            if (magicWord.ToLower() == "please")
            {
               Console.WriteLine("That's the magic word!");
            }
            Console.WriteLine("");
            Console.WriteLine("How old are you?");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));
            if (age < 16)
            {
                Console.WriteLine("You can't drive.");
            }
            if (age < 18)
            {
                Console.WriteLine("You can't vote.");
            }
            if (age < 25)
            {
                Console.WriteLine("You can't rent a car.");
            }
            if (age > 25)
            {
                Console.WriteLine("You can do anything that is legal!");
            }




        }
    }
}
