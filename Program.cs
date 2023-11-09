using DesafioPOO.Models;

Nokia celNokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);
Iphone celIphone = new Iphone("987654321", "Iphone 12", "987654321", 128);

Console.WriteLine("##### Testes com o objeto Nokia: #####");
celNokia.Ligar();
celNokia.ReceberLigacao();
celNokia.ReceberLigacao();
celNokia.InstalarAplicativo("Facebook");
celNokia.InstalarAplicativo("Instagram");

Console.WriteLine();

Console.WriteLine("##### Testes com o objeto Iphone: #####");
celIphone.Ligar();
celIphone.ReceberLigacao();
celIphone.Ligar();
celIphone.InstalarAplicativo("DIO");
celIphone.InstalarAplicativo("Tinder");
Console.WriteLine();
