﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommProject_1144.DataAccess.Repository.IRepository
{
   public interface ISP_CALL:IDisposable
    {
        void Execute(string procedureName, DynamicParameters param=null);
        T Single<T>(string procedureName, DynamicParameters param = null);
        T OneRecord<T>(string procedureName, DynamicParameters param = null);
        IEnumerable<T> list<T>(string procedureName, DynamicParameters param = null);
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedureName, DynamicParameters param = null);

    }
}
