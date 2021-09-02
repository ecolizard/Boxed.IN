using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    public float smoothing = 0.125f;

    // Start is called before the first frame update
    void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}
