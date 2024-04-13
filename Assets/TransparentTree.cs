using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentTree : MonoBehaviour
{
    public Transform player;
    public LayerMask mask;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Linecast(transform.position, player.position, out hit, mask))
        {
            Renderer renderer = hit.transform.GetComponent<Renderer>();
            Color originalColor = renderer.material.color;
            renderer.material.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0.5f);
        }
    }
}