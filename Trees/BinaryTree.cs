using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp;

namespace Trees
{
    public class BinaryTree
    {
        public TreeNode Root { get; private set; }

        public void Insert(Employee person)
        {
            Root = InsertRec(Root, person);
        }
        private TreeNode InsertRec(TreeNode root, Employee person)
        {
            if (root == null)
            {
                return new TreeNode(person);
            }

            if (person.CompareTo(root.Value) < 0)
            {
                root.Left = InsertRec(root.Left, person);
            }
            else if (person.CompareTo(root.Value) > 0)
            {
                root.Right = InsertRec(root.Right, person);
            }

            return root;
        }

        public void InOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Console.WriteLine($"Имя: {node.Value.Name}, Зарплата: {node.Value.Salary}");
                InOrderTraversal(node.Right);
            }
        }
        public  string FindNode(TreeNode root, int number)
        {
            if (number < root.Value.Salary)
            {
               if (root.Left != null)
                {
                    return FindNode(root.Left, number);
                }

                return ("Такой сотрудник не найден");
            }
            if (number > root.Value.Salary)
            {
                if (root.Right != null)
                {
                    return FindNode(root.Right, number);
                }

                return ("Такой сотрудник не найден");
            }

            return (root.Value.Name);
        }        
    }
}
