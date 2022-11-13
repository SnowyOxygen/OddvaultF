using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UIWindow : MonoBehaviour
{
    public GameObject panel;

    public abstract void OpenUI();
    public abstract void CloseUI();
}
