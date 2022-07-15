using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Sprite balloon;
    [SerializeField] private SpriteRenderer render;
    private bool move = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            move = true;
            render.sprite = balloon;
        }

        if(move==true)
        {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        }



    }
}

