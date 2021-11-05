using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedProjectile : MonoBehaviour
{

    // Properties
    private float force = 20;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 5f * force;
    }
}
