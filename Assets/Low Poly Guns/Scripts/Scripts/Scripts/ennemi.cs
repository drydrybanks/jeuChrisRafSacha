using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ennemi : MonoBehaviour
{

    GameObject joueur; //Le joueur

    Vector3 positionDepart; // Position initital

    public float distanceAttaque;

    public float vitesseDeplacement;

    int currentState = 0;

    Vector3 currentSetDestination;

    Animator animator;

    NavMeshAgent navMeshAgent;

    // VieJoueur vieJoueur; // À EFFACER QUAND SCRIPT VIE EXISTERA

    //  Dummy vie;

    bool alive = true;

   



    // Start is called before the first frame update
    void Start()
    {
        currentState = 0;

        joueur = GameObject.FindGameObjectWithTag("Player");

        animator = GetComponent<Animator>();
        currentSetDestination = positionDepart;

        navMeshAgent = GetComponent<NavMeshAgent>();

        

        //===== SECTION À COMPLETER PLUS TARD ============//


        // vie = GetComponent<Dummy>();
        // vieJoueur = GetComponent<VieJoueur>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
