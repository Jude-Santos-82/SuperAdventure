using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class HealingPotion : Item
    {
        public int AmountToHeal { get; set; }

        public HealingPotion(int id, string name, string plural, int amountToHeal) : base(id, name, plural)
        {
            AmountToHeal = amountToHeal;
        }
    }
}
