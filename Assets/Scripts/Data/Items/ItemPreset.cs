using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemPreset", menuName = "OddvaultF/ItemPreset", order = 0)]
public class ItemPreset : ScriptableObject {
    public int Id;
    public string itemName;
    public Sprite icon;
}
