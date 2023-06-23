namespace UnusualAlgorithms.BinTree;

internal class BinTreeNode<T>
    where T : IComparable
{
    public BinTreeNode<T>? Left { get; set; }
    public BinTreeNode<T>? Right { get; set; }
    public T Value { get; }

    public BinTreeNode(T value)
    {
        Value = value;
    }
}