using System;

namespace Game.Models
{
    public class MediumMonsterFactory : IMonsterFactory
    {
        private readonly Random random = new Random();
        public Actor GetNewMonster()
        {
            return new Actor()
            {
                Attack = random.Next(2, 4),
                Defense = random.Next(2, 4),
                Hitpoints = random.Next(2, 7)
            };
        }
    }
}