using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform pinTriggerPoint;
    [SerializeField] private Transform pinRespawnPoint;
    private bool move = false;
   
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            move = true;
        }
        if(move==true)
        {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if(this.transform.position.y >= pinTriggerPoint.position.y)
        {
            move = false;
            this.transform.position= pinRespawnPoint.position;
        }
    }
}

