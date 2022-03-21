using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    private Vector3 startPos;
    private float midPoint;
    public GameObject backGroundPrefab;
    private bool repeat = false;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        startPos.z = 14.15326f;
        midPoint = 5.8f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime);
        if (transform.position.z < -5.8f && repeat == false)
        {
            Instantiate(backGroundPrefab, startPos , backGroundPrefab.transform.rotation);
            repeat = true;
        }
        if(transform.position.z < -17f)
		{
            Destroy(gameObject);
		}
    }
}
