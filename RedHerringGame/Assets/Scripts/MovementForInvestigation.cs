using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementForInvestigation : MonoBehaviour
{
    public bool isInputEnabled = true;
    public float inputX;
    public float inputY;
    private Vector2Int cursorLocation = new Vector2Int(0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2Int screenOffset = new Vector2Int(Screen.width / 2, Screen.height / 2);
        Vector2Int screenNegClamp = new Vector2Int(0 - Screen.width / 2, 0 - Screen.height / 2);
        Vector2Int screenPosClamp = new Vector2Int(Screen.width / 2, Screen.height / 2);
        float inputX;
        float inputY;
        //Debug.Log(distanceToOriginPlane);
        if (isInputEnabled)
        {
            inputX = Input.GetAxis("Horizontal");
            inputY = Input.GetAxis("Vertical");
        }
        else
        {
            inputX = 0f;
            inputY = 0f;
        }
        Vector2 direction = new Vector2(inputX, inputY);
        Vector2 deltaMovement = direction * Time.deltaTime;
        Vector2Int deltaMovementInt = new Vector2Int((int)deltaMovement.x, (int)deltaMovement.y);
        cursorLocation += deltaMovementInt;
        cursorLocation.Clamp(screenNegClamp, screenPosClamp);


        Vector3 cursor2Screen = new Vector3(cursorLocation.x + screenOffset.x, cursorLocation.y + screenOffset.y, 0);
    }
}
