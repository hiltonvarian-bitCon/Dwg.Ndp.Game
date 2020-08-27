using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Dwg.Game.AI
 {
 public class TDwgGameAI
 {
 private Int32 fibValusNums;
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
 private Dictionary<byte, TDwgGameAI> thevaluePairs;
 
 private   readonly Int32 gameValueCountAI;
 private   readonly ArraySegment<Int32> arrSeg;
 
 public  virtual void  SetUpFibNums()
 {
 SetupFibNums(GetFibValue(fibValusNums,1));
                                                               
 }
  public void SetupFibNums(Int32 fibValueNum)
 {
 fibValusNums = fibValueNum;
 }
 public  Int32 GetFibValue(Int32 fibConValue,Int32 count)
 {
 if(fibConValue<2)
 {
 return 1;
 }
 return GetFibValue(fibConValue * 2,count);
 }
 private static Random randomValue = new Random();

 private static Thread  theThreads;

 private TDwgGameDatAI dwgGameDatAI;
 private Int32 theCounters = 0;
                                                                                        
 private Int32[] theGameArrAI;

 public void InitAllGameAI()
 {
 TDwgGameDatAI GameDatAI = new TDwgGameDatAI();
 try
  {
  TDwgGameAI DwgGameAI = new TDwgGameAI();
  for (Int32 GameAILoop = 0; GameAILoop < gameAI.LongLength; GameAILoop++)
  {
  theCounters++;

  gameAI[GameAILoop] = randomValue.Next() * 1;
  DwgGameAI.gameAI[GameAILoop] = gameAI[GameAILoop];
  }
  }
 finally
  {
  TDwgGameDatAI DatAI = new TDwgGameDatAI(gameAI);
  DatAI.InitSetUpRndNumAI(ref theCounters, TheRandomValue);

  DatAI.SetUpDic(DatAI.AllTheyValuePairs);

  DatAI.InitGameDatAI();
  DatAI.InitAllArr();
  DatAI.SetUpFibNums();
  }
  }
  public void InitAllArr()
  {
  theGameArrAI  = new Int32[gameAI.LongLength];

  thevaluePairs = new Dictionary<byte, TDwgGameAI>(theGameArrAI.Length);
 try
  {
  theGameArrAI[0] = TheRandomValue.Next()*1;
  theGameArrAI[1] = TheRandomValue.Next()*2;
  theGameArrAI[2] = TheRandomValue.Next()*3;

  InitAllArr(theGameArrAI);
  }                                                                                               
finally
  {
  ArraySegment<Int32> tharr = new ArraySegment<Int32>(theGameArrAI);
  
  InitAllArr(theGameArrAI, tharr);
  }
  }
  protected void InitAllArr(Int32[] valArray)
  {
  theGameArrAI = valArray;
  }

  public virtual void InitGameDatAI()
  {
  dwgGameDatAI = new TDwgGameDatAI(TheRandomValue);
 try
  {
  dwgGameDatAI.TheGameSetAI [0]  = randomValue.Next() * 1;
  }
 finally
  {
  dwgGameDatAI.theCounters++; 
  dwgGameDatAI.InitSetUpRndNumAI(ref theCounters, randomValue);                  
  }
  } 
 
  public virtual void  SetUpDic(Dictionary<byte,TDwgGameAI> valuePairs)
  {
  thevaluePairs = valuePairs;
  }                                                                                          
  public TDwgGameAI():this(theThreads)
  {
  //default Constructor
  }
  protected void InitAllArr(Int32[] valArray,ArraySegment<Int32> arSeg)
  {
  TheGamseArrAI = valArray;
  
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
  public Int32 TheCountersValue
  {
get => theCounters;
set => theCounters = value;
  }
  public Int32[] TheGamseArrAI
  {
 get => theGameArrAI;
 set => theGameArrAI = value;
  } 
  public Int32 TheFibValuNums
  {
get => fibValusNums;
set => fibValusNums = value;
 }
 public Int32 GameValueAI
 {
get
 {
 return gameValueCountAI;
 }
 }
 public ArraySegment<Int32>TheArrSeg 
 {
get
 {
 return arrSeg;
 }
 }

  public Dictionary<byte, TDwgGameAI> ThevaluePairs
  {
 get
  {
  return thevaluePairs;
  }
  }

 public TDwgGameAI(Thread thread)
 {
 theThreads = thread;
 }
 public TDwgGameAI(Int32 valueAi, Int32[] aiArr):this(valueAi,aiArr,new ArraySegment<Int32>(aiArr))
 {
 gameValueCountAI = valueAi;
 gameAI           = aiArr;
 }
  public  TDwgGameAI(Int32 valueAI, Int32[]aiArr,ArraySegment<Int32> arVs)
  {
  arrSeg = arVs;
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
  public override void SetUpFibNums()
  {

  base.SetUpFibNums();
  }
  public override void InitGameDatAI()
  {
  
  base.InitGameDatAI();
  }

  private  Dictionary<byte, TDwgGameAI> keyValuePairs = new Dictionary<byte, TDwgGameAI>(); 

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
  public Dictionary<byte, TDwgGameAI> AllTheyValuePairs                                                                                                  
  {                                                                            
get => keyValuePairs; 
set => keyValuePairs = value;
  }
   public override void SetUpDic(Dictionary<byte, TDwgGameAI> valuePairs)
   {
  
   foreach (KeyValuePair<byte,TDwgGameAI> theItem in valuePairs )
   {
    
   }
   base.SetUpDic(valuePairs);
   }
   public TDwgGameDatAI(Int32[] VsArr)
  {
  gameAI = VsArr;
  }
  protected void SetUpDic(Dictionary<byte,TDwgGameAI> valuePairs, Int32[] VsArr)
  {
  TheGameSetAI[0] = VsArr[0];
  }
  }
  }
  }
