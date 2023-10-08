using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCanvasControl : MonoBehaviour
{
    CanvasGroup cg;
    private void Start()
    {
        cg = GetComponent<CanvasGroup>();
        cg.alpha = 0;
    }
   public  void Display()
    {
        cg.alpha = 1;
    }
}
