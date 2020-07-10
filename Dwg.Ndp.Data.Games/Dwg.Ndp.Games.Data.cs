   namespace Dwg.Ndp.Data.Games
   {
    using System;
    using System.Windows.Forms;

   [Flags]
    public  enum NatureElementsFlags:int
    {
    EarthElem=0,AirElem=1,FireElem=2,
    WaterElem =3,DarcElem=4,NoElemFlagsValue=-1
    }

   [Flags]
    public  enum NatElementsFlagsGF:int
    {
    EarthElemGF=0,AirElemGF=1,FireElemGF=2,
    WaterGF =3,DarcElemGF=4,NoElemGF=-1
    }

    public class TDwgNdpGamesData
    {

    private static NatureElementsFlags elements = NatureElementsFlags.NoElemFlagsValue;
    private static NatElementsFlagsGF  elementsGF = NatElementsFlagsGF.NoElemGF;

    public TDwgNdpGamesData():this(elements)
    {
    //Default Constructor
    }
    public void InitAllData()
    {
    SetAllDataValues();
    }
    protected void SetAllDataValues()
    {
    TheNatElemDataSet = NatureElementsFlags.AirElem;
   
    }
    private string[] thelemArr = { "Earth Elemental", "Air Elemental", "Fire Elemental", "Water Elemental", "Darc Elemntal" };

    private ref NatureElementsFlags GetNameElements(string[]value)
    {
    thelemArr = value;

    return ref elements;
    }
    public virtual  NatureElementsFlags GetNameElements(TDwgGameDats theData)
    {
    if (theData == null)
    {
    throw new ArgumentNullException(nameof(theData));
    }
    switch (theData.TheNatElemDataSet)
    {
    case NatureElementsFlags.EarthElem:
         elements = NatureElementsFlags.EarthElem;
    break;
    case NatureElementsFlags.AirElem:
         elements = NatureElementsFlags.AirElem;
    break;
    case NatureElementsFlags.FireElem:
         elements = NatureElementsFlags.FireElem;
    break;
    case NatureElementsFlags.WaterElem:
         elements = NatureElementsFlags.WaterElem; 
    break;
    case NatureElementsFlags.DarcElem:
         elements = NatureElementsFlags.DarcElem;
    break;
 default:
     theData.TheNatElementsFlags = NatureElementsFlags.NoElemFlagsValue;
   break;
    }
    return theData.TheNatElementsFlags;
    }
    public NatureElementsFlags TheNatElemDataSet
    {
  get => elements;
  set => elements = value;
    }
    public TDwgNdpGamesData(NatureElementsFlags natureElements)
    {
   
    }
    public class TDwgGameDats:TDwgNdpGamesData
    {
    public TDwgGameDats():this(elements)
    {
    //Default Value
    }

    internal NatureElementsFlags TheNatElementsFlags
    {
  get => elements;
  set => elements = value; 
    }

    public string[] ElementalArr
    {
  get => thelemArr;
  set => thelemArr = value;
    }

    public NatElementsFlagsGF TheElementsGF
    {
  get => elementsGF;
  set => elementsGF = value;
    }
    public TDwgGameDats(NatureElementsFlags theNatureElements)
    {
    elements = theNatureElements;
    }

    public override NatureElementsFlags GetNameElements(TDwgGameDats theData)
    {

    return base.GetNameElements(theData);
    }
    }
    }
    }
