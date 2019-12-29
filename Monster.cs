using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionOverInheritance
{
    public class Monster
    {
        public enum AttackType                                           // attack types the monsters can perform
        {
            Biting,
            Kicking,
            Punching,
            Spitting
        }

        public int HitPoints { get; set; }                              // the monster has hitpoints
        public Dictionary<AttackType, int> AttackTypes { get; set; }    // this is a list of attack types the monster can perform

        public bool CanBite => AttackTypes.ContainsKey(AttackType.Biting);   // true or false based on if the monster is annointed with any of these 
        public bool CanKick => AttackTypes.ContainsKey(AttackType.Kicking);  // attack types
        public bool CanPunch => AttackTypes.ContainsKey(AttackType.Punching);
        public bool CanSpit => AttackTypes.ContainsKey(AttackType.Spitting); // boss wanted me to add spitting monsters

        public int BiteDamage
        {
            get
            {
                if(CanBite)                                                  // if canbite is true (it is able to bite)
                {                                                            // show whoever called the BiteDamage method that it can bite.
                    return AttackTypes[AttackType.Biting];                   // this returns how much damage (int) can be done as set in AddAttackType 
                                                                             // method below
                }

                throw new NotSupportedException("This monster cannot bite.");// otherwise, throw an exception saying it cannot bite.
            }
        }

        public int KickDamage
        {
            get
            {
                if (CanKick)                                                 // if cankick is true (it is able to kick)
                {                                                            // show whoever called the kickDamage method that it can kick.
                    return AttackTypes[AttackType.Kicking];
                }

                throw new NotSupportedException("This monster cannot kick.");// otherwise, throw an exception saying it cannot kick.
            }
        }

        public int PunchDamage
        {
            get
            {
                if (CanPunch)                                                // if canpunch is true (it is able to punch)
                {                                                            // show whoever called the punchDamage method that it can punch.
                    return AttackTypes[AttackType.Punching];
                }

                throw new NotSupportedException("This monster cannot punch.");// otherwise, throw an exception saying it cannot punch.
            }
        }

        public int SpitDamage
        {
            get
            {
                if (CanPunch)
                {
                    return AttackTypes[AttackType.Spitting];
                }

                throw new NotSupportedException("This monster cannot spit.");
            }
        }

        ///
        /// monster constructor
        ///

        public Monster(int hitPoints)
        {
            HitPoints = hitPoints;                           // anoints the new monster with hitpoints
            AttackTypes = new Dictionary<AttackType, int>(); // anoints the new monster with attack types? I'm not sure what this is doing
                                                             // no, it just makes a new, blank dictionary to hold the attack types that will
                                                             // be added later by the factory....
        }

        public void AddAttackType(AttackType attackType, int amountOfDamage) // here is where you add the attack type for the monster 
        {
            AttackTypes[attackType] = amountOfDamage;        // not sure what this is doing ... it is giving damage amounts to the named attack
                                                             // type sent along in the method. like if they sent 'Kicking' and 5 to this method...
                                                             // AttackTypes[Kicking] = 5
                                                             // this is where we add attack types to the monster instead of using inheritance
                                                             
        }

    }
}
