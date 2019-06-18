using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machkin
{
    class Player
    {
        string Name;
        string Sex;
        RaceCard race = null;
        ManchkinClassCard PlayerClass = null;
        List<Curse> PlayerCurse = new List<Curse>();

        int level = 1;
        int Damage;
        int EscapeBonus = 0;
        OtherDoorCards DoubleRace = null;
        OtherDoorCards DoublePlayerClass = null;
        bool DeathStatus = false;


        bool BanCurseDeck = false;
        bool BanCursePlayer = false;
        bool CurrentCurseFromOtherPlayer = false;

        #region
        HeadArmor Head = null;
        Weapon LeftHand = null;
        Weapon RightHand = null;
        ArmorBoots Legs = null;
        ChestArmor Body = null;
        List<OtherItem> Other = new List<OtherItem>();

        List<Cards> HandStack = new List<Cards>();

        List<Cards> BordDisStack = new List<Cards>();



        public Player(string sex, string name)
        {
            Sex = sex;
            Name = name;
        }

        #endregion

        void DamageCount()
        {
            int OtherDamageBonus = 0;
            int Buf = 0;
            if (Other.Count < 1)
            {
                foreach (OtherItem i in Other)
                {
                    Buf = i.Damage;
                    OtherDamageBonus += Buf;
                }
            }

            if (Head != null)
                OtherDamageBonus += Head.Damage;
            if (LeftHand != null)
            {
                OtherDamageBonus += LeftHand.Damage;
                if ((!LeftHand.TwoHand) && (RightHand != null))
                    OtherDamageBonus += RightHand.Damage;

            }
            else if (RightHand != null)
                OtherDamageBonus += RightHand.Damage;

            if (Legs != null)
                OtherDamageBonus += Legs.Damage;
            if (Body != null)
                OtherDamageBonus += Body.Damage;
        }

        public bool WearClothes( Item PutOnTheThing,ref Item BodyPart)
        {
            var PutOnTheThingType = Convert.ToString (PutOnTheThing.GetType());
            var BodyPartType = Convert.ToString( BodyPart.GetType());
            CardHandler cardh = new CardHandler();
            if (PutOnTheThingType != BodyPartType)
                return false;
            

            bool PresenceRCG = PutOnTheThing.Class == null && PutOnTheThing.Race == null && PutOnTheThing.Gender == null;

            bool CheckGenderCompatibility = (PutOnTheThing.Gender != null && Sex == PutOnTheThing.Gender) || (PutOnTheThing.Gender == null);

            bool CheckRaceCompatibility = (PutOnTheThing.Race != null && race.name == PutOnTheThing.Race) || (PutOnTheThing.Race == null);

            bool CheckClassCompatibility = (PutOnTheThing.Class != null && PlayerClass.name == PutOnTheThing.Class) || (PutOnTheThing.Class == null);

            bool CheckGRC = CheckGenderCompatibility && CheckRaceCompatibility && CheckClassCompatibility;

            bool Adpropert = PutOnTheThing.AdditProp;

            bool Naked = BodyPart == null;


            if (PutOnTheThingType != "machkin.Weapon")
            {

                if ((PresenceRCG || CheckGRC) && (!Adpropert))
                {

                    if (Naked)
                    { BodyPart = PutOnTheThing; return true; }
                    else { HandStack.Add(BodyPart); BodyPart = PutOnTheThing; }

                    return true;


                }
                if ((PresenceRCG || CheckGRC) && (Adpropert)) { return cardh.CardTypeView(PutOnTheThing, this); }

            }
            else

            {


                if ((PresenceRCG || CheckGRC) && (!Adpropert)) { }

            }

            return false;



                   







           





        }



      public void  TakeCard(Cards card)

        {
            HandStack.Add(card);

        }



    }

}
