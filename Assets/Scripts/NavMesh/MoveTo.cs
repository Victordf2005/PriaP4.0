   using UnityEngine;
   using UnityEngine.AI;
    
   public class MoveTo : MonoBehaviour {
       
      public Transform goal;
      NavMeshAgent agent;
       
      void Start () {
         agent = GetComponent<NavMeshAgent>();
      }

      void Update() {
         if (Mathf.Abs((goal.position - transform.position).magnitude) > 1 ) {
            Debug.Log($"Voy de {transform.position} a {goal.position}");
            agent.destination = goal.position;
         }
      }
   }