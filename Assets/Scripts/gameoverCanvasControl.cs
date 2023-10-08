using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameoverCanvasControl : MonoBehaviour
{
    CanvasGroup cg;
    private void Start()
    {
        cg = GetComponent<CanvasGroup>();
    }
    void gameOver(bool yes)
    {
        cg.alpha = yes ? 1 : 0;
    }
}
