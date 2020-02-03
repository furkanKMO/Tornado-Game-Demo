using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemysidemove : MonoBehaviour
{
    private float delta = 7f;  // Amount to move left and right from the start point
    private float speed = 4f;
    private Vector3 startPos;
    private bool hit = false;

    void Start()
    {
        startPos = transform.position;
    }

    void FixedUpdate()
    {
        if (start.MoveAllowed)
        {
            if (!hit)
            {
                Vector3 v = startPos;
                v.x += delta * Mathf.Sin(Time.time * speed);
                transform.position = v;
            }
        }
       
    }
    public void OnCollisionEnter(Collision other)
    {
        if (start.MoveAllowed)
        {
            if (other.gameObject.tag == "cylone")
            {
                hit = true;

                // how much the character should be knocked back
                var magnitude = 5000;
                // calculate force vector
                var force = transform.position - other.transform.position;
                // normalize force vector to get direction only and trim magnitude
                force.Normalize();
                gameObject.GetComponent<Rigidbody>().AddForce(force * magnitude);
            }
        }
    }
}
