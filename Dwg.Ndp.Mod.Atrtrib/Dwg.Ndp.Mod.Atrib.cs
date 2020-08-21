using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwg.Ndp.Mod.Atrtrib
{
    [Flags]
    public enum GameRealms : int
    {
    UpperWorld = 0, LowerWorld = 1,
    LightWorld = 2, DarcWorld = 3,
    SpiritWorld = 4, EmptyWorld = -1
    }
    public class TDwgNdpModAtibu:Attribute
    {
    protected GameRealms realms;
    }
    }
