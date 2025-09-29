#region UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll
#endregion

using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
    public abstract class UxmlAttributeDescription
    {
        protected const string xmlSchemaNamespace = "http://www.w3.org/2001/XMLSchema";

        protected UxmlAttributeDescription();

        public string name { get; set; }
        public IEnumerable<string> obsoleteNames { get; set; }
        public string type { get; protected set; }
        public string typeNamespace { get; protected set; }
        public abstract string defaultValueAsString { get; }
        public Use use { get; set; }
        public UxmlTypeRestriction restriction { get; set; }

        protected bool TryGetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue, ref T value);
        protected T GetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue);

        public enum Use
        {
            None = 0,
            Optional = 1,
            Prohibited = 2,
            Required = 3
        }
    }
}
