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
    UpperWorld = 0,  LowerWorld = 1,
    LightWorld = 2,  DarcWorld =  3,
    SpiritWorld = 4,MiddleWorld  =5,
    EmptyWorld =-1
    }
    public class TDwgNdpModAtibu:Attribute
    {
    protected GameRealms realms;
    protected Int32  realmsnumber;
    protected string namestr;
        
    public  void InitModAsembly()
    {
    TDwgNdpModAtibu dwgNdpMod = new TDwgNdpModAtibu();
   try
    {
    dwgNdpMod.namestr = "Upper World";
    }
   finally
    {
    dwgNdpMod.TheNameWorldsUpper(realms, namestr, realmsnumber);  
    }
    }

    public GameRealms TheGameRealms
     {
 get => realms;
 set => realms = value;
    }
    public Int32  TheRealmsNumbers 
    {
  get => realmsnumber;
  set => realmsnumber = value;
    }
    public string TheNameStr
    {
get => namestr;
set => namestr = value;
    }
    public TDwgNdpModAtibu()
    {
    TheGameRealms = GameRealms.EmptyWorld;        
    }
    public TDwgNdpModAtibu(GameRealms gameRealms)
    {
    realms = gameRealms;
    }

    public TDwgNdpModAtibu(GameRealms theRealms,Int32 numbe)
    {
    realms = theRealms;
    realmsnumber = numbe;
    }

    public TDwgNdpModAtibu(GameRealms threalms, string nameRealms,Int32 numbe)
    {
    realms       = threalms;
    realmsnumber = numbe;
    namestr      = nameRealms;              
    }

    [Serializable]
    public  class TDwNdpModWorldOneAtribu
    {
    [TDwgNdpModAtibu(GameRealms.UpperWorld)]
    public void GameWorldUpper() {}
    }

    [TDwgNdpModAtibu(GameRealms.LowerWorld)]
    public void GameWorldLower()  { }


    [TDwgNdpModAtibu(GameRealms.DarcWorld)] 
    public void GameWorldDarc()    { }

    [TDwgNdpModAtibu(GameRealms.SpiritWorld)]
    public void GameWorldSpirit() { }

    [TDwgNdpModAtibu(GameRealms.UpperWorld,"upper world",0)]
    public void TheNameWorldsUpper(GameRealms realms,string worlNstr,Int32 worlnum)
    {
    TheGameRealms = realms;
    TheNameStr = worlNstr;
    TheRealmsNumbers = worlnum;
    }                  
    }
    }
