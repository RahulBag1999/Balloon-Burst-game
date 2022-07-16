using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonManager : MonoBehaviour
{
    //[SerializeField] private List<GameObject> balloonPrefab = new List<GameObject>();
    [SerializeField] private GameObject[] balloonsToInstantiate;
    [SerializeField] private Transform spawnPoint;
    //[SerializeField] private Transform targetPoint;
    //[SerializeField] private float travelSpeed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int n = Random.Range(0, balloonsToInstantiate.Length);
            GameObject balloon = Instantiate(balloonsToInstantiate[n], spawnPoint.position, Quaternion.identity);
            //Destroy(balloon, 2);
            //balloon.GetComponent<Transform>();
            //balloon.transform.position = Vector3.MoveTowards(balloon.transform.position, targetPoint.position, travelSpeed * Time.deltaTime);
        }
    }
    
}
