using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
  class Program
  {
    public class Node
    {
      public int Value {get; set;}
      public Node Next { get; set; }
    }

    static void Main(string[] args)
    {
      var list = new Node
      {
        Value = 10,
        Next = new Node
        {
          Value = 30,
          Next = new Node
          {
            Value = 20,
            Next = null
          }
        }
      };

      Console.WriteLine("Before reverse:");
      PrintList(list);

      ReverseList(ref list);

      Console.WriteLine("After reverse:");
      PrintList(list);
    }

    public static void PrintList(Node list)
    {
      if(list == null) return;

      var currentNode = list;
      while (currentNode != null)
      {
         Console.WriteLine(currentNode.Value);
         currentNode = currentNode.Next;
      }
    }

    public static void ReverseList(ref Node list)
    {
      if (list == null) return;
      if (list.Next == null) return;

      var prevNode = list;
      var nextNode = prevNode.Next;

      prevNode.Next = null;

      while (nextNode != null)
      {
          var aux = nextNode.Next;

          nextNode.Next = prevNode;

          prevNode = nextNode;
          nextNode = aux;
      }

      list = prevNode;
    }
  }
}
