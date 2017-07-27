namespace FactoryMethod
{
    public class MonsterFactory : IMonsterFactory
    {
        private IRandom random;

        public MonsterFactory(IRandom random=null)
        {
            this.random = random ?? new RandomGenerator();
        }

        public IMonster CreateMonster()
        {
            var index = random.GetNext(1, 100);

            if (index % 2 == 0)
            {
                return new Troll() { Name = "Troll", Health = random.GetNext(10, 25) };
            }
            if (index % 11 == 0)
            {
                return new Dragon() { Name = "Dragon", Health = random.GetNext(30, 50) };
            };
            return new Orc() { Name = "Orc", Health = random.GetNext(5, 15) };
        }
    }
}
