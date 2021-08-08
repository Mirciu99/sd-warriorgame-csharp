using Game.Enum;

namespace Game.Equipment
{
    class Armor
    {
        private int armourPoints;

        public const int GOOD_GUY_ARMOR = 5;
        public const int BAD_GUY_ARMOR = 5;

        public int ArmourPoints {
            get
            {
                return armourPoints;
            }
        }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armourPoints = GOOD_GUY_ARMOR;
                    break;
                case Faction.BadGuy:
                    armourPoints = BAD_GUY_ARMOR;
                    break;
                default:
                    break;
            }
        }
    }
}