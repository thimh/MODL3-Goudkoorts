using GoudkoortsModelLib.GeneratedCode.Controller;

namespace Controller
{
	using Model;
	using System;
    using System.Timers;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using View;

    public class GameController
    {
        public string input;


        public virtual bool isGameOver { get; set; }

        public Board board;

        public GameView gameView;

        public OutputController outputController;

        public GameController()
        {
            board = new Board();
            gameView = new GameView(this);
            outputController = new OutputController(this);
            gameView.ShowBoard();
            PlayGame();
        }

        public void PlayGame()
        {
            //board.tileList1[5].currentObject = new Cart();
            //board.tileList1[5].isOccupied = true;

            AddShip();
            if (board.tileList0[9].ship.loadAmount == 10)
            {
                board.tileList0[9].hasShip = false;
                board.tileList0[9].ship = null;

                AddShip();

                board.score += 10;
            }

            Timer moveTimer = new Timer();
            moveTimer.Elapsed += new ElapsedEventHandler(OnTimedEventMove);
            moveTimer.Interval = 2000; //TODO: interval should be changed depenting on score
            moveTimer.Enabled = true;

            //while (Console.Read() != 'q') ;
            while (!isGameOver)
            {
                outputController.SwitchInput();
            }
        }

        public void OnTimedEventMove(object sender, ElapsedEventArgs e)
        {
            //TODO: move all movable opbjects
            //TODO: switch 2 causes problems
            AddCart();
            MoveCart();
            Console.WriteLine("");
            Console.WriteLine("Row 1:");
            Console.WriteLine("Tile 10 isOccupied: " + board.tileList1[10].isOccupied);
            Console.WriteLine("Tile 10 next: " + board.tileList1[10].Next);
            Console.WriteLine("Tile 10 next isOccupied: " + board.tileList1[10].Next.isOccupied);
            Console.WriteLine("Tile 10 next index: " + board.tileList1[10].Next.index);
            Console.WriteLine("Tile 10 next icon: " + board.tileList1[10].Next.icon);
            Console.WriteLine("");
            Console.WriteLine(board.tileList0[9].hasShip);
            Console.WriteLine(board.tileList0[9].ship.icon);
            //Test();
        }

        public void MoveCart()
        {
            MoveCartsRow1();

            MoveCartsRow2();

            MoveCartsRow3();

            MoveCartsRow4();

            MoveCartsRow5();

            MoveCartsRow6();

            MoveCartsRow7();

            MoveCartsRow8();

            gameView.ShowBoard();
        }

        public void MoveCartsRow1()
        {
            MovableObject tempCart;
            foreach (var tile in board.tileList1)
            {
                if (tile.isOccupied)
                {
                    tempCart = tile.currentObject;

                    if (tile.GetType() == typeof(DockTile) && board.tileList0[9].hasShip)
                    {
                        tile.ship.loadAmount++;
                        board.score++;
                    }

                    if (tile.Next != null)
                    {
                        tile.isOccupied = false;
                        tile.currentObject = null;

                        tile.Next.isOccupied = true;
                        tile.Next.currentObject = tempCart;
                        break;
                    }
                    else
                    {
                        tile.isOccupied = false;
                        tile.currentObject = null;
                        break;
                    }
                }
            }
        }

        private void MoveCartsRow2()
        {
            MovableObject tempCart;
            if (board.tileList2[0].isOccupied)
            {
                tempCart = board.tileList2[0].currentObject;
                if (!board.tileList2[0].Next.isOccupied)
                {
                    board.tileList2[0].isOccupied = false;
                    board.tileList2[0].currentObject = null;

                    board.tileList2[0].Next.currentObject = tempCart;
                    board.tileList2[0].Next.isOccupied = true;
                }
                else
                {
                    //collision!
                }
            }
        }

