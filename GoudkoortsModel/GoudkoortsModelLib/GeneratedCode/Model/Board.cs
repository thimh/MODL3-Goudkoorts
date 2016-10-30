﻿using GoudkoortsModelLib.GeneratedCode.Model;

namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Board
	{
	    public List<BaseTile> tileList0;
        public List<BaseTile> tileList1;
        public List<BaseTile> tileList2;
        public List<BaseTile> tileList3;
        public List<BaseTile> tileList4;
        public List<BaseTile> tileList5;
        public List<BaseTile> tileList6;
        public List<BaseTile> tileList7;
        public List<BaseTile> tileList8;

	    public int score { get; set; }

	    public Board()
	    {
	        tileList0 = new List<BaseTile>();
            tileList1 = new List<BaseTile>();
            tileList2 = new List<BaseTile>();
            tileList3 = new List<BaseTile>();
            tileList4 = new List<BaseTile>();
            tileList5 = new List<BaseTile>();
            tileList6 = new List<BaseTile>();
            tileList7 = new List<BaseTile>();
            tileList8 = new List<BaseTile>();
        }

	    public void MakeRows()
	    {
            //row 0
	        for (int i = 0; i < 12; i++)
	        {
                var tile = new WaterTile();
	            tile.index = i;
                tileList0.Add(tile);
	        }

            //row 1
	        for (int i = 0; i < 12; i++)
	        {
	            if (i != 9)
	            {
	                var tile = new BaseTile();
	                tile.index = i;
                    tileList1.Add(tile);
	                tile.isOccupied = false;
	            }
	            else
	            {
	                var tile = new DockTile();
	                tile.index = i;
                    tileList1.Add(tile);
                    tile.isOccupied = false;
                }
	        }

            //row 2
            var tileRow2 = new BaseTile();
	        tileRow2.index = 0;
            tileList2.Add(tileRow2);
            tileRow2.isOccupied = false;

            //row 3
            for (int i = 0; i < 11; i++)
	        {
                var tile = new BaseTile();
                tile.index = i;
                tileList3.Add(tile);
                tile.isOccupied = false;
            }

            //row 4
	        for (int i = 0; i < 6; i++)
	        {
	            if (i == 0)
	            {
                    var tile = new SwitchTile(1);
                    tile.index = i;
                    tileList4.Add(tile);
                    tile.isOccupied = false;
                }
	            else if (i == 2)
	            {
                    var tile = new SwitchTile(2);
                    tile.index = i;
                    tileList4.Add(tile);
                    tile.isOccupied = false;
                }
                else if (i == 3)
	            {
                    var tile = new SwitchTile(5);
                    tile.index = i;
                    tileList4.Add(tile);
                    tile.isOccupied = false;
                }
	            else
	            {
                    var tile = new BaseTile();
                    tile.index = i;
                    tileList4.Add(tile);
                    tile.isOccupied = false;
                }
	        }

            //row 5
	        for (int i = 0; i < 8; i++)
	        {
                var tile = new BaseTile();
                tile.index = i;
                tileList5.Add(tile);
                tile.isOccupied = false;
            }

            //row 6
	        for (int i = 0; i < 3; i++)
	        {
	            if (i == 1)
	            {
                    var tile = new BaseTile();
                    tile.index = i;
                    tileList6.Add(tile);
                    tile.isOccupied = false;
                }
	            else if (i == 0)
	            {
                    var tile = new SwitchTile(3);
                    tile.index = i;
                    tileList6.Add(tile);
                    tile.isOccupied = false;
                }
                else
	            {
                    var tile = new SwitchTile(4);
                    tile.index = i;
                    tileList6.Add(tile);
                    tile.isOccupied = false;
                }
	        }

            //row 7
	        for (int i = 0; i < 11; i++)
	        {
                var tile = new BaseTile();
                tile.index = i;
                tileList7.Add(tile);
                tile.isOccupied = false;
            }

            //row 8
	        for (int i = 0; i < 11; i++)
	        {
	            if (i > 7)
	            {
                    var tile = new BaseTile();
                    tile.index = i;
                    tileList8.Add(tile);
                    tile.isOccupied = false;
                }
	            else
	            {
                    var tile = new SafeTile();
                    tile.index = i;
                    tileList8.Add(tile);
                    tile.isOccupied = false;
                }
	        }
	    }

	    public void LinkLinks()
	    {
            //row 0
	        tileList0[11].Next = tileList0[10];
            tileList0[10].Next = tileList0[9];
            tileList0[9].Next = tileList0[8];
            tileList0[8].Next = tileList0[7];
            tileList0[7].Next = tileList0[6];
            tileList0[6].Next = tileList0[5];
            tileList0[5].Next = tileList0[4];
            tileList0[4].Next = tileList0[3];
            tileList0[3].Next = tileList0[2];
            tileList0[2].Next = tileList0[1];
            tileList0[1].Next = tileList0[0];

            //row 1
	        tileList1[11].Next = tileList1[10];
            tileList1[10].Next = tileList1[9];
            tileList1[9].Next = tileList1[8];
            tileList1[8].Next = tileList1[7];
            tileList1[7].Next = tileList1[6];
            tileList1[6].Next = tileList1[5];
            tileList1[5].Next = tileList1[4];
            tileList1[4].Next = tileList1[3];
            tileList1[3].Next = tileList1[2];
            tileList1[2].Next = tileList1[1];
            tileList1[1].Next = tileList1[0];

            //row 2 
            tileList2[0].Next = tileList1[11];

            //row 3 
	        tileList3[0].Next = tileList3[1];
	        tileList3[1].Next = tileList3[2];
	        tileList3[2].Next = tileList4[0];
	        tileList3[3].Next = tileList3[4];
            tileList3[4].Next = tileList3[5];
            tileList3[5].Next = tileList3[6];
            tileList3[6].Next = tileList3[7];
            tileList3[7].Next = tileList4[3];
            tileList3[9].Next = tileList2[0];

            //row 4 TODO
	        tileList4[0].Next = tileList4[1];
            tileList4[1].Next = tileList4[2];
	        if (tileList4[2].isUp)
	        {
	            tileList4[2].Next = tileList3[3];
	        }
	        else
	        {
	            tileList4[2].Next = tileList5[3];
	        }
	        tileList4[3].Next = tileList4[4];
            tileList4[4].Next = tileList4[5];
	        tileList4[5].Next = tileList3[9];


            //row 5 
            tileList5[0].Next = tileList5[1];
            tileList5[1].Next = tileList5[2];
	        tileList5[2].Next = tileList4[0];
	        tileList5[3].Next = tileList5[4];
	        tileList5[4].Next = tileList6[0];
	        tileList5[5].Next = tileList5[6];
	        tileList5[6].Next = tileList4[3];

            //row 6 
	        tileList6[0].Next = tileList6[1];
            tileList6[1].Next = tileList6[2];
	        if (tileList6[2].isUp)
	        {
	            tileList6[2].Next = tileList5[5];
	        }
	        else
	        {
	            tileList6[2].Next = tileList7[6];
	        }

            //row 7 
	        tileList7[0].Next = tileList7[1];
            tileList7[1].Next = tileList7[2];
            tileList7[2].Next = tileList7[3];
            tileList7[3].Next = tileList7[4];
            tileList7[4].Next = tileList7[5];
            tileList7[5].Next = tileList6[0];
            tileList7[6].Next = tileList7[7];
            tileList7[7].Next = tileList7[8];
            tileList7[8].Next = tileList7[9];
            tileList7[9].Next = tileList7[10];
            tileList7[10].Next = tileList8[10];

            //row 8
	        tileList8[10].Next = tileList8[9];
            tileList8[9].Next = tileList8[8];
            tileList8[8].Next = tileList8[7];
            tileList8[7].Next = tileList8[6];
            tileList8[6].Next = tileList8[5];
            tileList8[5].Next = tileList8[4];
            tileList8[4].Next = tileList8[3];
            tileList8[3].Next = tileList8[2];
            tileList8[2].Next = tileList8[1];
            tileList8[1].Next = tileList8[0];
        }
	}
}

