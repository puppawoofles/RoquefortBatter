using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persist : MonoBehaviour
{

    public double startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.timeAsDouble;
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
