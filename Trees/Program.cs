using System.Linq.Expressions;
using Trees;

namespace Trees
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            do
            {
                BinaryTree tree = new BinaryTree();
                MakingTree(tree);

                MenuSelection(tree);
            }
            while(true);
        }

        public static void MakingTree(BinaryTree binary)
        {
            while (true)
            {
                Console.Write("Введите Имя сотрудника : ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    break;
                }

                Console.Write("Введите Зарплату сотрудника : ");
                int salar = Convert.ToInt32(Console.ReadLine());

                binary.Insert(new Employee(name, salar));
            }
            binary.InOrderTraversal(binary.Root);

            SearchEmployee(binary);
        }

        public static void SearchEmployee(BinaryTree binary)
        {
            Console.Write("Введите Зарплату сотрудника которого хотите найти : ");
            int salarSearch = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(binary.FindNode(binary.Root, salarSearch));
        }

        public static void MenuSelection(BinaryTree binary)
        {
            bool closeMenu = true;
            while (closeMenu)
            {
                Console.WriteLine("Введите 1 (снова поиск зарплаты) , введите 0 (переход к началу программы)");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:  
                        closeMenu= false;
                        Console.Clear();
                        break;
                    case 1:
                        SearchEmployee(binary);

                        break;
                }
            }
        }
    }
}
