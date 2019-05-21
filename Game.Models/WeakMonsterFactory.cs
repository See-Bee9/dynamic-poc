using System;

namespace Game.Models
{
    public class WeakMonsterFactory : IMonsterFactory
    {
        private readonly Random random = new Random();

        public Actor GetNewMonster()
        {
            return new Actor()
            {
                Attack = random.Next(0, 2),
                Defense = random.Next(0, 2),
                Hitpoints = random.Next(0, 4)
            };
        }
    }
}