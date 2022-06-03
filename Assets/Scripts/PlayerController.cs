using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3.0f;
    private Vector3 startMousePosition;
    private List<Weapon> weapons;
    private int currentWeapon;
    // Start is called before the first frame update

    private void Awake()
    {
        weapons = new List<Weapon>();
        currentWeapon = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            startMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(1))
        {
            float offset = startMousePosition.x;
            startMousePosition = Input.mousePosition;
            offset = startMousePosition.x - offset;
            this.gameObject.transform.Rotate(0, offset, 0, Space.Self);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (weapons.Count > 0)
            {
                // POLYMORPHISM
                weapons[currentWeapon].Shoot(this.gameObject, this.transform.rotation);
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += this.transform.rotation * Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += this.transform.rotation * Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += this.transform.rotation * Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += this.transform.rotation * Vector3.back * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            this.SwitchWeapon();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Weapon"))
        {
            Debug.Log("Weapon " + other.gameObject.name + "Picked Up");
            this.AddWeapon(other.gameObject.GetComponent<Weapon>());
        }
    }

    private void SwitchWeapon()
    {
        if (weapons.Count > 0)
        {
            ++currentWeapon;
            if (currentWeapon == weapons.Count)
            {
                currentWeapon = 0;
            }
            Debug.Log("Weapon Switched to " + currentWeapon);
        }
    }

    private void AddWeapon(Weapon weapon)
    {
        foreach (Weapon currentWeapon in weapons) {
            if (currentWeapon.gameObject.name.Equals(weapon.gameObject.name))
            {
                Destroy(weapon);
                return;
            }
        }
        weapons.Add(weapon);
        weapon.gameObject.SetActive(false);
    }
}
