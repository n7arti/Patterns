using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IBuilder
{
    // Start is called before the first frame update
    void PutCell(int x, int y, Transform position);
}
