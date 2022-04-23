using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour
{
    NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 3f;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                agent.SetDestination(hit.point);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mana")
        {
            agent.speed = 0.5f;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Mana")
        {
            agent.speed = 0.5f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Mana")
        {
            agent.speed = 3f;
        }
    }
}
