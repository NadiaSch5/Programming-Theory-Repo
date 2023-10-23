using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animals : MonoBehaviour
{
    // ENCAPSULATION
    private MainUIHandler uiController;
    protected bool selected;

    [SerializeField] private AnimalManager animalManager;

    // POLYMORPHISM
    private void Start()
    {
        uiController = GameObject.FindWithTag("UIController").GetComponent<MainUIHandler>();
        selected = false;
        Debug.Log("Selected is false");

        if(uiController == null)
        {
            Debug.LogError("Animals: No UIController");
        }

        if(animalManager == null)
        {
            Debug.LogError("Animals: No AnimalsManager");
        }
    }

    private void OnMouseDown()
    {
        Select();
        /*Debug.Log("Mouse Clicked on"+ gameObject.name);*/
    }

    // ABSTRACTION
    private void Select()
    {
        if(!selected)
        {
            animalManager.DeselectAll();
            selected = true;
            uiController.Selected = gameObject.name;
            Selected();
        }
    }

    // ABSTRACTION
    public void Deselect()
    {
        if (selected)
        {
            selected = false;
            Deselected();
        }
    }

    // INHERITANCE
    public abstract void Selected();
    public abstract void Deselected();
}

