#region UnityEditor.Graphs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Programs\2021.3.36f1\Editor\Data\Managed\UnityEditor.Graphs.dll
#endregion

using System;
using System.ComponentModel;
using System.Globalization;

namespace UnityEditor.Graphs
{
    public class AnimationCurveTypeConverter : GraphsTypeConverter
    {
        public AnimationCurveTypeConverter(Type type);

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType);
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value);
        public override bool IsValid(ITypeDescriptorContext context, object value);
    }
}
