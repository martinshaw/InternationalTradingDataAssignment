using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingDataAssignment
{
    public class BinTree<Country> where Country : IComparable<Country>
    {

        protected Node<Country> root;

        public BinTree()  //creates an empty tree
        {
            root = null;
        }

        public BinTree(Node<Country> node)  //creates a tree with node as the root
        {
            root = node;
        }

        public void InOrder(ref List<Country> buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(Node<Country> tree, ref List<Country> buffer)
        {
            /*
              if tree is not empty InOrder traverse left sub-tree display value in node InOrder 
              traverse right sub-tree
              end if
             */
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer.Add(tree.Data);
                inOrder(tree.Right, ref buffer);
            }

        }

        public void PreOrder(ref List<Country> buffer)
        {
            preOrder(root, ref buffer);
        }

        private void preOrder(Node<Country> tree, ref List<Country> buffer)
        {
            /*
                if tree is not empty display value in node Preorder traverse left sub - tree 
                pre - order traverse right sub - tree
                end if
            */
            if (tree != null)
            {
                buffer.Add(tree.Data);
                preOrder(tree.Left, ref buffer);
                inOrder(tree.Right, ref buffer);
            }
        }

        public void PostOrder(ref List<Country> buffer)
        {
            postOrder(root, ref buffer);
        }

        private void postOrder(Node<Country> tree, ref List<Country> buffer)
        {
            /*
                 if tree is not empty
                 post-order traverse left sub-tree
                 post-order traverse right sub-tree
                 display value in node
                 end if
             */
            if (tree != null)
            {
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer.Add(tree.Data);
            }
        }

    }
}
