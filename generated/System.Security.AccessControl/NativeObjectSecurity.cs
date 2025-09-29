#region System.Security.AccessControl, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.20\System.Security.AccessControl.dll
#endregion

using System.Runtime.InteropServices;

namespace System.Security.AccessControl
{
    public abstract class NativeObjectSecurity : CommonObjectSecurity
    {

        protected NativeObjectSecurity(bool isContainer, ResourceType resourceType);
        protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext);
        protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, string name, AccessControlSections includeSections, ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext);
        protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, string name, AccessControlSections includeSections);
        protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, SafeHandle handle, AccessControlSections includeSections, ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext);
        protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, SafeHandle handle, AccessControlSections includeSections);

        protected sealed override void Persist(string name, AccessControlSections includeSections);
        protected void Persist(string name, AccessControlSections includeSections, object exceptionContext);
        protected sealed override void Persist(SafeHandle handle, AccessControlSections includeSections);
        protected void Persist(SafeHandle handle, AccessControlSections includeSections, object exceptionContext);
        protected internal delegate Exception ExceptionFromErrorCode(int errorCode, string name, SafeHandle handle, object context);
    }
}
