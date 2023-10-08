using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControlDemo : MonoBehaviour
{
    [SerializeField] private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("visible", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