        private void MoveCartsRow3()
        {
            MovableObject tempCart;
            foreach (var tile in board.tileList3)
            {
                if (tile.isOccupied)
                {

                    tempCart = tile.currentObject;
                    if (tile.Next.GetType() != typeof(SwitchTile))
                    {
                        if (!tile.Next.isOccupied)
                        {
                            tile.isOccupied = false;
                            tile.currentObject = null;

                            tile.Next.isOccupied = true;
                            tile.Next.currentObject = tempCart;
                            break;
                        }
                        else
                        {
                            //collision!
                        }
                    }
                    else
                    {
                        if (tile.Next.GetType() == typeof(SwitchTile))
                        {
                            if (!tile.Next.isUp)
                            {
                                break;
                            }
                            else
                            {
                                if (!tile.Next.isOccupied)
                                {
                                    tile.isOccupied = false;
                                    tile.currentObject = null;

                                    tile.Next.isOccupied = true;
                                    tile.Next.currentObject = tempCart;
                                    break;
                                }
                                else
                                {
                                    //collision!
                                }
                            }
                        }
                    }
                }
            }
        }

        private void MoveCartsRow4()
        {
            foreach (var tile in board.tileList4)
            {
                if (tile.isOccupied)
                {
                    tile.currentObject.hasMoved = false;
                }
            }
            MovableObject tempCart;
            foreach (var tile in board.tileList4)
            {
                if (tile.isOccupied)
                {
                    tempCart = tile.currentObject;

                    if (!(tile.GetType() == typeof(SwitchTile)))
                    {
                        if (!tile.Next.isOccupied /* && tile.currentObject.hasMoved == false*/)
                        {
                            tile.isOccupied = false;
                            tile.currentObject = null;

                            tile.Next.isOccupied = true;
                            tile.Next.currentObject = tempCart;
                            break;
                        }
                        else
                        {
                            //collision!
                        }
                    }
                    else
                    {
                        if (tile.index == 2 && tile.isUp)
                        {
                            tile.Next = board.tileList3[3];

                            if (!tile.Next.isOccupied /* && tile.currentObject.hasMoved == false*/)
                            {
                                tile.isOccupied = false;
                                tile.currentObject = null;

                                tile.Next.isOccupied = true;
                                tile.Next.currentObject = tempCart;
                                break;
                            }
                            else
                            {
                                //collision!
                            }
                        }
                        else if (!tile.isUp && tile.index == 2)
                        {
                            tile.Next = board.tileList5[3];

                            if (!tile.Next.isOccupied/* && tile.currentObject.hasMoved == false*/)
                            {
                                tile.isOccupied = false;
                                tile.currentObject = null;

                                tile.Next.isOccupied = true;
                                tile.Next.currentObject = tempCart;
                                break;
                            }
                            else
                            {
                                //collision!
                            }
                        }
                        else
                        {
                            if (!tile.Next.isOccupied/* && tile.currentObject.hasMoved == false*/)
                            {
                                tile.isOccupied = false;
                                tile.currentObject = null;

                                tile.Next.isOccupied = true;
                                tile.Next.currentObject = tempCart;
                                break;
                            }
                            else
                            {
                                //collision!
                            }
                        }
                    }
                    /*if (tile.Next.GetType() != typeof(SwitchTile))
                    {
                        if (!tile.Next.isOccupied && tile.currentObject.hasMoved == false)
                        {
                            tile.isOccupied = false;
                            tile.currentObject = null;

                            tile.Next.isOccupied = true;
                            tile.Next.currentObject = tempCart;

                            tile.ChangeIcon();
                            tile.currentObject.hasMoved = true;
                            break;
                        }
                    }
                    else
                    {
                        if (tile.index == 2)
                        {
                            if (tile.isUp)
                            {
                                tile.Next = board.tileList3[3];
                                //move to tileList3[3]
                                if (tile.Next.isOccupied)
                                {
                                    //collision!
                                }
                                else
                                {

                                    tile.isOccupied = false;
                                    tile.currentObject = null;

                                    tile.Next.isOccupied = true;
                                    tile.Next.currentObject = tempCart;

                                    tile.ChangeIcon();
                                    tile.currentObject.hasMoved = true;
                                    break;
                                }
                            }
                            else
                            {
                                tile.Next = board.tileList5[3];
                                //move to tileList5[3]
                                if (tile.Next.isOccupied)
                                {
                                    //collision!
                                }
                                else
                                {

                                    tile.isOccupied = false;
                                    tile.currentObject = null;

                                    tile.Next.isOccupied = true;
                                    tile.Next.currentObject = tempCart;

                                    tile.ChangeIcon();
                                    tile.currentObject.hasMoved = true;
                                    break;
                                }
                            }
                        }

                    }*/
                }
            }
        }

