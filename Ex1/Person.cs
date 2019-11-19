using System;
using System.Text;

public class Person
{
    private string name;
    private int? age;

    public Person(string name, int? age = null)
    {
        this.Name = name;
        this.Age = age;
    }
    public (string error, bool valid) IsValid()
    {
        if (string.IsNullOrEmpty(this.name))
            return ("Name is invalid", false);
        if (this.age.HasValue && (this.age < 1 || this.age > 50))
            return ("Age is invalid", false);

        return (string.Empty, true);
    }

    public string Name
    {
        get { return this.name; }

        private set
        {
            this.name = value;
        }
    }
    public int? Age
    {
        get { return this.age; }
        private set
        {
            this.age = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendFormat("Name: {0}, Age: {1}", this.name, this.age == null ? "No info for age" : this.age.ToString());

        return sb.ToString();
    }
}



