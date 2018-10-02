using UnityEngine;
using UnityEngine.AI;

public abstract class Node : MonoBehaviour
{
    protected AIController ControlledAI { get; set; }
    protected NavMeshAgent agent;
    public abstract bool Execute();

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    public virtual void SetControlledAI(AIController newControlledAI)
    {
        ControlledAI = newControlledAI;
    }
}