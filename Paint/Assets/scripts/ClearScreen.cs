using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ClearScreen : MonoBehaviour
{
     GameObject[] linesToDelete;
     GameObject lineToDelete;

   string tagToDelete = "lineTag";
    public void Update()//adds any new objects into object list
    {
        linesToDelete = GameObject.FindGameObjectsWithTag(tagToDelete);
    }
    public void clearAll()// deleltes all objects
    {
        foreach (GameObject line in linesToDelete)
        {
            Destroy(line);
        }
    }
    public void clearLast()//deletes last object
    {
        lineToDelete = linesToDelete.Last();
        Destroy(lineToDelete);
    }
   
}
