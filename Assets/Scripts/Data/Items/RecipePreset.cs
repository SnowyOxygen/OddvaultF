using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RecipePreset", menuName = "OddvaultF/RecipePreset", order = 0)]
public class RecipePreset : ScriptableObject {
    //int = id for item. 1, 1, 2 => 2 items of id 1, and 1 item of id 2
    public int Id;
    public List<ItemPreset> ingredients = new List<ItemPreset>();
    public ItemPreset product;
}
