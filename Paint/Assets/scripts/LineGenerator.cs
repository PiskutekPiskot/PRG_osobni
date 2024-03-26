using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineGenerator : MonoBehaviour
{
    
    public GameObject linePrefab;
    Line activeLine;
    public Slider widthSlider;
    public bool line=true;
    int layer=0;
    void Update()
    {
        if (line)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//get coordinates of mouse
            if (mousePos.x > -8 && mousePos.x < 6 && mousePos.y < 4.5 && mousePos.y > -4.5)//checks if mouse is on the drawing canvas
            {
                if (Input.GetMouseButtonDown(0))
                {
                    GameObject newLine = Instantiate(linePrefab); // creates a clone of the line Prefab
                    activeLine = newLine.GetComponent<Line>();
                    activeLine.wid = widthSlider;
                }
                if (Input.GetMouseButtonUp(0))
                {
                    activeLine = null;
                    layer--;// changes layer of next line, so that it is on top
                }
                if (activeLine != null)
                {
                    activeLine.UpdateLine(mousePos,layer);
                }
            }
        }
    }
    public void EnableLine()
    {
        line = true;
    }
    public void DisableLine()
    {
        line = false;
    }
}
