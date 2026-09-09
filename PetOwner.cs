class PetOwner(string firstName, string lastName, string email)
{
    // Public fields
    public string FirstName = firstName;
    public string LastName = lastName;
    public string Email = email;

    public List<Pet> pets = [];

    public string SayHi()
    {
        return $"Hi! I am {FirstName} {LastName}!";
    }

    public void BuyPet(Pet newPet)
    {
        // Add the pet to my list of pets
        // if i don't already own it
        if (!pets.Contains(newPet))
        {
            pets.Add(newPet);
        }
        // Set the owner field of the pet
        // NOTE: this -> me the instance running the method
        newPet.Owner = this;
    }

    public string TellAboutMyPets()
    {
        string story = SayHi() + "\n";
        if (pets.Count == 0)
        {
            return story + "I don't own any pets yet!";
        }
        story += "I own the following pets:";
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