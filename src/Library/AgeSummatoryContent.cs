namespace Library;

public class AgeSummatoryContent : INodesContent
{
    private Node node;
    public AgeSummatoryContent(Node node)
    {
        this.node = node;
    }
    public string GetResult()
    {
        Visitor visitor = new AgeSummatoryVisitor();
        this.node.Accept(visitor);
        return $"La sumatoria de las edades de los integrantes de la familia de {node.Person.Name} es de: {visitor.Content}.";
    }
}

