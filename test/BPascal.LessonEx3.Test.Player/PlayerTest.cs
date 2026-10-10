using BPascal.LessonEx3.ClassPlayer;
namespace BPascal.LessonEx3.TestPlayer
{
    public class PlayerTest
    {
        [Fact]
        public void Player_StartAtLv1()
        {
            Player guy = new Player("guy");
            Assert.Equal(1, guy.Lv);
        }
    }
}
