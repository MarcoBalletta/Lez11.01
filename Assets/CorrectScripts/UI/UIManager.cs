using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI goBackText;
    [SerializeField] private TextMeshProUGUI interactText;
    public static UIManager instance;

    /*public delegate void OnStopMovement();
    public OnStopMovement stopMovement;

    private void Start()
    {
        stopMovement += StoppedMovement;
    }

    /*
     * 
     * Update con stoppedMovement, booleano che permette di accedere
     * 
     */

    private void Start()
    {
        instance = this;
    }

    public void StoppedMovement()
    {
        goBackText.gameObject.SetActive(true);
    }    
    
    public void ResumedMovement()
    {
        goBackText.gameObject.SetActive(false);
    }

    public void CanInteract(string interactable)
    {
        interactText.text += constants.textInteractInteractable + interactable;
        interactText.gameObject.SetActive(true);
    }

    public void CannotInteract()
    {
        interactText.gameObject.SetActive(false);
    }

    public void SetInteractText(string interactable)
    {
        interactText.text = interactable;
    }

}
