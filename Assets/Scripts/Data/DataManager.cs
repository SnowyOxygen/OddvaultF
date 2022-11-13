using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    #region Singleton
        public static DataManager instance;

        private void Awake() {
            if(instance == null){
                instance = this;
            }
            else{
                Debug.LogWarning($"Already one instance of {this}");
                Destroy(gameObject);
            }
        }
    #endregion

    public List<ItemPreset> itemPresets = new List<ItemPreset>();
    public List<RecipePreset> recipePresets = new List<RecipePreset>();
    public List<RecipePreset> ownedRecipes = new List<RecipePreset>();
}
