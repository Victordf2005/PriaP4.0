   using UnityEngine;
   using UnityEngine.AI;
    
   public class Persecutor : MonoBehaviour {
       
      public Transform goal;
      NavMeshAgent agent;
       
      void Start () {
         agent = GetComponent<NavMeshAgent>();
      }

      void Update() {
         if (Mathf.Abs((goal.position - transform.position).magnitude) > 1.5 ) {
            agent.destination = goal.position;
         }
      }
   }