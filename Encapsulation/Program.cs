namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var newPerson = new Person(45, "Lasse", "Kongo");

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

            var userErrors = new List<UserError>()
            {
                new TextInputError(),
                new NumericInputError(),
                new EmptyInputError(),
                new FloatInputError(),
                new NonBoolInputError()
            };

            foreach (var error in userErrors) Console.WriteLine(error.UEMessage());
            
            Console.ReadLine();
        }
    }

    public class Person
    {
        private int age;
        private string? fName; //We validate the string in the public property so that it can't return null.
        private string? lName; //We validate the string in the public property so that it can't return null.
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set 
            { 
                if (value > 0) age = value;
                else throw new ArgumentException("Age needs to greater than 0.");
            }
        }

        public string FName
        {
            get 
            { 
                //Removes possibility of null return even though it shouldn't be possible for it to be null anyway,
                //since we check it when set.
                if (string.IsNullOrEmpty(fName)) throw new ArgumentException("FName is null or empty."); 
                else return fName;
            }

            set
            {
                if (value.Length >= 2 || value.Length <= 10) fName = value;
                else throw new ArgumentException("FName needs to be between 2 and 10 characters.");
            }
        }

        public string LName
        {
            // Removes warning instead of checking for null like we did in the FName property.
#pragma warning disable CS8603 // Possible null reference return.
            get { return lName; }
#pragma warning restore CS8603 // Possible null reference return.
            set
            {
                if (value.Length >= 3 || value.Length <= 15) lName = value;
                else throw new ArgumentException("LName needs to be between 3 and 15 characters.");
            }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        //public Person(int age, string fName, string lName, double height = 0, double weight = 0)
        //{
        //    Age = age;
        //    FName = fName;
        //    LName = lName;
        //    Height = height;
        //    Weight = weight;
        //}
    }

    public class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetFName(Person pers, string fName)
        {
            pers.FName = fName;
        }

        public void SetLName(Person pers, string lName)
        {
            pers.LName = lName;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public Person CreatePerson(int age, string fName, string lName, double height = 0, double weight = 0)
        {
            var pers = new Person();
            SetAge(pers, age);
            SetFName(pers, fName);
            SetLName(pers, lName);
            SetHeight(pers, height);
            SetWeight(pers, weight);
            return pers;
        }

    }

    public abstract class UserError
    {
        public abstract string UEMessage();
    }

    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    public class EmptyInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to input an empty value in a field that needed a value. This fired an error!";
        }
    }

    public class FloatInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a floating point value in an integer only field. This fired an error!";
        }
    }

    public class NonBoolInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to input a non-boolean value in a boolean only field. This fired an error!";
        }
    }
}