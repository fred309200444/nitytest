using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipcontril : MonoBehaviour {

    public GameObject Bullet;
    public GameObject Boom;
    static bool boomexist;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.position += new Vector3(0, 0.1f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.position += new Vector3(0, -0.1f, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pos = gameObject.transform.position + new Vector3(0, 0.6f, 0);

            Instantiate(Bullet, pos, gameObject.transform.rotation);

        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Vector3 pos = gameObject.transform.position + new Vector3(0, 4, 0);

            Instantiate(Boom, pos, gameObject.transform.rotation);
            boomexist = true;
            
        }

    }
}
