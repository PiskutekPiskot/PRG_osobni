using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonGenerator : MonoBehaviour
{
    public GameObject hexagonPrefab;
    Transform RT;
    Vector2 hexagonStart;
    public bool hexagon = false;
    void Update()
    {
        if (hexagon)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (mousePos.x > -8 && mousePos.x < 6 && mousePos.y < 4.5 && mousePos.y > -4.5)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    GameObject newHexagon = Instantiate(hexagonPrefab);
                    RT = newHexagon.GetComponent<RectTransform>();
                    hexagonStart = mousePos;
                }
                if (Input.GetMouseButton(0))
                {
                    UpdateHexagon(mousePos);
                }
                if (Input.GetMouseButtonUp(0))
                {
                    UpdateHexagon(mousePos);
                }
            }
        }
    }
    void UpdateHexagon(Vector2 mousePos)
    {
        Vector3 hexagonDiameter = hexagonStart - mousePos;
        RT.position = (hexagonStart + mousePos) / 2;
        RT.localScale = hexagonDiameter;
    }
    public void EnableHexagon()
    {
        hexagon = true;
    }
    public void DisableHexagon()
    {
        hexagon = false;
    }
}
