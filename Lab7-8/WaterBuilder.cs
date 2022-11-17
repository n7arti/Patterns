using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBuilder : MonoBehaviour, IBuilder
{
    public GameObject Cell;
    public void PutCell(int x, int y, Transform position)
    {
        var cell = Instantiate(Cell, position);
        cell.transform.position = new Vector3(x, y, 0);
    }
 
}
