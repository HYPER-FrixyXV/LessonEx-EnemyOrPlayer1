using BPascal.LessonEx3.ClassPlayer;
namespace BPascal.LessonEx3.TestPlayer
{
    public class PlayerTest
    {
        Player guy = new Player("guy");//nome provvisorio

        [Fact]
        public void Player_StartAtLv1()
        {
            Assert.Equal(1, guy.Lv);
        }

        [Fact]
        public void Player_NameNotBlank()
        {
            Assert.Equal("guy", guy.Name);
        }

        [Fact]
        public void Player_HealthAtMax()
        {
            Assert.Equal(guy.MaxHealth, guy.Health);
        }

        [Fact]
        public void Player_NoGold()
        {
            Assert.Equal(0, guy.Gold);
        }

        [Fact]
        public void Player_TakeDamageNormally()
        {
            guy.TakeDamage(10);
            Assert.Equal(90, guy.Health);
        }

        [Fact]
        public void Player_LevelUp()
        {
            guy.AddExp(100);
            Assert.Equal(2, guy.Lv);
        }

        [Fact]
        public void Player_HealNormally()
        {
            guy.TakeDamage(50);
            guy.Heal(25);
            Assert.Equal(75, guy.Health);
        }

        [Fact]
        public void Player_GainGold()
        {
            guy.GainGold(5);
            Assert.Equal(5, guy.Gold);
        }
    }
}
