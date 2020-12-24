using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLAPI;
using DO;
using DS;


namespace DAL
{
    sealed class DLObject:IDAL
    {
        #region singelton

        static readonly DLObject instance = new DLObject();
        static DLObject() {  }
        DLObject() { }
        public static DLObject Instance { get=> instance; }
        #endregion
    }
}
