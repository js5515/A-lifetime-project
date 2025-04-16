using UnityEngine;
/// <summary>
/// 角色可編程物件 - Jerry0401
/// </summary>

[CreateAssetMenu(fileName = "playerObject", menuName = "CreatePlayer")]
public class PlayerScriptableObject : ScriptableObject
{
    public string playerName;
    public float attack;
    public float hp;
    public float moveDistance; // 每步移動距離
    public float moveTime; // 每步移動時間
}
