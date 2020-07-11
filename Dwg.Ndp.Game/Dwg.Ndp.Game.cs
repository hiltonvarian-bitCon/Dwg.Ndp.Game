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
        Thread AllThreads01 = new Thread(new ThreadStart(TDwgNdpGameThreads.ThreadProc));

        TDwgNdpGamesData dwgNdpGame = new TDwgNdpGamesData();
       try
        {
        dwgNdpGame.InitAllData();

        AllThreads01.Start();

        }
      finally
        {
        AllThreads01.Abort();
        }
        }

        public class TDwgNdpPLayersChar : TDwgNdpGamesData, IDwgNdpPerson
        {
        public NatureElementsFlags TheNatCharPersonElem
        {
      get
        {
        return this.TheNatFlagsSet;
        }
        }

        public NatElementsFlagsGF TheNatCharPersonElemGF
        {
      get
        {
        return this.NatElementsFlagsSetGF;
        }
        }

        public TheKeysFlags TheGamesKeys
        {
      get
        {
        return this.AllTheKeysSet;
        }
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
        }
        private void OnDwgNdpLoad(object sender, EventArgs e)
        {
        InitThreadsStarts();
        }
        public  class TDwgNdpGameThreads
        {
        public static void ThreadProc()
        {
        for (int ThreadLoop = 0; ThreadLoop < 1000; ThreadLoop++)
        {
        Thread.Sleep(2000);
        } 
        }
        }
        }
        }
