using System;

public class Character
{
  public string Name { get; set; }
  public int SnusInventory { get; set; }

  public Character(string name, int snusInventory)
  {
    Name = name;
    SnusInventory = snusInventory;
  }

  public virtual void Snylta(Character target)
  {
    if (target.SnusInventory > 0)
    {
      Console.WriteLine($"{Name} takes a snus from {target.Name}.");
      target.TakeSnus();
    }
    else
    {
      Console.WriteLine($"{target.Name} dont have any snus left.");
    }
  }

  public virtual void TakeSnus()
  {
    SnusInventory--;
  }
}