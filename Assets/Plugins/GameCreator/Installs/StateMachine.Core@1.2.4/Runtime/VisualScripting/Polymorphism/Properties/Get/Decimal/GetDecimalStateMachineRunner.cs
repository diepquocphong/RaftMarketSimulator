﻿using System;
using UnityEngine;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.Variables;
using NinjutsuGames.StateMachine.Runtime.Common;
using NinjutsuGames.StateMachine.Runtime.Variables;

namespace NinjutsuGames.StateMachine.Runtime
{
    [Title("State Machine Runner Variable")]
    [Category("Variables/State Machine Runner Variable")]
    [Image(typeof(IconStateMachine), ColorTheme.Type.Yellow, typeof(OverlayBolt))]
    [Description("Returns the decimal value of a State Machine Runner Variable")]
    [Serializable]
    [HideLabelsInEditor]
    public class GetDecimalStateMachineRunner : PropertyTypeGetDecimal
    {
        [SerializeField] protected FieldGetStateMachineRunner m_Variable = new(ValueNumber.TYPE_ID);

        public override double Get(Args args) => m_Variable.Get<double>(args);

        public static PropertyGetDecimal Create => new(
            new GetDecimalStateMachineRunner()
        );

        public override string String => m_Variable.ToString();
    }
}