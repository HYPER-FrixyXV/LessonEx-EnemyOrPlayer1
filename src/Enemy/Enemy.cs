using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BPascal.LessonEx3.ClassEnemy
{
    public class Enemy
    {
        private int _health;

        public string Name {get; set; }
        public int Health
        {
            get { return _health; }
            private set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else
                {
                    _health = value;
                }
            }
        }
        public int Damage { get; set; }

        public Enemy(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
        public bool IsAlive()
        {
            return Health > 0;
        }

        public void TakeDamage(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Damage amount must be greater than 0.");
            }
            Health -= amount;
            if (Health <= 0)
            {
                Health = 0;
            }
        }
    }
}
