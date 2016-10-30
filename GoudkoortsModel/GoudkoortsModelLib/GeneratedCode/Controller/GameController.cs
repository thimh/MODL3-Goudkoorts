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
        public bool isGameOver { get; set; }

        public Board board;

        public GameView gameView;

        public OutputController outputController;

        public GameController()
        {
            board = new Board();
            gameView = new GameView(this);
            outputController = new OutputController(this);

            var moveTimer = new Timer();
            moveTimer.Elapsed += new ElapsedEventHandler(OnTimedEventMove);
            moveTimer.Interval = 5000; //TODO: interval should be changed depenting on score
            moveTimer.Enabled = true;

            gameView.ShowBoard();
            PlayGame();
        }

        public void PlayGame()
        {
            while (!isGameOver)
            {
                if (board.tileList0[9].hasShip == false)
                {
                    AddShip();
                }
                else if (board.tileList0[9].ship.loadAmount == 10)
                {
                    board.tileList0[9].hasShip = false;
                    board.tileList0[9].ship = null;

                    AddShip();

                    board.score += 10;
                }

                outputController.SwitchInput();
            }
        }

        public void OnTimedEventMove(object sender, ElapsedEventArgs e)
        {
            AddCart();
            MoveCart();
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
                        board.tileList0[9].ship.loadAmount++;
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
                    //isGameOver = true;
                    //gameView.ShowGameOver();
                    //moveTimer.Stop();
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
                            //isGameOver = true;
                            //gameView.ShowGameOver();
                            //moveTimer.Stop();
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
                                    //isGameOver = true;
                                    //gameView.ShowGameOver();
                                    //moveTimer.Stop();
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
                            //isGameOver = true;
                            //gameView.ShowGameOver();
                            //moveTimer.Stop();
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
                                //isGameOver = true;
                                //gameView.ShowGameOver();
                                //moveTimer.Stop();
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
                                //isGameOver = true;
                                //gameView.ShowGameOver();
                                //moveTimer.Stop();
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
                                //isGameOver = true;
                                //gameView.ShowGameOver();
                                //moveTimer.Stop();
                            }
                        }
                    }
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
                            //isGameOver = true;
                            //gameView.ShowGameOver();
                            //moveTimer.Stop();
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
                                    //isGameOver = true;
                                    //gameView.ShowGameOver();
                                    //moveTimer.Stop();
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
                            //isGameOver = true;
                            //gameView.ShowGameOver();
                            //moveTimer.Stop();
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
                                //isGameOver = true;
                                //gameView.ShowGameOver();
                                //moveTimer.Stop();
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
                                //isGameOver = true;
                                //gameView.ShowGameOver();
                                //moveTimer.Stop();
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
                                //isGameOver = true;
                                //gameView.ShowGameOver();
                                //moveTimer.Stop();
                            }
                        }
                    }
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
                            //isGameOver = true;
                            //gameView.ShowGameOver();
                            //moveTimer.Stop();
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
                                    //isGameOver = true;
                                    //gameView.ShowGameOver();
                                    //moveTimer.Stop();
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
    }
}

