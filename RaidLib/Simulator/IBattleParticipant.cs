﻿using RaidLib.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidLib.Simulator
{
    public interface IBattleParticipant
    {
        string Name { get; }

        double TurnMeter { get; }
        double TurnMeterIncreaseOnClockTick { get; }
        int TurnCount { get; }

        Dictionary<Constants.SkillId, int> GetSkillToCooldownMap();
        IEnumerable<Skill> GetPassiveSkills();
        IEnumerable<Skill> AllAvailableSkills();
        Skill NextAISkill();
        Skill GetA1();
        void TakeTurn(Skill skill);
        void AdditionalAttack();
        void ClockTick();

        void ApplyBuff(BuffToApply buff);
        void ApplyDebuff(DebuffToApply debuff);
        void ApplyEffect(Constants.Effect effect);
        void GetAttacked(int hitCount);
        Dictionary<Constants.Buff, int> ActiveBuffs { get; }
        Dictionary<Constants.Debuff, int> ActiveDebuffs { get; }

        bool LeaveOutOfAllyAttack { get; }
        bool IsClanBoss { get; }
        IBattleParticipant Clone();
    }
}
