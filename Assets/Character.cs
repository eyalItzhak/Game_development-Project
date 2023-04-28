using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private CharacterController characterController;
    public float speed = 5f;
    float rotatinX = 0f;
    float rotatinY = 0f;
    public float sensitivity = 15f;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        rotatinY += Input.GetAxis("Mouse X") * sensitivity;
        rotatinX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
        rotatinX = Mathf.Clamp(rotatinX, -90f, 90f);
        transform.localEulerAngles = new Vector3(rotatinX, rotatinY, 0);

        // Move the character in the direction of the input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0 || verticalInput != 0)
        {
            Vector3 direction = new Vector3(horizontalInput, 0, verticalInput).normalized;
            direction = transform.TransformDirection(direction);
            float distance = speed * Time.deltaTime;
            direction.y = 0f;
            characterController.Move(direction * distance);
        }
    }
}
