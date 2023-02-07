using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    private Transform PlayerTransform;

    // Start is called before the first frame update
    void Start()
    {
        PlayerTransform = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void lateUpdate()
    {
        transform.position = PlayerTransform.position;
    }
}
