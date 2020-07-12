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

     namespace Dwg.Ndp.Game
     {
     using Dwg.Ndp.Data.Games;
     using Dwg.Ndp.Person;

    public partial class TDwgNdpGame : Form
    {
        public TDwgNdpGame()
        {
        InitializeComponent();
        }
        private void InitThreadsStarts()
        {
        Thread AllThreads01 = new Thread(new ThreadStart(TDwgNdpGameThreads.ThreadProc1));

        Thread AllThreads02 = new Thread(new ThreadStart(TDwgNdpGameThreads.ThreadProc2));

        TDwgNdpGamesData dwgNdpGame = new TDwgNdpGamesData(AllThreads01);
       try
        {
        dwgNdpGame.InitAllData();

        AllThreads01.Start();
        AllThreads02.Start();
        }
      finally
        {
        AllThreads01.Abort(); 
        AllThreads02.Abort();
        }
         
        }

        public class TDwgNdpPLayersChar : TDwgNdpGamesData, IDwgNdpPerson
        {
        private IDwgNdpPerson person;

        public TDwgNdpPLayersChar() 
        {
        DwgNdpersonInit();
        }
        private void DwgNdpersonInit()
        {
        
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
        throw new NotImplementedException();
        }

        public void InitSetAllPersons(NatureElementsFlags natureElementsFlags, in string[] vsArr)
        {
        
        throw new NotImplementedException();
        }

        public void InitSetAllPersons(NatureElementsFlags nature, string[] ArrFlagVs)
        {
        throw new NotImplementedException();
        }
        }
        private void OnDwgNdpLoad(object sender, EventArgs e)
        {
        KeyPreview = true;
        InitThreadsStarts();
        }
        
        public  class TDwgNdpGameThreads
        {
        public static void ThreadProc1()
        {
        for (int ThreadLoop01 = 0; ThreadLoop01 < 1000; ThreadLoop01++)
        {
        Thread.Sleep(2000);
        }
        
        }
        public static void  ThreadProc2()
        {

        for (int ThreadLoop02 = 0; ThreadLoop02 < 2000; ThreadLoop02++)
        {
        Thread.Sleep(3000);
        }
        }
        }
        
        }
        }
        
