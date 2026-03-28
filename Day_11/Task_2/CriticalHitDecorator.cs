using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class CriticalHitDecorator : WeaponDecorator
    {
        public CriticalHitDecorator(IWeapon weapon) : base(weapon) { }

        public override string GetDescription() => $"{DecoratedWeapon.GetDescription()} (Нативный стат: +264 МС)";

        public override int GetDamage() => DecoratedWeapon.GetDamage() * 264;
    }
}

