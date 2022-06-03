using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon: MonoBehaviour
{
    [SerializeField] protected GameObject sphereWeaponProjectile;

    // ABSTRACTION
    public virtual void Shoot(GameObject shooter, Quaternion direction) {}
}
