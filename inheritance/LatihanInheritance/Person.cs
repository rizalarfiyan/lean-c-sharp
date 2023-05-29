class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void GetNameAndAge()
    {
        Console.WriteLine("The person has name: {0} and age: {1}", Name, Age);
    }
}