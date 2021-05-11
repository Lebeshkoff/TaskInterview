using System;

namespace Clock
{
    /// <summary>
    /// A class that stores time in analog form
    /// </summary>
    public class AnalogClock
    {
        /// <summary>
        /// Clockwise angle in degrees
        /// </summary>
        public int ClockwiseAngle { get; private set; }
        /// <summary>
        /// Minute hand angle in degrees
        /// </summary>
        public int MinuteHandAngle { get; private set; }
        /// <summary>
        /// Second hand angle in degrees
        /// </summary>
        public int SecondHandAngle { get; private set; }

        /// <summary>
        /// Time in analog form, given in the values ​​of the angles of the arrows
        /// </summary>
        /// <param name="clockwiseAngle">Clockwise angle</param>
        /// <param name="minuteHandAngle">Minute hand angle</param>
        /// <param name="secondHandAngle">Second hand angle</param>
        public AnalogClock(int clockwiseAngle, int minuteHandAngle, int secondHandAngle)
        {
            if (clockwiseAngle < 0 || clockwiseAngle > 720)
            {
                throw new ArgumentOutOfRangeException("clockwiseAngle", "The value must be between 0 and 720");
            }
            else
            {
                ClockwiseAngle = clockwiseAngle;
            }

            if (minuteHandAngle < 0 || minuteHandAngle > 360)
            {
                throw new ArgumentOutOfRangeException("minuteHandAngle", "The value must be between 0 and 360");
            }
            else
            {
                MinuteHandAngle = minuteHandAngle;
            }

            if (secondHandAngle < 0 || secondHandAngle > 360)
            {
                throw new ArgumentOutOfRangeException("secondHandAngle", "The value must be between 0 and 360");
            }
            else
            {
                SecondHandAngle = secondHandAngle;
            }            
        }

        public override string ToString()
        {
            return "Analog clock: " + 
                " Hour angle: " + ClockwiseAngle + 
                " Minute angle: " + MinuteHandAngle + 
                " Second angle: " + SecondHandAngle;
        }

        public override int GetHashCode()
        {
            return ClockwiseAngle.GetHashCode() ^ MinuteHandAngle.GetHashCode() ^ SecondHandAngle.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj as AnalogClock == null) return false;
            return ClockwiseAngle == ((AnalogClock)obj).ClockwiseAngle && 
                MinuteHandAngle == ((AnalogClock)obj).MinuteHandAngle && 
                SecondHandAngle == ((AnalogClock)obj).SecondHandAngle;
        }
    }
}
