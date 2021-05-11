using System;

namespace Clock
{
    /// <summary>
    /// Class adapter for analog clock 
    /// </summary>
    public class AnalogClockToDigitalAdapter : IClock
    {
        /// <summary>
        /// Analog clock
        /// </summary>
        private AnalogClock _analogClock;
        /// <summary>
        /// Hour
        /// </summary>
        public int Hour { get; set; }
        /// <summary>
        /// Minute
        /// </summary>
        public int Minute { get; set; }
        /// <summary>
        /// Second
        /// </summary>
        public int Second { get; set; }

        /// <summary>
        /// Adapts the clock from analog to digital
        /// </summary>
        /// <param name="analogClock">Analog clock</param>
        public AnalogClockToDigitalAdapter(AnalogClock analogClock)
        {
            _analogClock = analogClock;
            Hour = (int)Math.Truncate(analogClock.ClockwiseAngle / 30.0);
            Minute = (int)Math.Truncate(analogClock.MinuteHandAngle / 6.0);
            Second = (int)Math.Truncate(analogClock.SecondHandAngle / 6.0);
        }

        public override string ToString()
        {
            return "Digital clock: " +
                " Hour: " + Hour +
                " Minute: " + Minute +
                " Second: " + Second;
        }

        public override int GetHashCode()
        {
            return Hour.GetHashCode() ^ Minute.GetHashCode() ^ Second.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj as IClock == null) return false;
            return Hour == ((IClock)obj).Hour &&
                Minute == ((IClock)obj).Minute &&
                Second == ((IClock)obj).Second;
        }
    }
}
