using System;

class MainClass{
  public static void Main (string[] args) 
    
  {
   //variavel utilizada 
   double val_real,val_dolar,cot;
   Console.WriteLine("Calculadora estruturada para calcular o valor em Reais correspondente aos dólares que um turista possui no cofre do hotel.");
   Console.WriteLine("Digite a Quantidade de dólares guardados no cofre: ");
   val_dolar = double.Parse(Console.ReadLine());
   Console.WriteLine("Digite a cotação do dolár atual");
   cot = double.Parse(Console.ReadLine());
   val_real = ( val_dolar*cot);
   Console.WriteLine ("val_real:{0} ", val_real);
  }
}


   
  