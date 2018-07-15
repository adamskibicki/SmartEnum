using System;

namespace SmartEnumExample
{
    class Program
    {
        public enum EnemyType
        {
            Soldier,
            ToughSoldier,
            Captain,
            Boss
        }

        public class Enemy
        {
            public EnemyType Type { get; }

            public int MaxHp { get; }

            public Enemy(EnemyType type)
            {
                Type = type;

                switch (type)
                {
                    case EnemyType.Soldier:
                        MaxHp = 100;
                        break;
                    case EnemyType.ToughSoldier:
                        MaxHp = 200;
                        break;
                    case EnemyType.Captain:
                        MaxHp = 300;
                        break;
                    case EnemyType.Boss:
                        MaxHp = 300;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(type), type, null);
                }
            }

            public string GetDescription()
            {
                switch (Type)
                {
                    case EnemyType.Soldier:
                        return "This is soldier.";
                    case EnemyType.ToughSoldier:
                        return "This is tough soldier.";
                    case EnemyType.Captain:
                        return "This is captain.";
                    case EnemyType.Boss:
                        return "This is boss.";
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        static void Main(string[] args)
        {
            Enemy newEnemy = new Enemy(EnemyType.Soldier);

            Console.WriteLine(newEnemy.GetDescription());
        }
    }
}
