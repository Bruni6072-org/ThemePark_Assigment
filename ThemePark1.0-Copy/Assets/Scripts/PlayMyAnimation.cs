using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMyAnimation : MonoBehaviour
{
    [SerializeField] private Animator myAnimatorController;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "TriggerFerris")
        {
            myAnimatorController.SetBool("playSpin1", true);
        }
        //else
        //{
        //    myAnimatorController.SetBool("playSpin1", false);
        //}
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        myAnimatorController.SetBool("playSpin1", true);
    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        myAnimatorController.SetBool("playSpin1", false);
    //    }
    //}
}
