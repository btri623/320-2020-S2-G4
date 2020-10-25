using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using TMPro;
using UnityEngine;

public class APIManager : MonoBehaviour
{
    public GameObject Prefab;
    public GameObject HydrantLayer;
    public string URL;

    // Start is called before the first frame update
    private void Start()
    {
        Request();
    }

    public void Request()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string jsonResponse = reader.ReadToEnd();
        JArray encodedResponse = JArray.Parse(jsonResponse);

        float displacement = 0f;
        foreach (var item in encodedResponse)
        {
            Debug.Log(item);
            
            displacement++;

            
            Vector3 position = new Vector3(float.Parse(item["X"].ToString()), float.Parse(item["Y"].ToString()), float.Parse(item["Z"].ToString()));
            Debug.Log(position);
            GameObject hydrant = GameObject.Instantiate(Prefab, position, Quaternion.identity);
            hydrant.transform.parent = HydrantLayer.transform;
            hydrant.transform.Rotate(270f, 0f, 0f);

        }
    }
}