using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    [Serializable]
    public class BadStationException : Exception
    {
        public int Code;
        public BadStationException(int code) : base() => Code = code;
        public BadStationException(int code, string message) :
            base(message) => Code = code;
        public BadStationException(int code, string message, Exception innerException) :
            base(message, innerException) => Code = code;

        public override string ToString() => base.ToString() + $", bad station code: {Code}";
    }

    [Serializable]

    public class BadLineIdException : Exception
    {
        public int Id;
        public BadLineIdException(int id) : base() => Id = id;
        public BadLineIdException(int id, string message) :
            base(message) => Id = id;
        public BadLineIdException(int id, string message, Exception innerException) :
            base(message, innerException) => Id = id;

        public override string ToString() => base.ToString() + $", bad line id: {Id}";
    }


    [Serializable]

    public class BadLineCodeException : Exception
    {
        public int LineCode;
        public BadLineCodeException(int code) : base() => LineCode = code;
        public BadLineCodeException(int code, string message) :
            base(message) => LineCode = code;
        public BadLineCodeException(int code, string message, Exception innerException) :
            base(message, innerException) => LineCode = code;

        public override string ToString() => base.ToString() + $", bad line code: {LineCode}";
    }

    [Serializable]

    public class BadLineStationIndexException : Exception
    {
        public int LineStationIndex;
        public BadLineStationIndexException(int index) : base() => LineStationIndex = index;
        public BadLineStationIndexException(int index, string message) :
            base(message) => LineStationIndex = index;
        public BadLineStationIndexException(int index, string message, Exception innerException) :
            base(message, innerException) => LineStationIndex = index;

        public override string ToString() => base.ToString() + $", bad index of the station: {LineStationIndex}";
    }

    [Serializable]

    public class BadLineStationException : Exception
    {
        public int LineId, Station;
        public BadLineStationException(int station, int lineId) : base() => LineId = lineId;
        public BadLineStationException(int index, string message) :
            base(message) => LineId = index;
        public BadLineStationException(int station, int lineId, string message) :
            base(message) => LineId = lineId;
        public BadLineStationException(int index, string message, Exception innerException) :
            base(message, innerException) => LineId = index;

        public override string ToString() => base.ToString() + $", this station {Station} isn't in this line ";
    }
    [Serializable]
    public class BadAdjacentStationsException : Exception
    {
        public int StationA, StationB;
        public BadAdjacentStationsException(int Station1, int Station2, string message) : base(message){ StationA = Station1; StationB = Station2; }



    }

    [Serializable]
    public class BadBusException : Exception
    {
        public int Lic;
        public BadBusException(int lic) : base() => Lic = lic;
        public BadBusException(int lic, string message) :
            base(message) => Lic = lic;
        public BadBusException(int lic, string message, Exception innerException) :
            base(message, innerException) => Lic = lic;

        public override string ToString() => base.ToString() + $", bad bus license: {Lic}";


    }
}
