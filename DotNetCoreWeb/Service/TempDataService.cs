using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWeb.Service
{
    public class TempDataService : ITransientService
    {
        Dictionary<string, string> _config;
        public string serviceid { get { return Get<string, string>("uGUID"); } }

        public TempDataService()
        {
            Init();
        }

        public void Add(string name, string value)
        {
            _config.TryAdd(name, value);
        }

        public void Clear()
        {
            _config.Clear();
        }

        public TDestination Get<TSource, TDestination>(string name)
        {
            var converter = TypeDescriptor.GetConverter(typeof(TSource));

            TDestination result = default(TDestination);

            // 判斷能不能轉型
            if (converter.CanConvertTo(typeof(TDestination)))
            {
                result = (TDestination)(converter.ConvertTo(_config[name], typeof(TDestination)));
            }

            return result;
        }

        public void Init()
        {
            _config = new Dictionary<string, string>();
            _config.Add("uGUID", Guid.NewGuid().ToString());
        }

        public void Remove(string name)
        {
            _config.Remove(name);
        }

        public void Set(string name, string value)
        {
            _config[name] = value;
        }
    }
}
