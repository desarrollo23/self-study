using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Book.Intro.Game
{
    public abstract class Character
    {
        public IWeaponBehavior weaponBehavior;

        public Character()
        {
        }

        public void SetWeapon(IWeaponBehavior weaponBehavior)
        {
            this.weaponBehavior = weaponBehavior;
        }

        public abstract void Fight();
    }
}
