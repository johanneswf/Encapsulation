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
            var wolfMan = new Wolfman();
            wolfMan.Talk();
        }

        static void AnimalList()
        {
            var newHorse = new Horse();
            newHorse.Name = "Leif";
            newHorse.Weight = 600;
            newHorse.Age = 15;
            newHorse.IsRidable = true;

            var newPelican = new Pelican();
            newPelican.Name = "Pelle";
            newPelican.Weight = 15;
            newPelican.Age = 8;
            newPelican.WingSpan = 280;
            newPelican.BillLength = 30;

            var newDog = new Dog();
            newDog.Name = "Ieur";
            newDog.Weight = 34;
            newDog.Age = 3;
            newDog.IsTrained = true;

            var newWolfman = new Wolfman();
            newWolfman.Name = "Hels";
            newWolfman.Weight = 92;
            newWolfman.Age = 43;
            newWolfman.IsLoneWolf = true;

            var animalList = new List<Animal>();
            animalList.Add(newHorse);
            animalList.Add(newPelican);
            animalList.Add(newDog);
            animalList.Add(newWolfman);

            Console.WriteLine("\n\tANIMALS\n");
            foreach (var animal in animalList)
            {
                //We make a loop that iterates through animalList
                Console.WriteLine(animal.GetType().Name);

                Console.WriteLine(animal.Stats()); //See comments in Animal class file.

                animal.DoSound();

                if (animal is IPerson)
                {
                    var ipanimal = (IPerson)animal;
                    ipanimal.Talk();
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
                if (animal.GetType() == typeof(Dog))
                {
                    Console.WriteLine(animal.Stats());
                }
            }

        }

        static void DogList()
        {
            var fido = new Dog();
            fido.Name = "Fido";
            fido.Weight = 25;
            fido.Age = 5;
            fido.IsTrained = true;

            var byrackan = new Dog();
            fido.Name = "Byrackan";
            fido.Weight = 66;
            fido.Age = 15;
            fido.IsTrained = false;

            var dogList = new List<Dog>();
            dogList.Add(fido);
            dogList.Add(byrackan);
            //dogList.Add(new Horse());
            //Can't add Horse to DogList as Horse is a different subclass.
            //Only Dog and its subclasses (none) can be put in DogList.
            //We need an Animal list.

        }

    }
}
