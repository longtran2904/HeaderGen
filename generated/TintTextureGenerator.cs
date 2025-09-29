#region Unity.2D.Tilemap.Extras, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\Documents\GitHub\Rogue-like-game-i-guess\The game is liar\Library\ScriptAssemblies\Unity.2D.Tilemap.Extras.dll
#endregion

using UnityEngine;

[ExecuteInEditMode]
public class TintTextureGenerator : MonoBehaviour
{
    public int k_TintMapSize;

    public TintTextureGenerator();

    public void Start();
    public void Refresh(Grid grid);
    public void Refresh(Grid grid, Vector3Int position);
    public Color GetColor(Grid grid, Vector3Int position);
    public void SetColor(Grid grid, Vector3Int position, Color color);
}
