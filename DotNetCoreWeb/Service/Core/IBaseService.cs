using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWeb.Service
{
    public interface IBaseService
    {
        void Init();
        void Add(string name, string value);
        void Remove(string name);
        void Clear();
        TDestination Get<TSource, TDestination>(string name);
        void Set(string name, string value);
    }
}