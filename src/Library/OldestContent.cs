namespace Library;

public class OldestContent : INodesContent
{
    private Node node;
    public OldestContent(Node node)
    {
        this.node = node;
    }
    public string GetResult()
    {
        Visitor visitor = new OldestVisitor();
        this.node.Accept(visitor);
        return $"El hijo de {node.Person.Name} con mayor edad es: {visitor.Content}.";
    }
}