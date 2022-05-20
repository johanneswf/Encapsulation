namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TryCatch();
            //UserErrors();
            //WolfMan();
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
    }
}
