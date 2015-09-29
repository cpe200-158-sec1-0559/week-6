using System;
 
namespace Lab601
{
  class MainApp
  {
    public static void main()
    {
      ContinentFactory asian = new AsianFactory();
      AnimalWorld world = new AnimalWorld(asian);
      world.RunFoodChain();

      ContinentFactory africa = new AfricaFactory();
      AnimalWorld world = new AnimalWorld(africa);
      world.RunFoodChain();
 
      ContinentFactory america = new AmericaFactory();
      world = new AnimalWorld(america);
      world.RunFoodChain();
 
      // Wait for user input
      Console.ReadKey();
    }
  }
 
  abstract class ContinentFactory
  {
    public abstract Herbivore CreateHerbivore();
    public abstract Carnivore CreateCarnivore();
  }

    class AsianFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Worm();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Bird();
        }
    }

    class AfricaFactory : ContinentFactory
  {
    public override Herbivore CreateHerbivore()
    {
      return new Wildebeest();
    }
    public override Carnivore CreateCarnivore()
    {
      return new Lion();
    }
  }
  class AmericaFactory : ContinentFactory
  {
    public override Herbivore CreateHerbivore()
    {
      return new Bison();
    }
    public override Carnivore CreateCarnivore()
    {
      return new Wolf();
    }
  }
 
  abstract class Herbivore
  {
  }
 
  abstract class Carnivore
  {
    public abstract void Eat(Herbivore h);
  }

    class Worm : Herbivore
    {
    }

    class Bird : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Worm
            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }

    class Wildebeest : Herbivore
  {
  }

  class Lion : Carnivore
  {
    public override void Eat(Herbivore h)
    {
      // Eat Wildebeest
      Console.WriteLine(this.GetType().Name +
        " eats " + h.GetType().Name);
    }
  }
 
  class Bison : Herbivore
  {
  }
 
  class Wolf : Carnivore
  {
    public override void Eat(Herbivore h)
    {
      // Eat Bison
      Console.WriteLine(this.GetType().Name +
        " eats " + h.GetType().Name);
    }
  }
 
  class AnimalWorld
  {
    private Herbivore _herbivore;
    private Carnivore _carnivore;
 
    // Constructor
    public AnimalWorld(ContinentFactory factory)
    {
      _carnivore = factory.CreateCarnivore();
      _herbivore = factory.CreateHerbivore();
    }
 
    public void RunFoodChain()
    {
      _carnivore.Eat(_herbivore);
    }
   }
 }
  