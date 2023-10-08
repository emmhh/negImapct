using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class restart : MonoBehaviour
{
   void OnButtonClick()
    {
        GameManager.Instance.GameOver();
    }
}
