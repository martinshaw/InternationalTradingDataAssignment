using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingDataAssignment
{
    public class Node<Country> where Country : IComparable<Country>
    {

        private Country data;
        public Node<Country> Left;
        public Node<Country> Right;
        private int balanceFactor = 0; //added for AVLTree


        public Node(Country item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        public Country Data
        {
            set { data = value; }
            get { return data; }
        }

        public int BalanceFactor
        {
            set { balanceFactor = value; }
            get { return balanceFactor; }
        }

    }
}
