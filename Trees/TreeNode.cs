using Trees;

namespace ConsoleApp;

public class TreeNode
{
    public Employee? Value { get; set; }
    
    public TreeNode Left { get; set; }
    
    public TreeNode Right { get; set; }

    public TreeNode(Employee value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}