class PetOwner(string firstName, string lastName, string email)
{
    // Public fields
    public string FirstName = firstName;
    public string LastName = lastName;
    public string Email = email;

    public List<Pet> pets = [];

    public void BuyPet(Pet newPet)
    {
        pets.Add(newPet);
    }

    public string TellAboutMyPets()
    {
        string story = "I own the following pets:";
        // loop through the pets list and add
        // each pets name and species to the string story
        foreach (Pet pet in pets)
        {
            story += $"\n{pet.Name} ({pet.Species})";
        }
        // return the story
        return story;
    }
}