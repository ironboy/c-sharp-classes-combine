

// FIRST EXAMPLE: REMOVE MULTILINE COMMENT TO RUN
/*
PetOwner gabriella = new("Gabriella", "Gustavsson", "gabriella@snakelovers.com");
Pet sirHiss = new("Sir Hiss", "snake");
Pet mrMouse = new("Mr Mouse", "mouse");

gabriella.BuyPet(sirHiss);
gabriella.BuyPet(mrMouse);

Console.WriteLine(gabriella.TellAboutMyPets());
Console.WriteLine("");
Console.WriteLine(sirHiss.TellAboutMyOwner());
Console.WriteLine("");
Console.WriteLine(mrMouse.TellAboutMyOwner());
*/


// SECOND EXAMPLE: REMOVE MULTILINE COMMENT TO RUN
/*
List<PetOwner> owners = [];
List<Pet> pets = [];

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
        "2. Lägg till ett husdjur",
        "3. Visa alla djurägare",
        "4. Visa alla husdjur",
        "5. Låt en djurägare köpa ett husdjur"
    ];
    string choice = Ask(string.Join("\n", menu) + "\n");
    Console.Clear();
    if (choice == "1")
    {
        // Add a PetOwner
        PetOwner owner = new(Ask("First name:"), Ask("Last name:"), Ask("Email"));
        owners.Add(owner);
    }
    else if (choice == "2")
    {
        // Add a Pet
        Pet pet = new(Ask("Name:"), Ask("Species:"));
        pets.Add(pet);
    }
    else if (choice == "3")
    {
        // List pet owners
        int counter = 1;
        foreach (PetOwner owner in owners)
        {
            Console.WriteLine(counter++);
            Console.WriteLine(owner.TellAboutMyPets());

        }
        Console.ReadLine();
    }
    else if (choice == "4")
    {
        // List pets
        int counter = 1;
        foreach (Pet pet in pets)
        {
            Console.WriteLine(counter++);
            Console.WriteLine(pet.TellAboutMyOwner());
        }
        Console.ReadLine();
    }
    else if (choice == "5")
    {
        // Let a petowner buy a pet
        int ownerIndex = int.Parse(Ask("Vilken djurägare? (ange nummer)")) - 1;
        int petIndex = int.Parse(Ask("Vilket djur? (ange nummer)")) - 1;
        owners[ownerIndex].BuyPet(pets[petIndex]);
    }
}*/

// THIRD EXAMPLE: INHERITANCE / POLYMORFISM
List<Pet> pets = [
    new Dog("Fido"),
    new Cat("Garfield"),
    new Dog("Lassie"),
    new Pet("Sir Hiss", "snake")
];

foreach (Pet pet in pets)
{
    Console.WriteLine(pet.SayHi());
}

