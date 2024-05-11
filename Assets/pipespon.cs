using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawtime = 2;
    public float time = 0;
    public float heightofset = 10;
    //void showpipe();
    void Start()
    {
        showpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(time < spawtime)
        {
            time += Time.deltaTime;
        }
        else
        {
            showpipe();   
            time = 0;
        }
    }
    void showpipe()
    {
        float lowestpoint = transform.position.y - heightofset ;
        float hightpoint = transform.position.y + heightofset;
        Instantiate(pipe, new Vector3 (transform.position.x , Random.Range(lowestpoint , hightpoint), 0 ), transform.rotation);
    }
}
