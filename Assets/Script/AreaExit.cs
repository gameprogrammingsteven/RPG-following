using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AreaExit : MonoBehaviour
{
    public string sceneToUse;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Osamu");
        if(string.IsNullOrEmpty(sceneToUse))
        {
            Debug.Log("Chika");
            return;
        }

        Debug.Log("megane");

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Yuma");
            SceneManager.LoadScene(sceneToUse);
        }
    }
}
