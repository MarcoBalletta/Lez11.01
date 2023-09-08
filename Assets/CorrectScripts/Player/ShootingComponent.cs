using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingComponent : MonoBehaviour
{

    public WeaponData weaponSelected;
    public InputActions actions;
    public Transform equipLeftHand;
    public Transform equipRightHand;
    private GameObject modelWeapon;
    private AnimationHandler anim;
    void Awake()
    {
        actions = new InputActions();
        actions.Enable();
    }

    private void Start()
    {
        actions.PlayerActions.Shoot.performed += Shoot;
        anim = GetComponent<AnimationHandler>();
    }


    public void Shoot(InputAction.CallbackContext context)
    {
        if (weaponSelected == null) return;
        anim.ShootAnim(weaponSelected.animTrigger);
    }

    public void ShootSpawnProjectile()
    {
        var proj = Instantiate(weaponSelected?.projectile.prefab, modelWeapon.transform.position + weaponSelected.offsetProjSpawn, Quaternion.LookRotation(equipRightHand.forward));
        //proj.transform.SetParent(null);
        //proj.transform.rotation = equipRightHand.rotation;
    }

    public void EquipWeapon( WeaponData data)
    {
        weaponSelected = data;
        modelWeapon = Instantiate(weaponSelected.WeaponModel, equipRightHand);
    }

}
