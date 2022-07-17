using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinRespawn : MonoBehaviour
{
    [SerializeField] private Transform pin;
    [SerializeField] private Transform respawnpoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        pin.transform.position = respawnpoint.transform.position;
    }
}
