using static System.Net.Mime.MediaTypeNames;

/* Test av indata metoder...klasser? 
 * -> Klassen är Console! Metoden är Read, ReadKey etc! */
//Console.WriteLine("Test av Console.ReadLine:");
//string? testConsoleReadLine = Console.ReadLine();
//Console.WriteLine(testConsoleReadLine);

//Console.WriteLine("Test av Console.Read:");
//int testConsoleRead = Console.Read();
//Console.WriteLine(testConsoleRead);

Console.WriteLine("Test av Console.ReadKey, ange valfri tangentkombination:");
ConsoleKeyInfo key = Console.ReadKey();
Console.WriteLine();
Console.WriteLine("Character entered: " + key.KeyChar);
Console.WriteLine("Special keys entered: " + key.Modifiers);

/* Test av utdata metoder*/
/* Console.Write("1. Jag glömde fnuttar först, oj oj vad ledsen den blev.");
Console.Write("2. Tur att VS färgkodning hjälper att upptäcka sådana fel. Här testas Console.Write.");
Console.WriteLine("3. Men nu, nu testar vi Console.WriteLine.");
Console.WriteLine("4. Och jag måste säga att cw + tab är otroligt användbart.");*/

/* Test av strängformatering */
//string var1 = "test";
//Console.WriteLine("Kan man skriva klamerparaterer utan $ innan: {var1}?");
//Console.WriteLine($"Svaret verkar vara nej, eftersom det stod {{var1}} och inte {var1}");
//Console.WriteLine("Jag inser att skilladen ligger i att utan $ skriver man på formatet: (\"text { }\", var1) och inte ($ text {var1})");
//Console.WriteLine("Vilket jag nu bevisar genom att skriva var1 som {{0}}: {0}", var1);

//Console.WriteLine("---------------------------------------------------");

//double number = 1.2345;
//Console.WriteLine("Talet med 6 decimaler: {0:0.000000}", number);
//Console.WriteLine("Talet {0,20} högerjusterat", number);
//Console.WriteLine("Talet {0,20} högerjusterat", number);
//Console.WriteLine("Talet {0,-20} vänsterjusterat", number);
//Console.WriteLine("Talet {0,-20} vänsterjusterat", number);