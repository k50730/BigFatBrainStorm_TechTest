using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Vector3 velocity;
    private CharacterController characterController;

    

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
    }

    void KeyUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W))
            velocity.y += 2;
        if (Input.GetKeyDown(KeyCode.S))
            velocity.y += -2;
    }
}
