using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class CubeWeapon : Weapon
{
    public override void Shoot(GameObject shooter, Quaternion direction)
    {
        Instantiate(sphereWeaponProjectile, shooter.transform.position, direction * Quaternion.Euler(Vector3.up * 20));
        Instantiate(sphereWeaponProjectile, shooter.transform.position, direction);
        Instantiate(sphereWeaponProjectile, shooter.transform.position, direction * Quaternion.Euler(Vector3.up * -20));
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
