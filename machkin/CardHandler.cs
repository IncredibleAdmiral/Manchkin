using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machkin
{
  
   
    enum CardAction { Application , Cancellation }
   
    class CardHandler
    {

        public bool CardTypeView(Cards card, Player player)
         {
            var TypeCard = Convert.ToString(card.GetType());
            string Name = card.name;
            return false;
            //switch (TypeCard)
            //{
            //    case "machkin.Curse":
            //      return  CurseHandler(Name,player);
                        
            //    case "machkin.OtherItem":

            //       return OtherItemHandler(Name, player);
                        
            //    case "machkin.Monsters":
            //        return MonstersHandler( Name, player);
                        
            //    case "machkin.HeadArmor":
            //       return HeadArmorHandler(Name, player);
                    

            //    case "machkin.Weapon":
            //       return WeaponHandler(Name, player);
                    

            //    case "machkin.OtherBonusCards":
            //       return OtherBonusCardsHandker(Name, player);
                    
            //    case "machkin.ChestArmor":
            //       return ChestArmorHandler(Name, player);
                    
            //    case "machkin.ArmorBoots":
            //       return ArmorBootsHandler(Name, player);
                    
            //    case "machkin.LevelCard":
            //       return LevelCardHandler(Name, player);
                   
            //    case "machkin.BattleCard":
            //       return BattleCardHandler(Name, player);
                   
            //    case "machkin.ManchkinClassCard":
            //      return  ManchkinClassCardHandler(Name, player);
                    
            //    case "machkin.RaceCard":
            //       return RaceCardHandler(Name, player);
                    
            //    case "mackin.OtherDoorCards":
            //        return OtherDoorCardsHandler(Name, player);
                   

            //}

            //return false;
        }


       // private bool OtherBonusCardsHandker(string name, Player player)
       // {
       //     switch (name)
       //     {
       //         case "Магическая лампа": return MagicLamp(player);
       //         case "Зелья Полуморфа":  return PoliymorphPotion(player);
       //         case "Зелье стрелочника": return  Transferral(player);
       //         case "Хотельное кольцо":return WishingRing(player);
       //         case "Ура, клад": return  Hoard(player); 
       //         case "Допельгангер": return Doppleganger (player); 
       //         case "Тюбик клея": return FlaskOfGlue(player); 
       //         case "Зелье дружбы": return FriendshipPotion(player); 
       //         case "Стенка-Встанька": return InstantWall(player); 
       //         case "Читерский кубик": return  LoadedDie(player); 
       //         case "Яппито": return YuppieWater(player);
       //     //    case "Q-кубик": return (player, turnHandler, Pl); ;
                

       //     }
       //     return false;
       // }






       // private bool CurseHandler(string name,Player player)

       // {

            

       //     switch (name)
       //     {
       //         case "БольшаяПотеря":
       //             return CurseLoseIbigItem( player);
       //         case "ВКонецМерзкоеПроклятие":
       //             return TrulyObnoxiousCurse(player);
       //         case "КривящееЗеркало":
       //            return  CurseMalignMirror(player);
       //         case "КурицаНаБашне":
       //             return CurseChickenOnYourHead(player);
       //         case "Налоги":
       //             return CurseIncomeTax(player);
       //         case "НевиликаПотеря":
       //             return CurseLoseISmallItem(player);
       //         case "ПотеряйНадетыйБроник":
       //             return CurseLoseTheArmorYouAreWearing(player);
       //         case "ПотеряйУровень":
       //             return CurseLoseILevel(player);
       //         case "СменаКласса":
       //             return CurseChangeClass(player);
       //         case "СменаПола":
       //             return CurseChangeSex(player);
       //         case "СменаРассы":
       //             return CurseChangeRace(player);
       //         case "Теряешь2Карты":
       //             return CurseLoseTwoCards(player);
       //         case "ТеряешьКласс":
       //             return CurseLoseILevel(player);
       //         case "ТеряешьНадетуюОбувку":
       //             return CurseLoseTheFootgearYouAreWearing(player);
       //         case "ТеряешьНадетыйГоловняк":
       //             return CurseLoseTheHeadgearYouAreWearing(player);

       //         case "ТеряешьРасу":
       //             return CurseLoseYourRace(player);
       //         case "УткаОбреченности":
       //             return CurseDuckOfDoom(player);

                    

       //     }
       //     return false;


       // }
       // private bool ArmorBootsHandler(string name, Player player)
       // {

       //     switch (name)
       //     {
       //         case "Сандалеты - Протекторы": return SandalsOfProtection(player);

       //         case "Башмаки реально быстрого бега": return BootsOfRunningReallyFast(player);
       //     }


       //     return false;
       // }


       // private bool OtherItemHandler(string name, Player player)
       //     {
       //     switch (name)
       //     {
       //         case "НаколенникиРазвода": return KneepadsOfAllure(player);
       //     }
       //     return false;

       //     }

       // private bool MonstersHandler(string name, Player player)

       // {
       //     switch (name)
       //     {
       //         case "Молотая крысотка": return MaulRat(player );
       //         case "Г-н Кости": return MrBones(player);
       //         case "Форумный троль": return NetTroll (player);
       //         case "Питбуль": return PitBull (player);
       //         case "Утикора": return Platycore (player);
       //         case "Плутониевый Дракон": return PlutoniumDragon(player);
       //         case "Трава в горшке": return PottedPlant(player);
       //         case "Рыгачу": return Pukachu(player);
       //         case "Вопящий задрот": return ShriekingGeek(player);
       //         case "Ускоренные улитки": return SnailsOnSpeed(player);
       //         case "Желатиновый Октаэдр": return  GelatinousOctahedron(player);
       //         case "Мадемонуазели": return Ghoulfiends(player);
       //         case "Гарпистки": return Harpies(player);
       //         case "Гиппогриф": return Hippogriff(player);
       //         case "Страховой Агент": return InsuranceSalesman(player);
       //         case "Король Тут": return KingTut(player);
       //         case "Увеченный гоблин": return LameGoblin(player);
       //         case "Здоровая бешенная цыпа": return LargeAngryChicken(player);
       //         case "Адвокат": return Lawyers(player);
       //         case "Лепрокон": return Leperchaun (player);
       //         case "3872 орка": return  Orcs3872(player);
       //         case "Бигфут": return Bigfoot(player);
       //         case "Амазонка": return Amazon(player);
       //         case "Бульрог": return Bullrog(player);
       //         case "Типа Вошки": return Crabs(player);
       //         case "Сочащаяся слизь": return DroolingSlime(player);
       //         case "Лицесос": return FaceSucker (player);
       //         case "Сопливый Нос": return FloatingNose(player);
       //         case "Летучие лягушки": return FlyingFrogs(player);
       //         case "Газебо": return Gazebo(player);
       //         case "Кальмадзилла": return Squidzilla(player);
       //         case "Обдолбанный Голем": return StonedGolem (player);
       //         case "Языческий демон": return TongueDemon(player);

       //     }

       //     return false;

       // }

       // private bool HeadArmorHandler(string name, Player player)
       // {
       //     switch (name)
       //     {
       //      case   "Шлем-Рогач": return HornyHelmet(player);
       //     }

       //     return false;
       // }

       // private bool WeaponHandler(string name, Player player)
       // {
       //     switch (name)
       //     {
       //         case "Крыса на палочке": return RatOnAStick(player);
       //         case "Чарующая Дуда": return TubaOfCharm(player);
           
       //     }
       //     return false;


       // }

       // private bool ChestArmorHandler(string name, Player player)
       // {
       //     //nothing

       //     return false;



       // }
       // private bool LevelCardHandler(string name, Player player)
       // {
       //     switch (name)
       //     {
       //         case "Укради Уровень": return StealALevel(player);
       //         case "Рассчитайся с наемничком": return KillTheHireling(player);
       //         case "Поглумись над телами врагов": return MutilateTheBodies(player);
       //         case "Разжалоби мастера": return WHineAtTheGM(player);
       //     }
       //     return false;

       // }
       //private bool ManchkinClassCardHandler(string name, Player player)
       // {
       //     switch (name)
       //     {
       //         case "Клирик": return Cleric(player);
       //         case "Вор": return Thief(player);
       //         case "Волшебник": return Wizard(player);
       //         case "Воин": return Warrior(player);
       //     }

       //     return false;

       // }
       // private bool RaceCardHandler(string name, Player player)
       // {
       //     switch (name)
       //     {
       //         case "Дварф": return Dwarf(player);
       //         case "Эльф": return Elf(player);
       //         case "Халфлинг": return Halfling(player);
       //     }
       //     return false;
       // }
       // private bool BonusMonsterHandler(string name, Player player)
       // {
       //     //nothing

       //     return false;
       // }


       // private bool OtherDoorCardsHandler(string name, Player player)
       // {
       //     switch (name)
       //     {
       //         case "Полукровка": return HalfBreed(player);
       //         case "Помоги Себе Сам":return HelpMeOutHere(player);
       //         case "Иллюзия": return Illusion(player);
       //         case "Гадкая парочка": return Mate(player);
       //         case "Обеденный Перерыв": return OutToLunch(player);
       //         case "Супер Манчкин": return SuperMunchkin(player);
       //         case "Бродячая Тварь": return WanderingMonster(player);
                

       //     }

       //     return false;
       // }

       // private bool BattleCardHandler(string name, Player player) { return true; }

       // private bool HornyHelmet(Player player  ) { return true; }

       // private bool StealALevel(Player player ) { return true; }
       // #region
       // private bool MagicLamp(Player player ){ return true; }
       // private bool PoliymorphPotion(Player player) { return true; }

       // private bool Transferral(Player player) { return true; }

       

       // private bool BootsOfRunningReallyFast(Player player) { return true; }

       // private bool Hireling(Player player) { return true; }

       // private bool Hoard(Player player) { return true; }

       // private bool KneepadsOfAllure(Player player) { return true; }

       // private bool WandOfDowsing (Player player) { return true; }

       // private bool Doppleganger(Player player) { return true; }

       // private bool FlaskOfGlue(Player player) { return true; }
       // #endregion
       // private bool FriendshipPotion(Player player){ return true; }

       // private bool InstantWall (Player player){ return true; }

       // private bool InvisibilityPotion(Player player) { return true; }

       // private bool LoadedDie (Player player ) { return true; }

       // private bool CurseChangeClass(Player player) { return true; }

       // private bool CurseChangeRace(Player player) { return true; }

       // private bool CurseChangeSex(Player player) { return true; }

       // private bool CurseChickenOnYourHead(Player player) { return true; }

       // private bool CurseDuckOfDoom(Player player) { return true; }

       // private bool CurseIncomeTax(Player player) { return true; }

       // private bool CurseLoseIbigItem(Player player) { return true; }

       // private bool CurseLoseILevel(Player player) { return true; }

        

       // private bool TubaOfCharm(Player player ) { return true; }

       // private bool SandalsOfProtection(Player player) { return true; }

       // private bool YuppieWater(Player player ){ return true; }


       // private bool KillTheHireling(Player player) { return true; }

       // private bool MutilateTheBodies(Player player) { return true; }

       // private bool WHineAtTheGM(Player player) { return true; }

       // private bool RatOnAStick(Player player) { return true; }

       // private bool HalfBreed(Player player) { return true; }

       // private bool HelpMeOutHere(Player player) { return true; }

       // private bool Illusion(Player player) { return true; }

       // private bool Mate(Player player) { return true; }

       // private bool OutToLunch(Player player) { return true; }

       // private bool SuperMunchkin(Player player) { return true; }

       // private bool WanderingMonster(Player player) { return true; }

       // private bool Halfling(Player player) { return true; }

       // private bool Thief(Player player) { return true; }
       // private bool Warrior(Player player ) { return true; }
       // private bool Wizard(Player player) { return true; }

       // private bool Ancient(Player player) { return true; }
       // private bool Baby(Player player) { return true; }
       // private bool Enraged(Player player) { return true; }
       // private bool Humongous(Player player) { return true; }
       // private bool Intelligent(Player player) { return true; }

       // private bool Cheat(Player player) { return true; }

       // private bool DivineIntervention(Player player) { return true; }

       // private bool Cleric(Player player) { return true; }

       // private bool Dwarf(Player player) { return true; }
       // private bool Elf(Player player) { return true; }
       // private bool CurseLoseISmallItem(Player player) { return true; }

       // private bool CurseLoseTheArmorYouAreWearing(Player player) { return true; }

       // private bool CurseLoseTheFootgearYouAreWearing(Player player) { return true; }

       // private bool CurseMalignMirror(Player player) { return true; }

       // private bool CurseLoseTheHeadgearYouAreWearing(Player player) { return true; }

       // private bool CurseLoseTwoCards(Player player) { return true; }

       //  private bool CurseLoseYourClass(Player player) { return true; }

       // private bool CurseLoseYourRace(Player player ) { return true; }

       // private bool TrulyObnoxiousCurse(Player player) { return true; }


       // private bool GelatinousOctahedron(Player player) { return true; }

       // private bool Ghoulfiends(Player player) { return true; }


       // private bool Harpies(Player player) { return true; }


       // private bool Hippogriff(Player player) { return true; }



       // private bool InsuranceSalesman(Player player) { return true; }


       // private bool KingTut(Player player) { return true; }



       // private bool LargeAngryChicken(Player player) { return true; }



       // private bool Lawyers(Player player) { return true; }



       // private bool Leperchaun(Player player) { return true; }


       // private bool WishingRing(Player player) { return true; }


       // private bool Squidzilla(Player player) { return true; }

       // private bool StonedGolem(Player player ) { return true; }

       // private bool LameGoblin(Player player ) { return true; }
       // private bool TongueDemon(Player player  ) { return true; }

       // private bool UndeadHorse(Player player ) { return true; }
       // private bool UnspeakablyAwfulIndescribableHorror(Player player ) { return true; }
       // private bool WannabeVampire(Player player ) { return true; }
       // private bool WightBrothers(Player player) { return true; }
       // private bool Orcs3872(Player player ) { return true; }
       // private bool Amazon(Player player ) { return true; }
       // private bool Bigfoot(Player player) { return true; }
       // private bool Bullrog(Player player) { return true; }



       // private bool Crabs(Player player ) { return true; }

       // private bool DroolingSlime(Player player ) { return true; }

       // private bool FaceSucker(Player player ) { return true; }

       // private bool FloatingNose(Player player) { return true; }

       // private bool FlyingFrogs(Player player) { return true; }

       // private bool Gazebo(Player player) { return true; }


       // private bool MaulRat(Player player ) { return true; }
       // private bool MrBones(Player player ) { return true; }
       // private bool NetTroll(Player player  ) { return true; }
       // private bool PitBull(Player player  ) { return true; }
       // private bool Platycore(Player player ) { return true; }
       // private bool PlutoniumDragon(Player player) { return true; }
       // private bool PottedPlant(Player player ) { return true; }
       // private bool Pukachu(Player player ) { return true; }
       // private bool ShriekingGeek(Player player ) { return true; }
       // private bool SnailsOnSpeed(Player player ) { return true; }



    }
}
