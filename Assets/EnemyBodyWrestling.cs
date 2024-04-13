using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBodyWrestling : MonoBehaviour
{

    public WrestlingRule wrestlingRule;
    public float checkRadius = 1.0f; 
  
    void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, checkRadius);
        
        foreach (Collider collider in colliders)
        {
            if (collider.gameObject.CompareTag("Floor"))
            {
                wrestlingRule.floored = true;
                Debug.Log("EnemyPinned");
                return;
            }
        }
        
        wrestlingRule.floored = false;
    }
}
