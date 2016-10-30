using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace GoudkoortsModelLib.GeneratedCode.Model
{
    class WaterTile : BaseTile
    {
        public override string icon
        {
            get
            {
                if (hasShip)
                {
                    return "<0" + ship.loadAmount + ">";
                }
                return "<~~>";
            }
        }
    }
}
