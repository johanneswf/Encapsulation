using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal abstract class Animal
    {
        // If all animals need a property we put it here.
        public string Name { get; set; } = string.Empty;
        public double Weight { get; set; }
        public int Age { get; set; }

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public abstract void DoSound();

        //We will pass this overridable method to the methods of its subclasses.
        public virtual string Stats()
        {
            return 
                $"Type: {GetType().Name}\n" +
                $"Name: {Name}\n" +
                $"Weight: {Weight}\n" +
                $"Age: {Age}";
        }

        public virtual string WillWork() => string.Empty;


    }

    internal class Horse : Animal
    {
        public bool IsRidable { get; set; }
        
        public Horse(string name, double weight, int age, bool isRidable) : base(name, weight, age)
        {
            IsRidable = isRidable;
        }

        public override void DoSound()
        {
            Console.WriteLine("The horse neighs.");
        }

        public override string Stats()
        {
            //Here we pass the method from the base class to output both base class
            //and subclass methods. The same applies for subsequent subclasses.
            return 
                $"{base.Stats()}\n" +
                $"Ridable: {IsRidable}";
        }
    }

    internal class Dog : Animal
    {
        public bool IsTrained { get; set; }

        public Dog(string name, double weight, int age, bool isTrained) : base(name, weight, age)
        {
            IsTrained = isTrained;
        }

        public override void DoSound()
        {
            Console.WriteLine("The dog barks.");
        }
        public override string Stats()
        {
            return 
                $"{base.Stats()}\n" +
                $"Trained: {IsTrained}";
        }

        //We can't access this method from the Animal list because the Animal class
        //lacks an implementation for it. We could create an overridable method in
        //the Animal class and override it here to make it work.
        public string WontWork() => "This won't work.";

        public override string WillWork() => "This will work. (Dog method test)";
    }

    internal class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }

        public Hedgehog(string name, double weight, int age, int numberOfSpikes) : base(name, weight, age)
        {
            NumberOfSpikes = numberOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("The hedgehog sqeaks.");
        }
        public override string Stats()
        {
            return
                $"{base.Stats()}\n" +
                $"Spikes: {NumberOfSpikes}";
        }
    }

    internal class Worm : Animal
    {
        public Worm(string name, double weight, int age, double length) : base(name, weight, age)
        {
            Length = length;
        }

        public double Length { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The worm grunts.");
        }
        public override string Stats()
        {
            return 
                $"{base.Stats()}\n" +
                $"Length: {Length}";
        }
    }

    internal class Bird : Animal
    {
        public Bird(string name, double weight, int age, double wingSpan) : base(name, weight, age)
        {
                WingSpan = wingSpan;
        }

        // If all birds need a property we put it here.
        public double WingSpan { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The bird chirps.");
        }
        public override string Stats()
        {
            return 
                $"{base.Stats()}\n" +
                $"Wingspan: {WingSpan}";
        }
    }

    internal class Wolf : Animal
    {
        public Wolf(string name, double weight, int age, bool isLoneWolf) : base(name, weight, age)
        {
            IsLoneWolf = isLoneWolf;
        }

        public bool IsLoneWolf { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The wolf howls.");
        }
        public override string Stats()
        {
            return 
                $"{base.Stats()}\n" +
                $"Lone wolf: {IsLoneWolf}";
        }
    }

    internal class Pelican : Bird
    {
        public Pelican(string name, double weight, int age, double wingSpan, double billLength) : base(name, weight, age, wingSpan)
        {
            BillLength = billLength;
        }

        public double BillLength { get; set; }
        public override string Stats()
        {
            return 
                $"{base.Stats()}\n" +
                $"Bill length: {BillLength}";
        }
    }

    internal class Flamingo : Bird
    {
        public Flamingo(string name, double weight, int age, double wingSpan, bool isStandingOnOneLeg) : base(name, weight, age, wingSpan)
        {
            IsStandingOnOneLeg = isStandingOnOneLeg;
        }

        public bool IsStandingOnOneLeg { get; set; }
    }

    internal class Swan : Bird
    {
        public Swan(string name, double weight, int age, double wingSpan, bool isSinging) : base(name, weight, age, wingSpan)
        {
            IsSinging = isSinging;
        }

        public bool IsSinging { get; set; }
    }

    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, bool isLoneWolf) : base(name, weight, age, isLoneWolf)
        {
        }

        //Overriding DoSound would make more sense here but we follow the instructions.
        public void Talk()
        {
            Console.WriteLine("The wolfman says \"rawr\".");
        }
    }
}
