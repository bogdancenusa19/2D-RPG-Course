using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDashState : PlayerState
{
    public PlayerDashState(Player player, PlayerStateMachine stateMachine, string animBoolName) : base(player, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        stateTimer = player.dashDuration;
    }

    public override void Update()
    {
        base.Update();
        
        if(!player.IsGroundDetected() && player.IsWallDetected())
            stateMachine.ChangeState(player.walSlideState);
        
        player.SetVelocity(player.dashSpeed * player.dashDirection, 0);
        
        if(stateTimer < 0)
            stateMachine.ChangeState(player.idleState);
    }

    public override void Exit()
    {
        base.Exit();
        
        player.SetVelocity(0, rb.velocity.y);
    }
}
