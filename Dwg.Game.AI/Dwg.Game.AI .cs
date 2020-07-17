using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

 namespace Dwg.Game.AI
 {
 public class TDwgGameAI
 {

 private Int32[] gameAI = {0,0,0,-0,1-1,45,-78,35,-68,54,78,12,
                          -12,34,12,-5,5,89,4,4,23,23,-23,-23,12
                          ,89,6,100,300,500,700,34,0,34,-34,47,22
                          ,5,7,25,40,48,-48,-5,9,-9, 0,50,-3,10,11
                          ,8,9,12,900,-100,-300,-500,-700,23,-26,12
                          ,-8,-9,400,600,800,-100,0,300,7,9,10,9,3,1
                          ,120,-120,123,126,130,6,8,12,18,21,-21,7,5
                          ,34,36,-39,-45,2,2,2,-2,0-2,-2,5,-5-5,9,90,
                          -6,9,15,20,-400,-300,23,27,39,-39-39,3,9,1
                          ,10,15,18,24,240,0,245,246,248,3,9,-10,11,4
                          ,100,34,23,8,12,19,0-19,20,23,56,7,9,12,3,3
                           ,6,12,23,20,-20,-7,1,10,11,6,7,9,2,4,0,0,0, 
                          };

 private TDwgGameDatAI dwgGameDatAI;
 private static Random randomValue = new Random();
 private Int32 theCounters = 0;
 private static Thread  theThreads;
                                                        
 public void InitAllGameAI()
 {
 TDwgGameDatAI gameDatAI = new TDwgGameDatAI();

 TDwgGameDatAI datAI = new TDwgGameDatAI(gameAI);
try
 {
 TDwgGameAI dwgGameAI = new TDwgGameAI();
 for (int GameAILoop = 0; GameAILoop < gameAI.LongLength; GameAILoop++)
 {
 theCounters++;
 gameAI[GameAILoop]           =    randomValue.Next() * 1;
 dwgGameAI.gameAI[GameAILoop] =    gameAI[GameAILoop];
 }
 }
finally
 {
 datAI.InitSetUpRndNumAI(ref theCounters, TDwgGameDatAI.TheRandomValue);
 datAI.InitGameDatAI();
  }
  }
  public virtual void InitGameDatAI()
  {
  
  }
  public TDwgGameAI():this(theThreads)
  {
  //default Constructor
  }
  public Int32 [] TheGameSetAI
  {
 get => gameAI;
 set => gameAI = value;
  }

  public Thread Thread
  {
  get => theThreads;
  set => theThreads = value;
  }
  public static Random TheRandomValue
  {
get => randomValue;
set => randomValue = value;
  }
  public TDwgGameDatAI TheDwgGameDatAI
  {
get => dwgGameDatAI;
set => dwgGameDatAI = value;
  }
  public int TheCountersValue
  {
get => theCounters;
set => theCounters = value;
  }

  public TDwgGameAI(Thread thread)
  {
  theThreads = thread;
  }
  public class TDwgGameDatAI:TDwgGameAI
  {
  private Int32 rndNums = 0;
  public TDwgGameDatAI():this(TDwgGameAI.TheRandomValue)
  {
  //defaul constrctor  
  }
  public TDwgGameDatAI(Random randomn)
  {
  InitSetUpRndNumAI(randomn);
  }
  public override void InitGameDatAI()
  {

  base.InitGameDatAI();
  }
  public void InitSetUpRndNumAI(ref Int32 rndCou,Random random)
  {
  rndCou = InitGetRndValues(rndCou, random);
  }
  protected Int32 InitGetRndValues(in Int32 rndCou,Random random)
  {
  return random.Next(rndCou);
  }
  protected void InitSetUpRndNumAI(Random random)
  {
  TheRandomValue = random;
  }
   public Int32 TheRndNums
   {
get => rndNums;
set => rndNums = value;
   }
  public TDwgGameDatAI(Int32[] VsArr)
  {
  gameAI = VsArr;
  }
  }
  }
  }
