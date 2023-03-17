namespace DesignPatterns.Structural.Composite;

public class Directory : FileSystemItem
{
    private readonly long _size;
    private readonly List<FileSystemItem> _fileSystemItems = new();

    public Directory(string name, long size) : base(name)
    {
        _size = size;
    }

    public void Add(FileSystemItem fileSystemItem)
    {
        _fileSystemItems.Add(fileSystemItem);
    }

    public void Remove(FileSystemItem fileSystemItem)
    {
        _fileSystemItems.Remove(fileSystemItem);
    }

    public override long GetSize()
    {
        var treeSize = _size;
        foreach (var fileSystemItem in _fileSystemItems)
        {
            treeSize += fileSystemItem.GetSize();
        }

        return treeSize;
    }
}