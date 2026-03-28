using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public abstract class WeaponDecorator : IWeapon
    {
        protected readonly IWeapon DecoratedWeapon;

        protected WeaponDecorator(IWeapon weapon)
        {
            DecoratedWeapon = weapon;
        }

        public virtual string GetDescription() => DecoratedWeapon.GetDescription();

        public virtual int GetDamage() => DecoratedWeapon.GetDamage();
    }
}