        private void MoveCartsRow5()
        {
            MovableObject tempCart;
            foreach (var tile in board.tileList5)
            {
                if (tile.isOccupied)
                {

                    tempCart = tile.currentObject;
                    if (tile.Next.GetType() != typeof(SwitchTile))
                    {
                        if (!tile.Next.isOccupied)
                        {
                            tile.isOccupied = false;
                            tile.currentObject = null;

                            tile.Next.isOccupied = true;
                            tile.Next.currentObject = tempCart;
                            break;
                        }
                        else
                        {
                            //collision!
                        }
                    }
                    else
                    {
                        if (tile.Next.GetType() == typeof(SwitchTile))
                        {
                            if (tile.Next.isUp)
                            {
                                break;
                            }
                            else
                            {
                                if (!tile.Next.isOccupied)
                                {
                                    tile.isOccupied = false;
                                    tile.currentObject = null;

                                    tile.Next.isOccupied = true;
                                    tile.Next.currentObject = tempCart;
                                    break;
                                }
                                else
                                {
                                    //collision!
                                }
                            }
                        }
                    }
                }
            }
        }

        private void MoveCartsRow6()
        {
            MovableObject tempCart;
            foreach (var tile in board.tileList6)
            {
                if (tile.isOccupied)
                {

                    tempCart = tile.currentObject;

                    if (!(tile.GetType() == typeof(SwitchTile)))
                    {
                        if (!tile.Next.isOccupied)
                        {
                            tile.isOccupied = false;
                            tile.currentObject = null;

                            tile.Next.isOccupied = true;
                            tile.Next.currentObject = tempCart;
                            break;
                        }
                        else
                        {
                            //collision!
                        }
                    }
                    else
                    {
                        if (tile.index == 2 && tile.isUp)
                        {
                            tile.Next = board.tileList5[5];

                            if (!tile.Next.isOccupied)
                            {
                                tile.isOccupied = false;
                                tile.currentObject = null;

                                tile.Next.isOccupied = true;
                                tile.Next.currentObject = tempCart;
                                break;
                            }
                            else
                            {
                                //collision!
                            }
                        }
                        else if (!tile.isUp && tile.index == 2)
                        {
                            tile.Next = board.tileList7[6];

                            if (!tile.Next.isOccupied)
                            {
                                tile.isOccupied = false;
                                tile.currentObject = null;

                                tile.Next.isOccupied = true;
                                tile.Next.currentObject = tempCart;
                                break;
                            }
                            else
                            {
                                //collision!
                            }
                        }
                        else
                        {
                            if (!tile.Next.isOccupied)
                            {
                                tile.isOccupied = false;
                                tile.currentObject = null;

                                tile.Next.isOccupied = true;
                                tile.Next.currentObject = tempCart;
                                break;
                            }
                            else
                            {
                                //collision!
                            }
                        }
                    }
                    /*if (tile.Next.GetType() != typeof(SwitchTile))
                    {
                        if (!tile.Next.isOccupied)
                        {
                            tile.isOccupied = false;
                            tile.currentObject = null;

                            tile.Next.isOccupied = true;
                            tile.Next.currentObject = tempCart;

                            tile.ChangeIcon();
                            break;
                        }
                    }
                    else
                    {
                        if (tile.index == 2)
                        {
                            if (tile.isUp)
                            {
                                tile.Next = board.tileList5[5];
                                //move to tileList5[5]
                                if (tile.Next.isOccupied)
                                {
                                    //collision!
                                }
                                else
                                {

                                    tile.isOccupied = false;
                                    tile.currentObject = null;

                                    tile.Next.isOccupied = true;
                                    tile.Next.currentObject = tempCart;

                                    tile.ChangeIcon();
                                    break;
                                }
                            }
                            else
                            {
                                tile.Next = board.tileList7[6];
                                //move to tileList7[6]
                                if (tile.Next.isOccupied)
                                {
                                    //collision!
                                }
                                else
                                {

                                    tile.isOccupied = false;
                                    tile.currentObject = null;

                                    tile.Next.isOccupied = true;
                                    tile.Next.currentObject = tempCart;

                                    tile.ChangeIcon();
                                    break;
                                }
                            }
                        }
                    }*/
                }
            }
        }

