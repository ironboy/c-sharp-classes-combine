class Dog(string name) : Pet(name, "dog")
{
    public override string SayHi()
    {
        return "Woof! " + base.SayHi();
    }
}