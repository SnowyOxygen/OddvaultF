using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeCell : MonoBehaviour
{
    public Image icon;
    private RecipeStock recipeStock;

    public void UpdateCell(RecipeStock recipeStock){
        if(recipeStock != null){
            this.recipeStock = recipeStock;
        }
    }
}
