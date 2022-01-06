using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_FerrisWheel_Animator : MonoBehaviour
{
    public GameObject FerrisWhel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.tag == "TriggerFerris")
        {
            FerrisWhel.GetComponent<Animator>().Play("FerrisWHeel ANimation");
        }
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "TriggerFerris")
    //    {
    //        FerrisWhel.GetComponent<Animator>().Play("FerrisWHeel ANimation");
    //    }
    //}
}
    