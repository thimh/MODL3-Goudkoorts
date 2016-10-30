using Controller;
using Model;

namespace View
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class GameView
	{
	    public GameController controller;

	    public GameView(GameController controller)
	    {
	        this.controller = controller;
            controller.board.MakeRows();
            controller.board.LinkLinks();
	    }

		public virtual void ShowBoard()
		{
            Console.Clear();
            //row 0
		    foreach (var tile in controller.board.tileList0)
		    {
		        Console.Write(tile.icon);
		    }
            Console.WriteLine("");

            //row 1
		    foreach (var tile in controller.board.tileList1)
		    {
		        Console.Write(tile.icon);
		    }
            Console.WriteLine("");

            //row 2
		    for (int i = 0; i < 12; i++)
		    {
		        if (i == 11)
		        {
		            Console.Write(controller.board.tileList2[0].icon);
		        }
		        else
		        {
		            Console.Write("    ");
		        }
		    }
            Console.WriteLine("");

            //row 3
            Console.Write("[AA]");
		    for (int i = 0; i < 3; i++)
		    {
                Console.Write(controller.board.tileList3[i].icon);
            }
            Console.Write("    ");
            for (int i = 4; i < 9; i++)
            {
                Console.Write(controller.board.tileList3[i].icon);
            }
            Console.Write("    ");
            Console.Write(controller.board.tileList3[9].icon);
            Console.WriteLine("");

            //row 4
            Console.Write("    "); Console.Write("    "); Console.Write("    ");
            for (int i = 0; i < 3; i++)
            {
                
                    Console.Write(controller.board.tileList4[i].icon);
                
            }
            Console.Write("    "); Console.Write("    "); Console.Write("    ");
		    for (int i = 3; i < 6; i++)
		    {
		        Console.Write(controller.board.tileList4[i].icon);
		    }
            Console.WriteLine("");

            //row 5
            Console.Write("[BB]");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(controller.board.tileList5[i].icon);
            }
            Console.Write("    ");
		    for (int i = 3; i < 5; i++)
		    {
                Console.Write(controller.board.tileList5[i].icon);
            }
            Console.Write("    ");
            for (int i = 5; i < 7; i++)
            {
                Console.Write(controller.board.tileList5[i].icon);
            }


            Console.WriteLine("");

            //row 6
            Console.Write("    "); Console.Write("    "); Console.Write("    "); Console.Write("    "); Console.Write("    "); Console.Write("    ");
            foreach (var tile in controller.board.tileList6)
		    {
		        Console.Write(tile.icon);
		    }
            Console.WriteLine("");

            //row 7
            Console.Write("[CC]");
            for (int i = 0; i < 11; i++)
            {
                if (i == 6)
                {
                    Console.Write("    ");
                }
                else
                {
                    Console.Write(controller.board.tileList7[i].icon);
                }
            }
            Console.WriteLine("");

            //row 8
            Console.Write("    ");
		    foreach (var tile in controller.board.tileList8)
		    {
		        Console.Write(tile.icon);
		    }

            //score
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Score: " + controller.board.score);

            //controls
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Use the numbers 1 - 5 to control the switches");
        }

		public void ShowGameOver()
		{
            Console.Clear();
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("|--------------- GAMEOVER ----------------|");
            Console.WriteLine("|-----------------------------------------|");
        }

	}
}

