using System.Numerics;
using BPascal.LessonEx3.ClassPlayer;

namespace BPascal.LessonEx3.TestPlayer
{
    public class PlayerTest
    {
        [Fact]
        public void Player_NameIsntFuckingBlank()
        {
            Player You = new Player("name");
            Assert.Equal("name", You.Name);
        }

        [Fact]
        public void Player_StartAtLv1()
        {
            Player You = new Player("name");
            Assert.Equal(1, You.Lv);
        }
    }
}
