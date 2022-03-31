using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballControl : MonoBehaviour
{
    CircleCollider2D cc2d;
    [SerializeField] Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        float r1 = Random.Range(1, 2);
        float r2 = Random.Range(1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 randomNum = new Vector2(-4, 2);
        rb2d.AddForce(randomNum);
    }
}
