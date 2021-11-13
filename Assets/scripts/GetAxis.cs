using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Debug.Log(x);
    }
}
