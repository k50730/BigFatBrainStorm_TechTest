using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Vector3 velocity;
    private CharacterController characterController;
    private Vector3 rotation;
    

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        KeyUpdate();
        characterController.Move(velocity * Time.deltaTime);

        transform.Rotate(rotation * 100 * Time.deltaTime);
    }

    void onKeyDown()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            velocity.y += 10;
            rotation = Vector3.back;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            velocity.y += -10;
            rotation = Vector3.forward;
        }
    }
    void onKeyUp() 
    {
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            velocity.y = 0;
            rotation = Vector3.zero;
        }
    }

    void KeyUpdate()
    {
        onKeyDown();
        onKeyUp();
    }
}
