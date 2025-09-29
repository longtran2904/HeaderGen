#region UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEditor.Graphs.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEditor.Graphs
{
    public class GraphsTypeConverter : TypeConverter
    {

        public GraphsTypeConverter();

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType);
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType);
    }
}
