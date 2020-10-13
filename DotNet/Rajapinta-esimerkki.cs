public class Auto : IKäynnistettävä
{
  public int Huippunopeus { get; set; }

  public void Käynnistä()
  {
     //..
  }
}

public class Työkone : IKäynnistettävä
{
    public void Käynnistä()
  {
     //..
  }
}


public interface IKäynnistettävä
{
    void Käynnistä();
}

IKäynnistettävä kone = new Auto();
IKäynnistettävä kone2 = new Työkone();
kone.Käynnistä();
kone2.Käynnistä();
