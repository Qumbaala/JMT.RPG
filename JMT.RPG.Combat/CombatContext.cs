﻿using JMT.RPG.Core.Contracts.Combat;

namespace JMT.RPG.Combat
{
    public record CombatContext
    {
        public int TurnNumber { get; set; }
        public CombatantState[] CombatantContexts { get; set; }        
    }
}