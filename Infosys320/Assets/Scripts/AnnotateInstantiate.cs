using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnnotateInstantiate : MonoBehaviour
{
    public GameObject Annotation;
   

    public void CreateAnnotation()
    {
        Vector3 annotationPosition = Camera.main.transform.position + Camera.main.transform.forward * 3.0f;
        Quaternion annotationRotation = Camera.main.transform.rotation;
        Annotation = Instantiate(Annotation, annotationPosition, annotationRotation);
    }


    void Update()
    {
        if (Input.GetKeyDown("u"))
        {
            Vector3 annotationPosition = Camera.main.transform.position + Camera.main.transform.forward * 3.0f;
            Quaternion annotationRotation = Camera.main.transform.rotation;
            Annotation = Instantiate(Annotation, annotationPosition, annotationRotation);
        }
    }

}