using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstWave : MonoBehaviour
{
    private bool leftMove = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(leftMove == false)
		{
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        else
		{
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        

        if (transform.position.x < -4.61f)
        {
            transform.position = new Vector3(-4.61f, transform.position.y, transform.position.z);
            leftMove = false;
        }
        if (transform.position.x > -1.5f)
        {
            transform.position = new Vector3(-1.5f, transform.position.y, transform.position.z);
            leftMove = true;
        }
    }
}
