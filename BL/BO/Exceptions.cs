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
        public BadStationException(string message, int code) : base()
        {
            Code = code;
        }
        public BadStationException(int code, string message) :
          base(message) => Code = code;
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







    [Serializable]
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
    public class StationsInThisLine : Exception
    {
        public int stationCode;
        public StationsInThisLine(string message, int stationcode) : base() => stationCode = stationcode;
        //public LinesPassingAtThisStationException(int index, string message) :
        //    base(message) => LineId = index;
        //public BadStationException(string message, Exception innerException) :
        //    base(message, innerException) => Code = ((DO.BadStationException)innerException).Code;
        public StationsInThisLine(int code, string message, Exception innerException) :
            base(message, innerException) => stationCode = ((DO.BadStationException)innerException).Code;

        public override string ToString() => base.ToString() + $", this station {stationCode} is already in this line ";
    }




    [Serializable]
    public class BadLineException : Exception
    {
        public int id;
      
        public BadLineException( string message, Exception innerException) :
            base(message, innerException) => id = ((DO.BadLineIdException)innerException).Id;
        public BadLineException(string message) : base(message)
        { }
            

        //public BadLineIdException(string message, Exception innerException) :
        // base(message, innerException) => id = ((DO.BadLineIdException)innerException).Id;

        //public BadLineIdException(string message, Exception innerException) :
        //  base(message, innerException);
        //public override string ToString() => base.ToString() + $", bad line id: {id}";
    }


    [Serializable]
    public class BadBusException : Exception
    {
        public int BusLicense;
        public BadBusException(string message, Exception innerException) :
            base(message, innerException) => BusLicense = ((DO.BadBusException)innerException).Lic;
        public override string ToString() => base.ToString() + $", bad bus code: {BusLicense}";

    }
}
