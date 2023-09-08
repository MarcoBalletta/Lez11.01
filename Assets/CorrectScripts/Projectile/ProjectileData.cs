using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemObject", menuName = "ScriptableObjects" + "/Projectile" + "/CreateNewProjectile", order = 1)]
[System.Serializable]
public class ProjectileData : ScriptableObject
{
    public string nameProj;
    public GameObject prefab;
    public float speed;
    public float damage;
}
