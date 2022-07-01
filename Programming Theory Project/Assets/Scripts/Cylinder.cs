using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape// INHERITANCE
{
    // Start is called before the first frame update
    protected override void Start()
    {
        kindName = GetType().Name;// POLYMORPHISM
        base.Start();
    }
}
