using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showGameOver : MonoBehaviour
{
    CanvasGroup cg;

    // Start is called before the first frame update
    void Start()
    {
        cg = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }    
    void gameOver(bool yes)
    {
        cg.alpha = yes?1:0;
    }
}
