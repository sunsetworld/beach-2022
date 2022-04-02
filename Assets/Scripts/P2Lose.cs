using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Lose : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] Vector3 P1Spawn;
    [SerializeField] ScoringSystem scoringSystem;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Destroy(other.gameObject);
            Instantiate(ball, P1Spawn, Quaternion.identity);
        }
    }
}
