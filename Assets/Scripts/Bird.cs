using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animals
{
    // POLYMORPHISM
    public override void Selected()
    {
        Vector3 selectedScale = transform.localScale;
        selectedScale.x *= 2;
        selectedScale.z *= 2;
        transform.localScale = selectedScale;
    }

    //  POLYMORPHISM
    public override void Deselected()
    {
        Vector3 deselectedScale = transform.localScale;
        deselectedScale.x /= 2;
        deselectedScale.z /= 2;
        transform.localScale = deselectedScale;
    }

}
