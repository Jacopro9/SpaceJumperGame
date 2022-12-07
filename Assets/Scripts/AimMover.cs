using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimMover : MonoBehaviour
{
    [SerializeField] SpriteRenderer player;
    //[SerializeField] private Transform player;
    //private Vector3 temp;
    // Update is called once per frame
    void Update()
    {
        //temp = new Vector3(1.0f, 1.0f, 1.0f);
        //if (player.localScale == temp)
        //{
        //    transform.localPosition = new Vector3 (-0.33f, transform.localPosition.y, transform.localPosition.z);
        //}
        //else
        //{
        //    transform.localPosition = new Vector3 (0.33f, transform.localPosition.y, transform.localPosition.z);
        //}
        if (!player.flipX)
        {
            transform.localPosition = new Vector3(-0.33f, transform.localPosition.y, transform.localPosition.z);
        }
        else
        {
            transform.localPosition = new Vector3(0.33f, transform.localPosition.y, transform.localPosition.z);
        }
    }
}
