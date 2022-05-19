
namespace AlgorithmAndDataStruct;

public class BinaryTreeNode
{
    public BinaryTreeNode(int value)
    {
        this.Value = value;
    }
    public int Value { get; set; }
    public BinaryTreeNode left { get; set; }
    public BinaryTreeNode reight { get; set; }
}