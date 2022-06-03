using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class SphereWeapon : Weapon
{
    public override void Shoot(GameObject shooter, Quaternion direction)
    {
        Instantiate(sphereWeaponProjectile, shooter.transform.position, direction);
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
