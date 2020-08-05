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
    double CalculateValue (float axisX, double axisY, float axisZ);
    double CalculateValues(ref double total,double graverty, float trajectury,float angle,double speed);
    double CalculateValues(ref double total, in double graverty, double force, float angle, double speed);
    double CalculateValue(in float angle, float axisValueX, double axisValueY, double gravity, double force);
    double CalculateValueTrajValue(float axisValueX, double axisValueY, ref float trajectoryPercent, float angle);
    NatureElementsFlags InitAllPersons(NatureElementsFlags nature,NatElementsFlagsGF elementsFlagsGF);
    NatElementsFlagsGF InitAllPerson(NatureElementsFlags nature, NatElementsFlagsGF elementsFlagsGF);
    
    //Game Propertie values
    NatureElementsFlags TheNatCharPersonElem    { get;}
    NatElementsFlagsGF TheNatCharPersonElemGF   { get;}
    TheKeysFlags TheGamesKeys                   { get;}
    float  TheAxisValueX                        { get;}
    float  TheAxisValueY                        { get;}
    float  TheAxisValueZ                        { get;}
    double  TheTotal                            { get;}
    float  ItemTrajectory                       { get;}
    }
    }
