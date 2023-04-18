using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekken
{
    public class Program
    {
        public static void StartLogic()
        {
            var characterPaul = new Character();
            var characterKaz = new Character();
            var characterJin = new Character();
            var characterBryan = new Character();
            var characterAK = new Character();
            var characterKing = new Character();
            var characterDrag = new Character();
            var characterHwo = new Character();
            var characterSteve = new Character();
            var characterKazumi = new Character();
            ///
            ///Блок Paul
            ///
            characterPaul.Name = "Paul";
            characterPaul.Archetypes = new List<ArchetypeEnum>
            {
                 ArchetypeEnum.CounterHit,
                 ArchetypeEnum.Poking
            };
            characterPaul.GamePlan = "Пытаться поймать оппонента в контр хит, параллельно чипуя через df1 стринг и различные лоу, также использовать полный миксап захватов";
            characterPaul.StrongPoints = new List<string>
            {
                "Сильная контр хит игра",
                "Камбек потенциал во время рейджа",
                "Полноценная игра захватов",
                "Хороший персонаж для начала изучения основ игры"
            };
            characterPaul.WeakPoints = new List<string>
            {
                "Средний мувмент по сравнению с другми персонажами",
                "Прост в освоении, сложен в реализации на высоком уровне игры"
            };
            characterPaul.GoodMU = new List<Character>
            {
               characterKing
            };
            characterPaul.BadMU = new List<Character>
            {
                characterJin,
                characterSteve,
                characterDrag
            };
            ///
            /// Блок Kazuya
            /// 
            characterKaz.Name = "Kazuya";
            characterKaz.Archetypes = new List<ArchetypeEnum>
            {
                ArchetypeEnum.Fiftyfifty
            };
            characterKaz.GamePlan = "Большая часть плана на игру состоит из чистого миксапа между дамажным лоу (хелл свип) и сейф мид лаунчером (ff3), сложен в реализации и требует экзекюшена для проведения комбинаций и электриков (EWGF)";
            characterKaz.StrongPoints = new List<string>
            {
                "Большой комбо урон",
                "Отличное ОКИ после кнокдауна",
                "Мувмент выше среднего"
            };
            characterKaz.WeakPoints = new List<string>
            {
                "Нехватка стандартных быстрых пок",
                "Нет практически никаких паник мувов, чтобы выйти из прессинга",
                "Очень зависим от электрика, сложное исполнение (экзекюшен)",
                "На высоком уровне игры легко степается влево, что усложняет реализацию 50/50"
            };
            characterKaz.GoodMU = new List<Character>
            {
                characterDrag,
                characterPaul
            };
            characterKaz.BadMU = new List<Character>
            {
                characterSteve,
                characterKazumi
            };
            ///
            ///Блок Jin
            ///
            characterJin.Name = "Jin";
            characterJin.Archetypes = new List<ArchetypeEnum>
            {
                ArchetypeEnum.Poking
            };
            characterJin.GamePlan = "Игра от защиты, понемногу чипуя оппонента через лоу, и ловить правильный тайминг для проведения контрхита, а также использования электрика как панишмента и кипаута";
            characterJin.StrongPoints = new List<string>
            {
                "Хороший контроль дистанции",
                "Имеет практически все типы ударов в игре",
                "Лучшее пэрри в игре"
            };
            characterJin.WeakPoints = new List<string>
            {
                "Очень уязвим к степу вправо в присед",
                "Средний рейндж на базовых поках"
            };
            characterJin.GoodMU = new List<Character>
            {
                characterPaul       ///"Gigas","Eddy","Geese"
            };
            characterJin.BadMU = new List<Character>
            {
                characterKazumi     ///"Feng","Akuma"
            };
            ///
            ///Блок Bryan
            ///
            characterBryan.Name = "Bryan";
            characterBryan.Archetypes = new List<ArchetypeEnum>
            {
                ArchetypeEnum.CounterHit
            };
            characterBryan.GamePlan = "Игра построена на таймингах, в какой момент оппонент проведет свой удар, чтобы успеть опередить его собственным контрхит мувом.";
            characterBryan.StrongPoints = new List<string>
            {
                "Одни из лучших контрхит ударов в игре",
                "Дальние лоу с хорошим трекингом",
                "Очень сильный кипаут",
                "Большой комбо урон"
            };
            characterBryan.WeakPoints = new List<string>
            {
                "Есть стандартные быстрые удары для покинга, но после которых игрок теряет свой ход",
                "Требует исполнения (экзекюшена) от игрока для получения максимального потенциала персонажа"
            };
            characterBryan.GoodMU = new List<Character>
            {
                characterDrag
            };
            characterBryan.BadMU = new List<Character>
            {
                characterSteve
            };
            ///
            ///Блок Armor King
            ///
            characterAK.Name = "Armor King";
            characterAK.Archetypes = new List<ArchetypeEnum> 
            {
                ArchetypeEnum.Grappler 
            };
            characterAK.GamePlan = "Армор кинг очень разностороний в плане геймплея, имеет одни из самых лучших захватов и игре, хороший вифпанишмент, а так же ренджовые мид, лоу поки";
            characterAK.StrongPoints = new List<string>
            {
                "Одни из лучших захватов в игре",
                "Хорошие мид и лоу поки",
                "Эффективный вифпанишмент",
                "Есть быстрые контрхит лаунчеры"
            };
            characterAK.WeakPoints = new List<string>
            {
                "Сложное исполнение (экзекюшен)",
                "Есть некоторые проблемы с трекингом ударов",
            };
            characterAK.GoodMU = new List<Character>
            {
                characterBryan
            };
            characterAK.BadMU = new List<Character>
            {
                characterJin,
                characterKazumi
            };
            ///
            ///Блок King
            ///
            characterKing.Name = "King";
            characterKing.Archetypes = new List<ArchetypeEnum>
            {
                ArchetypeEnum.Grappler
            };
            characterKing.GamePlan = "Играть через различные мид чеки чтобы при подходе к оппоненту тот не садился, что в свою очередь дает возможность начать миксап захватов";
            characterKing.StrongPoints = new List<string>
            {
                "Одни из лучших захватов в игре",
                "Лучшее ОКИ после успешного проведения захватов",
                "Есть быстрые контрхит лаунчеры"
            };
            characterKing.WeakPoints = new List<string>
            {
                "Средний мувмент",
                "Страдает от сильного прессинга оппонента"
            };
            characterKing.GoodMU = new List<Character>
            {
                characterHwo
            };
            characterKing.BadMU = new List<Character>
            {
                characterKazumi,
                characterPaul
            };
            ///
            ///Блок Dragunov
            ///
            characterDrag.Name = "Dragunov";
            characterDrag.Archetypes = new List<ArchetypeEnum>
            {
                ArchetypeEnum.Rushdown
            };
            characterDrag.GamePlan = "Основная задача наносить урон через лоу д2, быстрые поки и ловить на ошибках оппонента используя мувмент и вифпанишмент";
            characterDrag.StrongPoints = new List<string>
            {
                "Выше среднего мувмент", 
                "Хороший виф панишмент", 
                "Полноценная игра грабов", 
                "Сильная покинг игра"
            };
            characterDrag.WeakPoints = new List<string>
            {
                "Нет контрхит игры кроме 1 относительно медленного удара", 
                "Плохие хитбоксы и трекинг на мид ударах"
            };
            characterDrag.GoodMU = new List<Character>
            {
                characterPaul,
                characterKazumi
            };
            characterDrag.BadMU = new List<Character>
            {
                characterBryan,
                characterSteve
            };
            ///
            ///Блок Hwoarang
            ///
            characterHwo.Name = "Hwoarang";
            characterHwo.Archetypes = new List<ArchetypeEnum>
            {
                ArchetypeEnum.Rushdown
            };
            characterHwo.GamePlan = "Прессинг можно начинать как с лоу так и с мид ударов, при этом используя сильные стойки против которых оппонент не имеет возможности ударить в ответ, лишь только уйти в защиту или знать слабости каждой стойки и в какой момент их реализовывать. Если вам нравится супер агрессивная и игра в быстром темпе, то этот персонаж вам подойдет.";
            characterHwo.StrongPoints = new List<string>
            {
                "Локдаун оппонента сериями из различных ударов с помощью стоек",
                "Хорошие 50/50",
                "Эффективный вифпанишмент"
            };
            characterHwo.WeakPoints = new List<string>
            {
                "Требует исполнения (экзекюшена) для масимальной эффективности",
                "На высоком уровне игры против сильных игроков, знающих все слабости стоек, очень сложен в реализации"
            };
            characterHwo.GoodMU = new List<Character>
            {
                characterKaz
            };
            characterHwo.BadMU = new List<Character>
            {
                characterKing
            };
            ///
            ///Блок Steve Fox
            ///
            characterSteve.Name = "Steve";
            characterSteve.Archetypes = new List<ArchetypeEnum>
            {
                ArchetypeEnum.CounterHit
            };
            characterSteve.GamePlan = "Лучшее что умеет персонаж - ловить оппонента на контрхите, играть в тайминги, чиповать оппонента, при это оставаясь относительно сейф";
            characterSteve.StrongPoints = new List<string>
            {
                "Быстрые и дальние контрхит лаунчеры",
                "Хорошие мид, лоу поки",
                "Имеет встроенный эвейд (уклонение) на своих ударах"
            };
            characterSteve.WeakPoints = new List<string>
            {
                "Сложно камбекать, если у оппонента ХП лид",
                "Очень неортодоксальное управление персонажем",
                "Требует больших знаний и исполнения (экзекюшена)",
                "Нет быстрого блок панишмента на лаунчер как у многих других персонажей"
            };
            characterSteve.GoodMU = new List<Character>
            {
                characterDrag,
                characterBryan
            };
            characterSteve.BadMU = new List<Character>
            {
                characterKazumi
            };
            ///
            ///Блок Kazumi
            ///
            characterKazumi.Name = "Kazumi";
            characterKazumi.Archetypes = new List<ArchetypeEnum>
            {
                ArchetypeEnum.Poking
            };
            characterKazumi.GamePlan = "Смерть от 1000 порезов, таким выражением можно описать геймплей Kazumi, используя быстрые лоу и мид поки на близкой дистанции, постепенно уменьшая полоску ХП оппонента";
            characterKazumi.StrongPoints = new List<string>
            {
                "Очень сильная покинг игра",
                "Выше среднего мувмент",
            };
            characterKazumi.WeakPoints = new List<string>
            {
                "Относительно малый комбо урон",
                "Требует сильного фундаментала игры",
                "Плохой рейндж на лаунчерах для блокпаниша"
            };
            characterKazumi.GoodMU = new List<Character>
            {
                characterKaz,
                characterSteve,
                characterKing,
                characterAK,
                characterJin
            };
            characterKazumi.BadMU = new List<Character>
            {
                characterDrag
            };

        }
        
        
        static void Main(string[] args) 
        {
            StartLogic();
        }

    }
   
}