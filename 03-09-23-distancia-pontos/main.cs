using System;

public class Ponto {
  private int x,y;
  
  public Ponto(int x, int y) {
  this.x = x;
  this.y = y;
  }
  public Ponto(){
    this.x = 0;
    this.y = 0;
  }
//contrutores acima
//métodos abaixo
  public bool equals(Ponto p){
    return this.x == p.x && this.y == p.y;
  } //se são iguais

  public double distance(Ponto p){
    double dx = this.x - p.x;
    double dy = this.y - p.y;

    return Math.Sqrt(dx*dx + dy*dy);
  } //distância
}


class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite os valores do primeiro ponto (x):");
    int x1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite os valores do primeiro ponto (y):");
    int y1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite os valores do segundo ponto (x):");
    int x2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite os valores do segundo ponto (y):");
    int y2 = int.Parse(Console.ReadLine());
    
    Ponto p1 = new Ponto(x1,y1);
    Ponto p2 = new Ponto(x2,y2);
    
    bool equals = p1.equals(p2);
    double distance = p1.distance(p2);

    Console.WriteLine("Os pontos são iguais? {0}", equals);
    Console.WriteLine("A distancia entre os pontos é: {0}", distance);
  } 
}
