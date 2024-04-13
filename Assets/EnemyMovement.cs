using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player; 
    public float speed = 2.0f; 
    public Rigidbody rb; 
    public float Distance = 5.0f;
  

    void Update()
    {

        Vector3 direction = (player.position - transform.position).normalized;


        float howFar = Vector3.Distance(transform.position, player.position);

        if (howFar < Distance)
        {
            direction += new Vector3(Random.Range(-10f, 10f), Random.Range(0f, 0f), Random.Range(-10f, 10f)).normalized;
        }

        rb.AddForce(direction * speed);
    }
   
}