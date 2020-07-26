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
       
        keysFlags = TheKeysFlags.RusterdKey;

        InitAsemblyNameAttrIB();
        }
        private void InitAsemblyNameAttrIB()
        {
        Assembly assembly = typeof(TDwgNdpCharCard).Assembly;
       try
        {
        
        }
     finally
        {
        
        }
        }
        public TDwgNdpGameAttrib(NatureElementsFlags natureElements)
        {
        elementsFlags = natureElements;
        }
        public NatureElementsFlags TheElementalFlags
        {
   get => elementsFlags;
   set => elementsFlags = value;
        }
        public NatElementsFlagsGF TheFlagsGF
        {
   get => FlagsGF;
   set => FlagsGF = value;
        }
        public TheKeysFlags ThekeyFlags
        {
   get => keysFlags;
   set => keysFlags = value;
        }

        public TDwgNdpGameAttrib(NatElementsFlagsGF theflagsGF)
        {
        FlagsGF = theflagsGF;
        }

        public TDwgNdpGameAttrib(TheKeysFlags theKeys)                                                     
        {
        keysFlags = theKeys;
        }
        public GameDirections TheGameDirections
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
        public void TheElamNature() { }

        [TDwgNdpGameAttrib(NatElementsFlagsGF.AirElemGF)]
        public void TheElemNatGF() { }

        [TDwgNdpGameAttrib(TheKeysFlags.CopperKey)]
        public void TheGameKeys() { }

        [TDwgNdpGameAttrib]
        public void InitallAtributes() { }
        }
        [TDwgNdpGameAttrib(GameDirections.North)]
        public void TheGameKeys() { }
     }
     [AttributeUsage(AttributeTargets.Constructor|AttributeTargets.Method)]
     public  class TDwcharAtribute:TDwgNdpGameAttrib
     {
     [TDwgNdpGameAttrib]
     public void TheCharAttributes()
     {
     
     }
     public NatureElementsFlags ThNatElementalFlagsGet
     {
   get
     {
     return TheElementalFlags;
     }
     }
     public NatElementsFlagsGF ThNatElementalFlagsGetGF
     {
   get
     {
     return TheFlagsGF;
      }
      }
     public GameDirections ThGameDirectionsFlagsGet
     {
  get
     {
     return TheGameDirections;
     }
     } 
     [TDwgNdpGameAttrib(NatureElementsFlags.NoElemFlagsValue)]
     public TDwcharAtribute()
     {
     //default constructor
     }

     public TDwcharAtribute(NatureElementsFlags elementsFlags):base(elementsFlags)
     {
     TheElementalFlags = elementsFlags;
     }
     }
     }
    
    
