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

    [Serializable]
    public class BadLineStationException : Exception
    {
        public int StationCode;
        public BadLineStationException(string message, Exception innerException) :
            base(message, innerException) => StationCode = ((DO.BadLineStationException)innerException).Station;
        public override string ToString() => base.ToString() + $", bad station code: {StationCode}";

    }

    public class LinesPassingAtThisStationException : Exception
    {
        public int Line;
        public LinesPassingAtThisStationException(string message,int line) : base() => Line = line;
        //public LinesPassingAtThisStationException(int index, string message) :
        //    base(message) => LineId = index;

        //public LinesPassingAtThisStationException(int index, string message, Exception innerException) :
        //    base(message, innerException) => LineId = index;

        public override string ToString() => base.ToString() + $", this line {Line} isn't passing at this station ";
    }


    [Serializable]
    public class BadLineIdException : Exception
    {
        public int id;
        public BadLineIdException(int id, string message, Exception innerException) :
            base(message, innerException) => id = ((DO.BadLineIdException)innerException).Id;



        //public BadLineIdException(string message, Exception innerException) :
        //  base(message, innerException);
        //public override string ToString() => base.ToString() + $", bad line id: {id}";
    }
}
