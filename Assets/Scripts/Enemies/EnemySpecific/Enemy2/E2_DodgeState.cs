using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2_DodgeState : DodgeState
{
    private Enemy2 enemy;
    public E2_DodgeState(Entity entity, Finitestatemachine stateMachine, string animBoolName, D_DodgeState stateData, Enemy2 enemy) : base(entity, stateMachine, animBoolName, stateData)
    {
        this.enemy = enemy;
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if (isDodgeOver)
        {
            if(isPlayerInMaXAgroRange && performCloseRangeAction)
            {
                stateMachine.ChangeState(enemy.meleeAttackState);
            }
            else if(isPlayerInMaXAgroRange && !performCloseRangeAction)
            {
                stateMachine.ChangeState(enemy.rangeAttackState);
            }
            else if (!isPlayerInMaXAgroRange)
            {
                stateMachine.ChangeState(enemy.lookForPlayerState);
            }
        }

        
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
