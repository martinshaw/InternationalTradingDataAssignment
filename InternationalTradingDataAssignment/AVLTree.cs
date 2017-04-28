using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingDataAssignment
{
    public class AVLTree<Country> : BSTree<Country> where Country : IComparable<Country>
    {
        public AVLTree()
        {
            root = null;
        }

        private void rotateLeft(ref Node<Country> tree)
        {
            if (tree.Right.BalanceFactor > 0)  //double rotate
                rotateRight(ref tree.Right);

            Node<Country> pivot = tree.Right;

            tree.Right = pivot.Left;
            pivot.Left = tree;
            tree = pivot;
        }
        private void rotateRight(ref Node<Country> tree)
        {
            if (tree.Left.BalanceFactor < 0)  //double rotate
                rotateLeft(ref tree.Left);

            Node<Country> pivot = tree.Left;

            tree.Left = pivot.Right;
            pivot.Right = tree;
            tree = pivot;

        }
        public new void InsertItem(Country item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(Country item, ref Node<Country> tree)
        {
            if (tree == null)
                tree = new Node<Country>(item);
            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
            tree.BalanceFactor = height(ref tree.Left) - height(ref tree.Right);
            if (tree.BalanceFactor <= -2)
                rotateLeft(ref tree);
            if (tree.BalanceFactor >= 2)
                rotateRight(ref tree);
        }

    }
}
