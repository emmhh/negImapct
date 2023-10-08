using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddColliderForObj : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject myObject = this.gameObject;

        // Add a Box Collider component to the GameObject
        BoxCollider boxCollider = myObject.AddComponent<BoxCollider>();

        // Adjust collider properties if necessary
        boxCollider.size = new Vector3(1f, 1f, 1f); // Set the size of the Box Collider
        boxCollider.center = new Vector3(0f, 0f, 0f); // Set the center of the Box Collider
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
