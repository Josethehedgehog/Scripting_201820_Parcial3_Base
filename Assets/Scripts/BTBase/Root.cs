using UnityEngine;
using UnityEngine.AI;

public class Root : Node
{
    [SerializeField]
    private Node child;


    public override bool Execute()
    {
        agent = GetComponent<NavMeshAgent>();
        return child.Execute();
    }

    public override void SetControlledAI(AIController newControlledAI)
    {
        child.SetControlledAI(newControlledAI);
    }
}