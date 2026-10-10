using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BPascal.LessonEx3.ClassPlayer
{
    public class Player
    { //parte costruttore
        private int _lv; //level
        private int _exp; //experience
        private int _health;
        private int _maxHealth;
        private bool _isAlive;
        private int _gold;

        public string Name { get; set; }

        public int Lv
        {
            get { return _lv; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Level cannot be less than 1.");
                }
            }
        }

        public int Exp
        {
            get { return _exp; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Experience cannot be negative.");
                }
                if (value >= 100)
                {
                    Lv++;
                    _exp = value - 100;
                }
                else
                {
                    _exp = value;
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
                    throw new ArgumentException("Health cannot be negative.");
                }
                if (value > _maxHealth)
                {
                    _health = _maxHealth;
                }
                else
                {
                    _health = value;
                }
            }
        }

        public int MaxHealth
        {
            get { return _maxHealth; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("MaxHealth cannot be less than 1.");
                }
                _maxHealth = value;
            }
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public int Gold
        {
            get { return _gold; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Gold cannot be negative.");
                }
                _gold = value;
            }
        }

        public Player()
        {
            Name = "Default name";
            Lv = 1;
            Exp = 0;
            MaxHealth = 20;
            Health = MaxHealth;
        }

        public Player(string name, int level=1)
        {
            Name = name;
            Lv = level;
            Exp = 0;
            MaxHealth = 100;
            Health = MaxHealth;
            Gold = 0;
        }
        //metodi
        public void AddExp(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be positive.");
            }
            Exp += amount;

            if (amount >= 100)
            {
                Lv+=Exp/100;
                Exp -= amount;
                this.ResetHealth();
            }
        }
        private void ResetExp()
        {
            Exp = 0;
        }
        public void TakeDamage(int amount)

        {
            if (amount <= 0)
            {
                throw new ArgumentException("Taking damage in a negative amount? We have Heal() for that bro");
            }
            Health -= amount;
            if (Health <= 0)
            {
                Health = 0;
            }
        }

        public void Heal(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Healing in a negative amount? We have TakeDamage() for that bro");
            }
            Health += amount;
        }
        public void GainGold(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be positive.");
            }
            Gold += amount;
        }
        private void ResetHealth()
        {
            Health = MaxHealth;
        }
    }
}