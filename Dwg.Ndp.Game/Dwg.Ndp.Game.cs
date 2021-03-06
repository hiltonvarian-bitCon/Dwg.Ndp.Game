﻿using System;
using System.Threading;
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
    using Dwg.Ndp.Mod;
    using Dwg.Ndp.Mod.Atrtrib;

    public partial class TDwgNdp : Form
    {
       
        private IDwgNdpPerson thperson = null;
       
        public IDwgNdpPerson Thperson
        {
      get => thperson;
      set => thperson = value;
        }

        public TDwgNdp()
        {
        InitializeComponent();
        }
        private void InitThreadsStarts() 
        {
        
        Thread AllThreads01 = new Thread(new ThreadStart(TDwgNdpGameThreads.ThreadProc1));

        Thread AllThreads02 = new Thread(new ThreadStart(TDwgNdpGameThreads.ThreadProc2));
       try
        {
        TDwgNdpGamesData DwgNdpGameData = new TDwgNdpGamesData(AllThreads01);

        TDwgGameAI DwgGameAI1 = DwgGameAllthreads(AllThreads02);

        DwgGameAI1.Thread = AllThreads01;

        DwgGameAI1.Thread = AllThreads02;
        DwgNdpGameData.InitAllData();

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

        private  TDwgGameAI DwgGameAllthreads(Thread AllThreads2)
        {
        return new TDwgGameAI(AllThreads2);
        }

        private void IniThreadsStart02()
        {
        TDwgNdpPLayersChar                PLayersChar  = new TDwgNdpPLayersChar              ();

        TDwgNdpGameAttrib                 DwgNdpAttrib = new TDwgNdpGameAttrib                ();
        
        TDwgNdpGamesData.TDwgGameDats     DwgGameDats = new TDwgNdpGamesData.TDwgGameDats     ();

        TDwgGameWorldMod.TGameWorldModOne DwgModOne = new TDwgGameWorldMod.TGameWorldModOne    ();

       try
        {
        GetDataElems GetTheDataElems  = new GetDataElems   (DwgGameDats.GetDataElems);

        GetDataElemsGF GetDataElemsGF = new GetDataElemsGF (DwgGameDats.GetDataElemsGF);

        if (GetTheDataElems.Method.MemberType == MemberTypes.Method)
        {
        PLayersChar.TdwgGameDatsSet = DwgGameDats;
        }
        PLayersChar.TdwgGameDatsSet.AllTheKeysSet = TheKeysFlags.GoldKey;

        GetDataElems TheDatElems = DwgGameDats.GetDataElems;

        PLayersChar.TdwgGameDatsSet.TheNatFlagsSet = TheDatElems(PLayersChar.TdwgGameDatsSet);

        DwgModOne.InitGameWorld();

        TDwgNdpModAtibu ModAtibu = new TDwgNdpModAtibu(DwgNdpAttrib.TheRealmsFlagsSet, 0);

        GetDataElemsGF TheDatElemsGF = DwgGameDats.GetDataElemsGF;
              
        PLayersChar.TdwgGameDatsSet.NatElementsFlagsSetGF =TheDatElemsGF(DwgGameDats);

        ModAtibu.InitModAsembly();                          
        }
       finally
        {
        TDwcharAtribute DwcharAtribute = new TDwcharAtribute(DwgNdpAttrib.TheElementalFlagsSet)
        {
      
        ThekeyFlagsSet = PLayersChar.TdwgGameDatsSet.AllTheKeysSet
        };
        PLayersChar.TheGameThreadSet.Abort();
        }
        }
       
        public class TDwgNdpPLayersChar : TDwgNdpGamesData, IDwgNdpPerson, IDwgNdpCaricDirections
        {
        private IDwgNdpPerson person=null ;

        private float  theAxisX      = TDwgNdpGameConVal.C_AxisX;
        private float  theAxisY      = TDwgNdpGameConVal.C_AxisY;
        private float  theAxisZ      = TDwgNdpGameConVal.C_AxisZ;
        private double theartGravity = TDwgNdpGameConVal.C_EarthGravity;
       
        private double allTheTotal;
        private float theTrajectory;

        private IDwgNdpPerson[]          ndpChaPeopleAr;
       private IDwgNdpCaricDirections[] dwgNdpsArr;
        
         private Int32 retValue;                                                                                                                                                                                                          
        public TDwgNdpPLayersChar()
        {
        DwgNdpersonInit();
        }
        private void DwgNdpersonInit()
        {                                                                   
        TDwgGameAI        ThegameAI       = new TDwgGameAI               ();

        TDwgNdpGameAttrib GameAttrib       = new TDwgNdpGameAttrib       ();

        TDwcharAtribute   DwcharAttrib     = new TDwcharAtribute         ();

        TDwgGameWorldMod  WorldMod         = new TDwgGameWorldMod        ();
       try
        {
        person = new TDwgNdpPLayersChar(GameAttrib.TheElementalFlagsSet, GameAttrib.TheFlagsGFSet);
      
        theTrajectory=1.40F; WorldMod.TheGameWorldNum = 0;
        if (GameAttrib.Match(GameAttrib.TheElementalFlagsSet))
        {
        GameAttrib.TheGameDirectionsSet = GameDirections.West;
        GameAttrib.ThekeyFlagsSet       = TheKeysFlags.MoonMetalKeys;
        }
       
        theAxisX = person.CalculateValues();
        allTheTotal = person.CalculateValueTrajValue( theAxisX, theAxisY, ref theTrajectory,ItemTrajectory);            
        }
       finally
        {
        person = new TDwgNdpPLayersChar(person, GameAttrib.ThekeyFlagsSet);
         
        theAxisY = person.CalculateValues(); theAxisZ = person.CalculateTrajectory();

        allTheTotal = person.CalculateValueTrajValue(theAxisX, theAxisY, ref theTrajectory,ItemTrajectory);
        InitPeopleArr(ThegameAI);

        ThegameAI.InitAllGameAI();
        }
        }
        protected void InitPeopleArr(TDwgGameAI gameAI)
        {
        TDwgGameAI DwgGameAI = new TDwgGameAI(gameAI.GameValueAI, gameAI.TheGameSetAI, gameAI.TheArrSeg);

         dwgNdpsArr = new TDwgNdpPLayersChar[TDwgNdpGameConVal.C_AmountPlayers];
        try
        {
        DwgGameAI.TheFibValuNums = 100; 

        ndpChaPeopleAr = new TDwgNdpPLayersChar[TDwgNdpGameConVal.C_AmountPlayers];
        }
      finally
        {
        ndpChaPeopleAr[0] = new TDwgNdpPLayersChar(TheNatCharPersonElem, TheNatCharPersonElemGF);
        retValue = DwgGameAI.GetFibValue(DwgGameAI.TheFibValuNums, 1);
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

         public IDwgNdpPerson[] IDwgNdpCarDirArr
         {
       get
         {
         return ndpChaPeopleAr;
         }
         }

         public double TheEarthsGravity
         {
       get
         {
         return theartGravity;
         }
         }
         public Int32 RetValue1
         {
        get
         {
         return retValue;
         }
         }

         public IDwgNdpCaricDirections[] IDwgNdpCaricDirecAr
         {
       get
         {
         return dwgNdpsArr;
         }
         }

        public TDwgNdpPLayersChar(NatureElementsFlags elementsFlags,NatElementsFlagsGF natElementsFlagsGF) 
        {
        elementsFlags = TheNatCharPersonElem;
       
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

        public  void InitSetAllPersons(NatureElementsFlags natureElementsFlags, in string[] vsArr)
        {

        InitSetAllPersons(natureElementsFlags, vsArr);
        }

        public void InitSetAllPersons(NatureElementsFlags nature, string[] ArrFlagVs)
        {
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
        protected  void  SetTheSumOfAxis(float axisValueX,float axisValueY,float axisValueZ)
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
        allTheTotal = total+force / Math.Sqrt(graverty*graverty)+(angle*angle)/theTrajectory*speed;

        return allTheTotal; 
        }

        public double CalculateValue(in float angle, float axisValueX, double axisValueY, double gravity, double force)
        {
        theTrajectory = angle + axisValueX;

        return CalculateValueTrajValue(axisValueX, axisValueY, ref theTrajectory,angle);
        }

        public double CalculateValueTrajValue(float axisValueX, double axisValueY, ref float trajectoryPercent, float angle)
        {
        theTrajectory = TheAxisValueY*TheAxisValueZ/trajectoryPercent/angle; 

        return CalculateValue(theTrajectory,axisValueX,Convert.ToUInt64(axisValueY),theTrajectory*trajectoryPercent,angle,Convert.ToSingle(angle));
        }

        private double  CalculateValue(in float angle, float axisValueX, float axisValueY, float trajectoryPerc,float  gravityForce, float theAnglValue)
        {
        theTrajectory = axisValueX * axisValueY - trajectoryPerc * theAnglValue/gravityForce;

        return Math.Cos(theTrajectory) * (Math.Sin(angle) * trajectoryPerc) - Math.PI;
        }

        public void SetTheSumsOfAxis(float axisValueX, float axisValueY, float axisValueZ)
        {
        allTheTotal = Math.Sin(axisValueX) * Math.Cos(axisValueY)+Math.Tan(axisValueZ);  
        }
        
        public double CalculateValueTrajValue(double axisValueX, double axisValueY, in float trajectoryPercent, ref float angle, float disttrav = 0)
        {
        allTheTotal = angle + axisValueX * axisValueY / trajectoryPercent + (trajectoryPercent * trajectoryPercent) / disttrav;

        return Math.Atan(allTheTotal * allTheTotal) + trajectoryPercent-disttrav;  
        }

        public float CalculateTrajectory()
        {

        return CalculateTrajectory(theAxisX, TheAxisValueY);
        }

        public float CalculateTrajectory(double axisX, double axisY)
        {

        return Convert.ToSingle(axisX*axisY/Math.Log(allTheTotal));
        }

        public void InitCharicDirections()
        {
         switch (TheGameDirectionSet)
         {
         case GameDirections.North:
         break;
         case GameDirections.South:
         break;
         case GameDirections.West:
         break;
         case GameDirections.East:
         break;
         case GameDirections.NorthEast:
         break;
         case GameDirections.SouthWest:
         break;
         default:
         break;

        }
        }

        public double CalculateTrajectoryAxisX()
        {
        return CalculateValueTrajValue(TheAxisValueX, TheAxisValueY, Convert.ToSingle(ItemTrajectory));
        }

        private double CalculateValueTrajValue(float theAxisValueX, float theAxisValueY, float itemTraj)
        {
        allTheTotal = (TheAxisValueX * TheAxisValueX) + (TheAxisValueY * theAxisValueY) /itemTraj;

        return Math.PI*Math.Sqrt(allTheTotal) ;  
        }

        public double CalculateTrajectoryAxisY()
        {
        return CalculateTrajectoryAxisY(theAxisY);
        }

        public double CalculateTrajectoryAxisZ()
        {

        return CalculateTrajectoryAxisZ(theAxisZ);
        }

        public double CalculateTrajectoryAxisX(float axisX)
        {
        return CalculateTrajectoryAxisY(axisX);
        }

        public double CalculateTrajectoryAxisY(float axisY)
        {

        return CalculateTrajectoryAxisZ(axisY);
        }

        public double CalculateTrajectoryAxisZ(float axisZ)
        {
        return axisZ;
        }

        public IDwgNdpCaricDirections[] CharictsDir(IDwgNdpCaricDirections ndpCaricDirections)
        {

        return CharictsDir(ndpCaricDirections, new TDwgNdpGamesData(NatureElementsFlags.FireElem), ndpCaricDirections);
        }

        private IDwgNdpCaricDirections[] CharictsDir(IDwgNdpCaricDirections ndpCaricDirections1, TDwgNdpGamesData dwgNdpGamesData, IDwgNdpCaricDirections ndpCaricDirections2)
        {

        return ndpChaPeopleAr[0].IDwgNdpCaricDirecAr;
        }

        public void SetTheGravityValue(double grValue)
        {
        theartGravity = grValue;
        }

        public void SetTheGravityValue(double grValue, double strength)
        {
        theartGravity = grValue * strength;
        }

        public TDwgNdpGamesData[] CharictsDir(IDwgNdpCaricDirections ndpCaricDirections, TDwgNdpGamesData dwgNdp)
        {
        
        throw new NotImplementedException();
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

        public TDwgNdpGameThreads(Thread thread, Int32 count1,Int32 count2 )
        {
        loopcoun1 = count1; loopCount2 = count2;
       
        }
        public static void ThreadProc1()
        {
        for (Int32 ThreadLoop01 = 0; ThreadLoop01 < 1000; ThreadLoop01++)
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

        for (Int32 ThreadLoop02 = 0; ThreadLoop02 < 2000; ThreadLoop02++)
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
        
