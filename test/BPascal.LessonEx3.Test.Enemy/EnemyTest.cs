using BPascal.LessonEx3.ClassEnemy;

namespace BPascal.LessonEx3.ClassEnemy
{
    public class EnemyTest
    {
        Enemy badguy = new Enemy("Slime", 50, 5); //nome provvisorio

        [Fact]
        public void Enemy_NameNotBlank()
        {
            Assert.Throws<ArgumentException>(() => new Enemy("", 50, 5));
        }

        [Fact]
        public void Enemy_HealthNotNeg()
        {
            Assert.Throws<ArgumentException>(() => new Enemy("Slime", -50, 5));
        }
        [Fact]
        public void Enemy_DmgNotNeg()
        {
            Assert.Throws<ArgumentException>(() => new Enemy("Slime", 50, -5));
        }

        [Fact]
        public void Enemy_NotDead()
        {
            Assert.True(badguy.IsAlive());
        }

        [Fact]
        public void Enemy_TakeDamageNormally()
        {
            badguy.TakeDamage(5);
            Assert.Equal(45, badguy.Health);
        }
        [Fact]
        public void Enemy_TakeDamageOverflow()
        {
            badguy.TakeDamage(500);
            Assert.Equal(0, badguy.Health);
        }
        [Fact]
        public void Enemy_TakeNegDamage()
        {
            Assert.Throws<ArgumentException>(()=> badguy.TakeDamage(-35));
        }

        [Fact]
        public void Enemy_Dead()
        {
            badguy.TakeDamage(50);
            Assert.False(badguy.IsAlive());
        }
    }
}
