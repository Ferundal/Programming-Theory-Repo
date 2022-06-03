using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float angle;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = player.transform.position + offset;
        this.transform.rotation = player.transform.rotation * Quaternion.Euler(Vector3.left * angle);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = player.transform.position + player.transform.rotation.normalized * offset;
        this.transform.rotation = player.transform.rotation * Quaternion.Euler(Vector3.left * angle);
    }
}
