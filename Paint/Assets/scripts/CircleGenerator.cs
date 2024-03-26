using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleGenerator : MonoBehaviour
{
    public GameObject circlePrefab;
    Transform RT;
    Vector2 circleStart;
    public bool circle=false;

    void Update()
    {
        if (circle)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (mousePos.x > -8 && mousePos.x < 6 && mousePos.y < 4.5 && mousePos.y > -4.5)
            {
                if (Input.GetMouseButtonDown(0))// creates copy of the circle prefab add sets the starting point of the circle
                {
                    GameObject newCircle = Instantiate(circlePrefab);
                    RT = newCircle.GetComponent<RectTransform>();
                    circleStart = mousePos;
                }
                if (Input.GetMouseButton(0))// continuously displays circle as it is being sized
                {
                    UpdateCircle(mousePos);
                }
                if (Input.GetMouseButtonUp(0))// final size of circle
                {
                    UpdateCircle(mousePos);
                }
            }
        }
    }
    void UpdateCircle(Vector2 mousePos)
    {
        Vector3 circleDiameter = circleStart - mousePos;
        RT.position = ((circleStart + mousePos) / 2);
        RT.localScale = circleDiameter;
    }
    public void EnableCircle()
    {
        circle = true;
    }
    public void DisableCircle()
    {
        circle = false;
    }
}
