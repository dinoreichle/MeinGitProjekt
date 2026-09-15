decimal geld = 20.00m;
decimal preisRiegel = 3.20m;

decimal riegel = Math.Floor (geld / preisRiegel);
Console.WriteLine($"Mit deinem Geld kannst du {riegel} riegel kaufen.");

decimal restgeld = geld % preisRiegel;
Console.WriteLine($"Du hast noch {restgeld} Fr. übrig.");
