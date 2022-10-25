
// M4 i fire punkter
// 
//  Algoritme vs flytte data
// 
//  Oppgaveideer
//  - Snu en tekst
//var text = "Hallo verden!";
//for (int i = text.Length - 1; i >= 0; i--)
//{
//    Console.Write(text[i]);
//}

//var reversedText = "";
//foreach (var character in text)
//{
//    reversedText = character + reversedText;
//}
//Console.WriteLine(reversedText);

//  - Telle A-er
//  - Formatere tekst annenhver upper og lower

//var text = "Hallo verden!"; // "HaLlO VeRdEn!"
//var nextText = "";
//var isUpper = true;
//foreach (var character in text)
//{
//    if (isUpper)
//        nextText += char.ToUpper(character);
//    else
//        nextText += char.ToLower(character);
//    isUpper = !isUpper;
//}
//Console.WriteLine(nextText);


//var nextText2 = "";
//for (var index = 0; index < text.Length; index++)
//{
//    var character = text[index];
//    var isEven = index % 2 == 0;
//    nextText2 += isEven ? char.ToLower(character) : char.ToUpper(character);
//}
//Console.WriteLine(nextText2);

//  - Sortere en liste manuelt
var cities = new string[] { "Oslo", "Larvik", "Stavern", "Stavanger", "Bergen"};
// Gammel liste: , "Larvik", "Stavern", "Stavanger", "Oslo"
// Ny liste: "Bergen", "Larvik"
// Array.Sort(cities);
// Insertion sort
var newCities = new string[cities.Length];
for (int i = 0; i < newCities.Length; i++)
{
    newCities[i] = FindFirst(cities, i);
}

// Pause til 10:35



//  - Kjenne igjen Yatzy-kombinasjoner
//  - Game of life
//    GameOfLife.Run();
//  - Ideer fra dere?
// 
