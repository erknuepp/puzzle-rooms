using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Vector3 RotateAmount;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotateAmount * Time.deltaTime);
    }
}
