using System;
using System.Collections.Generic;

namespace OnlineStore.Data
{
    public interface IData
    {
        public abstract void Handler(List<Object> list);
        public abstract List<Object> GetData();
        public abstract void RefactorString(String str);
    }
}
