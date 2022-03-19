using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string tag = this.gameObject.tag;
        GameObject[] found = GameObject.FindGameObjectsWithTag(tag);
        if (found.Length == 1) return;

        Persist oldest = null;
        List<Persist> persists = new List<Persist>(found.Length);

        for (int i = 0; i < found.Length; i++)
        {
            Persist persist = found[i].GetComponent<Persist>();
            if (persist == null) continue;
            persists.Add(persist);
            if (oldest == null)
            {
                oldest = persist;
                continue;
            }
            if (oldest.startTime < persist.startTime) continue;
            oldest = persist;
        }

        // There can only be one.
        for (int i = 0; i < persists.Count; i++)
        {
            Persist persist = persists[i];
            if (persist == oldest) return;
            Destroy(persist.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
