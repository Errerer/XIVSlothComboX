using FFXIVClientStructs.FFXIV.Client.Game.UI;
using System.Collections.Generic;
using XIVSlothComboX.Core;
using XIVSlothComboX.CustomComboNS;

namespace XIVSlothComboX.Combos.PvP
{
    internal class DRKPvP
    {
        public const uint
            HardSlash = 29085, //重斩
            SyphonStrike = 29086, //吸收斩
            Souleater = 29087, //噬魂斩
            Quietus = 29737,  //寂灭 AOE回血
            Shadowbringer = 29091, //暗影使者  直线伤害 扣血
            Plunge = 29092, //跳斩
            BlackestNight = 29093,  //黑盾
            SaltedEarth = 29094,  // 吸
            Bloodspiller = 29088,  //血溅
            SaltAndDarkness = 29095; //吸 二段止步
        public const uint
            Teleport = 5,
            Return = 6,
            StandardElixir = 29055,
            Recuperate = 29711,
            Purify = 29056,
            Guard = 29054,
            Sprint = 29057;
            

        public class Buffs
        {
            public const ushort
                Blackblood = 3033, //暗血 暗影使者后 连击变成血溅
                BlackestNight = 1038, //黑盾
                SaltedEarthDMG = 3036, //腐秽大地  产生攻击区域
                SaltedEarthDEF = 3037, // 腐秽大地  受到攻击的伤害减少，同时体力会随时间逐渐恢复
                DarkArts = 3034, //暗技  发动暗影使者不消耗体力
                UndeadRedemption = 3039;  //不死救赎
            public const ushort
                 Guard = 3054; //防御
        }
        internal static readonly List<uint>
          MovmentSkills = new() { WARPvP.Onslaught, NINPvP.Shukuchi, DNCPvP.EnAvant, MNKPvP.ThunderClap, RDMPvP.CorpsACorps, RDMPvP.Displacement, SGEPvP.Icarus, RPRPvP.HellsIngress, RPRPvP.Regress, BRDPvP.RepellingShot, BLMPvP.AetherialManipulation, DRGPvP.ElusiveJump, GNBPvP.RoughDivide },
          GlobalSkills = new() { Teleport, Guard, Recuperate, Purify, StandardElixir, Sprint };

        public class Config
        {
            public const string
                ShadowbringerThreshold = nameof(ShadowbringerThreshold);
            public const string
                QuietusThreshold = nameof(QuietusThreshold);
             public const string
                DrkHealThreshold = nameof(DrkHealThreshold);
        }

        internal class DRKPvP_BurstMode : CustomCombo
        {
            protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.DRKPvP_Burst;

            protected override uint Invoke(uint actionID, uint lastComboActionID, float comboTime, byte level)
            {
                // 如果当前动作是基础连击技能之一
                if (actionID is HardSlash or SyphonStrike or Souleater)
                {
                    // 检查是否可以进行技能交织
                    bool canWeave = CanWeave(HardSlash);
                    // 获取暗影使者阈值配置
                    int shadowBringerThreshold = GetOptionValue(Config.ShadowbringerThreshold);
                    // 寂灭阈值配置
                    int QuietusThreshold = GetOptionValue(Config.QuietusThreshold);

                    // 如果启用了跳斩且有目标，并且（不在近战范围内或者在近战范围内且启用了近战跳斩）并且跳斩技能准备好
                    if (IsEnabled(CustomComboPreset.DRKPvP_Plunge) && HasTarget() && ((!InMeleeRange()) || (InMeleeRange() && IsEnabled(CustomComboPreset.DRKPvP_PlungeMelee))) && ActionReady(Plunge))
                        return OriginalHook(Plunge);

                    if (canWeave)
                    {
                        // 如果黑盾技能准备好
                        if (ActionReady(BlackestNight))
                            return OriginalHook(BlackestNight);

                        // 如果暗血效果未激活并且（具有黑魔法效果或玩家血量百分比高于暗影使者阈值）
                        if (!HasEffect(Buffs.Blackblood) && (HasEffect(Buffs.DarkArts) || PlayerHealthPercentageHp() >= shadowBringerThreshold))
                            return OriginalHook(Shadowbringer);

                        if ((HasEffect(Buffs.Guard) || JustUsed(Guard)) && IsEnabled(CustomComboPreset.PvP_MashCancel))
                        {
                            if (actionID == Guard) return Guard;
                            else return OriginalHook(11);
                        }

                        if (Execute() &&
                             InPvP() &&
                            !GlobalSkills.Contains(actionID) &&
                            !MovmentSkills.Contains(actionID))
                            return OriginalHook(Recuperate);
                    }

                    if (InMeleeRange())
                    {
                        // 如果寂灭技能准备好并且血量低于预设阈值
                        if ((ActionReady(Quietus) && PlayerHealthPercentageHp() <= QuietusThreshold) && !HasEffect(Buffs.UndeadRedemption))
                            return OriginalHook(Quietus);

                        // 如果连击时间超过1秒
                        if (comboTime > 1f)
                        {
                            // 如果上一个连击动作是重斩
                            if (lastComboActionID == HardSlash)
                                return OriginalHook(SyphonStrike);

                            // 如果上一个连击动作是吸收斩
                            if (lastComboActionID == SyphonStrike)
                                return OriginalHook(Souleater);
                        }

                        // 返回重斩动作
                        return OriginalHook(HardSlash);
                    }
                }

                return actionID;
            }

            public bool Execute()
            {
                var jobMaxHp = LocalPlayer.MaxHp;
                var threshold = GetOptionValue(Config.DrkHealThreshold);
                var maxHPThreshold = jobMaxHp - 15000;
                var remainingPercentage = (float)LocalPlayer.CurrentHp / (float)maxHPThreshold;


                if (HasEffect(3180)) return false; //DRG LB buff
                if (HasEffect(DRKPvP.Buffs.UndeadRedemption)) return false;
                if (LocalPlayer.CurrentMp < 2500) return false;
                if (remainingPercentage * 100 > threshold) return false;

                return true;

            }
        }

    }
}
