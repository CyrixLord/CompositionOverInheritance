using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionOverInheritance
{
    class MonsterFactory
    {
        public enum MonsterType
        {
            Horse, // BitingKickingMonster
            Orc,   // BitingKickingPunchingMonster
            Crocodile, // BitingMonster
            MikeTyson, // BitingPunchingMonster
            Camel, // KickingMonster
            Kangaroo, // KickingPunchingMonster
            MantisShrimp, // PunchingMonster
            Cobra         // boss wanted to add a spitting monster
        }

        public static Monster CreateMonster(MonsterType monsterType)  // creates ONE monster of requested type.
        // you dont have to use 'new' to create an instance and use this method.. it's STATIC. like Math.Sqrt(144) you
        // didnt have to use 'new' to use the Math class
        {
            Monster monster;

            switch(monsterType)
            {
                case MonsterType.Horse:
                    monster = new Monster(10);
                    monster.AddAttackType(Monster.AttackType.Biting, 5);
                    monster.AddAttackType(Monster.AttackType.Kicking, 5);
                    break;
                case MonsterType.Orc:
                    monster = new Monster(10);
                    monster.AddAttackType(Monster.AttackType.Biting, 5);
                    monster.AddAttackType(Monster.AttackType.Kicking, 5);
                    monster.AddAttackType(Monster.AttackType.Punching, 5);
                    break;
                case MonsterType.Crocodile:
                    monster = new Monster(10);
                    monster.AddAttackType(Monster.AttackType.Biting, 5);
                    break;
                case MonsterType.MikeTyson:
                    monster = new Monster(10);
                    monster.AddAttackType(Monster.AttackType.Biting, 5);
                    monster.AddAttackType(Monster.AttackType.Punching, 5);
                    break;
                case MonsterType.Camel:
                    monster = new Monster(10);
                    monster.AddAttackType(Monster.AttackType.Kicking, 5);
                    monster.AddAttackType(Monster.AttackType.Spitting, 5); // boss wanted me to add a spitting attack type
                    break;
                case MonsterType.Kangaroo:
                    monster = new Monster(10);
                    monster.AddAttackType(Monster.AttackType.Kicking, 5);
                    monster.AddAttackType(Monster.AttackType.Punching, 5);
                    break;
                case MonsterType.MantisShrimp:
                    monster = new Monster(10);
                    monster.AddAttackType(Monster.AttackType.Punching, 5);
                    break;
                case MonsterType.Cobra:
                    monster = new Monster(10);
                    monster.AddAttackType(Monster.AttackType.Spitting, 5);
                    break;
                default:
                    throw new ArgumentException();
            }

            return monster; // return monster to caller
        }
    }
}
