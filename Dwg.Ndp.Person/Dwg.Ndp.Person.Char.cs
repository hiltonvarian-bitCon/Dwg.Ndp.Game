﻿    namespace Dwg.Ndp.Person
    {
    using System.Threading;
    using System.Threading.Tasks;
    using System.Timers;

    using Dwg.Ndp.Data.Games;

    public interface IDwgNdpPerson
    {
     void InitSetAllPersons();
     void InitSetAllPersons(NatureElementsFlags natureElementsFlags,in string[] vsArr);

     NatureElementsFlags InitAllPersons(NatureElementsFlags nature,NatElementsFlagsGF elementsFlagsGF);
     NatElementsFlagsGF InitAllPerson(NatureElementsFlags nature, NatElementsFlagsGF elementsFlagsGF);

    NatureElementsFlags TheNatCharPersonElem   { get; }
    NatElementsFlagsGF TheNatCharPersonElemGF  { get;}
    TheKeys TheGamesKeys                       { get;}
    }
    }