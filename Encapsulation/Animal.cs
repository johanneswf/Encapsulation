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
            return $"Name: {Name}\n" +
                $"Weight: {Weight}\n" +
                $"Age: {Age}\n";
        }


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
            return $"{base.Stats()}" +
                $"Ridable: {IsRidable}\n";
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
            return $"{base.Stats()}" +
                $"Trained: {IsTrained}\n";
        }
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
            return $"{base.Stats()}" +
                $"Number of Spikes: {NumberOfSpikes}\n";
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
            return $"{base.Stats()}\n" +
                $"Length: {Length}\n";
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
            return $"{base.Stats()}" +
                $"Wingspan: {WingSpan}\n";
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
            return $"{base.Stats()}" +
                $"Lone wolf: {IsLoneWolf}\n";
        }
    }

    internal class Pelican : Bird
    {
        public double BillLength { get; set; }
        public override string Stats()
        {
            return $"{base.Stats()}" +
                $"Bill length: {BillLength}\n";
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
        public void Talk()
        {
            Console.WriteLine("The wolfman says \"rawr\".");
        }
    }
}
