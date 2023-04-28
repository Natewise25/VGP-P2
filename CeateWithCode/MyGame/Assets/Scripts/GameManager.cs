using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour

{
    private int lives;
    public TextMeshProUGUI livesText;
    // Start is called before the first frame update
    void Start()
    {
        lives = 000;
        livesText.text = "lives" + lives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
