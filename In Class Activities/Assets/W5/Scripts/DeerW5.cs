using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...

[RequireComponent(typeof(NavMeshAgent))]
public class DeerW5 : MonoBehaviour
{
    // Set this in the Inspector by dragging the target GameObject here.
    // NOTE: This is a Transform (not a Vector3).
    [SerializeField] private Transform _target;

    private NavMeshAgent _agent;

    private void Start()
    {
        // Get the NavMeshAgent Component on the Deer GameObject
        _agent = GetComponent<NavMeshAgent>();

        // When the game begins, tell the deer where to walk
        
            _agent.SetDestination(_target.position);
        
        
    }
}