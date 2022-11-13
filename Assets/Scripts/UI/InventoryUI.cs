using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : UIWindow
{

    private void Start() {
        panel.SetActive(false);
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.E)){
            if(panel.activeSelf) CloseUI();
            else OpenUI();
        }
    }

    public override void OpenUI()
    {
        panel.SetActive(true);
    }
    public override void CloseUI()
    {
        panel.SetActive(false);
    }
}