        private void MoveCartsRow7()
        {
            MovableObject tempCart;
            foreach (var tile in board.tileList7)
            {
                if (tile.isOccupied)
                {

                    tempCart = tile.currentObject;
                    if (tile.Next.GetType() != typeof(SwitchTile))
                    {
                        if (!tile.Next.isOccupied)
                        {
                            tile.isOccupied = false;
                            tile.currentObject = null;

                            tile.Next.isOccupied = true;
                            tile.Next.currentObject = tempCart;
                            break;
                        }
                        else
                        {
                            //collision!
                        }
                    }
                    else
                    {
                        if (tile.Next.GetType() == typeof(SwitchTile))
                        {
                            if (tile.Next.isUp)
                            {
                                break;
                            }
                            else
                            {
                                if (!tile.Next.isOccupied)
                                {
                                    tile.isOccupied = false;
                                    tile.currentObject = null;

                                    tile.Next.isOccupied = true;
                                    tile.Next.currentObject = tempCart;
                                    break;
                                }
                                else
                                {
                                    //collision!
                                }
                            }
                        }

                    }
                }
            }
        }

        private void MoveCartsRow8()
        {
            MovableObject tempCart;
            foreach (var tile in board.tileList1)
            {
                if (tile.isOccupied)
                {

                    tempCart = tile.currentObject;

                    if (tile.Next != null)
                    {
                        if (!tile.Next.isOccupied)
                        {
                            tile.isOccupied = false;
                            tile.currentObject = null;

                            tile.Next.isOccupied = true;
                            tile.Next.currentObject = tempCart;
                            break;
                        }
                        else
                        {
                            //if(tile.Next.index > 7)
                            //usually a collision check but these are safe spaces
                            //check if(tile.index == 0)
                            //perform no aciton
                        }
                    }
                }
            }
        }

        public void AddCart()
        {
            int random = new Random().Next(1, 4);
            switch (random)
            {
                case 1:
                    if (!board.tileList3[0].isOccupied)
                    {
                        board.tileList3[0].isOccupied = true;
                        MovableObject cart = new Cart();
                        board.tileList3[0].currentObject = cart;
                    }
                    break;
                case 2:
                    if (!board.tileList5[0].isOccupied)
                    {
                        board.tileList5[0].isOccupied = true;
                        MovableObject cart = new Cart();
                        board.tileList5[0].currentObject = cart;
                    }
                    break;
                case 3:
                    if (!board.tileList7[0].isOccupied)
                    {
                        board.tileList7[0].isOccupied = true;
                        MovableObject cart = new Cart();
                        board.tileList7[0].currentObject = cart;
                    }
                    break;
                default:
                    break;
            }
            gameView.ShowBoard();
        }

        public void AddShip()
        {
            var tile = board.tileList0[9];
            tile.ship = new Ship();
            tile.hasShip = true;

            tile.ship.loadAmount = 0;
        }

        public void Test()
        {
            MoveCart();
            AddCart();
        }
    }
}

