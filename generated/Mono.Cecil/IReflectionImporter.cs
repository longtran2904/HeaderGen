#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

using System;
using System.Reflection;

namespace Mono.Cecil
{
    public interface IReflectionImporter
    {

        TypeReference ImportReference(Type type, IGenericParameterProvider context);
        FieldReference ImportReference(FieldInfo field, IGenericParameterProvider context);
        MethodReference ImportReference(MethodBase method, IGenericParameterProvider context);
    }
}
