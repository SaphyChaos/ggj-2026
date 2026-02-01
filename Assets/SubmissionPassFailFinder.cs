using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SubmissionPassFailFinder : MonoBehaviour
{
    [SerializeField]
    public GameManager gameManager;
    public void PassOrFail()
    {
        if(gameManager.GetCurrentClientName() == "Alien")
        { Debug.Log(gameManager.GetCurrentClientName()); }
        else
        {
            Debug.Log(gameManager.GetCurrentClientName());
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
