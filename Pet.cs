class Pet(string name, string species)
{
    // Public fields
    public string Name = name;
    public string Species = species;
    public PetOwner? Owner;

    // SayHi -> who am i
    public virtual string SayHi()
    {
        return $"I am the {Species} {Name}!";
    }

    // A method that lets the pet tell us who owns it
    public string TellAboutMyOwner()
    {
        return SayHi() + "\n" + (
           Owner == null ?
           "Noone owns me!" :
           $"My owner is {Owner.FirstName} {Owner.LastName} ({Owner.Email})"
        );
    }
}