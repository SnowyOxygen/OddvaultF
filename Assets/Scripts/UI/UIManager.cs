using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region Singleton
	public static UIManager instance;
	private void Awake() {
	    if(instance == null){
	        instance = this;
	    }
	    else{
	        Debug.LogWarning($"More than one instance of {this}!");
	    }
	}
    #endregion

    public ShopUI shopUI;
    public RecipesUI recipesUI;

    private void Start() {
        shopUI.CloseUI();
        recipesUI.CloseUI();
    }
}
