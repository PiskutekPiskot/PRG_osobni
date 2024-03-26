using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTexture : MonoBehaviour
{
    public Material currentMat;
    public Material pen;
    public Material highlighter;
    public Material brush;
    public Material test;
    public void Pen()
    {
        currentMat.mainTexture = pen.mainTexture;
    }
    public void Highlighter()
    {
        currentMat.mainTexture = highlighter.mainTexture;
    }
    public void Brush()
    {
        currentMat.mainTexture = brush.mainTexture;
    }
}
