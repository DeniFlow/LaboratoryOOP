using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask3
{
    public class Node
    {
        public int Value { get;private set; }
        private List<Node> childrens = new List<Node> { };
        
        public Node(int value)
        {
           Value =value;
        }
        public void PrintChildrens()
        {
            foreach (Node node in childrens)
            {
                Console.WriteLine(node.Value);
            }
        }
        
        public List<Node> GetChildrens()
        {
            return childrens;
        }
        public void AddChildren(Node children) 
        {
            childrens.Add(children);
        }

    }
}
