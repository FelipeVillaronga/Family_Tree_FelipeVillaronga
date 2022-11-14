namespace Library;

public class OldestVisitor : Visitor
{
    public OldestVisitor()
    {
        this.OldestAge = 0;
    }
    private int OldestAge { get; set; }
    public override void Visit(Node node)
    {
        this.Visit(node.Person);
        foreach (Node child in node.Children)
        {
            child.Accept(this);
        }
        this.content = this.OldestAge.ToString();
    }

    public override void Visit(Person person)
    {
        if (person.Age > this.OldestAge)
        {
            this.OldestAge = person.Age;
        }
    }
}