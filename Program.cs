using DesafioPOO.Models;







        Console.WriteLine("Smartphone Iphone:");
        Smartphone iphone = new Iphone(numero: "813490323", modelo: "iphone t45", imei: "111112222",   memoria: 128 );
        iphone.InstalarAplicativo(nomeApp: "YouTube");
        iphone.ReceberLigacao();
        iphone.Ligar();
    

          Console.WriteLine("\n");
    
         
        Console.WriteLine("Smartphoone Nokia:");
        Smartphone nokia = new Nokia(numero: "810290323", modelo: "Nokia k55", imei: "222222222",   memoria: 64 );
        nokia.InstalarAplicativo(nomeApp: "TikTok");
        nokia.ReceberLigacao();
        nokia.Ligar();
    


// TODO: Realizar os testes com as classes Nokia e Iphone