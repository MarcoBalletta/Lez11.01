using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI goBackText;
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

}
