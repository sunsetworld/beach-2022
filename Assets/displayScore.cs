using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class displayScore : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] ScoringSystem sc;
    [SerializeField] TextMeshProUGUI p1;
    [SerializeField] TextMeshProUGUI p2;

    int p1score;
    int p2score;
    // Start is called before the first frame update
    void Start()
    {
        p1.text = p1score.ToString();
        p2.text = p2score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        p1.text = p1score.ToString();
        p2.text = p2score.ToString();
    }

    public void AddP1Score()
    {
        p1score += 1;
    }

    public void AddP2Score()
    {
        p2score += 1;
    }
}
