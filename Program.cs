using System;

namespace ConsoleApp1;

class Program
{
    public static void Main(string[] args)
    {
        binaryTree b = new binaryTree();

        b.Add(56);
        b.Add(30);
        b.Add(70);
       
        b.TraversePreorder(b.Root);
    }
}