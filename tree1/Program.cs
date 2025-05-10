using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

class LOL
{
    public static void Main(string[] args)
    {
        // Создаём дерево: корень = 1, правое поддерево = 2
        int[] nodeArr = [1, 2, 3, 6, 7, 4, 5];
        TreeNode? root = treeGenerator(nodeArr);

        Solution solution = new();
        // IList<int> result = solution.PreorderTraversal(root);
Console.WriteLine(root.left.left.val+"------");

        Console.WriteLine(varDubpResult(root));

        string varDubpResult(TreeNode? root)
        {
            if (root == null)
            {
                return " ";
            }
            string result = root?.val.ToString() ?? "";
            result += " ";
            result += root?.left?.val.ToString() ?? "";
            result += root?.right?.val.ToString() ?? "";
            result += " ";
            result += varDubpResult(root?.left?.left);
            return result;
        }

        TreeNode? treeGenerator(int[] arr)
        {
            if (arr.Length == 0) return null;
            // arr = arr.Cast<int?>().ToArray();
            if (arr.Length == 1)
            {
                return new TreeNode(arr[0]);
            }
            {

            }
            TreeNode node = new(
                arr[0],
                treeGenerator([.. arr.Skip(1)]),
                treeGenerator([.. arr.Skip(2)])
            );
            return node;
        }
    }
}

public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{

    public IList<int> PreorderTraversal(TreeNode root)
    {
        List<int> result = new List<int>();
        return result;
    }

}

