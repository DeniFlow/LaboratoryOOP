
namespace LabTask3
{
    class Program
    {
        static void Main(string[] args)
        {

            TreeNode tree = new TreeNode();
            Node n1 = new Node(5);
            Node n2 = new Node(3);
            Node n3 = new Node(12);
            Node n4 = new Node(14);
            Node n5 = new Node(0);
            Node n6 = new Node(3);

            tree.InsertNode(n1);
            tree.InsertNode(n2);
            tree.InsertNode(n3);
            tree.InsertNode(n4);
            tree.InsertNode(n5);
            tree.InsertNode(n6);

            tree.PrintAllChildrens(n2);



        }
    }
    
}
