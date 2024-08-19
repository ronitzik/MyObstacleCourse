using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAng = 0;
    [SerializeField] float yAng = 0;
    [SerializeField] float zAng = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAng, yAng, zAng);
    }
}
