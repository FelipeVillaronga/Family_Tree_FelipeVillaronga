using System.Collections.Generic;

namespace Library;

public class AgeSummatoryVisitor : Visitor
{
    private int ageSummatory {get; set;}
    public override void Visit(Node node)
    {
        this.Visit(node.Person);
        foreach (Node child in node.Children)
        {
            child.Accept(this);
        }
        this.content = ageSummatory.ToString();
    }

    public override void Visit(Person person)
    {
        ageSummatory += person.Age;
    }

}