using System;
using System.Collections;

namespace AlgorithmAndDataStruct;

public class BinarySearchTree
{
    private BinaryTreeNode root { get; set; }

    private void SearchAndInsertValue(BinaryTreeNode node, int value)
    {
        if (node.Value < value && node.left != null)
            SearchAndInsertValue(node.left, value);
        else if (node.Value < value && node.left == null)
            node.left = new BinaryTreeNode(value);
        else if (node.Value > value && node.reight != null)
            SearchAndInsertValue(node.reight, value);
        else if (node.Value > value && node.reight == null)
            node.reight = new BinaryTreeNode(value);
        else 
            throw new ArgumentException($"this item as already been added: Value: {value}");
    }

    public void Add(int Value)
    {
        if (root == null)
            root = new BinaryTreeNode(Value);
        try {
            SearchAndInsertValue(root, Value);
        }
        catch (Exception e) {
            throw new Exception(e.Message);
        }
    }

    private BinaryTreeNode SearchClosestAncestor(BinaryTreeNode root, BinaryTreeNode n1, BinaryTreeNode n2)
    {
        if (root == null || n1 == root || n2 == root)
            return root;
        BinaryTreeNode left = SearchClosestAncestor(root.left, n1, n2);
        BinaryTreeNode reight = SearchClosestAncestor(root.reight, n1, n2);
        if (left != null && reight != null)
            return root;
        return left != null ? left : reight;
    }

    public int ClosestAncestor(BinaryTreeNode n1, BinaryTreeNode n2)
    {
        if (n1 == null || n2 == null)
            throw new NullReferenceException("the node n1 ou n2 est null");
        return SearchClosestAncestor(root, n1, n2).Value;
    }
}