﻿   namespace Dwg.Ndp.Data.Games
   {
    using System;
    using System.Windows.Forms;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Timers;
    using Dwg.Game.AI;

    [Flags]
    public  enum NatureElementsFlags:int
    {
    EarthElem=0,AirElem=1,FireElem=2,
    WaterElem =3,DarcElem=4,NoElemFlagsValue=-1
    }

   [Flags]
    public  enum NatElementsFlagsGF:int
    {
    EarthElemGF=0,AirElemGF=1,FireElemGF=2,
    WaterGF =3,DarcElemGF=4,
    NoElemGF =-1
    }

    [Flags]
    public enum TheKeysFlags:int
    {
    IronKey=0,MetalKey  =2,RusterdKey   =3,
    CopperKey =4,GoldKey=5,MoonMetalKeys=6,
    NoKeys =-1
    }

    [Flags]
    public  enum GameDirections:int
    {
    North=0,South=1,West=2,East=3,
    NorthEast=4,SouthEaast=4,
    SouthWest=5,NoDirection=-1
    }
    public class TDwgNdpGamesData
    {
    private TDwgGameDats dwgGameDats;

    private static  NatureElementsFlags elements        = NatureElementsFlags.NoElemFlagsValue;
    private static  NatElementsFlagsGF  elementsGF      = NatElementsFlagsGF.NoElemGF;
    private static  TheKeysFlags        theKeys         = TheKeysFlags.NoKeys;
    private static  GameDirections      gameDirections  = GameDirections.NoDirection;
    private static  Thread              gameThreadsValue;

    private  void SetAllFlags(TDwgNdpGamesData dwgNdpGame, NatureElementsFlags theNatFlagsSet, NatElementsFlagsGF natElementsFlagsSetGF)
    {
    dwgGameDats.SetAllFlags(dwgGameDats, theNatFlagsSet, natElementsFlagsSetGF, theNatFlagsSet);
    }

    public TDwgNdpGamesData():this(elements)
    {
    //Default Constructor
    }

    public void InitAllData()
    {
    SetAllDataValues();
    }

    protected void SetAllDataValues()
    {
    dwgGameDats = new TDwgGameDats();
  try
    {
    dwgGameDats.TheNatFlagsSet        = NatureElementsFlags.EarthElem;
    dwgGameDats.NatElementsFlagsSetGF = NatElementsFlagsGF.EarthElemGF;
    dwgGameDats.TheGameDirectionSet   = GameDirections.North;
     }
  finally
    {
    dwgGameDats.SetAllFlags(dwgGameDats,dwgGameDats.TheNatFlagsSet,dwgGameDats.NatElementsFlagsSetGF,dwgGameDats.TheNatFlagsSet  );
    dwgGameDats.SetAllFlags(dwgGameDats, dwgGameDats.TheNatFlagsSet, dwgGameDats.NatElementsFlagsSetGF, dwgGameDats.TheGameDirectionSet, dwgGameDats.TheNatFlagsSet); 
    }
    
    }
    private string[] thelemArr = { "Earth Elemental", "Air Elemental", "Fire Elemental", "Water Elemental", "Darc Elemntal" };


    public  void SetAllFlags(TDwgGameDats theval, NatureElementsFlags nature, NatElementsFlagsGF flagsGF ,in  NatureElementsFlags allTheFlags)
    {
    theval.TheNatFlagsSet         = nature;
    theval.TheElementsGetGF       = flagsGF;

    TheNatFlagsSet = GetNameElements(theval);
    }

    public void SetAllFlags(TDwgGameDats theVal,NatureElementsFlags nature,NatElementsFlagsGF flagsGF,GameDirections directions,in NatureElementsFlags allTheFlags)
    {
    theVal.TheGameDirectionSet = directions;
    theVal.TheNatFlagsSet      = allTheFlags;

    TheGameDirectionSet = TheGameDirections(theVal); 
    }
    private ref NatureElementsFlags GetNameElements(string[]value,NatureElementsFlags elementsFlags)
    {
    thelemArr = value;  elements = elementsFlags;

    return ref elements;
    }

    protected  virtual  NatureElementsFlags GetNameElements(TDwgGameDats theData)
    {
    if (theData == null)
    {
    throw new ArgumentNullException(nameof(theData));
    }
    switch (theData.TheNatFlagsSet)
    {
    case NatureElementsFlags.EarthElem:
         elements = NatureElementsFlags.EarthElem;
    break;
    case NatureElementsFlags.AirElem:
         elements = NatureElementsFlags.AirElem;
    break;
    case NatureElementsFlags.FireElem:
         elements = NatureElementsFlags.FireElem;
    break;
    case NatureElementsFlags.WaterElem:
         elements = NatureElementsFlags.WaterElem; 
    break;
    case NatureElementsFlags.DarcElem:
         elements = NatureElementsFlags.DarcElem;
    break;
 default:
     theData.TheNatElementsGetFlags = NatureElementsFlags.NoElemFlagsValue;
   break;
    }
    return theData.TheNatElementsGetFlags;
    }
    protected virtual  NatElementsFlagsGF  GetElementsFlagsGF(TDwgGameDats gameDats)
    {
    if (gameDats==null)
    {
    throw new ArgumentException(nameof(gameDats));
    }
    switch (gameDats.NatElementsFlagsSetGF)
    {
    case NatElementsFlagsGF.EarthElemGF:
         elementsGF = NatElementsFlagsGF.EarthElemGF;
    break;
    case NatElementsFlagsGF.AirElemGF:
         elementsGF = NatElementsFlagsGF.AirElemGF;
    break;
    case NatElementsFlagsGF.FireElemGF:
         elementsGF = NatElementsFlagsGF.FireElemGF;
    break;
    case NatElementsFlagsGF.WaterGF:
         elementsGF = NatElementsFlagsGF.WaterGF;
    break;
    case NatElementsFlagsGF.DarcElemGF:
         elementsGF = NatElementsFlagsGF.DarcElemGF; 
    break;
    default:
     gameDats.NatElementsFlagsSetGF = NatElementsFlagsGF.NoElemGF;
    break; 
    }
    return gameDats.TheElementsGetGF;
    }

    protected virtual  TheKeysFlags GetTheKeysFlags(TDwgGameDats gameDats)
    {
    if (gameDats == null)
    {
    throw new ArgumentException(nameof(gameDats));
    }
    switch (gameDats.AllTheKeysSet)
    {
    case TheKeysFlags.IronKey:
         theKeys = TheKeysFlags.IronKey;
    break;
    case TheKeysFlags.MetalKey:
          theKeys = TheKeysFlags.MetalKey;
     break;
     case TheKeysFlags.RusterdKey:
          theKeys = TheKeysFlags.RusterdKey;
    break;
     case TheKeysFlags.CopperKey:
          theKeys = TheKeysFlags.CopperKey; 
     break;
     case TheKeysFlags.GoldKey:
          theKeys = TheKeysFlags.GoldKey;
     break;
    default:
      gameDats.AllTheKeysSet = TheKeysFlags.NoKeys;
    break;
    }
    return gameDats.TheGameKeysGet;
    }
    protected virtual GameDirections TheGameDirections(TDwgGameDats dwgGameDats)
    {
    if (dwgGameDats == null)
    {
    throw new AggregateException(nameof(dwgGameDats));
    }
    switch (dwgGameDats.TheGameDirectionSet)
    {
    case GameDirections.North:
         gameDirections = GameDirections.North;
    break;
    case GameDirections.South:
         gameDirections = GameDirections.South;
    break;
    case GameDirections.West:
         gameDirections = GameDirections.West;
    break;
    case GameDirections.East:
         gameDirections = GameDirections.East;
    break;
    case GameDirections.NorthEast:
         gameDirections = GameDirections.NorthEast;
    break; 
    default:
      dwgGameDats.GameDirectionsGet = GameDirections.NoDirection;
    break;
    }
    return dwgGameDats.GameDirectionsGet;
    }

    public NatureElementsFlags TheNatFlagsSet
    {
  get => elements;
  set => elements = value;
    }

   public NatElementsFlagsGF NatElementsFlagsSetGF
    {
  get => elementsGF;
  set => elementsGF = value;
    }
    public TheKeysFlags AllTheKeysSet
    {
  get => theKeys;
  set => theKeys = value;
   }

   public Thread TheGameThreadSet
   {
  get => gameThreadsValue;
  set => gameThreadsValue = value;
   }
   public TDwgGameDats TdwgGameDatsSet
   {
  get => dwgGameDats;
  set => dwgGameDats = value;
    }

   public GameDirections TheGameDirectionSet
    {
  get => gameDirections;
  set => gameDirections = value;
    }
    public TDwgNdpGamesData(NatureElementsFlags natureElements):this(gameThreadsValue)
    {
    
    }
     public TDwgNdpGamesData(Thread threads)
    {
    gameThreadsValue = threads;
    }
    public class TDwgGameDats: TDwgNdpGamesData
    {

    public TDwgGameDats():this(elements)
    {
    //Default Value
    }

    internal Thread GameThreadsGet
    {
  get => gameThreadsValue;
  set => gameThreadsValue = value;
    }
   
    //Internal Getter TheElementsGetFlags
    internal NatureElementsFlags TheNatElementsGetFlags
    {
  get => elements;
  set => elements = value; 
    }

    public string[] ElementalArrGet
    {
  get => thelemArr;
  set => thelemArr = value;
    }
    
    //Internal Getter TheElementsGetGF
    internal NatElementsFlagsGF TheElementsGetGF
    {
  get => elementsGF;
  set => elementsGF = value;
    }
    
    //Internal Getter TheGameKeysGet
    internal TheKeysFlags TheGameKeysGet
    {
  get => theKeys;
  set => theKeys = value;
    }
    
    //Internal Getter GameDirectionsGet
    internal GameDirections GameDirectionsGet
   {
  get => gameDirections;
  set => gameDirections = value;
    }
    public TDwgGameDats(NatureElementsFlags theNatureElements):this(gameThreadsValue)
    {
    elements = theNatureElements;
    }

    public TDwgGameDats(Thread thread)
    {
    gameThreadsValue = thread;
    }
    

    protected override NatureElementsFlags GetNameElements(TDwgGameDats theData)
    {

    return base.GetNameElements(theData);
    }

    protected override NatElementsFlagsGF GetElementsFlagsGF(TDwgGameDats gameDats)
    {
    return base.GetElementsFlagsGF(gameDats);
    }

    protected override TheKeysFlags GetTheKeysFlags(TDwgGameDats gameDats)
    {

    return base.GetTheKeysFlags(gameDats);
    }


    protected override GameDirections TheGameDirections(TDwgGameDats dwgGameDats)
    {
    return base.TheGameDirections(dwgGameDats);
    }
    }
    }
}
