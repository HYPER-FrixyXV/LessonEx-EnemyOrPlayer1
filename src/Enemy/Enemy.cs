using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BPascal.LessonEx3.ClassEnemy
{
    public class Enemy
    {
        private string _name;
        private int _health;
        private bool _isAlive;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.IsWhiteSpace() || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty or blank.");
                }
            }
        }
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
        public bool IsAlive
        {
            get { return _isAlive; }
            private set
            {
                _isAlive = value;
            }
        }

        public int Damage { get; set; }

        public Enemy(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
            IsAlive = true;
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
                IsAlive = false;
                Health = 0;
            }
        }
    }
}
