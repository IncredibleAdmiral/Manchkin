using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machkin
{
    static  class dise
    {
       static public int Throw()
        {
            Random rnd = new Random();
            int x = rnd.Next(1,6);
            return x;
        }

    }
        abstract class Deck
    {


       

        protected static void MixList<t>(List<t> list)
        {
            Random rnd = new Random();
            for (int i = 0; i < 200; i++)
            {
                int rand1 = rnd.Next(0,list.Count);
                int rand2;
                do
                {
                    rand2 = rnd.Next(0,list.Count);
                } while (rand2 == rand1);

                var  Buf = list[rand1];
                list[rand1] = list[rand2];
                list[rand2] = Buf;
             


            }
           
        }
        
    }

    class RicherDeck : Deck
    {
      private  List<Riches> deck     = new List<Riches>();
      private  List<Riches> FoldDeck = new List<Riches>();
        public List<Riches> FormationDeck()

        {

            OtherBonusCardsFormation();
            ItemFormation();
            BattleCardDamegeBonusFormation();
            LevelCardFormation();
            MixList(deck);
            return deck;
        }

        private void ItemFormation()
        {
            ChestArmorFormation();
            ItemHeadArmorFormation();
            WeaponFormation();
            ArmorBootsFormation();
            OtherItemFormation();

        }
        private void OtherBonusCardsFormation()
        {
            List<Riches> otherBonusCards = new List<Riches>() { new OtherBonusCards("Магическая лампа", 500, false, "OwnBattle"), new OtherBonusCards("Зелья Полуморфа", 1300, false, "AllBattle"),
                new OtherBonusCards("Зелье стрелочника",300,false, "AllBattle"),new OtherBonusCards("Зелье стрелочника",1100,false,"Turn"),new OtherBonusCards("Хотельное кольцо",500,false,"All"),
                new OtherBonusCards("Хотельное кольцо",500,false,"All"),new OtherBonusCards("Ура, клад",0,false, "Turn"),new OtherBonusCards("Допельгангер",300,false, "OwnBattle"),
            new OtherBonusCards("Тюбик клея",100,false, "Escape"),new OtherBonusCards("Зелье дружбы",200,false, "AllBattle"),new OtherBonusCards("Стенка-Встанька",300,false, "AllBattle"),
            new OtherBonusCards("Зелье невидимости",200,false, "Escape"),new OtherBonusCards("Читерский кубик",300,false,"Dice"),new OtherBonusCards("Яппиток",100,false, "Escape"),
            new OtherBonusCards("Q-кубик",1000,false, "Turn")};

            deck.AddRange(otherBonusCards);
        }
      
        private void BattleCardDamegeBonusFormation()
        {
            List<Riches> battleDamegeBonus = new List<Riches>() { new BattleCardDamegeBonus("Пелье зутаницы", 100, "AllBattle", false, 3), new BattleCardDamegeBonus("Радиоактивное электрокислотное зелье", 200, "AllBattle", false, 5),
            new BattleCardDamegeBonus("Зелье пламенной отравы",100, "AllBattle",false,3),new BattleCardDamegeBonus("Замораживающее взрывное зелье", 100, "AllBattle", false, 3),
            new BattleCardDamegeBonus("Магическая ракета",300, "AllBattle", false, 5), new BattleCardDamegeBonus("Питье противное спортивное",200, "AllBattle", false, 2),
            new BattleCardDamegeBonus("Зелье ротовой вони",100, "AllBattle", false, 2),new BattleCardDamegeBonus("Зелье идиотской храбрости",100, "AllBattle", false, 2),
            new BattleCardDamegeBonus("Клевые Шарики",0, "AllBattle", false, 5),new BattleCardDamegeBonus("Снотворное зелье",100, "AllBattle", false, 2)};


            deck.AddRange(battleDamegeBonus);

        }
        private void OtherItemFormation()
        {
            List<Riches> otherItem = new List<Riches>() { new OtherItem("КолготкиВеликанскойСилы", 600, "Other", 3, false, null, "!Воин", null, "Small") ,
            new OtherItem("РеальноКонкретныйТитул",0,"Other",3,false,null,null,null,"Small"),new OtherItem("МечПесниИПляски",600,"Other",2,false,null,"!Вор",null,"Small"),
            new OtherItem("Плащ замутнения",600,"Other",4,false,null,"Вор",null,"Small"),new OtherItem("Сэндвич запоздалого прозрения с сыром и селедкой",400,"Other",3,false,null,null,
                "Халфлинг","Small"),new OtherItem("НаколенникиРазвода",600,"Other",0,true,null,null,null,"Small"),new OtherItem("Острые коленки",200,"Other",1,false,null,null,null,"Small"),
            new OtherItem("Боевая стремянка",400,"Other",3,false,null,null, "Халфлинг","Big")};


            deck.AddRange(otherItem);

        }
        private void ChestArmorFormation()
        {
            List<Riches> chestArmor = new List<Riches>() { new ChestArmor("Доспехи Поперек-Себя шире", 400, "Бронник", 3, false, null, null, "Дварф", "Small") ,
            new ChestArmor("Склизистая оболочка",200,"Броник",1,false,null,null,null,"Small"),new ChestArmor("Паленые Доспехи",400,"Броник",2,false,null,null,null,"Small"),
            new ChestArmor("Кожанный прикид",200,"Броник",1,false,null,null,null,"Small"),new ChestArmor("Мифрильный доспех",600,"Броник",3,false,null,"!Волшебник",null,"Big"),
            new ChestArmor("Сорвиголовная Бандана",400,"Броник",3,false,null,null,"Человек","Small")};

            deck.AddRange(chestArmor);

        }
        private void ArmorBootsFormation()
        {
            List<Riches> armorBoots = new List<Riches>() { new ArmorBoots("Башмаки могучего пендаля", 400, "Boots", 2, false, null, null, null, "Small"),
            new ArmorBoots("Сандалеты-Протекторы",700,"Boots",0,true,null,null,null,"Small"),new ArmorBoots("Башмаки реально быстрого бега",400,"Boots",0,true,null,null,null,"Small")};


            deck.AddRange(armorBoots);
        }
        private void ItemHeadArmorFormation()
        {
            List<Riches> itemHeadArmor = new List<Riches>() { new HeadArmor("Шлем Бесстрашия", 200, "Smut", 1, false, null, null, null, "Small"), new HeadArmor("Шлем-Рогач", 600, "Smut", 1, true, null, null, null, "Small"),
            new HeadArmor("Остроконечная Шляпа Могущества",400, "Smut",3,false,null,"Волшебник", null, "Small")};

            deck.AddRange(itemHeadArmor);
            

        }

        private void WeaponFormation()
        {

            List<Riches> weaponFormation = new List<Riches>() { new Weapon("Посох Напалма", 800, "Weapon", 5, false, null, "Волшебник", null, "Small", false),
            new Weapon("Швейцарская Армейская Алебарда",600,"Weapon",4,false,null,null,"Человек","Big",true),new Weapon("Дуб Джентельмена",400, "Weapon",3,false,"Мужчина",null,null, "Small",false),
            new Weapon("Коленеотбойный Молоточек",600, "Weapon",4,false,null,null, "Дварф","Small",false),new Weapon("Огромная Каменюга",0, "Weapon",3,false,null,null,null,"Big",true),
            new Weapon("Булава Остроконечности", 600,"Weapon",4,false,null, "Клирик",null, "Small",false),new Weapon("Лук с ленточками",800, "Weapon",4,false,null,null, "Эльф", "Small",true),
            new Weapon("Меч широты взглядов",400, "Weapon",3,false,"Женьщина",null,null, "Small",false),new Weapon("Пафосный Баклер",400, "Weapon",2,false,null,null,null,"Small",false),
            new Weapon("Бензопила Кровавого Расчленения",600, "Weapon",3,false,null,null,null, "Big",true),new Weapon("Терка Умиротворения",400, "Weapon",3,false,null, "Клирик",null, "Small",false),
            new Weapon("Кинжал Измены",400, "Weapon",3,false,null, "Вор",null, "Small",false),new Weapon("Одиннадцатифутовый Кий",200, "Weapon",1,false,null,null,null, "Small",true),
            new Weapon("Рапира Такнечесности",600, "Weapon",3,false,null,null, "Эльф", "Small",false),new Weapon("Крыса на палочке",0, "Weapon",0,true,null,null,null, "Small",false),
            new Weapon("Меч Коварного Бастарада",400, "Weapon",2,false,null,null,null, "Small",false),new Weapon("Чарующая Дуда",300, "Weapon",0,true,null,null,null, "Big",false),
            new Weapon("Совсехсторонний Щит",600,"Weapon",4,false,null,"Воин",null,"Big",false)};


            deck.AddRange(weaponFormation);

        }
        private void LevelCardFormation()
        {

            List<Riches> levelCard = new List<Riches>() { new LevelCard("Получи уровень", 0, false), new LevelCard("Укради Уровень", 0, true), new LevelCard("1000 Голдов", 0, false),
               new LevelCard("Кипяток в Муравейнике",0,false) ,new LevelCard("Прикорми мастера",0,false ),new LevelCard("Выгодная ошибка при сложении",0,false),new LevelCard("Используй неопнятное правило",0,false),
               new LevelCard("Рассчитайся с наемничком",0,true),new LevelCard("Поглумись над телами врагов",0,true),new LevelCard("Зелье крутизны",0,false),new LevelCard("Разжалоби мастера",0,true) };


            deck.AddRange(levelCard);
        }

    }

    class DoorDeck : Deck
    {
        List<Door> deck = new List<Door>();
        List<Door> FoldDeck = new List<Door>();
        internal  List<Door> FormationDeck()
        {
            
            MonsterFormation();
            ManchkinClassCardFormation();
            RaceCardFormation();
            BonusMonsterFormation();
            CurseFormation();
            OtherDoorCardsFormation();
            MixList(deck);
            return deck;
        }

       private void MonsterFormation()
        {
            List<Monsters> monstersFormation = new List<Monsters>()
            {
                new Monsters("Молотая крысотка", 1, 1, 1,false,0),
                new Monsters("Г-н Кости",2,1,1,true,0), new Monsters("Форумный троль",10,3,1,false,0),new Monsters("Питбуль",2,1,1,false,10),new Monsters("Утикора",6,2,1,false,0),
                new Monsters("Плутониевый Дракон",20,5,2,false,5),new Monsters("Трава в горшке",1,1,1,false,10),new Monsters("Рыгачу",6,2,1,false,0),new Monsters("Вопящий задрот",6,2,1,false,0),
                new Monsters("Ускоренные улитки",4,2,1,false,0),new Monsters("Желатиновый Октаэдр",2,1,1,false,0),new Monsters("Мадемонуазели",8,2,1,false,0),new Monsters("Гарпистки",4,2,1,false,0),
                new Monsters("Гиппогриф",16,4,2,false,3),new Monsters("Страховой Агент",14,4,1,false,0),new Monsters("Король Тут",16,4,2,true,3),new Monsters("Увеченный гоблин",1,1,1,false,0),
                new Monsters("Здоровая бешенная цыпа",2,1,1,false,0),new Monsters("Адвокат",6,2,1,false,0),new Monsters("Лепрокон",4,2,1,false,0), new Monsters("3872 орка", 10, 3, 1, false, 0),
                new Monsters("Амазонка", 8, 2, 1, false, 0),new Monsters("Бигфут", 12, 3, 1, false, 0),new Monsters("Бульрог", 18, 5, 2, false, 4),new Monsters("Типа Вошки", 1, 1, 1, false, 0),
                new Monsters("Сочащаяся слизь", 1, 1, 1, false, 0),new Monsters("Лицесос", 8, 3, 1, false, 0),new Monsters("Сопливый Нос", 10, 3, 1, false, 0),new Monsters("Летучие лягушки", 2, 1, 1, false, 0),
                new Monsters("Газебо", 8, 2, 1, false, 0),new Monsters("Кальмадзилла", 18, 4, 2, false, 4),new Monsters("Обдолбанный Голем", 14, 4, 1, false, 10),new Monsters("Языческий демон", 12, 3, 1, false, 4)

            , new Monsters("Андедный Коник", 4, 2, 1, true, 0)
        
          , new Monsters("Невыразимо Жуткий Неописуемы Ужас", 14, 4, 1, false, 0)

           ,new Monsters("Закос под Вампира", 12, 3, 1, false, 0)

            , new Monsters("Бледные Братья", 16, 4, 2, true, 3)
        };
            deck.AddRange(monstersFormation);

                   
            
            

        }
       
       private void ManchkinClassCardFormation()
        {
            List<Door> manchkinClassCard = new List<Door>() { new ManchkinClassCard("Клирик"), new ManchkinClassCard("Клирик"), new ManchkinClassCard("Клирик")
                ,new ManchkinClassCard("Вор"),new ManchkinClassCard("Вор"),new ManchkinClassCard("Вор"),new ManchkinClassCard("Волшебник"),new ManchkinClassCard("Волшебник")
                ,new ManchkinClassCard("Волшебник"),new ManchkinClassCard("Воин"),new ManchkinClassCard("Воин"),new ManchkinClassCard("Воин") };


            deck.AddRange(manchkinClassCard);
        }

       private void RaceCardFormation()
        {
            List<Door> raceCard = new List<Door>() { new RaceCard("Дварф"), new RaceCard("Дварф"), new RaceCard("Дварф"), new RaceCard("Эльф"), new RaceCard("Эльф"),
                new RaceCard("Эльф"),new RaceCard("Халфлинг"),new RaceCard("Халфлинг"),new RaceCard("Халфлинг") };


            deck.AddRange(raceCard);

        }

       private void BonusMonsterFormation()
        {
            List<Door> BonusMonster = new List<Door>() { new BonusMonster("Древний", 10, 2), new BonusMonster("Детеныш", -5, -1), new BonusMonster("Психованный", 5, 1),
                new BonusMonster("Амбал",10,2),new BonusMonster("Мозговитый",5,1) };


            deck.AddRange(BonusMonster);
        }

       private void CurseFormation()
        {
            List<Door> curse = new List<Door>() { new Curse("СменаКласса"), new Curse("СменаРассы"), new Curse("СменаПола"), new Curse("КурицаНаБашне"),
                new Curse("УткаОбреченности"),new Curse("Налоги"),new Curse("БольшаяПотеря"), new Curse("ПотеряйУровень"),new Curse("ПотеряйУровень"),
                new Curse("НевиликаПотеря"),new Curse("НевиликаПотеря"),new Curse("ПотеряйНадетыйБроник"),new Curse("ТеряешьНадетыйГоловняк"),new Curse("ТеряешьНадетуюОбувку"),
           new Curse("Теряешь2Карты") ,new Curse("ТеряешьКласс"),new Curse("ТеряешьРасу"),new Curse("КривящееЗеркало"),new Curse("ВКонецМерзкоеПроклятие")};


            deck.AddRange(curse); 


           
        }

       private void OtherDoorCardsFormation()
        {
            List<Door> OtherDoor = new List<Door>() { new OtherDoorCards("Полукровка"), new OtherDoorCards("Помоги Себе Сам"), new OtherDoorCards("Иллюзия"), new OtherDoorCards("Гадкая парочка"),
            new OtherDoorCards("Обеденный Перерыв"),new OtherDoorCards("Супер Манчкин"),new OtherDoorCards("Супер Манчкин"),new OtherDoorCards("Бродячая Тварь"),new OtherDoorCards("Бродячая Тварь")
            ,new OtherDoorCards("Бродячая Тварь")};


            deck.AddRange(OtherDoor);

        

        }

        

    }

    



}
