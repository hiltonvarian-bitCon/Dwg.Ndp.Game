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
    using Dwg.Ndp.Char.Counters;

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
        private float theAxisY = TDwgNdpGameConVal.C_AxisY;
        private float theAxisZ = TDwgNdpGameConVal.C_AxisZ;

        private double allTheTotal;
        private float theTrajectory;

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
        GameAttrib.ThekeyFlagsSet       = TheKeysFlags.MoonMetalKeys;
        }
        theAxisX = person.CalculateValues();
      
        }
       finally
        {
        person = new TDwgNdpPLayersChar(person, GameAttrib.ThekeyFlagsSet);
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

        public double TheTotal
        {
      get
        {
        return allTheTotal;
        }
        }

        public float ItemTrajectory
        {
      get
        {
        return theTrajectory;
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
        protected void  SetTheSumOfAxis(float axisValueX,float axisValueY,float axisValueZ)
        {
         theAxisZ = axisValueZ;
        }
        public void SetTheSumOfAxis(float axisValueX, float axisValueY)
        {
        
        theAxisY = axisValueY; 
        }

        public double CalculateValue(float axisX, double axisY, float axisZ)
        {
        return Math.Cos(axisX + axisY) * Math.Sin(axisX + axisZ);       
        }

        public double CalculateValues(ref double total, double graverty, float trajectury, float angle, double speed)
        {

        return CalculateValues(ref total, graverty, graverty, angle/trajectury,speed); 
        }

        public double CalculateValues(ref double total, in double graverty, double force, float angle, double speed)
        {
        allTheTotal = total+force/ Math.Sqrt(graverty*graverty)/angle*theTrajectory+speed;

        return allTheTotal; 
        }

        public double CalculateValue(in float angle, float axisValueX, double axisValueY, double gravity, double force)
        {
        theTrajectory = angle + axisValueX;

        return CalculateValueTrajValue(axisValueX, axisValueY, ref theTrajectory,angle);
        }

        public double CalculateValueTrajValue(float axisValueX, double axisValueY, ref float trajectoryPercent, float angle)
        {
        theTrajectory = trajectoryPercent/angle;

        return theTrajectory;
        }
        }
        private void OnDwgNdpLoad(object sender, EventArgs e)
        {
        KeyPreview = true;
        
        InitThreadsStarts();
        }
        protected double CalculateValue(float axisValueX, double axisValueY)
        {
        return (axisValueX * axisValueX) + (axisValueY * axisValueY);
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

        private void OnPaintMainGame(object sender, PaintEventArgs e)
        {
        InitPaintGameScreen();
        }

        protected void InitPaintGameScreen()
        {
       
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
        
