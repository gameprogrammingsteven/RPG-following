using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float playerSpeed = 800;

    public Animator animator;

    bool safeCheck = false;
    // Start is called before the first frame update
    void Start()
    {
        if(rigidBody != null && animator != null) //performant safety in code;
        {
            safeCheck = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!safeCheck)
        {
            return;
        }

        float hVelocity = (Input.GetAxisRaw("Horizontal") * Time.deltaTime * playerSpeed);
        float yVelocity = (Input.GetAxisRaw("Vertical") * Time.deltaTime * playerSpeed);

        rigidBody.velocity = new Vector2(hVelocity, yVelocity);
    }
}
