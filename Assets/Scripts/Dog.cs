using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animals
{
    [SerializeField] private PlayerController playerController;

    //  POLYMORPHISM
    private void Update()
    {
        if (base.selected)
        {
            transform.Rotate(Vector3.up, 1.0f);
            
        }
    }

    //  POLYMORPHISM
    public override void Selected()
    {
        Debug.Log("Dog Selected");
    }

    //  POLYMORPHISM
    public override void Deselected()
    {
        transform.rotation = new Quaternion();
    }
}

