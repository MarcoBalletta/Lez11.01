using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WeaponData : IWeapon
{
    public ProjectileData projectile;
    public Vector3 offsetProjSpawn;
    public GameObject WeaponModel;
    public string animTrigger;
}

public interface IWeapon
{

}
