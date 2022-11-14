namespace Library;

public class LongestNameContent : INodesContent
{
    private Node node;
    public LongestNameContent(Node node)
    {
        this.node = node;
    }
    public string GetResult()
    {
        Visitor visitor = new LongestNameVisitor();
        this.node.Accept(visitor);
        return $"El integrante de la familia de {node.Person.Name} con nombre más largo es: {visitor.Content}.";
    }
}