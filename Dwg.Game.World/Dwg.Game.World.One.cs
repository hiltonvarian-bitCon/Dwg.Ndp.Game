using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Dwg.Game.World
 {
 using Dwg.Game.AI;
 using Dwg.Ndp.Data.Games;
 using Dwg.Ndp.Attrib;
 using Dwg.Ndp.Person;
 using Dwg.Ndp.Game.Con;

    public  enum TheGamWorlds:int
  {
  EarthWorld=0,AirWorld=1,
  FireWorld =2,WaterWorld=2,
  DarcWorld =3,SpiritWorld=4,
  NoWorld =-1
  }
 [Serializable]
 public class TDwgGameWorld
    {
  private string nameWorld;
  private TheGamWorlds worlds = TheGamWorlds.NoWorld;

  private Int32 gameWorldAmounts = TDwgNdpGameConVal.C_GameWorldsCount;
  private Int32 temAi;

 public TDwgGameWorld()
 {
 gameWorldAmounts = TDwgNdpGameConVal.C_GameWorldsCount;
 }

 public string TheNameWorldSet
 {
get => nameWorld;
set => nameWorld = value;
 }
 public Int32 TheTemAi
 { 
get => temAi;
set => temAi = value;
 }
 public TheGamWorlds TheGameWorldsSet
 {
get => worlds;
set => worlds = value;
 }
 public Int32 TheGameWorldAmounts
 {
get                                                     
 {

  return gameWorldAmounts;
 }
 set => gameWorldAmounts = value;
 }

 public virtual void InitGameWorld()
 {

 }
 public void InitGameWorld(Int32 worldAxisX,Int32 worldAxisY)
 {
 
 }
 public virtual TDwgGameAI  InitGameWorld(Int32 valueAi,Int32[]aiArr)
 {

 return new TDwgGameAI(valueAi, aiArr);
 } 
 [Serializable]
 public class TDwgGameWorldOne:TDwgGameWorld
 {
 
 public TDwgGameWorldOne()
 {

 }
 internal string TheDwgGameWorldGet
 {
get => nameWorld;
set => nameWorld = value;
 }
 internal TheGamWorlds TheWorldsGet
 {
get => worlds;
set => worlds = value;
 }
  public override void InitGameWorld()
 {
 base.InitGameWorld();
 }

 public override TDwgGameAI InitGameWorld(Int32 valueAi, Int32[] aiArr)
 {
 return base.InitGameWorld(valueAi, aiArr);
 }
 }
 
 }
 }
