using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoreText;
    private int score;
    void Start()
    {
        score = 0;
        scoreText.text = "Score: "  + score;
    }

    // Update is called once per frame
    
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other) 
    {
        Destroy(other.gameObject);
        score = score + 1;
        scoreText.text = "Score: " + score;
    }
}
