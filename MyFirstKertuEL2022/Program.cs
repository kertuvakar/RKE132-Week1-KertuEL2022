// This is a comment 
//Rakendus küsib kasutajalt sisesta oma nime ja seejärel rakendus tervitab kasutajat nimepidi
Console.WriteLine("Enter your name:");
//String on sõne. Panen arvuti mälusse kastikesse,kuhu salvestan andmetüübi sõne
//Muid andmetüüpe sinna kirjutada ei saa
String userName = Console.ReadLine();
//võrdusmark tähendab, et salvesta väärtus
//järgmine rida loeb sisu konsoolist mällu salvestab selle kasti userName

//järgmisena rakendus tervitab nimepidi
//ka jutumärkides olev asi on sõne
//Pluss lihtsalt liidab andmeväljad kokku, see ei tekita tühikuid konsoolis
//Console.WriteLine("Hello" + ", " + userName + "!") aga see on liiga pikk variant

Console.WriteLine("Hello" + ", " + userName + "!");
//string interpolation
//Teksti peab piirama hoidma jutumärkide vahel
//votan andmed mida olen kasutanud ja lisan need uuele koodile
Console.WriteLine($"Hello, {userName}!");
