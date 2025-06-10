using DesafioPOO.Models;

class Program
{
  static void Main()
  {
    Smartphone nokia = new Nokia("999999-999", "Windows Phone 5", "IMEI0989829382", 32);
    Console.WriteLine("--- Testando Nokia---\n");
    nokia.Ligar();
    nokia.ReceberLigacao();
    nokia.InstalarAplicativo("WhatsApp");


    Smartphone iphone = new Iphone("9999999-9999", "Iphone 15", "IMEI 983232673458322", 128);
    Console.WriteLine("\n---Testando Iphone---\n");
    iphone.Ligar();
    iphone.ReceberLigacao();
    iphone.InstalarAplicativo("Telegram");

    Console.WriteLine("\n---Testes Finalizados---\n");



  }



}