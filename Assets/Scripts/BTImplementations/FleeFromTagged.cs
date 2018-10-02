using UnityEngine;
/// <summary>
/// Task that instructs ControlledAI to move away from 'tagged' player
/// </summary>
public class FleeFromTagged : Task
{
    public override bool Execute()
    {

        
        Vector3 dirToChaser = transform.position - chaser.transform.position;

        Vector3 awayFromChaser = transform.position + dirToChaser;

        agent.SetDestination(awayFromChaser);
        return base.Execute();
    }
}