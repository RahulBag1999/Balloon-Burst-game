using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonScript : MonoBehaviour
{
    [SerializeField] private Transform targetPoint;
    [SerializeField] private float travelSpeed;
    [SerializeField] private int scoreCount;
    // [SerializeField] private float rotationSpeed;
    // [SerializeField] private float ySpeed;
    // [SerializeField] private float yMin;
    // [SerializeField] private float yMax;


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, travelSpeed * Time.deltaTime);

        /* float yMove = Input.GetAxis("Vertical");
           transform.Translate(new Vector3(0, yMove, 0));

           float yPos = Mathf.Clamp(transform.position.y, yMin, yMax);
           transform.position = new Vector3(0, yPos, 0);    
       */
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Pin")
        {
            ScoreManager.scoreManager.IncreaseScore(scoreCount);
            Destroy(gameObject);
        }
        
    }
}
