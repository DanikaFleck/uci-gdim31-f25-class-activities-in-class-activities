using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...
public class DeerW5W5 : MonoBehaviour
{
    
    [SerializeField] private NavMeshAgent nav;
    [SerializeField] private Transform mushroom;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        nav.SetDestination(mushroom.position);
    }
}
