using System;
using System.Threading.Tasks;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.VisualScripting;
using NinjutsuGames.StateMachine.Runtime.Common;
using NinjutsuGames.StateMachine.Runtime.Variables;
using UnityEngine;

namespace NinjutsuGames.StateMachine.Runtime
{
    [Title("Enable State Machine Node")]
    [Description("Enables a node from State Machine asset")]

    [Category("State Machine/Asset/Enable State Machine Node")]

    [Parameter(
        "Node",
        "The node to execute from the specified State Machine"
    )]
    
    [Keywords("Enable", "Instruction", "Action", "State Machine", "Runner")]
    [Image(typeof(IconStateMachineOverlayGreen), ColorTheme.Type.Blue, typeof(OverlayTick))]
    
    [Serializable]
    public class InstructionStateMachineAssetEnableNode : Instruction
    {
        // MEMBERS: -------------------------------------------------------------------------------

        [SerializeField] private PropertyGetString m_Node = GetNodeStateMachine.Create;
        [SerializeField, HideInInspector] private StateMachineAsset m_StateMachine = null;

        // PROPERTIES: ----------------------------------------------------------------------------

        public override string Title => $"Enable {m_Node}";

        // RUN METHOD: ----------------------------------------------------------------------------

        protected override Task Run(Args args)
        {
            var nodeId = m_Node.Get(args);
            m_StateMachine.EnableNode(nodeId);
            return DefaultResult;
        }
    }
}