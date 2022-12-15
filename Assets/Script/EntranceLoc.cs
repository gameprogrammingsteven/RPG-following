using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceLoc : MonoBehaviour
{

    public string fromScene; // null if Edit

    // Start is called before the first frame update
    void Start()
    {
        if( (fromScene != null) && (fromScene == PlayerController.instance.fromScene)) //User Preferences better.
        {
            PlayerController.instance.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
