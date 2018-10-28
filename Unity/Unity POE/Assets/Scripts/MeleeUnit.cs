﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace RTSGame
{
    class MeleeUnit : Unit
    {
        #region Variables
        protected const int DAMAGE = 10;
        #endregion

        #region Constructors

        public MeleeUnit()
        {

        }

        public MeleeUnit(int x, int y, int health, int speed, bool attack, int attackRange, string faction, string symbol, string name)
            : base(x, y,health,speed,attack,attackRange,faction,symbol, name)
        {
        }

        #endregion

        #region Destructor

        ~MeleeUnit()
        {
        }

        #endregion

        #region Methods

        public override void move(int x, int y)
        {
            if( x >= 0 && x < 20)
            {
                this.x = x;
            }
            if(y >= 0 && y < 20)
            {
                this.y = y;
            }
        }

        public override void combat(Unit enemy)
        {
            if (this.inRange(enemy))
            {
                enemy.Health -= DAMAGE;
            }
        }

        public override bool inRange(Unit enemy)
        {
            if (!this.Faction.Equals(enemy.Faction))
            {
                if ((Math.Abs(this.X - enemy.X) <= this.AttackRange) && (Math.Abs(this.Y - enemy.Y) <= this.AttackRange))
                    return true;
            }
            return false;
        }

        //Gets the list of Units and checks which unit is closest to the current unit.
        public override Unit nearestUnit(List<Unit> list)
        {
            Unit closest = null;
            int attackRangeX, attackRangeY;
            double range;
            double shortestRange = 1000;

            foreach(Unit u in list)
            {
                if (!this.Faction.Equals(u.Faction))
                {
                    attackRangeX = Math.Abs(this.X - u.X);
                    attackRangeY = Math.Abs(this.Y - u.Y);

                    range = Math.Sqrt(Math.Pow(attackRangeX, 2) + Math.Pow(attackRangeY, 2));

                    if (range < shortestRange)
                    {
                        shortestRange = range;
                        closest = u;
                    }

                    if (attackRangeY < shortestRange)
                    {
                        shortestRange = range;
                        closest = u;
                    }
                }
            }
            return closest;
        }

        public override bool attackRangeFactory(FactoryBuilding enemy)
        {
            if (Math.Abs(this.x - enemy.X) <= this.attackRange || (Math.Abs(this.y - enemy.Y) <= this.attackRange))
            {
                return true;
            }
            return false;
        }

        public override bool attackRangeResource(ResourceBuilding enemy)
        {
            if (Math.Abs(this.x - enemy.X) <= this.attackRange || (Math.Abs(this.y - enemy.Y) <= this.attackRange))
            {
                return true;
            }
            return false;
        }

        public override void combatFactory(FactoryBuilding enemy)
        {
            enemy.Health = enemy.Health - DAMAGE;
        }

        public override void combatResource(ResourceBuilding enemy)
        {
            enemy.Health = enemy.Health - DAMAGE;
        }


        public override bool isDead()
        {
            return (this.Health <= 0);
        }

        public override string toString()
        {
            string output = "Name: " + name + Environment.NewLine 
                + "x : " + X + Environment.NewLine 
                + "y : " + Y + Environment.NewLine
                + "Health: " + Health + Environment.NewLine
                + "Speed : " + Speed + Environment.NewLine 
                + "Attack : " + (Attack ? "Yes" : "No") + Environment.NewLine 
                + "Attack Range : " + AttackRange + Environment.NewLine 
                + "Faction/Team : " + Faction + Environment.NewLine 
                + "Symbol : " + Symbol + Environment.NewLine;

            return output;
        }


        public override void save()
        {
            FileStream outFile = null;
            StreamWriter writer = null;
            try
            {
                // open the file
                outFile = new FileStream(@"SaveGame\MeleeUnits.txt", FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(outFile);

                // write to the file
                writer.WriteLine(Name);
                writer.WriteLine(X);
                writer.WriteLine(Y);
                writer.WriteLine(Health);
                writer.WriteLine(Speed);
                writer.WriteLine(Attack);
                writer.WriteLine(AttackRange);
                writer.WriteLine(Faction);
                writer.WriteLine(Symbol);

                // close the file
                writer.Close();
                outFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);        // put using System.Diagnostics; at the top
            }
            finally
            {
                if (outFile != null)
                {
                    writer.Close();
                    outFile.Close();
                }
            }
        }

    }

    #endregion
}
