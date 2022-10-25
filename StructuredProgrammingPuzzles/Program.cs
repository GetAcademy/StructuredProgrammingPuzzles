
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

// Insertion sort
// 1. Liste: "Oslo", "Larvik", "Stavern", "Stavanger", "Bergen"
// 2. Hvilken by er først fra og med index 0? "Bergen"
//    Ny liste: "Bergen"
//    Oppdaterer original liste: "Oslo", "Larvik", "Stavern", "Stavanger", "Oslo"
// 3. Hvilken by er først fra og med index 1? "Larvik"
//    Ny liste: "Bergen", "Larvik"
//    Oppdaterer original liste: "Oslo", "Larvik", "Stavern", "Stavanger", "Oslo"
// 4. Hvilken by er først fra og med index 2? "Oslo"
//    Ny liste: "Bergen", "Larvik", "Oslo"
//    Oppdaterer original liste: "Oslo", "Larvik", "Stavern", "Stavanger", "Stavern"
// 5. Hvilken by er først fra og med index 3? "Stavanger"
//    Ny liste: "Bergen", "Larvik", "Oslo", "Stavanger"
//    Oppdaterer original liste: "Oslo", "Larvik", "Stavern", "Stavanger", "Stavern"
// 6. Hvilken by er først fra og med index 4? "Stavern"
//    Ny liste: "Bergen", "Larvik", "Oslo", "Stavanger", "Stavern"
//    Oppdaterer original liste: "Oslo", "Larvik", "Stavern", "Stavanger", "Stavern"

// Array.Sort(cities);
var newCities = new string[cities.Length];
for (int i = 0; i < newCities.Length; i++)
{
    // 1. finne første fra og med index i
    var first = cities[i];
    var foundIndex = i;
    for (var index = i; index < cities.Length; index++)
    {
        var city = cities[index];
        // if(city < first)
        if (city.CompareTo(first) == -1)
        {
            first = city;
            foundIndex = index;
        }
    }

    newCities[i] = first;
    // 2. Erstatte den vi fant med det som ligger på index i
    cities[foundIndex] = cities[i];
}

foreach (var city in newCities)
{
    Console.WriteLine(city);
}

// Pause til 11:10



//  - Kjenne igjen Yatzy-kombinasjoner
//  - Game of life
//    GameOfLife.Run();
//  - Ideer fra dere?
// 
