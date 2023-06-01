   using UnityEngine;
   using UnityEngine.AI;
    
   public class Persecutor : MonoBehaviour {
       
      public Transform goal;
      NavMeshAgent agent;
       
      void Start () {
         agent = GetComponent<NavMeshAgent>();
         agent.destination = goal.position;
      }

      void Update() {
         if (Vector3.Distance(transform.position, goal.position) > 1.5f ) agent.destination = goal.position;
      }
   }