using DesafioPOO.Models;



Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "995684037", modelo: "Iphone 14", imei: "65564654", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("ArkKnights");


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "98152370", modelo: "A2", imei: "98706546", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Angry Birds");