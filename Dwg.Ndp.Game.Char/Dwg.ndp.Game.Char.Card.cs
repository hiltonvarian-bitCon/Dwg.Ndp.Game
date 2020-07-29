    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Dwg.Ndp.Game.Char
    {
    using Dwg.Game.AI;
    using Dwg.Ndp.Game.Con;
    public class TDwgNdpCharCard:Form
    {
       
    private float hitpoints     = TDwgNdpGameConVal.C_Hitpointrs;
    private float dexterity     = TDwgNdpGameConVal.C_TheDexterity;
    private float oritory       = TDwgNdpGameConVal.C_TheOritory;
    private float attacPoints   = TDwgNdpGameConVal.C_TheAttackPoints;
    private float stanimaPoints = TDwgNdpGameConVal.C_TheStanimaPoints;
    private float strengthPoints = TDwgNdpGameConVal.C_TheStrengthPoints; 

    private TDCharictorsCardItems[] charictorsCardItems;
       
    public float HitpointsSet
    {
  get => hitpoints;
  set => hitpoints = value;
    }
    public float TheDexteritySet
    {
  get => dexterity;
  set => dexterity = value;
    }
    public float TheOritorySet
    {
  get => oritory;
  set => oritory = value;
    }
     public float AttacPointsSet
     {
   get => attacPoints;
   set => attacPoints = value;
     }
    public TDwgNdpCharCard()
    {
    
    }
    public TDCharictorsCardItems[] CharictorsItems
    {
  get => charictorsCardItems;
  set => charictorsCardItems = value;
    }
     public float StanimaPointsSet
    {
   get => stanimaPoints;
   set => stanimaPoints = value;
     }
    public float StrengthPointSet
    {                                                                                                                       
  get => strengthPoints;
  set => strengthPoints = value;
    }
    public TDwgNdpCharCard(TDCharictorsCardItems[] tDCharictors)
    {
    charictorsCardItems = tDCharictors;
    }
    private void InitializeComponent()

    {
    this.SuspendLayout();
    // 
    // TDwgNdpCharCard
    // 
    this.ClientSize = new System.Drawing.Size(305, 652);
    this.Name = "TDwgNdpCharCard";
    this.Text = "Game Charitors Card";
    this.Activated += new System.EventHandler(this.OnGameCharictorsCardActivate);
    this.ResumeLayout(false);

    }
    public void InitArraysVal()
    {
        
    }
        
    public  class TDCharictorsCardItems
    {
    public string namewepons;
    public string nameItems;
    }

    internal float HitpointGet
    {
  get => hitpoints;
  set => hitpoints = value;
    }

    internal float TheDexterityGet
    {
  get => dexterity;
  set => dexterity = value;
    }

    internal float TheOritoryGet
    {
  get => oritory;
  set => oritory = value;
    }

    internal float AttacPointsGet
     {
  get => attacPoints;
  set => attacPoints = value;
    }
     internal  float StanimaPointsGet
    {
  get => stanimaPoints;
  set => stanimaPoints = value;
    }
    internal  float StrengthPointGet
    {
  get => strengthPoints;
  set => strengthPoints = value;
    }

    public  class TDwgNdpGameCharCardThread
    {
       
    }

    private void OnGameCharictorsCardActivate(object sender, EventArgs e)
    {
        
    }
    }
    }
