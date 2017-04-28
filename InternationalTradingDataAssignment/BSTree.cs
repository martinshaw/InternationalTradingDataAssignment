using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingDataAssignment
{
    public class BSTree<Country> : BinTree<Country> where Country : IComparable<Country>
    {       

        public void InsertItem(Country item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(Country item, ref Node<Country> tree)
        {
            if (tree == null)
            {
                tree = new Node<Country>(item);
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
        }

        public int Height()
        {
            return height(ref root);
        }

        protected int height(ref Node<Country> tree)
        //Return the max level of the tree
        {
            if (tree == null)
            {
                return 0;
            }

            int leftHeight = height(ref tree.Left);
            int rightHeight = height(ref tree.Right);

            if (leftHeight > rightHeight)
            {
                return leftHeight + 1;
            }
            else
            {
                return rightHeight + 1;
            }
        }

        public int Count()
        {
            return count(ref root);
        }

        private int count(ref Node<Country> tree)
        //Return the number of nodes in the tree
        {
            int counter = 0;

            if (tree == null)
            {
                return 0;
            }
            else if (tree.Left != null)
            {
                counter += count(ref tree.Left);
                counter++;
            }
            else if (tree.Right != null)
            {
                counter += count(ref tree.Right);
                counter++;
            }
            return counter;
        }


        public Boolean Contains(Country item)
        {
            return contains(item, ref root);
        }

        private Boolean contains(Country item, ref Node<Country> tree)
        //Return true if the item is contained in the BSTree, false 	  //otherwise.
        {
            if (tree == null)
            {
                return false;
            }

            else if (tree.Data.CompareTo(item) == 0)
            {
                return true;
            }

            else if (item.CompareTo(tree.Data) < 0)
            {
                return contains(item, ref tree.Left);
            }

            else if (item.CompareTo(tree.Data) > 0)

            {
                return contains(item, ref tree.Right);
            }
            else return false;
        }

        public Boolean RemoveItem(Country item)
        {
            return removeItem(item, ref root);
        }

        private Boolean removeItem(Country item, ref Node<Country> tree)
        {
            //Case 1
            if (tree == null)
            {
                Console.WriteLine("Tree empty");
                return false;
            }
            //Find the item
            else if (item.CompareTo(tree.Data) < 0)
            {
                removeItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                removeItem(item, ref tree.Right);
            }
            //Case 2
            else if (tree.Left == null)
            {
                tree = tree.Right;
                return true;
            }
            else if (tree.Right == null)
            {
                tree = tree.Left;
                return true;
            }
            //Case 3
            else
            {
                Country newRoot = leastItem(tree.Right);
                tree.Data = newRoot;
                removeItem(newRoot, ref tree.Right);
                return true;
            }

            return false;
        }
        private Country leastItem(Node<Country> tree)
        {
            if (tree.Left == null) //Stopping condition
            {
                return tree.Data;
            }
            return leastItem(tree.Left);
        }

    }
}