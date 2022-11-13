using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipesUI : UIWindow
{

    private void Update() {
        if(Input.GetKeyDown(KeyCode.R)){
            if(panel.activeSelf) CloseUI();
            else OpenUI();
        }
    }
    public override void CloseUI()
    {
        panel.SetActive(false);
    }

    public override void OpenUI()
    {
        panel.SetActive(true);
    }
}
