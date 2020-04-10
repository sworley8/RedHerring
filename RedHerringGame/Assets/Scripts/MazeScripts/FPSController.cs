using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    [SerializeField] private string horizontalInputName, verticalInputName;
    public CharacterController cc;

    public bool iswalk;
    public float walkspeed = 30.0f;
    public float runspeed = 65.0f;
    public float jumpSpeed = 5.0f;
    public float jumpForce;
    public float speed;
    public bool isJump;
    [SerializeField] private AnimationCurve jumpOff;
    //[Range(0.5f, 10f)]
    //public float mouseSensitivity;
    private void Awake()
    {
        cc = GetComponent<CharacterController>();
    }
    

    private void Update()
    {
        iswalk = !Input.GetKey(KeyCode.E);
        playerMove();
    }
    private void playerMove()
    {
        speed = iswalk ? walkspeed : runspeed;
        float vertInput = Input.GetAxis(verticalInputName) * speed * Time.deltaTime;
        float horInput = Input.GetAxis(horizontalInputName) * speed * Time.deltaTime;
        //Debug.Log(Input.GetAxis(horizontalInputName));
        //float horInput = 1;
        Vector3 forMove = transform.forward * vertInput;
        Vector3 rMove = transform.right * horInput;
        cc.SimpleMove(forMove + rMove);
        jumpIn();


    }
    private void jumpIn()
    {
        if (Input.GetKey(KeyCode.Space) && !isJump)
        {
            isJump = true;
            StartCoroutine(jumping());
        }
    }
    private IEnumerator jumping()
    {
        float timeInAir = 0.0f;
        do
        {
            jumpForce = jumpOff.Evaluate(timeInAir);
            cc.Move(Vector3.up * jumpForce * jumpSpeed * Time.deltaTime);
            timeInAir += Time.deltaTime;
            yield return null;
        } while (!cc.isGrounded && cc.collisionFlags != CollisionFlags.Above);
        isJump = false;
        
    }
    //private void cameraRotate()
    //{
    //    float mouseX = Input.GetAxis(mouseXInputName) * mouseSensitivity * Time.deltaTime;
    //    float mouseY = Input.GetAxis(mouseYInputName) * mouseSensitivity * Time.deltaTime;
    //    transform.Rotate(-transform.right * mouseY);
    //}
    //float forward = Input.GetKey(KeyCode.W) ? 1 : Input.GetKey(KeyCode.S) ? -1f : 0f;
    //float sideward = Input.GetKey(KeyCode.A) ? -1 : Input.GetKey(KeyCode.D) ? 1f : 0f;
    //private Vector3 moveDirection = Vector3.zero;

    //void Start()
    //{
    //    characterController = GetComponent<CharacterController>();
    //}

    //void Update()
    //{
    //    if (characterController.isGrounded)
    //    {
    //        // We are grounded, so recalculate
    //        // move direction directly from axes
    //        //iswalk = !Input.GetKey(KeyCode.LeftShift);

    //        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
    //        //speed = iswalk ? walkspeed : runspeed;
    //        speed = 6f;
    //        moveDirection *= speed;

    //        if (Input.GetButton("Jump"))
    //        {
    //            moveDirection.y = jumpSpeed;
    //        }
    //    }
    //    else
    //    {

    //        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
    //        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
    //        // as an acceleration (ms^-2)
    //        moveDirection.y -= gravity * Time.deltaTime;
    //    }

    //    // Move the controller
    //    characterController.Move(moveDirection * Time.deltaTime);
    //}
}
