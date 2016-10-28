using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using View;

namespace GoudkoortsModelLib.GeneratedCode.Controller
{
    public class OutputController
    {
        public string input;

        public GameController gameController;

        public OutputController(GameController gameController)
        {
            this.gameController = gameController;
        }

        public void SwitchInput()
        {
            //TODO: check if isOccupied
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    if (gameController.board.tileList4[0].isUp)
                    {
                        gameController.board.tileList4[0].isUp = false;
                    }
                    else
                    {
                        gameController.board.tileList4[0].isUp = true;
                    }
                    break;
                case "2":
                    if (gameController.board.tileList4[2].isUp)
                    {
                        gameController.board.tileList4[2].isUp = false;
                    }
                    else
                    {
                        gameController.board.tileList4[2].isUp = true;
                    }
                    break;
                case "3":
                    if (gameController.board.tileList6[0].isUp)
                    {
                        gameController.board.tileList6[0].isUp = false;
                    }
                    else
                    {
                        gameController.board.tileList6[0].isUp = true;
                    }
                    break;
                case "4":
                    if (gameController.board.tileList6[2].isUp)
                    {
                        gameController.board.tileList6[2].isUp = false;
                    }
                    else
                    {
                        gameController.board.tileList6[2].isUp = true;
                    }
                    break;
                case "5":
                    if (gameController.board.tileList4[3].isUp)
                    {
                        gameController.board.tileList4[3].isUp = false;
                    }
                    else
                    {
                        gameController.board.tileList4[3].isUp = true;
                    }
                    break;
                default:
                    break;
            }
            gameController.gameView.ShowBoard();
        }
    }
}
