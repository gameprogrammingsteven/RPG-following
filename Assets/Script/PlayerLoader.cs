using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{

    public GameObject player;
    public Transform startLoc;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerController.instance == null && player)
        {
            Instantiate(player);
           // player.transform.position = startLoc.position;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
