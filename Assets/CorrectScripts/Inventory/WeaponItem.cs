using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ItemObject", menuName = "ScriptableObjects" + "/Inventory" + "/CreateNewWeapon", order = 1)]
public class WeaponItem : InventoryItem
{
    public WeaponData data;
    public WeaponCategory categoryWeapon;
}

public enum WeaponCategory
{
    oneHanded,
    dual,
    twoHanded,
    ranged
}
