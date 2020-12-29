using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    public class BadStationException : Exception
    {
        public int Code;
        public BadStationException(string message, Exception innerException) :
            base(message, innerException) => Code = ((DO.BadStationException)innerException).Code;
        public override string ToString() => base.ToString() + $", bad station code: {Code}";
    }
}
