using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwg.Ndp.Char.Counters
{
    using Dwg.Ndp.Game.Con;
    public class TGameCharictorsPersonCounters
    {
    public TGameCharictorsPersonCounters(string chfNameCh, string chLnameCh) : this(chfNameCh, chLnameCh, theVsCh)
    {
    chFName = chfNameCh;
    chLName = chLnameCh;
    }
    public string chFName = TDwgNdpGameConVal.C_StringsName;
    public string chLName = TDwgNdpGameConVal.C_StringsName;

    private static string[] theVsCh;

    public TGameCharictorsPersonCounters(string fnameCh, string lnameCh, string[] valstrChar)
    {
    theVsCh = valstrChar;
    }
    public string[] TheValuStrCh
    {
  get => theVsCh;
  set => theVsCh = value;
    }
    public  class TGamePersonChar : IEnumerable
    {
    private  TGameCharictorsPersonCounters[] _gameCharictors;

    public TGameCharictorsPersonCounters[] TheGamesCharictors
    {
  get => _gameCharictors;
  set => _gameCharictors = value;
    }

    public TGamePersonChar(TGameCharictorsPersonCounters[]gameCharictorsPeopleArr)
    {
   _gameCharictors = gameCharictorsPeopleArr;

   _gameCharictors = new TGameCharictorsPersonCounters[gameCharictorsPeopleArr.Length];
    for (Int32 GameCharictorsLoop = 0; GameCharictorsLoop < gameCharictorsPeopleArr.Length; GameCharictorsLoop++)
    {
   _gameCharictors[GameCharictorsLoop] = gameCharictorsPeopleArr[GameCharictorsLoop];  
    }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
    return (IEnumerator) GetEnumerator();
    }
    public TGamePersonChar GetEnumerator()
    {
    return new TGamePersonChar(_gameCharictors); 
    }
    }
    
    public sealed  class TgamePersonsEnumChar : IEnumerator
    {
    public TGameCharictorsPersonCounters[] _personCounters;
    private  Int32 position = -1;
    public TgamePersonsEnumChar(TGameCharictorsPersonCounters[]personsChars)
    {
    _personCounters = personsChars;
    }
    object IEnumerator.Current
    {
  get
    {
    return ThePersonCurrent;
    }
    }
    public TGameCharictorsPersonCounters ThePersonCurrent
    {
  get
    {
   try
    {
    return _personCounters[position];
    }
    catch (IndexOutOfRangeException)
    {
    throw new InvalidOperationException();
    }
    }
    }
    bool IEnumerator.MoveNext()
    {
    position++;
    return (position < _personCounters.Length);
    }

    void IEnumerator.Reset()
    {
    position =- 1;
    }
    }
    }
    }
