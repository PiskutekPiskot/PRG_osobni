using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    public Material currentMat;
    public SpriteRenderer SR;
    private void Start()
    {
        SR.material = Instantiate(currentMat);
    }
}
