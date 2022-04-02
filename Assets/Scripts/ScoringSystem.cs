using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringSystem : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] Vector3 P1Spawn;
    [SerializeField] Vector3 P2Spawn;
    [SerializeField] int P1Score;
    [SerializeField] int P2Score;
    [SerializeField] displayScore dS;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "P1")
        {
            dS.AddP1Score();
            Instantiate(ball, P1Spawn, Quaternion.identity);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "P2")
        {
            dS.AddP2Score();
            Instantiate(ball, P2Spawn, Quaternion.identity);
            Destroy(gameObject);
        }


    }

}
