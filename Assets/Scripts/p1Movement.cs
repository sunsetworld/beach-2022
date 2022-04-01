using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1Movement : MonoBehaviour
{
    Vector2 movement = new Vector2(10, 0);
    GameObject p;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-movement.x * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(movement.x * Time.deltaTime, 0, 0);
        }
    }
}
