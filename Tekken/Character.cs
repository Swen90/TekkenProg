using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekken
{
    public class Character
    {
        /// <summary>
        /// Имя персонажа 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Сильные стороны персонажа
        /// </summary>
        public List<string> StrongPoints { get; set; }
        /// <summary>
        /// Слабые стороны персонажа
        /// </summary>
        public List<string> WeakPoints { get; set; }
        /// <summary>
        /// Архетип
        /// </summary>
        public ArchetypeEnum Archetype { get; set; }
        /// <summary>
        /// Содержит краткое описание о стратегии на игру за определенного персонажа
        /// </summary>
        public string GamePlan { get; set; }
        /// <summary>
        /// Персонажи с которымми есть больший шанс на победу
        /// </summary>
        public List<Character> GoodMU { get; set; }
        /// <summary>
        /// Персонажи с которыми есть меньший шанс на победу
        /// </summary>
        public List<Character> BadMU { get; set; }
    }
    

}
