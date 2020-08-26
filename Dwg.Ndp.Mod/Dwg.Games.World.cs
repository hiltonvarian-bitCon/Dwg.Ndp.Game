
    namespace Dwg.Ndp.Mod
    {
    using Dwg.Ndp.Game.Con;
    using Dwg.Ndp.Person;
    using System;
    using Dwg.Ndp.Attrib;
    using System.IO;

    public class TDwgGameWorldMod 
    {
    private string namworldslable;
    private Int32  gameWorldNum=0;                                           

    public TDwgGameWorldMod()
    {
    InitGameWorldMod();
    }
    private void InitGameWorldMod()
    {
    TheGameWorldNum   = 0;
    TheNamLabelworlds = "TheUpperWorlds";
    InitGameWorldMod(TheGameWorldNum, TheNamLabelworlds);
    }
    private void InitGameWorldMod(Int32 numIndex,string namRealms)
    {
    namworldslable = namRealms;
    gameWorldNum   = numIndex;
    }
    public string TheNamLabelworlds
    {
  get => namworldslable;
  set => namworldslable = value;
    }
   public Int32 TheGameWorldNum
   {
  get => gameWorldNum;
  set => gameWorldNum = value;
    }

    public virtual void InitGameWorld()
    {
    for (Int32 RealmsLoopCount = 0; RealmsLoopCount < TDwgNdpGameConVal.C_GameWorldsCount; RealmsLoopCount++)
    {
    TheGameWorldNum++;
    }
    }
    public class TGameWorldModOne:TDwgGameWorldMod
    {
   
    public TGameWorldModOne()
    {
        
    }
    public override void InitGameWorld()
    {
    base.InitGameWorld();
    }
    }
    }
    }

        
       
       
      
