using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidePanelOpen : MonoBehaviour
{
    public GameObject SidePanel;
    public GameObject containerToOpen;
    public GameObject containerToClose;
    static private GameObject activeContainer;

    public void OpenPanel()
    {

        if (SidePanel != null)
        {
            Animator animator = SidePanel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("open");



                if(isOpen)  //gdy jest otwarty
                {
                    if (activeContainer == containerToOpen) //zamknij
                    {

                        animator.SetBool("open", false);
                        activeContainer = null;

                    }
                    else      // zmienia panel boczny
                    {
                        activeContainer = containerToOpen;
                        containerToOpen.SetActive(true);
                        containerToClose.SetActive(false);

                    }
                }
                else   // gdy jest zamkniety
                {
                    containerToOpen.SetActive(true);
                    activeContainer = containerToOpen;
                    containerToClose.SetActive(false);

                    animator.SetBool("open", true);
                }


            }   //koniec


        }
    }
}
