using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : MonoBehaviour
{
    public Material currentMat;
    public SpriteRenderer SR;
    private void Start()
    {
        SR.material = Instantiate(currentMat);
    }
}
