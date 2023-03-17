namespace DesignPatterns.Structural.Composite;

// The intent of this pattern is to compose objects into tree structures to represent part-whole hierarchies.
// As such, it lets clients treat individual objects and compositions of objects uniformly: as if they were 
// individual objects.


public abstract class FileSystemItem
{
    private string _name;
    
    public abstract long GetSize();

    protected FileSystemItem(string name)
    {
        _name = name;
    }
}