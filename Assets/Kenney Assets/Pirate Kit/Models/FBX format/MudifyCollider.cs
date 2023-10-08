using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshCollider))]

public class MudifyCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        Mesh mesh = meshFilter.mesh;

        MeshCollider meshCollider = GetComponent<MeshCollider>();
        meshCollider.sharedMesh = null; // Clear the existing mesh

        // Set the mesh collider to a convex mesh if possible
        if (mesh.isReadable && meshCollider.convex)
        {
            meshCollider.convex = true;
            meshCollider.sharedMesh = mesh;
        }
        else
        {
            // If the mesh is not convex, you might want to consider other solutions,
            // such as creating multiple smaller colliders or using a different collider type.
            Debug.LogWarning("Mesh is not readable or not convex. Mesh Collider cannot be applied.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
