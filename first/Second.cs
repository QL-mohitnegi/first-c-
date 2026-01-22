class Human
{
    string name;
    int age;

    public Human()
    {
        
    }
    public Human(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string Name
    {
        get;
        set;
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public void setName(string n)
    {
        this.name = n;
    }

    public void setAge(int age)
    {
        this.age = age;
    }

    public string getName()
    {
        return this.name;
    }

    public int getAge()
    {
        return this.age;
    }
}

class Sonu : Human
{
    public Sonu() : base("Sonu", 20) {}
}