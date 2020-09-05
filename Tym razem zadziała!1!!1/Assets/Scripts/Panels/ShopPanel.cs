using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPanel : MonoBehaviour
{

    public GameObject panel;
    public Animator animator;

    public void OpenPanel(){

        panel.SetActive(true);
        animator.SetTrigger("Open");
        
    }

    public void ClosePanel()
    {
        animator.SetTrigger("Close");
        Invoke("Paneloff", 1);
        
    }

    private void Paneloff()
    {

        panel.SetActive(false);

    }
}

    
