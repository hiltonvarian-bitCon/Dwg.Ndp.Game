    namespace Dwg.Ndp.Person
    {
    using System.Threading;
    using System.Threading.Tasks;
    using System.Timers;

    using Dwg.Ndp.Data.Games;

    public interface IDwgNdpPerson
    {
    void InitSetAllPersons();
    void InitSetAllPersons(NatureElementsFlags natureElementsFlags,in string[] vsArr);
    void InitSetAllPersons(NatureElementsFlags nature, string[] ArrFlagVs);
    void SetTheSumOfAxis(float axisValueX, double axisValueY);
    void SetTheSumOfAxis(float axisValueX, float axisValueY);
    float CalculateValues();
    float CalculateValues(float value);
    double CalculateValue(double axisX, double axisY);
    double CalculateValue(float axisX, double axisY, float axisZ);

    NatureElementsFlags InitAllPersons(NatureElementsFlags nature,NatElementsFlagsGF elementsFlagsGF);
    NatElementsFlagsGF InitAllPerson(NatureElementsFlags nature, NatElementsFlagsGF elementsFlagsGF);
    
    //Game Propertie values
    NatureElementsFlags TheNatCharPersonElem    { get;}
    NatElementsFlagsGF TheNatCharPersonElemGF   { get;}
    TheKeysFlags TheGamesKeys                   { get;}
    float  TheAxisValueX                        { get;}
    float  TheAxisValueY                        { get;}
    float  TheAxisValueZ                         { get;}
    }
    }
