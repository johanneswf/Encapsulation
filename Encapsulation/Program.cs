namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TryCatch();
            //UserErrors();
            //WolfMan();
            AnimalList();
            //DogList();
            Console.ReadLine();
        }

        static void TryCatch()
        {
            try
            {
                var pers = new PersonHandler().CreatePerson(45, "Lasse", "Kongo", 200, 100);
                Console.WriteLine(
                    $"Name: {pers.FName} {pers.LName}\n" +
                    $"Age: {pers.Age}\n" +
                    $"Height: {pers.Height}cm\n" +
                    $"Weight: {pers.Weight}kg");
            }
            catch (ArgumentException e) { Console.WriteLine(e.Message); }
        }

        static void UserErrors()
        {
            var userErrors = new List<UserError>()
            {
                new TextInputError(),
                new NumericInputError(),
                new EmptyInputError(),
                new FloatInputError(),
                new NonBoolInputError()
            };

            foreach (var error in userErrors) Console.WriteLine(error.UEMessage());
        }

        static void WolfMan()
        {
            var wolfMan = new Wolfman("Hels", 92, 43, true);
            wolfMan.Talk();
        }

        static void AnimalList()
        {
            var animalList = new List<Animal>()
            {
                new Horse("Leif", 500, 15, true),
                new Pelican("Pelle", 15, 8, 200, 30),
                new Dog("Ieur", 34, 3, true),
                new Wolfman("Hels", 92, 43, true)
            };

            Console.WriteLine("\n\tANIMALS\n");
            foreach (var animal in animalList)
            {
                //We make a loop that iterates through animalList
                //Console.WriteLine(animal.GetType().Name); Moved to Animal class.

                Console.WriteLine(animal.Stats()); //See comments in Animal class file.

                animal.DoSound();

                if (animal is IPerson)
                {
                    ((IPerson)animal).Talk();
                }

                if (animal is Dog)
                {
                    Console.WriteLine(animal.WillWork());
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n\tDOG STATS\n");
            foreach (var animal in animalList)
            {
                if (animal is Dog)
                {
                    Console.WriteLine(animal.Stats());
                }
            }

        }

        static void DogList()
        {
            var dogList = new List<Dog>()
            {
                new Dog("Fido", 42, 4, true),
                new Dog("Byrackan", 66, 15, false)
            };

            //dogList.Add(new Horse("Nope", 555, 11, false));

            //Can't add Horse to DogList as Horse is a different subclass.
            //Only Dog and its subclasses (none) can be put in DogList.
            //We need an Animal list.

        }

    }
}
