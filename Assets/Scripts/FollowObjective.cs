using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObjective : MonoBehaviour
{
    [SerializeField] Transform objective;
    [SerializeField] Vector3 offset;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        transform.position = objective.position + offset;
    }
}
