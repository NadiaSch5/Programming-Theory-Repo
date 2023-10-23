using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalManager : MonoBehaviour
{
    // ENCAPSULATION
    [SerializeField] private List<Animals> animalList;

    // ABSTRACTION
    public void DeselectAll()
    {
        foreach(Animals animals in animalList)
        {
            animals.Deselect();
        }
    }
}
