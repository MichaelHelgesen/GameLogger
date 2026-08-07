using Spectre.Console;
using System.IO;
using System.Text.Json;
/*

Controller for å håndtere menyvalgene

loggerController
    .Legg til spill
    .Se registrerte spill
    .Logg spill
    .Slett spill

Enum for menyvalg

Klasse for SpillRunde



*/

var minModell = new { Navn = "Ola", Alder = 30 };

// 1. Konverter til JSON-streng
string jsonString = JsonSerializer.Serialize(minModell);

// 2. Skriv direkte til fil (med pen formatering)
var options = new JsonSerializerOptions { WriteIndented = true };
File.WriteAllText("data.json", JsonSerializer.Serialize(minModell, options));


string[] meny = new[] { "Marvel Champions", "Lord Of The Rings" };

while (true)
{
    Console.Clear();

    var choice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("Choose game")
            .AddChoices(meny));
/*
    switch (choice)
    {
        case Enums.MenuOption.ViewBooks:
            booksController.ViewBooks();
            break;
        case Enums.MenuOption.AddBook:
            booksController.AddBook();
            break;
        case Enums.MenuOption.DeleteBook:
            booksController.DeleteBook();
            break;
    }
    */
}

enum Meny
{
    test,
    test2
}