    namespace Dwg.Ndp.Person
    {
    using Dwg.Ndp.Data.Games;
    public interface IDwgNdpPerson
    {
    NatureElementsFlags InitAllPersons(NatureElementsFlags nature,NatElementsFlagsGF elementsFlagsGF);
    NatureElementsFlags TheCharPerson { get; }
    }
    }
