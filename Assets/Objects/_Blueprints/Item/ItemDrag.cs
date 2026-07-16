using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrag : MonoBehaviour
{
    [SerializeField] private bool isDragging = false;

    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;

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
            // casting to vector2 removes Z position
            transform.position = (Vector2)(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }

    // on mouse click
    private void OnMouseDown()
    {
        isDragging = !isDragging;
    }

    private void DropObject()
    {
        isDragging = false;
    }
}
