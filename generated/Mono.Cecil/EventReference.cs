#region Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74
// D:\Programs\2021.3.36f1\Editor\Data\Managed\Unity.Cecil.dll
#endregion

namespace Mono.Cecil
{
    public abstract class EventReference : MemberReference
    {

        protected EventReference(string name, TypeReference eventType);

        public TypeReference EventType { get; set; }
        public override string FullName { get; }

        protected override IMemberDefinition ResolveDefinition();
        public abstract EventDefinition Resolve();
    }
}
