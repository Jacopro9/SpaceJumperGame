using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyImpact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
        Object.Destroy(gameObject, 0.3f);
    }

}
