using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statistics
{
    public interface IAlerter
    {


    }

    public class StatsAlerter
    {
        public float MaxThreshold;
        readonly EmailAlert _emailAlert;
        readonly LEDAlert ledAlert;
        public StatsAlerter(float maxThreshold, IAlerter[] alerter)
        {
            this.MaxThreshold = maxThreshold;
            this._emailAlert = (Statistics.EmailAlert)alerter[0];
            this.ledAlert = (Statistics.LEDAlert)alerter[1];
        }
       public void checkAndAlert(List<double> listValues)
        {
            foreach (var value in listValues.Where(value => value > MaxThreshold))
            {
                _emailAlert.emailSent = true;
                ledAlert.ledGlows = true;
            }
        }

    }
   public class EmailAlert:IAlerter
    {
        public Boolean emailSent = false;
    }
   public class LEDAlert: IAlerter
    {
        public Boolean ledGlows = false;
    }
}
