﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Board
	{
	    public LinkedList<BaseTile> tileList0;
        public LinkedList<BaseTile> tileList1;
        public LinkedList<BaseTile> tileList2;
        public LinkedList<BaseTile> tileList3;
        public LinkedList<BaseTile> tileList4;
        public LinkedList<BaseTile> tileList5;
        public LinkedList<BaseTile> tileList6;
        public LinkedList<BaseTile> tileList7;
        public LinkedList<BaseTile> tileList8;

	    public int switchTileCounter = 1;
        
        public Board()
	    {
            tileList0 = new LinkedList<BaseTile>();
            tileList1 = new LinkedList<BaseTile>();
            tileList2 = new LinkedList<BaseTile>();
            tileList3 = new LinkedList<BaseTile>();
            tileList4 = new LinkedList<BaseTile>();
            tileList5 = new LinkedList<BaseTile>();
            tileList6 = new LinkedList<BaseTile>();
            tileList7 = new LinkedList<BaseTile>();
            tileList8 = new LinkedList<BaseTile>();
        }

	    public void FillLinkedLists()
        {
            //For array index 0
            var tileList0Node = new LinkedListNode<BaseTile>(new BaseTile());
            tileList0.AddFirst(tileList0Node);
            for (int i = 0; i < 11; i++)
            {
                var node = new LinkedListNode<BaseTile>(new BaseTile());
                tileList0.AddAfter(tileList0.FindLast(tileList0Node.Value), node);
            }

            //For array index 1
            var tileList1Node = new LinkedListNode<BaseTile>(new BaseTile());
            tileList1.AddFirst(tileList1Node);
            for (int i = 0; i < 11; i++)
            {
                if (i == 2)
                {
                    var node = new LinkedListNode<BaseTile>(new DockTile());
                    tileList1.AddAfter(tileList1.FindLast(tileList1Node.Value), node);
                }
                else
                {
                    var node = new LinkedListNode<BaseTile>(new BaseTile());
                    tileList1.AddAfter(tileList1.FindLast(tileList1Node.Value), node);
                }
            }

            //For array index 2
            tileList2.AddFirst(new BaseTile());
            //tileList2.AddAfter(tileList2.FindLast(tileList2.First.Value), tileList1.First);
            tileList2.First.Next = tileList1.First;


            ////For array index 3
            //var tileList1Node = new LinkedListNode<BaseTile>(new BaseTile());
            //tileList1.AddFirst(tileList1Node);
            //for (int i = 0; i < 11; i++)
            //{
            //    if (i == 2)
            //    {
            //        var node1 = new LinkedListNode<BaseTile>(new DockTile());
            //        tileList1.AddAfter(tileList1.FindLast(tileList1Node.Value), node);
            //    }
            //    else
            //    {
            //        var node1 = new LinkedListNode<BaseTile>(new BaseTile());
            //        tileList1.AddAfter(tileList1.FindLast(tileList1Node.Value), node);
            //    }
            //}

            ////For array index 4
            //var tileList1Node = new LinkedListNode<BaseTile>(new BaseTile());
            //tileList1.AddFirst(tileList1Node);
            //for (int i = 0; i < 11; i++)
            //{
            //    if (i == 2)
            //    {
            //        var node1 = new LinkedListNode<BaseTile>(new DockTile());
            //        tileList1.AddAfter(tileList1.FindLast(tileList1Node.Value), node);
            //    }
            //    else
            //    {
            //        var node1 = new LinkedListNode<BaseTile>(new BaseTile());
            //        tileList1.AddAfter(tileList1.FindLast(tileList1Node.Value), node);
            //    }
            //}

            ////For array index 5
            //var tileList1Node = new LinkedListNode<BaseTile>(new BaseTile());
            //tileList1.AddFirst(tileList1Node);
            //for (int i = 0; i < 11; i++)
            //{
            //    if (i == 2)
            //    {
            //        var node1 = new LinkedListNode<BaseTile>(new DockTile());
            //        tileList1.AddAfter(tileList1.FindLast(tileList1Node.Value), node);
            //    }
            //    else
            //    {
            //        var node1 = new LinkedListNode<BaseTile>(new BaseTile());
            //        tileList1.AddAfter(tileList1.FindLast(tileList1Node.Value), node);
            //    }
            //}

            ////For array index 6
            //var tileList1Node = new LinkedListNode<BaseTile>(new BaseTile());
            //tileList1.AddFirst(tileList1Node);
            //for (int i = 0; i < 11; i++)
            //{
            //    if (i == 2)
            //    {
            //        var node1 = new LinkedListNode<BaseTile>(new DockTile());
            //        tileList1.AddAfter(tileList1.FindLast(tileList1Node.Value), node);
            //    }
            //    else
            //    {
            //        var node1 = new LinkedListNode<BaseTile>(new BaseTile());
            //        tileList1.AddAfter(tileList1.FindLast(tileList1Node.Value), node);
            //    }
            //}

            ////For array index 7
            //var tileList1Node = new LinkedListNode<BaseTile>(new BaseTile());
            //tileList1.AddFirst(tileList1Node);
            //for (int i = 0; i < 11; i++)
            //{
            //    if (i == 2)
            //    {
            //        var node1 = new LinkedListNode<BaseTile>(new DockTile());
            //        tileList1.AddAfter(tileList1.FindLast(tileList1Node.Value), node);
            //    }
            //    else
            //    {
            //        var node1 = new LinkedListNode<BaseTile>(new BaseTile());
            //        tileList1.AddAfter(tileList1.FindLast(tileList1Node.Value), node);
            //    }
            //}

            ////For array index 8
            //var tileList8Node = new LinkedListNode<BaseTile>(new BaseTile());
            //tileList1.AddFirst(tileList1Node);
            //for (int i = 0; i < 11; i++)
            //{
            //    if (i == 2)
            //    {
            //        var node = new LinkedListNode<BaseTile>(new DockTile());
            //        tileList1.AddAfter(tileList8.FindLast(tileList8Node.Value), node);
            //    }
            //    else
            //    {
            //        var node = new LinkedListNode<BaseTile>(new BaseTile());
            //        tileList8.AddAfter(tileList8.FindLast(tileList8Node.Value), node);
            //    }
            //}

        }

        public void TestLists()
	    {
            FillLinkedLists();
	        foreach (var tile in tileList1)
	        {
                Console.Write(tile.icon);
            }
	        foreach (var baseTile in tileList2)
	        {
	            Console.Write(tile.icon);
	        }
            Console.WriteLine("Test");
	        Console.ReadLine();
	    }
	}
}

