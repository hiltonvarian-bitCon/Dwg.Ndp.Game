using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Dwg.Game.World
 {
 using Dwg.Game.AI;
 using Dwg.Ndp.Data.Games;
 using Dwg.Ndp.Attrib;
 using Dwg.Ndp.Person;

 [Serializable]
 public class TDwgGameWorld
    {
 private string nameWorld;
 private Int32 temAi;
 public TDwgGameWorld()
 {
 }

 public string TheNameWorldSet
 {
get => nameWorld;
set => nameWorld = value;
 }
 public Int32 TheTemAi
 { 
get => temAi;
set => temAi = value;
 }

 public virtual void InitGameWorld()
 {

 }
 public void InitGameWorld(Int32 worldAxisX,Int32 worldAxisY)
 {
 
 }
 public virtual TDwgGameAI  InitGameWorld(Int32 valueAi,Int32[]aiArr)
 {

 return new TDwgGameAI(valueAi, aiArr);
 } 
 [Serializable]
 public class TDwgGameWorldOne:TDwgGameWorld
 {
 public TDwgGameWorldOne()
 {

 }
 internal string TheDwgGameWorldGet
 {
get => nameWorld;
set => nameWorld = value;
 }

 public override void InitGameWorld()
 {
 base.InitGameWorld();
 }

 public override TDwgGameAI InitGameWorld(Int32 valueAi, Int32[] aiArr)
 {
 return base.InitGameWorld(valueAi, aiArr);
 }
 }
 
 }
 }
