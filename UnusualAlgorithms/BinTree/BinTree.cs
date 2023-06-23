using System.CodeDom.Compiler;
using StringWriter = System.IO.StringWriter;

namespace UnusualAlgorithms.BinTree;

public class BinTree<T>
where T : IComparable
{
    private BinTreeNode<T>? root;

    public void Add(T value)
    {
        if (root == null)
        {
            root = new BinTreeNode<T>(value);
            return;
        }
        AddInternal(root, value);
    }

    private void AddInternal(BinTreeNode<T> node, T value)
    {
        if (value.CompareTo(node.Value) == -1)
        {
            if (node.Left == null)
                node.Left = new BinTreeNode<T>(value);
            else
                AddInternal(node.Left, value);
        }
        else
        {
            if (node.Right == null)
                node.Right = new BinTreeNode<T>(value);
            else
                AddInternal(node.Right, value);
        }
    }

    public void Print()
    {
        var stringWriter = new StringWriter();
        var writer = new IndentedTextWriter(stringWriter);
        PrintInternal(writer, root);
        Console.WriteLine(stringWriter.ToString());
    }

    private void PrintInternal(IndentedTextWriter indentedTextWriter, BinTreeNode<T>? node)
    {
        if (node == null)
            return;
        
        indentedTextWriter.WriteLine(node.Value);
        indentedTextWriter.Indent++;
        PrintInternal(indentedTextWriter, node.Left);
        PrintInternal(indentedTextWriter, node.Right);
        indentedTextWriter.Indent--;
    } 
}