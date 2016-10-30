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
        public ConsoleKeyInfo input;

        public GameController gameController;

        public OutputController(GameController gameController)
        {
            this.gameController = gameController;
        }

        public void SwitchInput()
        {
            input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    var switch1 = gameController.board.tileList4[0];
                    if (!switch1.isOccupied)
                    {
                        if (switch1.isUp)
                        {
                            switch1.isUp = false;
                        }
                        else
                        {
                            switch1.isUp = true;
                        }
                    }
                    break;
                case ConsoleKey.D2:
                    var switch2 = gameController.board.tileList4[2];
                    if (!switch2.isOccupied)
                    {
                        if (switch2.isUp)
                        {
                            switch2.isUp = false;
                        }
                        else
                        {
                            switch2.isUp = true;
                        }
                    }
                    break;
                case ConsoleKey.D3:
                    var switch3 = gameController.board.tileList6[0];
                    if (!switch3.isOccupied)
                    {
                        if (switch3.isUp)
                        {
                            switch3.isUp = false;
                        }
                        else
                        {
                            switch3.isUp = true;
                        }
                    }
                    break;
                case ConsoleKey.D4:
                    var switch4 = gameController.board.tileList6[2];
                    if (!switch4.isOccupied)
                    {
                        if (switch4.isUp)
                        {
                            switch4.isUp = false;
                        }
                        else
                        {
                            switch4.isUp = true;
                        }
                    }
                    break;
                case ConsoleKey.D5:
                    var switch5 = gameController.board.tileList4[3];
                    if (!switch5.isOccupied)
                    {
                        if (switch5.isUp)
                        {
                            switch5.isUp = false;
                        }
                        else
                        {
                            switch5.isUp = true;
                        }
                    }
                    break;
                default:
                    break;
            }
            gameController.gameView.ShowBoard();
        }
    }
}
