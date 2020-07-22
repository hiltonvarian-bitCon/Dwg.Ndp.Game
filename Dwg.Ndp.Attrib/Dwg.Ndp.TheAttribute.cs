using System;
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
    }
    
    
