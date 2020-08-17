    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Threading;
    using System.Drawing;
    using System.IO;
    using System.Reflection.Emit; 
    using System.Runtime.Serialization;

namespace Dwg.Ndp.Game.Char
    {
    using Dwg.Game.AI;
    using Dwg.Ndp.Game.Con;
    using Dwg.Ndp.Char.Counters;
   

    public class TDwgNdpCharCardInfo : Form
    {

        private float hitpoints       = TDwgNdpGameConVal.C_Hitpoints;
        private float dexterityPoints = TDwgNdpGameConVal.C_TheDexterityPoints;
        private float oritoryPoints   = TDwgNdpGameConVal.C_TheOritoryPoints;
        private float attacPoints     = TDwgNdpGameConVal.C_TheAttackPoints;
        private float stanimaPoints   = TDwgNdpGameConVal.C_TheStanimaPoints;
        private float strengthPoints  = TDwgNdpGameConVal.C_TheStrengthPoints;
        private float karmaPoints     = TDwgNdpGameConVal.C_TheKarmaPoints;
            
        private Int32 charCounter1 = 0;
        private Int32 charCounter2 =-1;

        private Int32 theHeights = TDwgNdpGameConVal.C_Height;
        private Int32 theWidths  = TDwgNdpGameConVal.C_Width;
                           
        private TDwgNdpGameCharCardThread charCardThread;
        private TDCharictorsTheItems[] charictorsCardItems;

        private TDCharictorsTheItems  theItems;

        private Int32[,] TDCharictorsArr2D = {{0,1},{0,2},     { 0,3},  {0,-6  },
                                              {0,4},{1, 5},    {1,6 },  {-1,7  },
                                              {1,9},{1,10},    {-1,12}, {1,5   },
                                              {1,7},  {-1,8},  {1,9  }, {1,10  },
                                              {-1,11},{1,12},  {-1,13}, {1,11  },
                                              {1,12},{1,13},   {-1,14}, {-1,15 },
                                              {1,16},{-1,17},  {1,18 }, {1,19  },
                                              {-1,20},{1,-21}, {1,22 }, {1,20  },
                                              {-1,23},{1,27},  {1,30 }, {-1,33 },
                                              {1,100},{1,300}, {1,500}, {1,700 },
                                              {1,99}, {1,-100},{1,200}, {1,400 },
                                              {-1,9 },{-1,700},{-1,200},{-1,300}
        };
        
    public float HitpointsSet
    {
  get => hitpoints;
  set => hitpoints = value;
    }

    public float TheDexteritySet
    {
  get => dexterityPoints;
  set => dexterityPoints = value;
    }

    public float TheOritorySet
    {
  get => oritoryPoints;
  set => oritoryPoints = value;
    }
    public float AttackPointsSet
    {
   get => attacPoints;
   set => attacPoints = value;
    }
    public Int32 CharCounterOneSet
    {                                                                  
   get => charCounter1;
   set => charCounter1 = value;
    }
    public Int32 CharCounterTwoSet
    {
  get => charCounter2;
  set => charCounter2 = value;
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
    public float KarmaPointsSet
    {
  get => karmaPoints;
  set => karmaPoints = value;
    }
    public  TDwgNdpCharCardInfo(TDCharictorsTheItems[] tDCharictors)
    {
    charictorsCardItems = tDCharictors;
    }

    private void InitializeComponent()

    {
            this.SuspendLayout();
            // 
            // TDwgNdpCharCardInfo
            // 
            this.ClientSize = new System.Drawing.Size(305, 652);
            this.Name = "TDwgNdpCharCardInfo";
            this.Text = "Game Charitors Card";
            this.ResumeLayout(false);

    }
    protected override void OnLoad(EventArgs e)
    {
    InitCharForClientSize();

    base.OnLoad(e);
    }

    public void SetUpSize( Int32 theWidth,Int32 theHeigh, Size thesize)
    {
    thesize.Width = theWidth;
    thesize.Height = theHeigh;
    }

    protected void  SetUpSize(Int32 theWith,Int32 theHight)
    {
    theWidths = theWith;
    theHeights = theHight;
    }
    
    public void InitArraysVal()
    {
    charCounter2 = 0;
    charictorsCardItems = new TDCharictorsTheItems[TDwgNdpGameConVal.C_TheAmountWepons];
   do
    {
    TDwgNdpCharCardInfo ndpCharCard = new TDwgNdpCharCardInfo(charictorsCardItems);

   try
    {

    ndpCharCard.CharictorsItems[0]  = new TDCharictorsTheItems (charictorsCardItems.Length);
    ndpCharCard.CharictorsItems[1]  = new  TDCharictorsTheItems(charictorsCardItems.Length);
    ndpCharCard.CharictorsItems[2]  = new  TDCharictorsTheItems(charictorsCardItems.Length);
    ndpCharCard.CharictorsItems[3]  = new  TDCharictorsTheItems(charictorsCardItems.Length);
    ndpCharCard.CharictorsItems[4]  = new  TDCharictorsTheItems(charictorsCardItems.Length);
    ndpCharCard.CharictorsItems[5]  = new  TDCharictorsTheItems(charictorsCardItems.Length);
    ndpCharCard.CharictorsItems[6]  = new  TDCharictorsTheItems(charictorsCardItems.Length);
    ndpCharCard.CharictorsItems[7]  = new  TDCharictorsTheItems(charictorsCardItems.Length);
    ndpCharCard.CharictorsItems[8]  = new  TDCharictorsTheItems(charictorsCardItems.Length);
    ndpCharCard.CharictorsItems[9]  = new  TDCharictorsTheItems(charictorsCardItems.Length);
    ndpCharCard.CharictorsItems[10] = new  TDCharictorsTheItems(charictorsCardItems.Length);
    {
    ndpCharCard.CharictorsItems[0].TheNameItems =  "Iron Sword";
    ndpCharCard.CharictorsItems[1].TheNameItems =  "Metal Sword";
    ndpCharCard.CharictorsItems[2].TheNameItems =  "Rusterd Sword";
    ndpCharCard.CharictorsItems[3].TheNameItems =  "Gold Sword";
    ndpCharCard.CharictorsItems[4].TheNameItems =  "Silver Sword";
    ndpCharCard.CharictorsItems[5].TheNameItems =  "Copper Sword";
    ndpCharCard.CharictorsItems[6].TheNameItems =  "Nickle Sword";
    ndpCharCard.CharictorsItems[7].TheNameItems =  "Steel sword";   
    ndpCharCard.CharictorsItems[8].TheNameItems =  "Star Metal Sword";
    ndpCharCard.CharictorsItems[9].TheNameItems =  "Star Metal Darc Sword";
    ndpCharCard.CharictorsItems[10].TheNameItems = "Darc Metal Sword";

    charCounter2++;
   
    }
    }
   finally
    {
    TDwgNdpGameCharCardThread charCardThread = new TDwgNdpGameCharCardThread(new TDCharictorsTheItems(charictorsCardItems.Rank));
    
    charCounter1++;
    
    InitArraysVal(charictorsCardItems,charCounter1);
    
    }
    }
    while (charCounter1<TDwgNdpGameConVal.C_TheAmountWepons);
    }
    
    protected void InitArraysVal(TDCharictorsTheItems[] tDCharictors,Int32 valcount)
    {
    theItems = new TDCharictorsTheItems(charCounter1);
   
    for (Int32 CharLoop01 = 0; CharLoop01 < tDCharictors.Length; CharLoop01++)
    {
    charCounter1 = valcount++;

    InitArraysVal(InitArraysVals(tDCharictors,valcount,theItems));

    theItems.TheTotalValues = charCounter1;

    }     
    }

     protected void InitCharForClientSize()
    {
    ClientSize = new System.Drawing.Size(TDwgNdpGameConVal.C_Width, TDwgNdpGameConVal.C_Height);
   try
    {
    theWidths = ClientSize.Width;
    theHeights = ClientSize.Height;

    SetUpSize(theHeights, theWidths);
    }
  finally
    {

    SetUpSize(TheScreenHeights, TheScreenWidths, ClientSize);
    }
    }
    protected   void  InitArraysVal(TDCharictorsTheItems[] tDCharictorsCardItems)
    {
    CharictorsItems = tDCharictorsCardItems;
    }

    protected  TDCharictorsTheItems[] InitArraysVals(TDCharictorsTheItems[] tDCharictorsCardItems,Int32 valcount,TDCharictorsTheItems charictorsTheItems)
    {

    return tDCharictorsCardItems;
    }

    [Serializable]
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
    private string nameItems  = TDwgNdpGameConVal.C_StringsName;
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
  get => dexterityPoints;
  set => dexterityPoints = value;
    }

    internal float TheOritoryGet
    {
  get => oritoryPoints;
  set => oritoryPoints = value;
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

    internal float KarmaPointsGet 
    {
  get => karmaPoints;
  set => karmaPoints = value;
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

    internal Int32 CharCounterOneGet
    {
  get => charCounter1;
  set => charCounter1 = value;
    }

    internal Int32 CharCounterTwoGet
    {
  get => charCounter2;
  set => charCounter2 = value;
    }

    public Int32[,] TheCharictorsArr2D
    {
  get => TDCharictorsArr2D;
  set => TDCharictorsArr2D = value;
    }

    public Int32 TheScreenHeights
    {
  get => theHeights;
  set => theHeights = value;
    }

    public int TheScreenWidths
    {
  get => theWidths;
  set => theWidths = value;
    }
    public TDCharictorsTheItems TheChaItems
    {
  get => theItems;
  set => theItems = value;
    }

    public  class TDwgNdpGameCharCardThread
    {
    public TDwgNdpGameCharCardThread(TDCharictorsTheItems theChItems )
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
    Thread.Sleep(4000);
    }
    }
    }
    }
