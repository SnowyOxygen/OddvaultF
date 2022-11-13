using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Shop Manager
public class ShopUI : UIWindow
{
    private DataManager dataManager;

    public RecipeCell[] recipeCells;
    public Transform recipeCellParent;

    private void Awake() {
        recipeCells = recipeCellParent.GetComponentsInChildren<RecipeCell>();
    }
    private void Start() {
        dataManager = DataManager.instance;
    }
    public override void CloseUI()
    {
        panel.SetActive(false);
    }

    public override void OpenUI()
    {
        panel.SetActive(true);
    }

    public void UpdateUI(List<RecipeStock> stock){
        
    }
}
