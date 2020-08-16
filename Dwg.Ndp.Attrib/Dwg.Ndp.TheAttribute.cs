using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Dwg.Ndp.Attrib
{
    using Dwg.Game.AI;
    using Dwg.Ndp.Person;
    using Dwg.Ndp.Data.Games;
    using Dwg.Ndp.Game.Char;

   
    public class TDwgNdpGameAttrib : Attribute
    {
        protected NatureElementsFlags elementsFlags;
        protected NatElementsFlagsGF FlagsGF;
        protected TheKeysFlags keysFlags;
        protected GameDirections directions;

        public TDwgNdpGameAttrib()
        {
        InitAsemblyNameAttrib();
        }
        private void InitAsemblyNameAttrib()
        {
        TDwgNdpAttributs NdpAttributsdwg = new TDwgNdpAttributs();
       try
        {
        TheElementalFlagsSet = NatureElementsFlags.AirElem;
        }
     finally
        {
        NdpAttributsdwg.TheElamNature(); 
        }
        }
        public TDwgNdpGameAttrib(NatureElementsFlags natureElements)
        {
        elementsFlags = natureElements;
        }
        public NatureElementsFlags TheElementalFlagsSet
        {
   get => elementsFlags;
   set => elementsFlags = value;
        }
        public NatElementsFlagsGF TheFlagsGFSet
   
        {
   get => FlagsGF;
   set => FlagsGF = value;
        }
        public TheKeysFlags ThekeyFlagsSet
        {
   get => keysFlags;
   set => keysFlags = value;
        }

        public   TDwgNdpGameAttrib(NatElementsFlagsGF theflagsGF)
        {
        FlagsGF = theflagsGF;
        }

        public TDwgNdpGameAttrib(TheKeysFlags theKeys)                                                     
        {
        keysFlags = theKeys;
        }
        public GameDirections TheGameDirectionsSet
        {
   get => directions;
   set => directions = value;
        }

        public TDwgNdpGameAttrib(GameDirections thegameDir)
        {
        directions = thegameDir;
        }
        public override bool Match(object obj)
        {

        return base.Match(obj);
        }

       
        public class TDwgNdpAttributs                                        
        {
        [TDwgNdpGameAttrib(NatureElementsFlags.AirElem)]
        public void TheElamNature()
        {                                                     
        }
        
        [TDwgNdpGameAttrib(NatElementsFlagsGF.AirElemGF)]
        public void TheElemNatGF(){ }

        [TDwgNdpGameAttrib(TheKeysFlags.CopperKey)]
        public void TheGameKeys() {}
        
        [TDwgNdpGameAttrib]
        public void InitallAtributes() { }
        }
        [TDwgNdpGameAttrib(GameDirections.North)]
        public void TheGameDirections() { }
     }
     
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
     public sealed class TDwcharAtribute:TDwgNdpGameAttrib
     {

     [TDwgNdpGameAttrib]
     public void TheCharAttributes()
     {
     //default Method
     }

     [TDwgNdpGameAttrib(NatureElementsFlags.AirElem)]
     public TDwcharAtribute()
     {
     //default constructor
     }
    
     public NatureElementsFlags ThNatElementalFlagsGet
     {
    get
      {
      return TheElementalFlagsSet;
      }
      }
      public NatElementsFlagsGF ThNatElementalFlagsGetGF
      { 
    get
      {
      return TheFlagsGFSet;
      }
      }
     public GameDirections ThGameDirectionsFlagsGet
     {
   get
     {
     return TheGameDirectionsSet;
     }
     }

     
     public TDwcharAtribute(NatureElementsFlags elementsFlags) : base(elementsFlags)
     {
     TheElementalFlagsSet = elementsFlags;
     }
     }
     }
    
    
