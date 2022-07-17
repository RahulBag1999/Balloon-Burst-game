using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private bool move = false;
   
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            move = true;
        }
        if(move==true)
        {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }

    



}

