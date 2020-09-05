using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ClickZone : MonoBehaviour
{
    public GameObject Player;
    public Animator animator;
 
   
    public void Click()
    {

        animator.SetTrigger("IfClick");
       
    
    }

  
}
