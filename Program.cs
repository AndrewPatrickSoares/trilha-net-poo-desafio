using DesafioPOO.Models;

Console.WriteLine("Smatphone Nokia:");
Smartphone smartNokia1 = new Nokia(numero: "920104114", modelo: "Modelo: 456", imei: "3669", memoria: 32);
smartNokia1.Ligar();
smartNokia1.InstalarAplicativo("SNAP");

Console.WriteLine("\n");

Console.WriteLine("Smatphone Iphone");
Smartphone smartIphone1 = new Iphone(numero: "920243265", modelo: "Modelo: 588", imei: "4787", memoria: 32);
smartIphone1.ReceberLigacao();
smartIphone1.InstalarAplicativo("WhatsApp");