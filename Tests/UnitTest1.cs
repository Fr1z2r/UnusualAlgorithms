using UnusualAlgorithms.BinTree;

namespace Tests;

public class BinTreeTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var tree = new BinTree<int>();
        tree.Add(2);
        tree.Add(1);
        tree.Add(1);
        tree.Add(3);
        tree.Print();
            Assert.Pass();
    }
}