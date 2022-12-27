namespace ReactionTimeTester
{
    public class GapTimer
    {
        //Constructor
        public GapTimer()
        {
            lastTime = Environment.TickCount;
        }

        //Returns the time in milliseconds between the last invocation of this method, if no invocation has existed returns time since the instantiation of this class 
        public int Time()
        {
            var timeBetween = Environment.TickCount - lastTime;

            lastTime = Environment.TickCount;
            return timeBetween;
        }

        private int lastTime;
    }
}