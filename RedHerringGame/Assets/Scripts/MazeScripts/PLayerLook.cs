using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerLook : MonoBehaviour
{
    public CharacterController characterController;
    [SerializeField] private string mouseXInputName, mouseYInputName;
    [Range(0.5f, 150f)] public float mouseSensitivity;
    [SerializeField] private Transform playerBod;
    public float xAxisClamp;
    public float speed = 2;
    // Start is called before the first frame update
    private void Awake()
    {
        lookCursor();
        xAxisClamp = 0.0f;
    }
    private void lookCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        cameraRotate();
    }
    private void cameraRotate()
    {
        float mouseX = Input.GetAxis(mouseXInputName) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis(mouseYInputName) * mouseSensitivity * Time.deltaTime;
        xAxisClamp += mouseY;
        if (xAxisClamp > 85.0f)
        {
            xAxisClamp = 85.0f;
            mouseY = 0f;
            clampXAxisRotateToVal(270.0f);
        }
        else if (xAxisClamp < -60.0f)
        {
            xAxisClamp = -60.0f;
            mouseY = 0f;
            clampXAxisRotateToVal(90.0f);
        }
        transform.Rotate(Vector3.left * mouseY * speed);
        playerBod.Rotate(Vector3.up * mouseX * speed);

    }
    private void clampXAxisRotateToVal(float val)
    {
        Vector3 eulerRotate = transform.eulerAngles;
        eulerRotate.x = val;
        transform.eulerAngles = eulerRotate;
    }
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
