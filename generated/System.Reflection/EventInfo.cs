#region System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Private.CoreLib.dll
#endregion

namespace System.Reflection
{
    public abstract class EventInfo : MemberInfo
    {

        protected EventInfo();

        public override MemberTypes MemberType { get; }
        public abstract EventAttributes Attributes { get; }
        public bool IsSpecialName { get; }
        public virtual MethodInfo AddMethod { get; }
        public virtual MethodInfo RemoveMethod { get; }
        public virtual MethodInfo RaiseMethod { get; }
        public virtual bool IsMulticast { get; }
        public virtual Type EventHandlerType { get; }

        public MethodInfo[] GetOtherMethods();
        public virtual MethodInfo[] GetOtherMethods(bool nonPublic);
        public MethodInfo GetAddMethod();
        public MethodInfo GetRemoveMethod();
        public MethodInfo GetRaiseMethod();
        public abstract MethodInfo GetAddMethod(bool nonPublic);
        public abstract MethodInfo GetRemoveMethod(bool nonPublic);
        public abstract MethodInfo GetRaiseMethod(bool nonPublic);
        public virtual void AddEventHandler(object target, Delegate handler);
        public virtual void RemoveEventHandler(object target, Delegate handler);
        public override bool Equals(object obj);
        public override int GetHashCode();

        public static bool operator ==(EventInfo left, EventInfo right);
        public static bool operator !=(EventInfo left, EventInfo right);
    }
}
