using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFlip : MonoBehaviour
{
    [SerializeField] private Transform Aim;

    private SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.flipY = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Aim.rotation.eulerAngles.z < 90 || Aim.rotation.eulerAngles.z > 270)
        {
            sprite.flipY = false;
        }
        else
        {
            sprite.flipY = true; 
        }
    }
}
