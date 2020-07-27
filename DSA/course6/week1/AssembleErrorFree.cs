using Util.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.course6.week1
{
    class AssembleErrorFree
    {
        public static void Run() {
            string[] strings = new string[] { "AAGGG", "ACTTT", "AGGCT", "GCCAC", "TCCGC" };
            PrefixTree tree = new PrefixTree(strings);
            tree.PrintTree();
        }

    }
}
