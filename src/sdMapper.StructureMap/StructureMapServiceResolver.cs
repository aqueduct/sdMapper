﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;

namespace sdMapper.StructureMap
{
    class StructureMapServiceResolver : IServiceResolver
    {
        #region IServiceResolver Members

        public T Resolve<T>()
        {
            return ObjectFactory.GetInstance<T>();
        }

        public T Resolve<T>(string serviceName)
        {
            return ObjectFactory.GetNamedInstance<T>(serviceName);
        }

        public object Resolve(Type type)
        {
            return ObjectFactory.GetInstance(type);
        }

        public object Resolve(Type type, string serviceName)
        {
            return ObjectFactory.GetNamedInstance(type, serviceName);
        }

        #endregion
    }
}
