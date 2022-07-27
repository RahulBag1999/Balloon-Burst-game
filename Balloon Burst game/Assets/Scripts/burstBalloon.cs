using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burstBalloon : MonoBehaviour
{
    [SerializeField] private Transform targetPoint;
    [SerializeField] private float travelSpeed;
    //[SerializeField] private int scoreCount;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite spriteToRender;
    private GameObject Pin;

     void Start()
    {
        Pin = GameObject.FindGameObjectWithTag("Pin");
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, travelSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pin")
        {
            spriteRenderer.sprite = spriteToRender;
            //ScoreManager.scoreManager.IncreaseScore(scoreCount);
            Destroy(gameObject, 0.1f);
            Destroy(Pin);
        }
    }
}
