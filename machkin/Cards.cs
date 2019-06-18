using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machkin
{
    class Cards
    {
        string Name;
       public string name { get{ return Name; } }
       protected Cards(string name)
        {
            Name = name;
        }
    }
    class Door: Cards
    {
       protected Door(string name) : base(name) { }


    }
   
    class Monsters : Door
    {
        int Level;
        int Damage;
        int RicherGive;
        int LevelGive;
        bool Undead;
        int Chase;
        public Monsters(string name, int level, int richerGive, int levelGive,bool undead,int chase) : base(name)
        {
            Undead = undead;
            Level = level;
            RicherGive = richerGive;
            LevelGive = levelGive;
            Chase = chase;
        }
    }
    class RaceCard : Door
    {
        
       public RaceCard(string name) : base(name) { }

    }
    class ManchkinClassCard : Door
    {
        
       public ManchkinClassCard(string name) : base(name) { }
    }
    class Curse : Door
    {

       public Curse(string name) : base(name) { }
    }
       
    class BonusMonster : Door       
    {
        int DamageBonus;
        int RicherBonus;
          public  BonusMonster(string name,int damageBonus, int richerBonus):base (name)
            {
            DamageBonus = damageBonus;
            RicherBonus = richerBonus;
            }
    }

    class OtherDoorCards : Door
    {
        public  OtherDoorCards(string name): base(name) { }
    }


    class Riches : Cards
    {
        int Cost;

       protected  Riches(string name, int cost) : base(name) { Cost = cost; }

    }
    class OtherBonusCards : Riches
    {
        bool Reusable;
        string WhenToUse;
        public  OtherBonusCards(string name,int cost,bool reusable,string whenToUse) :base(name,cost)
        {
            Reusable = reusable;
            WhenToUse = whenToUse;
        }
    }
    class Item : Riches
    {
        int DamageBonus;
        string Part;
        bool AdditionalProperty;
        string GenderOnly;
        string ClassOnly;
        string RaceOnly;
        string SmallOrBig;


        public bool AdditProp { get { return AdditionalProperty; } }

        public string Gender { get { return GenderOnly; } }
        public string Class { get { return ClassOnly; } }

        public string Race { get { return RaceOnly; } }

        public int Damage { get { return DamageBonus; } }


       protected Item(string name,int cost, string part, int damageBonus,bool additionalProperty, string genderOnly,string classOnly,string raceOnly,string smallorbig) : base(name,cost)
        { DamageBonus = damageBonus; Part = part; AdditionalProperty = additionalProperty; GenderOnly = genderOnly; ClassOnly = classOnly;RaceOnly = raceOnly; SmallOrBig = smallorbig; }

    }
    class HeadArmor : Item
    {
        public HeadArmor(string name, int cost, string part, int damageBonus, bool additionalProperty,string genderOnly,string classOnly, string raceOnly, string smallorbig)
            : base(name, cost, part, damageBonus, additionalProperty, genderOnly, classOnly, raceOnly, smallorbig) { }
    }

    class Weapon : Item
    {
        bool TwoHanded;

        public bool TwoHand
        {
            get{ return TwoHanded; }

        }
        
        public Weapon(string name, int cost, string part, int damageBonus, bool additionalProperty, string genderOnly, string classOnly, string raceOnly, string smallorbig, bool twohanded)
             : base(name, cost, part, damageBonus, additionalProperty, genderOnly, classOnly, raceOnly, smallorbig) { TwoHanded = twohanded; }

    }
    class ArmorBoots : Item
    {
        public ArmorBoots(string name, int cost, string part, int damageBonus, bool additionalProperty, string genderOnly, string classOnly,
            string raceOnly, string smallorbig) : base(name, cost, part, damageBonus, additionalProperty, genderOnly, classOnly, raceOnly, smallorbig) { }

    }
    class ChestArmor : Item
    {
        public ChestArmor(string name, int cost, string part, int damageBonus, bool additionalProperty, string genderOnly, string classOnly,
            string raceOnly, string smallorbig) : base(name, cost, part, damageBonus, additionalProperty, genderOnly, classOnly, raceOnly, smallorbig) { }
    }
    class OtherItem : Item
    {
        public OtherItem(string name, int cost, string part, int damageBonus, bool additionalProperty, string genderOnly, string classOnly, string raceOnly,
            string smallorbig) : base(name, cost, part, damageBonus, additionalProperty, genderOnly, classOnly, raceOnly, smallorbig) { }

    }

    class LevelCard : Riches
    {
        bool Restrictions;
      public  LevelCard(string name, int cost, bool restrictions) : base(name, cost) { Restrictions = restrictions; }
    }
    class BattleCard : Riches
    {
        string WhenToUse;
        bool Reusable;
        protected   BattleCard(string name, int cost,string whentouse,bool reusable): base(name, cost) { WhenToUse = whentouse; }
    }
    class BattleCardDamegeBonus : BattleCard

    {
        int DamageBonus;
        public BattleCardDamegeBonus(string name, int cost,string whentouse,bool reusable, int damageBonus) : base(name,cost,whentouse, reusable) { DamageBonus = damageBonus; }
    }

}
