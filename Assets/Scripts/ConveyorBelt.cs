using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 direction = Vector3.forward;
    public List<GameObject> onBelt = new List<GameObject>();

    void Update()
    {
        for (int i = onBelt.Count - 1; i >= 0; i--)
        {
            if (onBelt[i] == null)
            {
                onBelt.RemoveAt(i);
                continue;
            }

            Rigidbody rb = onBelt[i].GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = direction.normalized * speed;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!onBelt.Contains(collision.gameObject))
        {
            onBelt.Add(collision.gameObject);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        onBelt.Remove(collision.gameObject);
    }
}
