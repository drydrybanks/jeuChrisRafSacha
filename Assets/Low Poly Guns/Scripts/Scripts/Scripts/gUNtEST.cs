using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class gUNtEST : MonoBehaviour
{

    public bool isGrabbed = false;

    public bool peutTirer;

    public Transform boutFusil;

    public GameObject MainG;
    public GameObject MainD;

    public GameObject BalleOG;
    public GameObject BalleClone;

    public AudioSource sonGun;

    [SerializeField] InputActionReference shootInputAction;

    // Start is called before the first frame update
    void Start()
    {
        peutTirer = true;
    }

    // Update is called once per frame
    void Update()
    {

        //  Debug.Log(MainD.GetComponent<Animator>().GetFloat("Trigger"));
        if(isGrabbed == true)
        {
            if (MainD.GetComponent<Animator>().GetFloat("Trigger") >= 0.9f  || MainG.GetComponent<Animator>().GetFloat("Trigger") >= 0.9f )
            {

                if(peutTirer) { 
                peutTirer = false;
                /* BalleClone = Instantiate(BalleOG, BalleOG.transform);
                 BalleClone.SetActive(true);
                 BalleClone.GetComponent<Rigidbody>().AddForce(0, 0, 100);*/
                Debug.Log("BANG");
                Invoke("Shoot", 0);
                }

            }

          /*  if (shootInputAction)
            {
                BalleClone = Instantiate (BalleOG, BalleOG.transform);
                BalleClone.SetActive(true);
                BalleClone.GetComponent<Rigidbody>().AddForce(0, 0, 100);
                Debug.Log("BANG");
            }*/
        }
    }


    private void OnTriggerEnter(Collider other)
    {
      if(other.tag == "Main")
        {
            isGrabbed = true; 
        }

      else
        {
            isGrabbed = false;
        }

    }

    void Shoot()
    {
        sonGun.Play();
        BalleClone = Instantiate(BalleOG, boutFusil.position, boutFusil.rotation);
        BalleClone.SetActive(true);
        BalleClone.GetComponent<Rigidbody>().velocity = transform.TransformDirection(Vector3.forward * 100);

       

        Invoke("ShootAgain", 1);
       
    }

    void ShootAgain()
    {
        peutTirer = true;
    }

   
}
