using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopObject : MonoBehaviour
{
    private ShopUI shopUI;
    private RecipesUI recipesUI;

    private void Start() {
        shopUI = UIManager.instance.shopUI;
        recipesUI = UIManager.instance.recipesUI;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        shopUI.OpenUI();
        recipesUI.OpenUI();
    }
    private void OnTriggerExit2D(Collider2D other) {
        shopUI.CloseUI();
    }
}
