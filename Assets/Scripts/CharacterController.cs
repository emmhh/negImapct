using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    //Following Code manages the age of the character, once the age reaches 80, it dies and resets the game.
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            age = value;

            // Check if age is 80 or above
            if (age >= 80)
            {
                Die();
            }
        }
    }

    private void Die()
    {
        // Inform the GameManager about character death
        GameManager.Instance.CharacterDied();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
