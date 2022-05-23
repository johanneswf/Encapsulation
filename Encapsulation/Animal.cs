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

        public abstract void DoSound();

        //We will pass this overridable method to the methods of its subclasses.
        public virtual string Stats()
        {
            return 
                $"Name: \t{Name}\n" +
                $"Weight: \t{Weight}\n" +
                $"Age: \t{Age}";
        }

        public virtual string WillWork() => string.Empty;


    }

    internal class Horse : Animal
    {
        public bool IsRidable { get; set; }
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
                $"Ridable: \t{IsRidable}";
        }
    }

    internal class Dog : Animal
    {
        public bool IsTrained { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The dog barks.");
        }
        public override string Stats()
        {
            return 
                $"{base.Stats()}\n" +
                $"Trained: \t{IsTrained}";
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
        public override void DoSound()
        {
            Console.WriteLine("The hedgehog sqeaks.");
        }
        public override string Stats()
        {
            return
                $"{base.Stats()}\n" +
                $"Spikes: \t{NumberOfSpikes}";
        }
    }

    internal class Worm : Animal
    {
        public double Length { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The worm grunts.");
        }
        public override string Stats()
        {
            return 
                $"{base.Stats()}\n" +
                $"Length: \t{Length}";
        }
    }

    internal class Bird : Animal
    {
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
                $"Wingspan: \t{WingSpan}";
        }
    }

    internal class Wolf : Animal
    {
        public bool IsLoneWolf { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The wolf howls.");
        }
        public override string Stats()
        {
            return 
                $"{base.Stats()}\n" +
                $"Lone wolf: \t{IsLoneWolf}";
        }
    }

    internal class Pelican : Bird
    {
        public double BillLength { get; set; }
        public override string Stats()
        {
            return 
                $"{base.Stats()}\n" +
                $"Bill length: \t{BillLength}";
        }
    }

    internal class Flamingo : Bird
    {
        public bool IsStandingOnOneLeg { get; set; }
    }

    internal class Swan : Bird
    {
        public bool IsSinging { get; set; }
    }

    internal class Wolfman : Wolf, IPerson
    {

        //Overriding DoSound would make more sense here but we follow the instructions.
        public void Talk()
        {
            Console.WriteLine("The wolfman says \"rawr\".");
        }
    }
}
