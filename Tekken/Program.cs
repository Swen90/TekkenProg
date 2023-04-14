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
            var characterJin = new Character()
            {
                Name = "Jin",
                StrongPoints = new List<string>
                {
                    "Хороший контроль дистанции",
                    "Имеет практически все типы ударов в игре",
                    "Лучшее пери в игре"
                },
                WeakPoints = new List<string>
                {
                    "Очень уязвим к ssr в присед",
                    "Средний рейндж на базовых поках"
                },
                Archetype = ArchetypeEnum.Poking,
                GamePlan = "Игра от защиты, понемногу чипуя оппонента через лоу, и ловить правильный тайминг для проведения контрхита, а также использования электрика как панишмента и кипаута",
                GoodMU = new List<Character>
                {
                    //"Gigas", 
                    ///"Eddy", 
                    //"Geese"
                },
                BadMU = new List<Character>
                {
                    ///"Feng",
                    ///"Akuma"
                }


            };  
            

            var characterDrag = new Character();
            //characterDrag.Name = "Dragunov";
            //characterDrag.StrongPoints = new List<string> {"Выше среднего мувмент", "Хороший виф панишмент", "Полноценная игра грабов", "Сильная покинг игра");
            //characterDrag.WeakPoints = new List<string>("Нет контрхит игры кроме 1 относительно медленного удара", "Плохие хитбоксы и трекинг на мид ударах");
            //characterDrag.Archetype = ArchetypeEnum.Rushdown;
            //characterDrag.GamePlan = "Основная задача наносить урон через лоу д2 и ловить на ошибках оппонента используя мувмент и покинг";
            //characterDrag.GoodMU = new List<Character>("Paul", "Jack-7");
            //characterDrag.BadMU = new List<Character>("Kunimitsu", "Zafina", "Xiaoyu", "Anna", "Feng");

            var characterJulia = new Character();
            //characterJulia.Name = "Julia";
            //characterJulia.StrongPoints = new List<string>("???");
            //characterJulia.WeakPoints = new List<string>("???");
            //characterJulia.Archetype = ArchetypeEnum.Poking;
            //characterJulia.GamePlan = "Покинг игра через фф1 и быстрые лоу, когда оппонент начинает уважать миды и перестает садиться, можно пробовать начать свой миксап с позиции приседа";
            //characterJulia.GoodMU = new List<string>("Dragunov", "Bryan", "Kazuya", "Fakhumram");
            //characterJulia.BadMU = new List<string>("Noctis");
        }

        static void Main(string[] args) 
        {
            StartLogic();
        }

    }
   
}