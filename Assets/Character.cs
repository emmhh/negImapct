using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetHairColor(Color color)
    {
       Renderer hair = transform.Find("root").Find("pelvis").Find("spine_01").Find("spine_02").Find("spine_03").Find("neck_01").Find("head").Find("Hair01").GetComponent<Renderer>();
        hair.material.color = color;
    }
  
}
