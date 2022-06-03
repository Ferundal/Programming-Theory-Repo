using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 startPosition;
    // Start is called before the first frame update
    void Awake()
    {
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, startPosition) > 20)
        {
            Destroy(this.gameObject);
        }
        this.transform.position += this.transform.rotation * Vector3.forward * speed * Time.deltaTime;
    }
}
