
namespace AlgorithmAndDataStruct;

public class BinaryTreeNode<T> where T : IComparable 
{
    public BinaryTreeNode(T value)
    {
        this.Value = value;
    }
    public T Value { get; set; }
    public BinaryTreeNode<T> left { get; set; }
    public BinaryTreeNode<T> reight { get; set; }
}