using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineColor : MonoBehaviour
{
    public Material currentMat;
    public Material red;
    public Material blue;
    public Material black;
    public Material green;
    public Material yellow;
    public Material pink;
    public Material purple;
    public Material brown;
    public Material turqoise;
    public Material orange;
    public Material eraser;
    public void ChangeEraser()
    {
        currentMat.color = eraser.color;
    }
    public void ChangeColorRed()
    {
        currentMat.color=red.color;
    }
    public void ChangeColorBlue()
    {
        currentMat.color = blue.color;
    }
    public void ChangeColorGreen()
    {
        currentMat.color = green.color;
    }
    public void ChangeColorYellow()
    {
        currentMat.color = yellow.color;
    }
    public void ChangeColorPink()
    {
        currentMat.color = pink.color;
    }
    public void ChangeColorPurple()
    {
        currentMat.color = purple.color;
    }
    public void ChangeColorOrange()
    {
        currentMat.color = orange.color;
    }
    public void ChangeColorBrown()
    {
        currentMat.color = brown.color;
    }
    public void ChangeColorTurqoise()
    {
        currentMat.color = turqoise.color;
    }
    public void ChangeColorBlack()
    {
        currentMat.color = black.color;
    }
}
