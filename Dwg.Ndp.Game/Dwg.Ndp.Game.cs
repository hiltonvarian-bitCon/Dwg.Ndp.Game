     using System;
     using System.Collections.Generic;
     using System.ComponentModel;
     using System.Data;
     using System.Drawing;
     using System.Linq;
     using System.Text;
     using System.Threading;
     using System.Threading.Tasks;                               
     using System.Windows.Forms;
     using System.Reflection;
       
    namespace Dwg.Ndp.Game
     {
    using Dwg.Ndp.Data.Games;
    using Dwg.Ndp.Person;
    using Dwg.Ndp.Game.Char;
    using Dwg.Game.AI;
    using Dwg.Ndp.Attrib;
    using Dwg.Ndp.Game.Con;
    public partial class TDwgNdpGame : Form
    {
        private IDwgNdpPerson thperson = null;

        public IDwgNdpPerson Thperson
        {
      get => thperson;
      set => thperson = value;
        }

        public TDwgNdpGame()
        {
        InitializeComponent();
        }
        private void InitThreadsStarts()
        {
        Thread AllThreads01 = new Thread(new ThreadStart(TDwgNdpGameThreads.ThreadProc1));

        Thread AllThreads02 = new Thread(new ThreadStart(TDwgNdpGameThreads.ThreadProc2));

        TDwgNdpGamesData AllThreads03 = new TDwgNdpGamesData(AllThreads01);
      try
        {
        TDwgGameAI dwgGameAI = new TDwgGameAI(AllThreads02);

        AllThreads03.InitAllData();                                                       
        
        AllThreads01.Start();
        AllThreads02.Start();
        }
      finally
        {
        AllThreads01.Abort(); 
        AllThreads02.Abort();
        }
        IniThreadsStart02(); 
        }
        private void IniThreadsStart02()
        {
        TDwgNdpPLayersChar            pLayersChar  = new TDwgNdpPLayersChar    ();

        TDwgNdpGameAttrib             dwgNdpAttrib = new TDwgNdpGameAttrib     ();

        TDwgNdpGamesData.TDwgGameDats dwgGameDats = new TDwgNdpGamesData.TDwgGameDats();
       try                                                                                           
        {
       
       
        pLayersChar.TdwgGameDatsSet = dwgGameDats;
        pLayersChar.TdwgGameDatsSet.AllTheKeysSet = TheKeysFlags.GoldKey;
       
        }
       finally
        {
        TDwcharAtribute dwcharAtribute=new TDwcharAtribute(dwgNdpAttrib.TheElementalFlagsSet);
        pLayersChar.TheGameThreadSet.Abort();            
        }
        }

        [TDwgNdpGameAttrib]
        public class TDwgNdpPLayersChar : TDwgNdpGamesData, IDwgNdpPerson
        {
        private IDwgNdpPerson person;

        private float theAxisX = TDwgNdpGameConVal.C_AxisX;
        private float theAxisY =TDwgNdpGameConVal.C_AxisY;
        private float theAxisZ = TDwgNdpGameConVal.C_AxisZ;
     
        public TDwgNdpPLayersChar() 
        {
        DwgNdpersonInit();
        }
        private void DwgNdpersonInit()
        {
        TDwgGameAI       ThegameAI  = new TDwgGameAI         ();

        TDwgNdpGameAttrib GameAttrib = new TDwgNdpGameAttrib ();
       try
        {
        person = new TDwgNdpPLayersChar(GameAttrib.TheElementalFlagsSet, GameAttrib.TheFlagsGFSet);
        if (GameAttrib.Match(GameAttrib.TheElementalFlagsSet))
        {
        GameAttrib.TheGameDirectionsSet = GameDirections.West;
        }
        theAxisX = person.CalculateValues();
        }
       finally
        {
        theAxisY = person.CalculateValues();
        ThegameAI.InitAllGameAI();
        }    
        }
        
        public TDwgNdpPLayersChar(IDwgNdpPerson dwgNdpPerson, TheKeysFlags theKeysFlags):this(dwgNdpPerson.TheNatCharPersonElem,dwgNdpPerson.TheNatCharPersonElemGF)
        {
        AllTheKeysSet = dwgNdpPerson.TheGamesKeys;
        TheNatFlagsSet = dwgNdpPerson.TheNatCharPersonElem; 
        }
        public NatureElementsFlags TheNatCharPersonElem
        {
      get
        {
        return TheNatFlagsSet;
        }
        }

        public NatElementsFlagsGF TheNatCharPersonElemGF
        {
      get
        {
        return NatElementsFlagsSetGF;
        }
        }

        public TheKeysFlags TheGamesKeys
        {
      get
        {
        return AllTheKeysSet;
        }
       
        }
        public IDwgNdpPerson ThePersons
        {
      get => person;
      set => person = value;
        }

        public float TheAxisValueX
        {
      get
        {
        return theAxisX;
        }
        }

        public float TheAxisValueY
        {
      get
        {
        return theAxisY;
        }
        }

        public float TheAxisValueZ
        {
      get
        {
        return theAxisZ;
        }
        }

        public TDwgNdpPLayersChar(NatureElementsFlags elementsFlags,NatElementsFlagsGF natElementsFlagsGF) 
        {
         
        }
        public NatElementsFlagsGF InitAllPerson(NatureElementsFlags nature, NatElementsFlagsGF elementsFlagsGF)
        {
        TheNatFlagsSet        = nature; NatElementsFlagsSetGF = elementsFlagsGF;
        return TheNatCharPersonElemGF;
        }

        public NatureElementsFlags InitAllPersons(NatureElementsFlags nature, NatElementsFlagsGF elementsFlagsGF)
        {
        throw new NotImplementedException();
        }

        public void InitSetAllPersons()
        {
       
        }

        public void InitSetAllPersons(NatureElementsFlags natureElementsFlags, in string[] vsArr)
        {
        
        throw new NotImplementedException();
        }

        public void InitSetAllPersons(NatureElementsFlags nature, string[] ArrFlagVs)
        {
        throw new NotImplementedException();
        }

        public float CalculateValues()
        {
        return  CalculateValues(theAxisX*theAxisX)+(theAxisY*theAxisY);
        }

        public float CalculateValues(float value)
        {
        return  value;    
        }
        
        public double CalculateValue(double axisX, double axisY)
        {                                                                    

        return Math.Sqrt((axisX * axisX) + (axisY * axisY)); 
        }

        public void SetTheSumOfAxis(float axisValueX, double axisValueY)
        {
        theAxisX = axisValueX;         
        }

        public void SetTheSumOfAxis(float axisValueX, float axisValueY)
        {
        theAxisY = axisValueY; 
        }

        public double CalculateValue(float axisX, double axisY, float axisZ)
        {
        return Math.Cos(axisX + axisY) * Math.Sin(axisX + axisZ);       
        }
        }
        protected double CalculateValue(float axisValueX,double axisValueY)
        {
        return (axisValueX*axisValueX)+(axisValueY * axisValueY);
        }

        private void OnDwgNdpLoad(object sender, EventArgs e)
        {
        KeyPreview = true;

        InitThreadsStarts();
        }
        
        public  class TDwgNdpGameThreads
        {
        private        readonly Int32   loopcoun1  = -1;
        private        readonly  Int32  loopCount2  = 0;

        public static void ThreadProc1()
        {
        for (int ThreadLoop01 = 0; ThreadLoop01 < 1000; ThreadLoop01++)
        {
       
        Thread.Sleep(2000);
        }
        
        }
        public Int32 ThreadCounSet1
        {
      get
        {
        return loopcoun1;
        }
        } 
        public static void  ThreadProc2()
        {

        for (int ThreadLoop02 = 0; ThreadLoop02 < 2000; ThreadLoop02++)
        {
        
        Thread.Sleep(3000);
        }
        }
        public Int32 ThreadCounSet2
        {
      get
        {
        return  loopCount2;
        }
        }
        }
        private void OnFormClick(object sender, EventArgs e)
        {
        InitCharictors();
        }
        private void InitCharictors()
        {
        TDwgNdpCharCardInfo ndpCharCard = new TDwgNdpCharCardInfo();
      try
        {
        ndpCharCard.ShowDialog();
        }
      finally
        {
        ndpCharCard.Close();
        }
        }
        }
        }
        
