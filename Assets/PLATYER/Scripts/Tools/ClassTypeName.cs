using System;
using NUnit.Framework;

namespace PLATYER.Scripts.Tools
{
    public class ClassTypeName:PropertyAttribute
    {
        public Type type;

        public ClassTypeName(Type type)
        {
            this.type = type;
        }
    }
}