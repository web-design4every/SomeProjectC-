using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test1
{
    public class Transformer
    {
        public string Name;
        public Transformer(string name)
        {
            this.Name = name;
        }

        public string getName()
        {
            return Name;
        }

        public virtual void transform()
        {
            
        }

        public virtual void fire(Transformer f)
        {
            
        }
    }

    public interface ITransformable
    {
         void transform();
    }

    public class Autobot : Transformer, ITransformable
    {
        public Autobot(string name):base(name)
        {

        }

        public override void transform()
        {
            Console.WriteLine("Transform to car");
        }

        public override void fire(Transformer f)
        {
            Console.WriteLine(base.getName()+" shoots "+f.getName());
        }
    }
    public class Decepticon : Transformer, ITransformable
    {
        public Decepticon(string name): base(name)
        {

        }

        public override void transform()
        {
            Console.WriteLine("Transform to space ship");
        }

        public override void fire(Transformer f)
        {
            Console.WriteLine(base.getName() + " shoots " + f.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Transformer optimus = new Autobot("Optimus");
            Transformer megatron = new Decepticon("Megatron");
            megatron.fire(optimus); // - > print Megatron shoots Optimus;
            megatron.transform(); // transform to space ship;
            optimus.transform(); // transform to car;
            //transform is abstract method of the interface ITransformable
            Console.ReadKey();
        }
    }
}
