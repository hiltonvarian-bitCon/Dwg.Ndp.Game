namespace Dwg.Ndp.Data.Games
{
    public  enum NatureElements:int
    {
    EarthElem=0,AirElem=1,FireElem=2,
    WaterElem =3,DarcElem=4,NoElem=-1
    }

    public  enum NatElementsGF:int
    {
    EarthElemGF=0,AirElemGF=1,FireElemGF=2,
    WaterGF =3,DarcElemGF=4,NoElemGF=-1
    }
    public class TDwgNdpGamesData
    {

    private static NatureElements elements = NatureElements.NoElem;
    private static NatElementsGF elementsGF = NatElementsGF.NoElemGF;
    public TDwgNdpGamesData():this(elements)
    {
    //Default Constructor
    }
    public void InitAllData()
    {
    
    }
    private string[] thelemArr = { "Earth Elemental", "Air Elemental", "Fire Elemental", "Water Elementa", "Darc Elemnta" };

    private ref NatureElements GetNameElements(string[]value)
    {
    thelemArr = value;

    return ref elements;
    }

    public TDwgNdpGamesData(NatureElements natureElements)
    {
   
    }
    public class TDwgGameDats:TDwgNdpGamesData
    {
    public TDwgGameDats():this(elements)
    {
    //Default Value
    }

    public NatureElements TheNatElements
    {
  get => elements;
  set => elements = value; 
    }

    public string[] ElementalArr
    {
  get => thelemArr;
  set => thelemArr = value;
    }

    public NatElementsGF TheElementsGF
    {
  get => elementsGF;
  set => elementsGF = value;
    }
    public TDwgGameDats(NatureElements theNatureElements)
    {
    elements = theNatureElements;
    }
    }
    }
    }
