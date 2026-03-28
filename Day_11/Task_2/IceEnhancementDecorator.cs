using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class IceEnhancementDecorator : WeaponDecorator
    {
        public IceEnhancementDecorator(IWeapon weapon) : base(weapon) { }

        public override string GetDescription() => $"{DecoratedWeapon.GetDescription()} и игнорированием 20% Ice RES PEN";

        public override int GetDamage() => DecoratedWeapon.GetDamage() + 200;
    }
}

