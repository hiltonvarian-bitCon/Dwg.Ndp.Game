    namespace Dwg.Ndp.Person
    {
    using System;
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
     void SetTheSumsOfAxis(float axisValueX, float axisValueY, float axisValueZ);
     float CalculateValues();
     float CalculateTrajectory();
     float CalculateTrajectory(double axisX, double axisY);
     float CalculateValues(float value);
     double CalculateValue(double axisX, double axisY);
     double CalculateValue (float axisX, double axisY, float axisZ);
     double CalculateValues(ref double total,double graverty, float trajectury,float angle,double speed);
     double CalculateValues(ref double total, in double graverty, double force, float angle, double speed);
     double CalculateValue(in float angle, float axisValueX, double axisValueY, double gravity, double force);
     double CalculateValueTrajValue(float axisValueX, double axisValueY, ref float trajectoryPercent, float angle);
     double CalculateValueTrajValue(double  axisValueX, double axisValueY, in  float trajectoryPercent,ref float angle,float disttrav=default(long));

     NatureElementsFlags InitAllPersons(NatureElementsFlags nature,NatElementsFlagsGF elementsFlagsGF);
     NatElementsFlagsGF InitAllPerson(NatureElementsFlags nature, NatElementsFlagsGF elementsFlagsGF);
     IDwgNdpCaricDirections[] CharictsDir(IDwgNdpCaricDirections ndpCaricDirections);
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

     public interface IDwgNdpCaricDirections:IDwgNdpPerson
     {
     void InitCharicDirections();
     double CalculateTrajectoryAxisX();
     double CalculateTrajectoryAxisY();
     double CalculateTrajectoryAxisZ();
     double CalculateTrajectoryAxisX(float axisX);
     double CalculateTrajectoryAxisY(float axisY);
     double CalculateTrajectoryAxisZ(float axisZ);

    IDwgNdpPerson[] IDwgNdpCarDirArr  { get; }
    }
    }
