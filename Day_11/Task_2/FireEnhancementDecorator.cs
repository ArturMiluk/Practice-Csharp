using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class FireEnhancementDecorator : WeaponDecorator
    {
        public FireEnhancementDecorator(IWeapon weapon) : base(weapon) { }

        public override string GetDescription() => $"{DecoratedWeapon.GetDescription()} с игнорированием 20% Fire RES PEN";

        public override int GetDamage() => DecoratedWeapon.GetDamage() + 200;
    }
}

