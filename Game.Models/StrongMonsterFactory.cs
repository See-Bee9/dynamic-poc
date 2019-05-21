using System;

namespace Game.Models
{
    public class StrongMonsterFactory : IMonsterFactory
    {
        private readonly Random random = new Random();
        public Actor GetNewMonster()
        {
            return new Actor()
            {
                Attack = random.Next(5, 9),
                Defense = random.Next(5, 9),
                Hitpoints = random.Next(9, 14)
            };
        }
    }
}