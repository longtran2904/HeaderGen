#region UnityEngine.TestRunner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\UnityEngine.TestRunner.dll
#endregion

using NUnit.Framework.Constraints;

namespace UnityEngine.TestTools.Constraints
{
    public class AllocatingGCMemoryConstraint : Constraint
    {

        public AllocatingGCMemoryConstraint();

        public override string Description { get; }

        public override ConstraintResult ApplyTo(object obj);
        public override ConstraintResult ApplyTo<TActual>(ActualValueDelegate<TActual> del);
    }
}
