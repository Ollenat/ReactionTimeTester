namespace ReactionTimeTester.Tests;

public class TimerTests
{
    [Fact]
    public void GapTimerTimesFromInstantiation()
    {
        //Arrange
        int time = 500;
        
        //Act
        GapTimer timer = new GapTimer(); 
        Thread.Sleep(time);
        int timerTime = timer.Time();

        //Assert
        Assert.Equal(time, timerTime);

    }

    
}