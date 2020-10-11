using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnnotateInstantiate : MonoBehaviour
{
    public Rigidbody Annotation;
    public Transform annotationLocation;


void Update()
    {
        if (Input.GetButtonDown("u"))
        {
            Annotation = Instantiate(Annotation, Camera.main.transform.position, Camera.main.transform.rotation);
        }
    }
}