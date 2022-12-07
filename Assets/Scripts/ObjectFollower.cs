using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFollower : MonoBehaviour
{
    [SerializeField] private Transform followedObject;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(followedObject.position.x, followedObject.position.y, transform.position.z);
    }
}
