using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectangleGenerator : MonoBehaviour
{
    public GameObject rectanglePrefab;
    Transform RT;
    Vector2 rectStart;
    public bool rect = false;
    void Update()
    {
        if (rect)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (mousePos.x > -8 && mousePos.x < 6 && mousePos.y < 4.5 && mousePos.y > -4.5)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    GameObject newRect = Instantiate(rectanglePrefab);
                    RT = newRect.GetComponent<RectTransform>();
                    rectStart = mousePos;
                }
                if (Input.GetMouseButton(0))
                {
                    UpdateRect(mousePos);
                }
                if (Input.GetMouseButtonUp(0))
                {
                    UpdateRect(mousePos);
                }
            }
        }
    }
    void UpdateRect(Vector2 mousePos)
    {
        Vector3 rectDiameter = rectStart - mousePos;
        RT.position = (rectStart + mousePos) / 2;
        RT.localScale = rectDiameter;
    }
    public void EnableRectangle()
    {
        rect = true;
    }
    public void DisableRectangle()
    {
        rect = false;
    }
}
