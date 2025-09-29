#region Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.TextMeshPro.dll
#endregion

using UnityEngine;

namespace TMPro
{
    [DisallowMultipleComponent]
    public class TMP_SpriteAnimator : MonoBehaviour
    {
        public TMP_SpriteAnimator();

        public void StopAllAnimations();
        public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate);
    }
}
