using InterfaceExample.actors;
using InterfaceExample.architecture;

namespace InterfaceExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            // abstract enemy
            //      this is all enemies
            //      attack action
            //      movement
            //      loot
            //      take damage
            // knight
            //      basic melee attack
            //      heavy armor
            // wizard
            //      no armor
            //      devastating magic
            //      attack at range
            // dragon
            //      melee attack
            //      heavy armor
            //      fire breath
            //      can fly
            //      can do multiple attacks
            // goblin
            //      flee
            //      steals from player
            //      basic melee attack
            //      light armor

            Map myMap = new Map(10, 10);
            myMap.PrintMap();

            Wizard tim = new Wizard("Tim, The Enchanter", 3, 3, 15);

            List<AbstractEnemy> enemies = new List<AbstractEnemy>()
            {
                new Goblin("Skrit, the goblin", 2, 2, 10),
                tim
            };


            // all enemies at this step
            foreach(AbstractEnemy enemy in enemies)
            {
                enemy.Move(0, 0);
            }

            // all enemies attempt to flee (if they can)
            foreach (AbstractEnemy enemy in enemies)
            {
                if (enemy is IFleeable typedEnemy)
                {
                    typedEnemy.Flee();
                }
            }
        }
    }
}
