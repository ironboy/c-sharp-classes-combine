/*PetOwner gabriella = new("Gabriella", "Gustavsson", "gabriella@snakelovers.com");
Pet sirHiss = new("Sir Hiss", "snake");
Pet mrMouse = new("Mr Mouse", "mouse");

gabriella.BuyPet(sirHiss);
gabriella.BuyPet(mrMouse);

Console.WriteLine(gabriella.TellAboutMyPets());
Console.WriteLine("");
Console.WriteLine(sirHiss.TellAboutMyOwner());
Console.WriteLine("");
Console.WriteLine(mrMouse.TellAboutMyOwner());*/

List<PetOwner> owners = [];

static string Ask(string question)
{
    Console.Write(question + " ");
    return Console.ReadLine()!;
}

while (true)
{
    Console.Clear();
    string[] menu = [
        "Vad vill du göra?",
        "1. Lägg till en djurägare",
        "2: Lägg till ett husdjur"
    ];
    string choice = Ask(string.Join("\n", menu) + "\n");
    if (choice == "1")
    {
        // Add a PetOwner
        PetOwner owner = new(Ask("First name:"), Ask("Last name:"), Ask("Email"));
        owners.Add(owner);
    }
}