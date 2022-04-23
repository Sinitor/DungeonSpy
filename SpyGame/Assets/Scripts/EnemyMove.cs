using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] waypoints;
    private int waipointsIndex;
    private Vector3 target;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }
    private void Update()
    {
        if (Vector3.Distance(transform.position, target) < 1.2)
        {
            WaypointIndex();
            UpdateDestination();
        }
    } 
    private void UpdateDestination()
    {
        target = waypoints[waipointsIndex].position;
        agent.SetDestination(target);
    } 
    private void WaypointIndex()
    {
        waipointsIndex++;
        if (waipointsIndex == waypoints.Length)
        {
            waipointsIndex = 0;
        }
    }
}
