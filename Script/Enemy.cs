using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyBullet;
    private int triggerBullet = 2;
    private int randomValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*randomValue = Random.Range(0, 10);
        if(randomValue == triggerBullet)
		{
            Instantiate(enemyBullet, transform.position, enemyBullet.transform.rotation);
            Debug.Log("Entering");
        }
        */
           
        
    }
	private void OnTriggerEnter(Collider other)
	{
        if(other.tag == "bullet")
		{
            Destroy(gameObject);
		}
	
	}
}
