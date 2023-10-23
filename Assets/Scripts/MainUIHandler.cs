using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainUIHandler : MonoBehaviour  
{
    // ENCAPSULATION
    [SerializeField] private TMP_Text selectedAnimalText;
    [SerializeField] private TMP_Text instructionText;
    [SerializeField] private TMP_Text currentPlayerText;

    public string Selected { get; set; }

    //  POLYMORPHISM
    private void Start()
    {
        if (selectedAnimalText == null)
        {
            Debug.LogError("Main UI: 'Selected Text' not assigned");
        }

        if (instructionText == null)
        {
            Debug.LogError("Main UI: 'Instructions Text' not assigned");
        }

        if (currentPlayerText == null)
        {
            Debug.LogError("Main UI: 'Current Player Text' not assigned");
        }
    }

    //  POLYMORPHISM
    private void Update()
    {
        if (Selected == null)
        {
            selectedAnimalText.text = "Nothing Selected";
            instructionText.gameObject.SetActive(true);
        }
        else
        {
            selectedAnimalText.text = Selected;
            instructionText.gameObject.SetActive(false);
        }
    }
}
