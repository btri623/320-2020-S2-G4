using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallApiScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        await CallAzure();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Task CallAzure()
    {
        throw new NotImpementedException();
    }
}
