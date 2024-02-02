﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreDredge.Libs
{
    public static class TypeHelper
    {
        public static IEnumerable<Type> GetTypesWithAttribute(Type attribute) =>
            from a in AppDomain.CurrentDomain.GetAssemblies()
            from t in a.GetTypes()
            let attributes = t.GetCustomAttributes(attribute, true)
            where attributes != null && attributes.Length > 0
            select t;
    }
}
