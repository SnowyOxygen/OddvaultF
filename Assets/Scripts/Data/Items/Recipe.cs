using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe
{
    public int Id {get; set;}
    public List<int> Ingredients {get; set;} = new List<int>(); 
    public int Product {get; set;}

    //Testing constructor
    public Recipe(RecipePreset preset){
        Id = preset.Id;
        Ingredients = preset.ingredients;
        Product = preset.product;
    }
    //Constructor from db
    public Recipe(int id, List<int> ingredients, int product){

    }
}
