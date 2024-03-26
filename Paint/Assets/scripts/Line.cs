using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Line : MonoBehaviour
{
    public LineRenderer LR;
    public Material currentMat;
    float width;
    public Slider wid;
    List<Vector3> points;
    public void Start()// settings of the line(color,width,texture/material)
    {
        width = wid.value;
        LR.material = Instantiate(currentMat);
        LR.SetWidth(width, width);
    }
    public void UpdateLine(Vector2 position,int layer)// Adds points in to the line renderer 
    {
        
        if (points == null)//finds out if the line is new or if it is being continued
        {
            points = new List<Vector3>();
            SetPoint(position,layer);
            return;
        }
        if (Vector2.Distance(points.Last(), position) > 0.1f)// finds out if the new point is not the same as the last point of the line (no duplicat points)
        {
            SetPoint(position,layer);
        }
    }
    void SetPoint(Vector2 point,int layer)//Adds current point to list of points that the line follows
    {
        Vector3 point3 = new Vector3(point.x, point.y, layer);
        points.Add(point3);
        LR.positionCount = points.Count;
        LR.SetPosition(points.Count - 1, point3);
    }
}
