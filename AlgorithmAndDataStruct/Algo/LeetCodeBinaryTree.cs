namespace AlgorithmAndDataStruct;


// Definition for a binary tree node.
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution {

    private int defineDepth(TreeNode root, int n)
    {
        if (root == null)
            return n;
        int left = defineDepth(root.left, n + 1);
        int reight = defineDepth(root.right, n + 1);

        return left > reight ? left : reight;
    }

    public int MaxDepth(TreeNode root) {
        return defineDepth(root, 0);
    }

    private bool DefineValidBST(TreeNode reight, TreeNode left)
    {
        if (reight == null || left == null)
            return false;
        if (!DefineValidBST(reight.right, reight.left))
            return false;
        if (!DefineValidBST(left.right, left.left))
            return false;
        return reight.val < left.val;
    }

    public bool IsValidBST(TreeNode root) {
        return DefineValidBST(root.right, root.left);
    }
}