using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemove : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed = 5;
    public float deadzone = -45;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
        if (transform.position.x < deadzone)
        {
            Debug.Log("pipe delited");
            Destroy(gameObject);
        }
    }
}
