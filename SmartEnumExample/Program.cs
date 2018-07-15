using System;

namespace SmartEnumExample
{
    class Program
    {
        public sealed class EnemyType
        {
            public static readonly EnemyType Soldier = new EnemyType(100, "This is soldier.");
            public static readonly EnemyType ToughSoldier = new EnemyType(200, "This is tough soldier.");
            public static readonly EnemyType Captain = new EnemyType(300, "This is captain.");
            public static readonly EnemyType Boss = new EnemyType(500, "This is boss.");

            public string Description { get; }
            public int MaxHp { get; }

            private EnemyType(int maxHp, string description)
            {
                MaxHp = maxHp;
                Description = description;
            }
        }

        public class Enemy
        {
            public EnemyType Type { get; }

            public int MaxHp { get; }

            public Enemy(EnemyType type)
            {
                MaxHp = type.MaxHp;
                Type = type;
            }

            public string GetDescription()
            {
                return Type.Description;
            }
        }

        static void Main(string[] args)
        {
            Enemy newEnemy = new Enemy(EnemyType.Soldier);

            if (newEnemy.Type == EnemyType.Soldier)
            {
                Console.WriteLine("This is simple solder - no threat.");
            }


            Console.WriteLine(newEnemy.GetDescription());



            switch (newEnemy.Type)
            {
                case var enemyType when enemyType == EnemyType.Captain:
                    Console.WriteLine("This is captain - it will be hard.");
                    break;
                case var enemyType when enemyType == EnemyType.Boss:
                    Console.WriteLine("This is boss - run ASAP!");
                    break;
            }
        }
    }
}
