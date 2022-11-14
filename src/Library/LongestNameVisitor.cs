using System.Text;

namespace Library;

public class LongestNameVisitor : Visitor
{
    public LongestNameVisitor()
    {
        this.Longest= "";
    }
    private string Longest { get; set; }
    public override void Visit(Node node)
    {
        this.Visit(node.Person);
        foreach (Node child in node.Children)
        {
            child.Accept(this);
        }
    }
    public override void Visit(Person person)
    {
        if (person.Name.Length > this.Longest.Length)
        {
            this.Longest = person.Name;
            this.content = person.Name;
        }
    }
}