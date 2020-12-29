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

    public class BadLineIdExeption : Exception
    {
        public int Id;
        public BadLineIdExeption(int id) : base() => Id = id;
        public BadLineIdExeption(int id, string message) :
            base(message) => Id = id;
        public BadLineIdExeption(int id, string message, Exception innerException) :
            base(message, innerException) => Id = id;

        public override string ToString() => base.ToString() + $", bad line id: {Id}";
    }


    [Serializable]

    public class BadLineCodeExeption : Exception
    {
        public int LineCode;
        public BadLineCodeExeption(int code) : base() => LineCode = code;
        public BadLineCodeExeption(int code, string message) :
            base(message) => LineCode = code;
        public BadLineCodeExeption(int code, string message, Exception innerException) :
            base(message, innerException) => LineCode = code;

        public override string ToString() => base.ToString() + $", bad line code: {LineCode}";
    }




}
