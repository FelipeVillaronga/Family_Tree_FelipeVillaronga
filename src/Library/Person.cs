using System;

namespace Library;

public class Person
{
    public Person(string name, int age)
    {
        this.Name= name;
        this.Age= age;
    }

    private string name;
    private int age;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if(!string.IsNullOrEmpty(value))
            {
                this.name= value;
            }
        }
    }
    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if(value>0)
            {
                this.age= value;
            }
        }
    }

    public void Accept(Visitor visitor)
    {
        visitor.Visit(this);
    }

}