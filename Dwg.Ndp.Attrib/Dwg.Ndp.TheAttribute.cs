﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
     public  class TcharAtribute:TDwgNdpGameAttrib
     {
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
     public NatElementsFlagsGF ThNatElementalFlagsSetGF
     {
   get
     {
     return TheFlagsGF;
      }
      }

     [TDwgNdpGameAttrib(NatureElementsFlags.NoElemFlagsValue)]
     public TcharAtribute()
     {
     //default constructor
     }
     public TcharAtribute(NatureElementsFlags elementsFlags)
     {
     TheElementalFlags = elementsFlags;
     }
     }
     }
    
    
