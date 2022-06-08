using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmAndDataStruct;

public class BinarySearchTree<T> where T : IComparable
{
    public BinaryTreeNode<T> root { get; set; }

    public BinarySearchTree(T[] array)
    {
        this.root = ArraySortedToTree(array, 0, array.Length);
    }


    private BinaryTreeNode<T> ArraySortedToTree(T[] array, int Start, int End)
    {
        if (Start > End || (Start + End) / 2 >= array.Length)
            return null;

        int middle = (Start + End) / 2;

        BinaryTreeNode<T> node = new BinaryTreeNode<T>(array[middle]);

        node.left = ArraySortedToTree(array, Start, middle - 1);
        node.reight =  ArraySortedToTree(array, middle + 1, End);

        return node;
    }

    private void SearchAndInsertValue(BinaryTreeNode<T> node, T value)
    {
        if (node.Value.CompareTo(value) > 0 && node.left != null)
            SearchAndInsertValue(node.left, value);
        else if (node.Value.CompareTo(value) > 0 && node.left == null) 
            node.left = new BinaryTreeNode<T>(value);
        else if (node.Value.CompareTo(value) < 0 && node.reight != null)
            SearchAndInsertValue(node.reight, value);
        else if (node.Value.CompareTo(value) < 0 && node.reight == null) 
            node.reight = new BinaryTreeNode<T>(value);
        else 
            throw new ArgumentException($"this item as already been added: Value: {value}");
    }

    public void Add(T Value)
    {
        if (root == null) {
            root ??= new BinaryTreeNode<T>(Value);
            return ;
        }
        try {
            SearchAndInsertValue(root, Value);
        }
        catch (Exception e) {
            throw new Exception(e.Message);
        }
    }

    private BinaryTreeNode<T> SearchAndReturnElement(BinaryTreeNode<T> node, T value)
    {
        if (node.Value.CompareTo(value) > 0 && node.left != null)
            return SearchAndReturnElement(node.left, value);
        else if (node.Value.CompareTo(value) < 0 && node.reight != null)
            return SearchAndReturnElement(node.reight, value);
        return node.Value.CompareTo(value) == 0 ? node : null; 
    }

    public BinaryTreeNode<T> Search(T value)
    {
        return SearchAndReturnElement(root, value);
    }

    private BinaryTreeNode<T> SearchClosestAncestor(BinaryTreeNode<T> root, BinaryTreeNode<T> n1, BinaryTreeNode<T> n2)
    {
        if (root == null || n1 == root || n2 == root)
            return root;
        BinaryTreeNode<T> left = SearchClosestAncestor(root.left, n1, n2);
        BinaryTreeNode<T> reight = SearchClosestAncestor(root.reight, n1, n2);
        if (left != null && reight != null)
            return root;
        return left ?? reight;
    }

    public BinaryTreeNode<T> ClosestAncestor(BinaryTreeNode<T> n1, BinaryTreeNode<T> n2)
    {
        if (n1 == null || n2 == null)
            throw new NullReferenceException("the node n1 ou n2 est null");
        return SearchClosestAncestor(root, n1, n2);
    }

    public int CalculateMaxHeight(BinaryTreeNode<T> node, int n)
    {
        if (node == null)
            return n - 1;
        int left = CalculateMaxHeight(node.left, n + 1);
        int reight = CalculateMaxHeight(node.reight, n + 1);
        return left > reight ? left : reight;
    }

    public int MaxHeight()
    {
        return CalculateMaxHeight(root, 0);
    }

//     class Tree{
// 	int current;
//   Tree left;
//   Tree right;
  
//   bool IsBinaryResearch(){
//   	return IsBinaryResearchRecursive(this, int.Max, int.Min);
//   }
  
//   private static bool IsBinaryResearchRecursive(Tree root, int max, min){
//   bool left = true;
//   bool right = true;
  
//   	if (root.left != null) {
//     	if (root.left.current < root.curent)
//   			left = IsBinaryResearchRecursive(root.left, max, root.Current);
//       else
//       	return false;
//       }
//     if (root.reight != null)
//     	if (root.right.current > root.curent)
//  		 right = IsBinaryResearchRecursive(root.right);
//     	else
//       	return false;
// 		return left && right;
//   }
}