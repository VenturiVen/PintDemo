using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class DragTest : MonoBehaviour
{

    [SerializeField] private bool isDragging = false;
    [SerializeField] private bool isRotating = false;

    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;

    // player set settings

    // originally had this to allow players to switch between hold to drag or toggle drag
    // but felt clunky once more controll of the dragged object was added
    // [SerializeField] public bool toggle = false; // if true, dont have to hold down LMB to drag object; if false, hold down LMB to drag object, if LMB is released then it is dropped

    // originally had OnMouseDrag() as an option, so that player can click and hold to pick up object
    // but with this one it felt really weird to use and didnt work propely if toggle was enabled
    // [SerializeField] public bool click = false; // if true, a simple click will let you drag the object; if false, hold briefly to carry object

    void Update()
    {

        // cursor doesnt have to be over the object collider
        if (Input.GetKey(KeyCode.Mouse1))
        {
            DropObject();
            transform.Rotate(0, 0, 0);
        }

        if (isDragging)
        {
            //Detect if the middle mouse button is pressed
            if (Input.GetKey(KeyCode.Mouse2))
            {
                isDragging = false;
                isRotating = true;
            }

            // casting to vector2 removes Z position
            transform.position = (Vector2)(Camera.main.ScreenToWorldPoint(Input.mousePosition)); 
        }

        if (isRotating)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                DropObject();
            }

            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            float y = verticalSpeed * Input.GetAxis("Mouse Y");

            transform.Rotate(0, 0, (h + y));
        }
    }

    // on mouse click
    private void OnMouseDown()
    {
        if (isRotating)
        {
            DropObject();
        }
        else
        {
            isDragging = !isDragging;
        }
    }  

    private void DropObject()
    {
        isDragging = false;
        isRotating = false;
    }
}
