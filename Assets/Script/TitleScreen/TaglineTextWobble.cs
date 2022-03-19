using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaglineTextWobble : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
      transform.SetPositionAndRotation(transform.position, Quaternion.Euler(0, 0, Mathf.Sin(Time.time) * 5));
        
    }
}
