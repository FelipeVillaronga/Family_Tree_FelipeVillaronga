
namespace Library;

public abstract class Visitor
{
    public string Content 
    { 
        get
        {
            return this.content;
        }
    }

    protected string content;

    public abstract void Visit(Node nodes);
    public abstract void Visit(Person person);
}