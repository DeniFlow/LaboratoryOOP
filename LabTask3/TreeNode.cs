using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask3
{
    public class TreeNode
    {
        private Node rootNode;
        private Node currentNode;
        public TreeNode()
        {
            rootNode = null;
            currentNode = null;
        }
        public void InsertNode(Node node)
        {
            if (rootNode == null)
            {
                rootNode = node;
                currentNode = node;
            }
            else
            {
                while (true)
                {
                    
                    if (currentNode.GetChildrens().Count == 0)
                    {
                        currentNode.AddChildren(node);
                        currentNode = node;
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.GetChildrens()[0];
                    }
                }
                
            }
        }
        public void PrintAllChildrens(Node node)
        {
            currentNode = node;
            while (currentNode.GetChildrens().Count > 0)
            {
                currentNode.PrintChildrens();
                currentNode = currentNode.GetChildrens()[0];
            }
        }

    }
}
