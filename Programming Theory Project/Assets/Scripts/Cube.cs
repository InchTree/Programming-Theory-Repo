using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    // Start is called before the first frame update
    protected override void Start()
    {
        kindName = GetType().Name;
        base.Start();
    }
}
