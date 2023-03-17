namespace DesignPatterns.Structural.Composite;

public class File : FileSystemItem
{
    private readonly long _size;

    public File(string name, long size) : base(name)
    {
        _size = size;
    }

    public override long GetSize()
    {
        return _size;
    }
}