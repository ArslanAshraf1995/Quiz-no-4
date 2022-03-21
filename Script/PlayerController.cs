using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10;
    private float xRangeRight = 5.62f;
    private float xRangeLeft = -10.26f;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xRangeRight)
        {
            transform.position = new Vector3(xRangeRight, transform.position.y, transform.position.z);
        }
        if (transform.position.x < xRangeLeft)
        {
            transform.position = new Vector3(xRangeLeft, transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.RightArrow))
		{
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
