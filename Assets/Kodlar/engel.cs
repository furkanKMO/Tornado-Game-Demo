using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engel : MonoBehaviour
{

    public void OnCollisionEnter(Collision other)
    {
        if (start.MoveAllowed)
        {
            if (other.gameObject.tag == "cylone")
            {


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
