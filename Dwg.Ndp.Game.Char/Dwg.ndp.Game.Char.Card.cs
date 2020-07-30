    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Threading;

    namespace Dwg.Ndp.Game.Char
    {
    using Dwg.Game.AI;
    using Dwg.Ndp.Game.Con;
   

    public class TDwgNdpCharCardInfo:Form
    {
       
    private float hitpoints     = TDwgNdpGameConVal.C_Hitpointrs;
    private float dexterity     = TDwgNdpGameConVal.C_TheDexterity;
    private float oritory       = TDwgNdpGameConVal.C_TheOritory;
    private float attacPoints   = TDwgNdpGameConVal.C_TheAttackPoints;
    private float stanimaPoints = TDwgNdpGameConVal.C_TheStanimaPoints;
    private float strengthPoints = TDwgNdpGameConVal.C_TheStrengthPoints;

    private TDwgNdpGameCharCardThread charCardThread;
    private TDCharictorsTheItems[] charictorsCardItems;
       
    public float HitpointsSet
    {
  get => hitpoints;
  set => hitpoints = value;
    }
    public float TheDexteritySet
    {
  get => dexterity;
  set => dexterity = value;
    }
    public float TheOritorySet
    {
  get => oritory;
  set => oritory = value;
    }
     public float AttacPointsSet
     {
   get => attacPoints;
   set => attacPoints = value;
     }
    public TDwgNdpCharCardInfo()
    {
    InitArraysVal();
    }

    public TDCharictorsTheItems[] CharictorsItems
    {
  get => charictorsCardItems;
  set => charictorsCardItems = value;
    }
     public float StanimaPointsSet
    {
   get => stanimaPoints;
   set => stanimaPoints = value;
    }
    public float StrengthPointSet
    {                                                                                                                       
  get => strengthPoints;
  set => strengthPoints = value;
    }

    public TDwgNdpCharCardInfo(TDCharictorsTheItems[] tDCharictors)
    {
    charictorsCardItems = tDCharictors;
    }

    private void InitializeComponent()

    {
            this.SuspendLayout();
            // 
            // TDwgNdpCharCard
            // 
            this.ClientSize = new System.Drawing.Size(305, 652);
            this.Name = "TDwgNdpCharCard";
            this.Text = "Game Charitors Card";
            this.ResumeLayout(false);

    }
   
    public void InitArraysVal()
    {
    charictorsCardItems = new TDCharictorsTheItems[TDwgNdpGameConVal.C_TheAmountWepons];

    TDwgNdpCharCardInfo ndpCharCard = new TDwgNdpCharCardInfo(charictorsCardItems);
   try
    {
    ndpCharCard.CharictorsItems[0] = new TDCharictorsTheItems(charictorsCardItems.Length);
    {
    ndpCharCard.CharictorsItems[0].TheNameItems = "Iron Sword";
    }
    }
   finally
    {
    TDwgNdpGameCharCardThread charCardThread = new TDwgNdpGameCharCardThread(new TDCharictorsTheItems( ));
    
    InitArraysVal(charictorsCardItems);
    }
    }

    protected void InitArraysVal(TDCharictorsTheItems[] tDCharictorsCardItems)
    {
    CharictorsItems = tDCharictorsCardItems;
    }
    public  class TDCharictorsTheItems
    {
    public TDCharictorsTheItems() :this(TheTotalVal=TDwgNdpGameConVal.C_TheAmountWepons)
    {
   //default Constructor
    }
   
    public TDCharictorsTheItems(Int32 value)
    {
    TheTotalVal = value;
    }
    private string namewepons = TDwgNdpGameConVal.C_StringsName;
    private string nameItems = TDwgNdpGameConVal.C_StringsName;
    private string nameSpells = TDwgNdpGameConVal.C_StringsName;

    public Int32 TheTotalValues
    {
  get => TheTotalVal;
  set => TheTotalVal = value;
    }

    public string TheNamewepons
    {
  get => namewepons;
  set => namewepons = value;
    }

    public string TheNameItems
    {
  get => nameItems;
  set => nameItems = value;
    }

    public string TheNameSpells
    {
  get => nameSpells;
  set => nameSpells = value;
    }

    public static Int32 TheTotalVal
    {
  get => theTotalVal;
  set => theTotalVal = value;
    }
    private static Int32  theTotalVal=TDwgNdpGameConVal.C_TheAmountWepons;

    }
   
    internal float HitpointGet
    {
  get => hitpoints;
  set => hitpoints = value;
    }

    internal float TheDexterityGet
    {
  get => dexterity;
  set => dexterity = value;
    }

    internal float TheOritoryGet
    {
  get => oritory;
  set => oritory = value;
    }

    internal float AttacPointsGet
     {
  get => attacPoints;
  set => attacPoints = value;
    }

    internal  float StanimaPointsGet
    {
  get => stanimaPoints;
  set => stanimaPoints = value;
    }

    internal  float StrengthPointGet
    {
  get => strengthPoints;                                                    
  set => strengthPoints = value;
    }

    public TDwgNdpGameCharCardThread TheCharCardThread
    {
  get => charCardThread;
  set => charCardThread = value;
    }

    public  class TDwgNdpGameCharCardThread
    {
    public TDwgNdpGameCharCardThread(TDCharictorsTheItems theItems )
    {
    InitThreadsSet();
    }

    protected void InitThreadsSet()
    {
    Thread Threads = new Thread(new ThreadStart(InitThReads));
   try
    {
    Threads.Start();
    }
  finally                                                                                    
    {
    Threads.Abort();               
    }
    }
    }
    protected static void InitThReads()
    {
    for (int ThreadLoop01 = 0; ThreadLoop01 < 3000; ThreadLoop01++)
    {
    Thread.Sleep(400);

    }
    }

    }
    }
