using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int Id {get; private set;}
    public string Name {get; private set;}
    public Sprite Icon {get; private set;}

    public Item(ItemPreset preset){
        Id = preset.Id;
        Name = preset.name;
        Icon = preset.icon;
    }
}
