using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom_panel : MonoBehaviour
{
    public Animator animator;

    public GameObject Przycisk;

    public GameObject Panel;
    public static GameObject Last_panel;

    public static int active_panel_number;
    public int panel_number;
    private bool czy_otwarty = false;


    public void Toggle_botton_panel()
    {


        if (animator.GetBool("Opened"))     // Gdy jest otwarty  
        {
            if(active_panel_number == panel_number) //zamknij
            {
                animator.SetBool("Opened", false);
                Invoke("Open_delay", .25f);
                Debug.Log(panel_number+" -> zamkniety");

            }
            else                   // zmienia panel_shop na inny
            {
                Last_panel.SetActive(false);
                Last_panel = Panel;
                Panel.SetActive(true);
                active_panel_number = panel_number;

                Debug.Log( active_panel_number + "->"+ panel_number );
            }
            

        }
        else                      // Gdy jest zamknięty
        {
            active_panel_number = panel_number;
            Last_panel = Panel;

            Panel.SetActive(true);
            animator.SetBool("Opened", true);

            Debug.Log("zamkniety -> otwarty");
        }



    }



    private void Open_delay()
    {
        Panel.SetActive(false);
    }


    private void changeCzyOtwarty()
    {
        if(czy_otwarty)
            czy_otwarty = false;
        else
            czy_otwarty = true;
    }


}
