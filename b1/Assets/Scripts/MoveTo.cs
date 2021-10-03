using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 
    
public class MoveTo : MonoBehaviour {
    private NavMeshAgent agent;
    public LayerMask canBeClickedOn;
    
    
    void Start() {
        agent = GetComponent<NavMeshAgent>();
    }
        
    void Update() {
         if (Input.GetMouseButtonDown(1)) {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
                
        if (Physics.Raycast(myRay, out hit, 100, canBeClickedOn)) {
            agent.SetDestination(hit.point);
            agent.velocity = Vector3.zero;
            }
        }
        
    }
}
