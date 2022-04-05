using XIVSlothComboPlugin.Attributes;
using XIVSlothComboPlugin.Combos;

namespace XIVSlothComboPlugin
{
    /// <summary>
    /// Combo presets.
    /// </summary>
    public enum CustomComboPreset
    {
        // ====================================================================================
        #region Misc

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", ADV.JobID)]
        AdvAny = 0,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", AST.JobID)]
        AstAny = AdvAny + AST.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", BLM.JobID)]
        BlmAny = AdvAny + BLM.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", BRD.JobID)]
        BrdAny = AdvAny + BRD.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DNC.JobID)]
        DncAny = AdvAny + DNC.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DOH.JobID)]
        DohAny = AdvAny + DOH.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DOL.JobID)]
        DolAny = AdvAny + DOL.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DRG.JobID)]
        DrgAny = AdvAny + DRG.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", DRK.JobID)]
        DrkAny = AdvAny + DRK.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", GNB.JobID)]
        GnbAny = AdvAny + GNB.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", MCH.JobID)]
        MchAny = AdvAny + MCH.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", MNK.JobID)]
        MnkAny = AdvAny + MNK.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", NIN.JobID)]
        NinAny = AdvAny + NIN.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", PLD.JobID)]
        PldAny = AdvAny + PLD.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", RDM.JobID)]
        RdmAny = AdvAny + RDM.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", RPR.JobID)]
        RprAny = AdvAny + RPR.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SAM.JobID)]
        SamAny = AdvAny + SAM.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SCH.JobID)]
        SchAny = AdvAny + SCH.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SGE.JobID)]
        SgeAny = AdvAny + SGE.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", SMN.JobID)]
        SmnAny = AdvAny + SMN.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", WAR.JobID)]
        WarAny = AdvAny + WAR.JobID,

        [CustomComboInfo("Any", "This should not be displayed. This always returns true when used with IsEnabled.", WHM.JobID)]
        WhmAny = AdvAny + WHM.JobID,

        [CustomComboInfo("Disabled", "This should not be used.", ADV.JobID)]
        Disabled = 99999,

        #endregion
        // ====================================================================================
        #region ADV
        #endregion
        /*
        #region GLOBAL FEATURES
        [CustomComboInfo("Global Interrupt Feature", "Replaces Stun (LowBlow) with interrupt (Interject) when the target can be interrupted.", All.JobID)]
        InterruptFeature = 90000,

        [ConflictingCombos(SchRaiseFeature, WHMRaiseFeature, AstrologianAscendFeature, SageEgeiroFeature)]
        [CustomComboInfo("Global Raise Feature", "Replaces Swiftcast with Raise/Resurrection/Verraise/Ascend/Egeiro when appropriate.", All.JobID)]
        DoMSwiftcastFeature = 90001,

        #endregion
        */
        // ====================================================================================
        #region ASTROLOGIAN

        [CustomComboInfo("Draw on Play", "Play turns into Draw when no card is drawn, as well as the usual Play behavior.", AST.JobID, 0, "Pot of Greed", "Draw some cards, or something. Idk, you're the one that chose to play AST.")]
        AstrologianCardsOnDrawFeaturelikewhat = 1000,

        [CustomComboInfo("Minor Arcana to Crown Play", "Changes Minor Arcana to Crown Play when a card is not drawn or has Lord Or Lady Buff.", AST.JobID, 0, "Bestow Royalty", "This one's for the Lords and Ladies, lemme get a HYEEEAAAAAH!")]
        AstrologianCrownPlayFeature = 1001,

        [CustomComboInfo("Benefic 2 to Benefic Level Sync", "Changes Benefic 2 to Benefic when below level 26 in synced content.", AST.JobID, 0, "Sprout's Benedict Cumberbatch", "Changes Big Benedict into Little Benedict when you visit the sprout universe.")]
        AstrologianBeneficFeature = 1002,

        [ConflictingCombos(AstrologianAlternateAscendFeature)]
        [CustomComboInfo("AST Raise Feature", "Changes Swiftcast to Ascend", AST.JobID, 0, "Rez-bot-3000", "Does your job for you, but faster. You're welcome, little sloth.")]
        AstrologianAscendFeature = 1003,

        [ConflictingCombos(AstrologianAscendFeature)]
        [CustomComboInfo("AST Raise Alternate Feature", "Changes Resurrection To Swiftcast when Swiftcast is available", AST.JobID, 0, "Rez-bot-0003", "Same same, but different!")]
        AstrologianAlternateAscendFeature = 1019,

        [ConflictingCombos(AstrologianAlternateDpsFeature, CustomValuesTest)]
        [CustomComboInfo("DPS Feature(On Malefic)", "Adds Combust to the main malefic combo whenever the debuff is not present or about to expire", AST.JobID, 0, "Green DPS? Look no further", "Adds fatter deeps to your combo. Just pick another job already...")]
        AstrologianDpsFeature = 1004,

        [CustomComboInfo("Lucid Dreaming Feature", "Adds Lucid dreaming to the DPS feature when below 8k mana", AST.JobID, 0, "Lucid SCREAMING Feature", "I heard once you could control your dreams... But then I woke up.")]
        AstrologianLucidFeature = 1008,

        [CustomComboInfo("Astrodyne Feature", "Adds Astrodyne to the DPS feature when ready", AST.JobID, 0, "Astro-whine Feature", "Astro-whining again? Sorry, everyone's busy looking at the SGE's cool floating sticks.")]
        AstrologianAstrodyneFeature = 1009,

        [CustomComboInfo("Aspected Helios Feature", "Replaces Aspected Helios whenever you are under Aspected Helios regen with Helios", AST.JobID, 0, "HELIOSCOPTER", "HELIOSCOPTER HELIOSCOPTER")]
        AstrologianHeliosFeature = 1010,

        [CustomComboInfo("Auto Card Draw", "Adds Auto Card Draw Onto Main DPS Feature", AST.JobID, 0, "Kaiba Feature", "You just activated my trap card!")]
        AstrologianAutoDrawFeature = 1011,

        [CustomComboInfo("Auto Crown Card Draw", "Adds Auto Crown Card Draw Onto Main DPS Feature ", AST.JobID, 0, "Kaiba 2, Electric Boogaloo", "It's a trap!")]
        AstrologianAutoCrownDrawFeature = 1012,

        [CustomComboInfo("AoE DPS Feature", "Adds AutoDraws/Astrodyne to the AoE Gravity combo", AST.JobID, 0, "A bowlful of cards", "Oops! All AoE!")]
        AstrologianDpsAoEFeature = 1013,

        [CustomComboInfo("Lazy Lord Feature", "Adds Lord Of Crowns Onto Main DPS/AoE Feature", AST.JobID, 0, "Brainless Lord Feature", "You're like that tiny guy from Shrek. - E -")]
        AstrologianLazyLordFeature = 1014,

        [CustomComboInfo("Astrodyne on Play", "Play becomes Astrodyne when you have 3 seals.", AST.JobID, 0, "Astro-whine on Play", "Seal me up and let me die, baby")]
        AstrologianAstrodyneOnPlayFeature = 1015,

        [ConflictingCombos(AstrologianDpsFeature, CustomValuesTest)]
        [CustomComboInfo("Alternate DPS Feature (On Combust)", "Adds Combust to the main malefic combo whenever the debuff is not present or about to expire", AST.JobID, 0, "Alternate Deeps, buddy", "Now we're really doing your job for you. Damn.")]
        AstrologianAlternateDpsFeature = 1016,

        [ConflictingCombos(AstrologianDpsFeature, AstrologianAlternateDpsFeature, DisableCombustOnDpsFeature)]
        [CustomComboInfo("DPS Feature Custom Values Testing", "Same as DPSFeature (On Malefic).Allows you to customize target MaxHp & CurrentPercentageHp & CurrentHp checks. Testing Only! ", AST.JobID, 0, "Green DPS? But you looked further...", "Same as that other guy, but with NUMBERS.")]
        CustomValuesTest = 1017,

        [ParentCombo(AstrologianDpsFeature)]
        [ConflictingCombos(AstrologianAlternateDpsFeature)]
        [CustomComboInfo("Removes DoT From DPS Feature", "Removed DoT From the DPS Feature, You can still use all other features that are on malefic! ", AST.JobID, 0, "DPS Less", "Oh, look, guys! Look! This one's actually healing!")]
        DisableCombustOnDpsFeature = 1018,

        [CustomComboInfo("Lightspeed Feature", "Adds Lightspeed to the DPS Feature", AST.JobID, 0, "Warp-speed", "GO FASTER! FASTER!")]
        AstrologianLightSpeedFeature = 1020,

        [ParentCombo(AstrologianHeliosFeature)]
        [CustomComboInfo("Celestial Opposition Feature", "Adds Celestial Opposition", AST.JobID, 0)]
        AstrologianCelestialOppositionFeature = 1021,

        [ParentCombo(AstrologianHeliosFeature)]
        [CustomComboInfo("Lazy Lady Feature", "Adds Lady of Crowns, if the card is drawn", AST.JobID, 0)]
        AstrologianLazyLadyFeature = 1022,
        
        #endregion
        // ====================================================================================
        #region BLACK MAGE

        [ConflictingCombos(BlackSimpleFeature)]
        [CustomComboInfo("Enochian Stance Switcher ++", "Change Scathe to Fire 4 or Blizzard 4 depending on stance.\nScathe becomes all in one rotation.\nIf Thunder Feature is turned on it also adds Thunder3 proces onto all in one combo when DoT is about to expire or dosen't exist\nThis REQUIRES other features to be turned on!!!", BLM.JobID, 0, "BrainLess Mage", "One button, BAYBEE!")]
        BlackEnochianFeature = 2000,

        [CustomComboInfo("Umbral Soul/Transpose Switcher", "Change Transpose into Umbral Soul when Umbral Soul is usable.", BLM.JobID, 0, "Eh? Huh?", "Just does BLM things. Probably.")]
        BlackManaFeature = 2001,

        [CustomComboInfo("(Between the) Ley Lines", "Change Ley Lines into BTL when Ley Lines is active.", BLM.JobID, 0, "BLT Sandwich feature", "Look between, and you shall find")]
        BlackLeyLinesFeature = 2002,

        [ParentCombo(BlackEnochianFeature)]
        [CustomComboInfo("Blizzard 1/2/3 Feature", "Blizzard 1 becomes Blizzard 3 when out of Umbral Ice. Freeze becomes Blizzard 2 when synced.", BLM.JobID, 0, "Chilly boi", "Chill out, for real. It's sleepy sloth time")]
        BlackBlizzardFeature = 2003,

        [ConflictingCombos(BlackEnochianFeature, BlackSimpleFeature)]
        [CustomComboInfo("Scathe/Xenoglossy Feature", "Scathe becomes Xenoglossy when available.", BLM.JobID, 0, "Glossy paint", "So shiny, so glossy...")]
        BlackScatheFeature = 2004,

        [ParentCombo(BlackEnochianFeature)]
        [CustomComboInfo("Fire 1/3", "Fire 1 becomes Fire 3 outside of Astral Fire, OR when Firestarter proc is up.", BLM.JobID, 0, "Burna boi", "It's getting hot in here...")]
        BlackFire13Feature = 2005,

        [ParentCombo(BlackEnochianFeature)]
        [CustomComboInfo("Thunder", "Thunder 1/3 replaces Enochian/Fire 4/Blizzard 4 on Enochian switcher.\n Occurs when Thundercloud is up and either\n- Thundercloud buff on you is about to run out, or\n- Thunder debuff on your CURRENT target is about to run out\nAssuming it won't interrupt timer upkeep.\nEnochian Stance Switcher must be active.", BLM.JobID, 0, "Plug Socket Mode", "Forks at the ready!")]
        BlackThunderFeature = 2006,

        [ParentCombo(BlackEnochianFeature)]
        [CustomComboInfo("Despair Feature", "Despair replaces Fire 4 when below 2400 MP.\nEnochian Stance Switcher must be active.", BLM.JobID, 0, "My MP!", "The horror! The despair!")]
        BlackDespairFeature = 2007,

        [CustomComboInfo("AoE Combo Feature", "One Button AoE Feature that adds whole AoE rotation onto FLARE (TESTING ONLY!!!)", BLM.JobID, 0, "Dungeon Tesla Mode", "Asleep at the wheel? We've got you!")]
        BlackAoEComboFeature = 2008,

        [ParentCombo(BlackEnochianFeature)]
        [CustomComboInfo("Blizzard Paradox Feature", "Adds Paradox onto ice phase combo", BLM.JobID, 0, "The sentence below is false.", "The sentence above is true.")]
        BlackBlizzardParadoxFeature = 2009,

        [ParentCombo(BlackEnochianFeature)]
        [CustomComboInfo("Aspect Swap Feature", "Changes Scathe to Blizzard 3 when at 0 MP in Astral Fire or to Fire 3 when at 10000 MP in Umbral Ice with 3 Umbral Hearts.", BLM.JobID, 0, "", "")]
        BlackAspectSwapFeature = 2010,

        [ParentCombo(BlackThunderFeature)]
        [CustomComboInfo("Thunder Uptime Feature", "Changes Scathe to Thunder 1/3 when not detected on target.", BLM.JobID, 0, "Bzzt", "Shocking!")]
        BlackThunderUptimeFeature = 2011,

        [ConflictingCombos(BlackEnochianFeature, BlackScatheFeature)]
        [CustomComboInfo("Simple BLM", "Adds the whole rotation to one button.", BLM.JobID, 0, "", "")]
        BlackSimpleFeature = 2012,

        [ParentCombo(BlackSimpleFeature)]
        [CustomComboInfo("Simple Buffs Feature", "Adds Manafont, Sharpcast, Amplifier onto the Simple BLM feature.", BLM.JobID, 0, "", "!")]
        BlackSimpleBuffsFeature = 2013,

        [ParentCombo(BlackSimpleFeature)]
        [CustomComboInfo("Simple Buffs - Ley Lines", "Adds Ley Lines onto the Simple BLM feature.", BLM.JobID, 0, "", "!")]
        BlackSimpleBuffsLeylinesFeature = 2014,

        [ParentCombo(BlackSimpleFeature)]
        [CustomComboInfo("Simple Casts Feature", "Adds Triplecast/Swiftcast onto the Simple BLM feature.", BLM.JobID, 0, "", "!")]
        BlackSimpleCastsFeature = 2015,

        [ParentCombo(BlackSimpleFeature)]
        [CustomComboInfo("Simple Casts - Pooling", "Keep one triplecast usage for movement in the Simple BLM feature.", BLM.JobID, 0, "", "!")]
        BlackSimpleCastPoolingFeature = 2016,

        [ParentCombo(BlackSimpleFeature)]
        [CustomComboInfo("Simple Pooling", "Keep one xenoglossy usage for movement in the Simple BLM feature.", BLM.JobID, 0, "", "!")]
        BlackSimplePoolingFeature = 2017,

        [ParentCombo(BlackSimpleFeature)]
        [CustomComboInfo("Simple Fire3 Opener", "Adds the Fire III Opener to Simple BLM.", BLM.JobID, 0, "", "")]
        BlackSimpleOpenerFeature = 2018,

        #endregion
        // ====================================================================================
        #region BLUE MAGE

        [CustomComboInfo("Buffed Song of Torment", "Turns Song of Torment into Bristle so SoT is buffed. \nSpells Required: Song of Torment.", BLU.JobID)]
        BluBuffedSoT = 70000,

        [CustomComboInfo("Moon Flute Opener", "Puts the Full Moon Flute Opener on Moon Flute or Whistle. \nSpells Required: Whistle, Tingle, Moon Flute, J Kick, Triple Trident, Nightbloom, Rose of Destruction, Feather Rain, Bristle, Glass Dance, Surpanakha, Matra Magic, Shock Strike, Phantom Flurry.", BLU.JobID)]
        BluOpener = 70001,

        [CustomComboInfo("Final Sting Combo", "Turns Final Sting into the buff combo of: Moon Flute, Tingle, Whistle, Final Sting. Will use any primals off CD before casting Final Sting. \nSpells Required: Moon Flute, Tingle, Whistle, Final Sting", BLU.JobID)]
        BluFinalSting = 70002,

        [ParentCombo(BluFinalSting)]
        [CustomComboInfo("Off CD Primal Additions", "Adds any Primals that are off CD to the Final Sting Combo. \nPrimals Used: Feather Rain, Shock Strike, Glass Dance, J Kick, Rose of Destruction. ", BLU.JobID)]
        BluPrimals = 70003,

        [CustomComboInfo("Swiftcasted Angel Whisper", "Turns Angel Whisper to Swiftcast when Swiftcast and Angel Whisper are available. \nSpells required: Angel Whisper ", BLU.JobID)]
        BluRez = 70004,

        [CustomComboInfo("Ram's Voice into Ultravibration", "Turns Ultravibration into Ram's Voice if Deep Freeze isn't on the target. Will swiftcast Ultravibration if available. \nSpells Required: Ram's Voice, Ultravibration. ", BLU.JobID)]
        BluUltravibrate = 70005,

        [CustomComboInfo("Tank Debuff Feature", "Puts Devour, Off-Guard, Lucid Dreaming, and Bad Breath into one button when under Tank Mimicry. \nSpells Required: Devour, Off-Guard, Bad Breath.", BLU.JobID)]
        BluDebuffCombo = 70006,

        [CustomComboInfo("Addle/Magic Hammer Debuff Feature", "Turns Magic Hammer into Addle when off CD. \nSpells Required: Magic Hammer.", BLU.JobID)]
        BluAddleFeature = 70007,

        [CustomComboInfo("Primal Feature", "Turns Feather Rain into any Primals that are off CD. \nSpells Required: Feather Rain, Shock Strike, The Rose of Destruction, Glass Dance, J Kick. \nWill cause primals to desync from Moon Flute burst phases if used on CD.", BLU.JobID)]
        BluPrimalFeature = 70008,

        [CustomComboInfo("Knight's Tour Feature", "Turns Black Knight's Tour or White Knight's Tour into its counterpart when the enemy is under the effect of the spell's debuff. \nSpells Required: White Knight's Tour, Black Knight's Tour", BLU.JobID)]
        BluKnightFeature = 70009,

        [CustomComboInfo("Peripheral Synthesis into Mustard Bomb", "Turns Peripheral Synthesis into Mustard Bomb when target is under the effect of Lightheaded. \nSpells Required: Peripheral Synthesis, Mustard Bomb.", BLU.JobID)]
        BluLightheadedCombo = 70010,


        #endregion
        // ====================================================================================
        #region BARD

        [CustomComboInfo("Wanderer's into Pitch Perfect", "Replaces Wanderer's Minuet with Pitch Perfect while in WM.", BRD.JobID, 0, "Braindead Minuet", "Songs for idiots")]
        BardWanderersPitchPerfectFeature = 3000,

        [ConflictingCombos(SimpleBardFeature)]
        [CustomComboInfo("Heavy Shot into Straight Shot", "Replaces Heavy Shot/Burst Shot with Straight Shot/Refulgent Arrow when procced.", BRD.JobID, 0, "This shot into that shot", "You're still using a bow? In this day and age?\nJust play MCH. They have guns, dude.")]
        BardStraightShotUpgradeFeature = 3001,

        [ConflictingCombos(SimpleBardFeature)]
        [ParentCombo(BardStraightShotUpgradeFeature)]
        [CustomComboInfo("DoT Maintenance Option", "Enabling this option will make Heavy Shot into Straight Shot refresh your DoTs on your current.", BRD.JobID, 0, "Butter Maintenance Option", "Slathers butter on your target if butter is not present.")]
        BardDoTMaintain = 3002,

        [ConflictingCombos(BardIronJawsAlternateFeature)]
        [CustomComboInfo("Iron Jaws Feature", "Iron Jaws is replaced with Caustic Bite/Stormbite if one or both are not up.\nAlternates between the two if Iron Jaws isn't available.", BRD.JobID, 0, "Jaws", "Wasn't this guy a James Bond villain in the '70s?")]
        BardIronJawsFeature = 3003,

        [ConflictingCombos(BardIronJawsFeature)]
        [CustomComboInfo("Iron Jaws Alternate Feature", "Iron Jaws is replaced with Caustic Bite/Stormbite if one or both are not up.\nIron Jaws will only show up when debuffs are about to expire.", BRD.JobID, 0, "Mr. Larson", "Oh, and Happy Gilmore!!")]
        BardIronJawsAlternateFeature = 3004,

        [ConflictingCombos(SimpleBardFeature)]
        [CustomComboInfo("Burst Shot/Quick Nock into Apex Arrow", "Replaces Burst Shot and Quick Nock with Apex Arrow when gauge is full and Blast Arrow when you are Blast Arrow ready.", BRD.JobID, 0, "Robin Hood Feature", "Steal from Lolorito and give to Garlemald, I guess?\nGood on ya.")]
        BardApexFeature = 3005,

        [ConflictingCombos(SimpleBardFeature, BardSimpleOpener)]
        [CustomComboInfo("Single Target oGCD Feature", "All oGCD's on Bloodletter (+ Songs rotation) depending on their CD.", BRD.JobID, 0, "oGCD's spilling everywhere", "The Algorithm between the lines. Trademark")]
        BardoGCDSingleTargetFeature = 3006,

        [ConflictingCombos(BardAoEComboFeature)]
        [CustomComboInfo("AoE oGCD Feature", "All AoE oGCD's on Rain of Death depending on their CD.", BRD.JobID, 0, "", "Arrows! Everywhere! Run!")]
        BardoGCDAoEFeature = 3007,

        [ConflictingCombos(BardSimpleAoEFeature)]
        [CustomComboInfo("AoE Combo Feature", "Replaces Quick Nock/Ladonsbite with Shadowbite when ready", BRD.JobID, 0, "", "C-C-C-Combo!")]
        BardAoEComboFeature = 3008,

        [ConflictingCombos(BardStraightShotUpgradeFeature, BardDoTMaintain, BardApexFeature, BardoGCDSingleTargetFeature)]
        [CustomComboInfo("Simple Bard", "Adds every single target ability except DoTs to one button,\nIf there are DoTs on target Simple Bard will try to maintain their uptime.", BRD.JobID, 0, "Sbimple Sbard", "Goodbye, brain. And then there's this feature, too!")]
        SimpleBardFeature = 3009,

        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple Bard DoT Option", "This option will make Simple Bard apply DoTs if none are present on the target.", BRD.JobID, 0, "", "If you don't look at the DoTs, they don't exist.")]
        SimpleDoTOption = 3010,

        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple Bard Song Option", "This option adds the bards songs to the Simple Bard feature.", BRD.JobID, 0, "Sing-song", "Look, a raid contribution feature!\nShame nobody will thank you for it")]
        SimpleSongOption = 3011,

        [ParentCombo(BardoGCDAoEFeature)]
        [CustomComboInfo("Song Feature", "Adds Songs onto AoE oGCD Feature.", BRD.JobID, 0, "", "Get your MIDI files ready, it's song time.")]
        BardSongsFeature = 3012,

        [CustomComboInfo("Bard Buffs Feature", "Adds Raging Strikes and Battle Voice onto Barrage.", BRD.JobID, 0, "", "Buff me up, Judy")]
        BardBuffsFeature = 3013,

        [CustomComboInfo("One Button Songs", "Add Mage's Ballad and Army's Paeon to Wanderer's Minuet depending on cooldowns", BRD.JobID, 0, "EDM songs", "They all sound the same, anyway.")]
        BardOneButtonSongs = 3014,

        [CustomComboInfo("Simple AoE Bard", "Weaves oGCDs onto Quick Nock/Ladonsbite", BRD.JobID, 0, "", "Group attacks to make you feel like you're not the worst Ranged DPS in the room")]
        BardSimpleAoEFeature = 3015,

        [ParentCombo(BardSimpleAoEFeature)]
        [CustomComboInfo("Simple AoE Bard Song Option", "Weave songs on the Simple AoE", BRD.JobID, 0, "", "Wow. You're performing to a crowd now, huh")]
        SimpleAoESongOption = 3016,

        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple Buffs Feature", "Adds buffs onto the Simple Bard feature.", BRD.JobID, 0, "", "Buff for me, buff for you.")]
        BardSimpleBuffsFeature = 3017,

        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple Buffs - Radiant", "Adds Radiant Finale to the Simple Buffs feature.", BRD.JobID, 0, "", "Nothing radiant about it, if you ask me.")]
        BardSimpleBuffsRadiantFeature = 3018,

        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple Raid Mode", "Removes enemy health checking on mobs for buffs, dots and songs.", BRD.JobID, 0, "But Muh Parse", "Just slings all the shit, all the time!")]
        BardSimpleRaidMode = 3019,

        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple Interrupt", "Uses interrupt during simple bard rotation if applicable", BRD.JobID, 0, "Simple Interr-", "Excuse me, I wa-")]
        BardSimpleInterrupt = 3020,

        [CustomComboInfo("Disable Apex Arrow", "Removes Apex Arrow from Simple Bard and AoE Feature.", BRD.JobID, 0, "Disable Apex Legends", "Removing features? You? Surely not")]
        BardRemoveApexArrowFeature = 3021,

        [ConflictingCombos(BardoGCDSingleTargetFeature)]
        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple Opener", "BETA - Adds the optimum opener to simple bard.\nThis conflicts with pretty much everything outside of simple bard options due to the nature of the opener.", BRD.JobID, 0, "Totally hands-off feature", "It's like watching a YouTube video!")]
        BardSimpleOpener = 3022,

        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple Pooling", "BETA - Pools bloodletter chargers to allow for optimum burst phases", BRD.JobID, 0, "Dancer pooling feature", "NOW you're Dancing.")]
        BardSimplePooling = 3023,

        [ParentCombo(BardIronJawsFeature)]
        [CustomComboInfo("Iron Jaws Apex", "Adds Apex and Blast Arrow to Iron Jaws when available", BRD.JobID, 0, "", "Arrows this, jaws that.\nTruly the apex of BRD technology")]
        BardIronJawsApexFeature = 3024,

        [ParentCombo(SimpleBardFeature)]
        [CustomComboInfo("Simple RagingJaws", "BETA - Enable the snapshotting of DoTs, within the remaining time of Raging Strikes below:", BRD.JobID, 0, "No thanks, DoTs", "Wish you'd had changes like SMN in Endwalker? Wish no more!")]
        BardSimpleRagingJaws = 3025,

        #endregion
        // ====================================================================================
        #region DANCER

        // Single Target Multibutton Section
        [CustomComboInfo("Single Target Multibutton", "Change Cascade into procs and combos as available.", DNC.JobID, 0, "All the buttons!", "Now with less buttons!")]
        DancerSingleTargetMultibutton = 4000,

        [ParentCombo(DancerSingleTargetMultibutton)]
        [CustomComboInfo("ST Esprit Overcap Option", "Adds Saber Dance to the Cascade combo if you are at 85 or more Esprit.", DNC.JobID, 0, "Anti-Bean-Spilling Feature", "Uses your magical dancing beans when you're nearly full of 'em")]
        DancerEspritOvercapSTFeature = 4001,

        [ParentCombo(DancerEspritOvercapSTFeature)]
        [CustomComboInfo("ST Instant Saber Option", "Adds Saber Dance to the Cascade combo if you have at least 50 Esprit.", DNC.JobID, 0, "Early Beans Feature", "You in a hurry or something?")]
        DancerEspritOvercapSTInstantOption = 4002,

        [ParentCombo(DancerSingleTargetMultibutton)]
        [CustomComboInfo("Fan Dance Overcap Protection", "Adds Fan Dance 1 onto Cascade when Fourfold Feathers are full.", DNC.JobID, 0, "Fangirl", "Oh my god! Slothy! I'm your biggest fan!")]
        DancerFanDanceMainComboOvercapFeature = 4003,

        [ParentCombo(DancerSingleTargetMultibutton)]
        [CustomComboInfo("Fan Dance On Cascade Feature", "Adds Fan Dance 3/4 onto Cascade when available.", DNC.JobID, 0, "Dan Fance Free/Thour", "Even more feathers? But how?!")]
        DancerFanDance34OnMainComboFeature = 4004,

        // AoE Multibutton Section
        [CustomComboInfo("AoE Multibutton", "Change Windmill into procs and combos as available.", DNC.JobID, 0, "All the buttons! But wider this time!", "Share with your friends! More-less buttons for everyone!")]
        DancerAoEMultibutton = 4010,

        [ParentCombo(DancerAoEMultibutton)]
        [CustomComboInfo("AoE Esprit Overcap Option", "Adds Saber Dance to the Windmill combo if you are at 85 or more Esprit.", DNC.JobID, 0, "Anti-Bean-Spilling Feature", "Uses your magical dancing beans when you're nearly full of 'em")]
        DancerEspritOvercapAoEFeature = 4011,

        [ParentCombo(DancerEspritOvercapAoEFeature)]
        [CustomComboInfo("AoE Instant Saber Option", "Adds Saber Dance to the Windmill combo if you have at least 50 Esprit.", DNC.JobID, 0, "Early Beans Feature", "You in a hurry or something?")]
        DancerEspritOvercapAoEInstantOption = 4012,

        [ParentCombo(DancerAoEMultibutton)]
        [CustomComboInfo("FanDance On Windmill Feature", "Adds FanDance 2/3/4 Onto Windmill When available", DNC.JobID, 0, "Fangirls", "Oh my god! Slothy! We're your biggest fans!")]
        DancerFanDanceOnAoEComboFeature = 4013,

        // Dance Features Section (SS/TS)
        [CustomComboInfo("Dance Features", "Features and options involving Standard Step and Technical Step.\nCollapsing this category does NOT disable the features inside.", DNC.JobID, 0, "Reinventing the wheel", "Stuff in here will make you dizzy. Careful.")]
        DancerMenuDanceFeatures = 4020,

        [ParentCombo(DancerMenuDanceFeatures)]
        [ConflictingCombos(DancerDanceComboCompatibility, DancerCombinedDanceFeature)]
        [CustomComboInfo("Dance Step Combo", "Change Standard Step and Technical Step into each dance step while dancing.", DNC.JobID, 0, "Ez-clap Prancing", "Colorblind? Just an idiot? We've got you covered, little sloth!")]
        DancerDanceStepCombo = 4021,

        [ParentCombo(DancerMenuDanceFeatures)]
        [ConflictingCombos(DancerDanceComboCompatibility, DancerDanceStepCombo)]
        [CustomComboInfo("Combined Dance Feature", "Standard And Technical Dance on one button (SS). Standard > Technical. This combos out into Tillana and Starfall Dance.", DNC.JobID, 0, "Stechnicandard Steppe", "You spin me right round, baby, right round...")]
        DancerCombinedDanceFeature = 4022,

        [ParentCombo(DancerCombinedDanceFeature)]
        [CustomComboInfo("Devilment Plus Option", "Adds Devilment right after Technical finish.", DNC.JobID, 0, "BUT MUH CRIT", "Throw a lil' evil in there.")]
        DancerDevilmentOnCombinedDanceFeature = 4023,

        [ParentCombo(DancerCombinedDanceFeature)]
        [CustomComboInfo("Flourish Plus Option", "Adds Flourish to the Combined Dance Feature.", DNC.JobID, 0, "Custard Option", "It's yellow. I wonder what it tastes like")]
        DancerFlourishOnCombinedDanceFeature = 4024,

        [ParentCombo(DancerMenuDanceFeatures)]
        [ConflictingCombos(DancerDanceStepCombo, DancerCombinedDanceFeature)]
        [CustomComboInfo("Custom Dance Step Feature",
        "Change custom actions into dance steps while dancing." +
        "\nThis helps ensure you can still dance with combos on, without using auto dance." +
        "\nYou can change the respective actions by inputting action IDs below for each dance step." +
        "\nThe defaults are Cascade, Flourish, Fan Dance and Fan Dance II. If set to 0, they will reset to these actions." +
        "\nYou can get Action IDs with Garland Tools by searching for the action and clicking the cog.", DNC.JobID, 0, "Obsessive DNC Feature", "Dude, just code the damn thing yourself at this point. What do you need us for?")]
        DancerDanceComboCompatibility = 4025,

        // Flourishing Features Section
        [CustomComboInfo("Flourishing Features", "Features and options involving Fourfold Feathers and Flourish.\nCollapsing this category does NOT disable the features inside.", DNC.JobID, 0, "Big Bird Features", "It's BIRDIN' Time, y'all.")]
        DancerMenuFlourishingFeatures = 4030,

        //[ParentCombo(DancerMenuGaugeFeatures)]
        //[CustomComboInfo("Fan Dance Combos", "Change Fan Dance and Fan Dance 2 into Fan Dance 3 while flourishing.", DNC.JobID)]
        //DancerFanDanceCombo = 4031,

        [ParentCombo(DancerMenuFlourishingFeatures)]
        [CustomComboInfo("Flourish Proc Saver Feature", "Change Flourish into any available Feather-generating procs before using.", DNC.JobID, 0, "Flourish, but not", "Think it's Flourish? Think again!")]
        DancerFlourishProcFeature = 4032,

        [ConflictingCombos(DancerFlourishProcFanDanceWeaveOption)]
        [ParentCombo(DancerFlourishProcFeature)]
        [CustomComboInfo("Proc Saver Fan Dance Option", "Include Fan Dance 3 & 4 in the proc saver (disregards weave windows).", DNC.JobID, 0, "Big-Bird Pathetic Mode", "This one sucks.")]
        DancerFlourishProcFanDanceOption = 4033,

        [ConflictingCombos(DancerFlourishProcFanDanceOption)]
        [ParentCombo(DancerFlourishProcFeature)]
        [CustomComboInfo("Proc Saver Fan Dance Weave Option", "Include Fan Dance 3 & 4 in the proc saver, ONLY during weave-windows.", DNC.JobID, 0, "Big-Bird Pro Mode", "This one rules!")]
        DancerFlourishProcFanDanceWeaveOption = 4034,

        [ParentCombo(DancerMenuFlourishingFeatures)]
        [CustomComboInfo("Fan Dance Combo Features", "Options for Fan Dance combos. Fan Dance 3 takes priority over Fan Dance 4.\nCollapsing this category disables the options inside.", DNC.JobID, 0, "", "")]
        DancerFanDanceComboFeatures = 4035,

        [ParentCombo(DancerFanDanceComboFeatures)]
        [CustomComboInfo("Fan Dance 1 -> 3", "Changes Fan Dance 1 to Fan Dance 3 when available.", DNC.JobID, 0, "Fan Dance 6 -> 9", "Yeah, we went there.")]
        DancerFanDance1_3Combo = 4036,

        [ParentCombo(DancerFanDanceComboFeatures)]
        [CustomComboInfo("Fan Dance 1 -> 4", "Changes Fan Dance 1 to Fan Dance 4 when available.", DNC.JobID, 0, "Fan Dance 4 -> 20", "Blaze it, or fan dance it, or something. We don't care")]
        DancerFanDance1_4Combo = 4037,

        [ParentCombo(DancerFanDanceComboFeatures)]
        [CustomComboInfo("Fan Dance 2 -> 3", "Changes Fan Dance 2 to Fan Dance 3 when available.", DNC.JobID, 0, "Fan Dance 9 -> 6", "!sdrawkcab lla s'tI")]
        DancerFanDance2_3Combo = 4038,

        [ParentCombo(DancerFanDanceComboFeatures)]
        [CustomComboInfo("Fan Dance 2 -> 4", "Changes Fan Dance 2 to Fan Dance 4 when available.", DNC.JobID, 0, "Fan Dance 20 -> 4", "It's all backwards!")]
        DancerFanDance2_4Combo = 4039,

        // Why does this exist? I can't really think of a use-case for it, but I'm leaving it here in case I missed something
        //[ParentCombo(DancerMenuGaugeFeatures)]
        //[CustomComboInfo("Fan Saber Dance Feature", "Adds Saber Dance onto all Fan Dance skills when no feathers are available and you have 50+ Esprit", DNC.JobID)]
        //DancerSaberFanDanceFeature = 4039,

        [CustomComboInfo("Devilment to Starfall Feature", "Change Devilment into Starfall Dance after use.", DNC.JobID, 0, "ooooh implicit combo or something", "Just press the other button 4hed why is this even a feature")]
        DancerDevilmentFeature = 4040,

        [CustomComboInfo("Simple Dancer (Single Target)", "BETA - Single button, single target dancer. Includes songs, flourishes and overprotections.\nConflicts with all other non-simple toggles. Use at your own risk!", DNC.JobID, 0, "Supid Idiot mode", "Oh no! My brain! It's gone!")]
        DancerSimpleFeature = 4060,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple Interrupt", "Includes an interrupt in the rotation", DNC.JobID, 0, "Simple Interr-", "Excuse me, I wa-")]
        DancerSimpleInterruptFeature = 4061,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple Standard Step", "Includes Standard Step in the rotation", DNC.JobID, 0, "Braindead...brain?", "It's standard, really")]
        DancerSimpleStandardFeature = 4062,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple Technical Step", "Includes Technical Step in the rotation", DNC.JobID, 0, "Braindead Techie", "Well, technically...")]
        DancerSimpleTechnicalFeature = 4063,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple Tech Devilment", "Includes Devilment in the rotation (during Technical Finish).", DNC.JobID, 0, "Little Devil...", "Evil, but smarter.")]
        DancerSimpleDevilmentFeature = 4064,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple Flourish", "Includes Flourish in the rotation", DNC.JobID, 0, "Dummy Flourish", "Darling, you're FLOURISHING!")]
        DancerSimpleFlourishFeature = 4065,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple Feather", "Includes feather usage in the rotation", DNC.JobID, 0, "Did someone say Feather?", "YOU get a feather! And YOU get a feather!")]
        DancerSimpleFeatherFeature = 4066,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple Feather Pooling", "Makes the rotation only use feathers when you have more than 3, or when under the effects of Technical Step", DNC.JobID, 0, "Feather Hoarder", "Mine, all mine...")]
        DancerSimpleFeatherPoolingFeature = 4067,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple Samba", "Includes Shield Samba in the rotation when available (not optimal).", DNC.JobID, 0, "DURRRRR SHIELD", "Brainless, but thick-skinned, at least.")]
        DancerSimpleSambaFeature = 4068,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple Panic Heals", "Includes Curing Waltz and Second Wind in the rotation when available and below 30 and 50 percent HP, respectively.", DNC.JobID, 0, "panik.mp4", "oh god oh fuck oh no quick quick the medkit")]
        DancerSimplePanicHealsFeature = 4069,

        [ParentCombo(DancerSimpleFeature)]
        [CustomComboInfo("Simple Improvisation", "Includes Improvisation in the rotation when available", DNC.JobID, 0, "Camera... ACTION!", "Thinking on your feet? We love that.")]
        DancerSimpleImprovFeature = 4070,

        [CustomComboInfo("Simple Dancer (AOE)", "BETA - Single button aoe dancer, including songs, flourishes and overprotections.\nConflicts with all other non-simple toggles. Use at your own risk!\nExtra features like in simple single target coming soon (after other fixes!)", DNC.JobID, 0, "Stupid Idiot mode WIDEPEEPO", "It's stupid idiot mode again, but for all the family!")]
        DancerSimpleAoeFeature = 4080,

        [ParentCombo(DancerSimpleAoeFeature)]
        [CustomComboInfo("Simple AOE Standard", "Includes Standard Step in the AoE rotation", DNC.JobID, 0, "Standard for everyone", "Y'know...")]
        DancerSimpleAoeStandardFeature = 4081,

        [ParentCombo(DancerSimpleAoeFeature)]
        [CustomComboInfo("Simple AOE Technical", "Includes Technical Step in the AoE rotation", DNC.JobID, 0, "One-step two-step three-step four", "I'm getting really sick")]
        DancerSimpleAoeTechnicalFeature = 4082,

        [ParentCombo(DancerSimpleAoeFeature)]
        [CustomComboInfo("Simple AOE Buffs", "Includes Devilment and Flourish in the AoE rotation", DNC.JobID, 0, "So buffed, so sleek", "Of writing these damn skill descriptions")]
        DancerSimpleAoeBuffsFeature = 4083,

        [ParentCombo(DancerSimpleAoeFeature)]
        [CustomComboInfo("Simple AOE Feathers", "Includes feather usage in the AoE rotation", DNC.JobID, 0, "Literally shitting feathers", "And I'm running out of ideas, too, y'know?")]
        DancerSimpleAoeFeatherFeature = 4084,

        [ParentCombo(DancerSimpleAoeFeature)]
        [CustomComboInfo("Simple AOE Feather Pooling", "Makes it so the AoE rotation only uses feathers when you have more than 3", DNC.JobID, 0, "Pool's closed", "Happy April fools! Gotcha!")]
        DancerSimpleAoeFeatherPoolingFeature = 4085,

        #endregion
        // ====================================================================================
        #region DARK KNIGHT

        [CustomComboInfo("Souleater Combo", "Replace Souleater with its combo chain.", DRK.JobID, 0, "Fetch me their souls!", "Heheheheheh")]
        DarkSouleaterCombo = 5000,

        [CustomComboInfo("Stalwart Soul Combo", "Replace Stalwart Soul with its combo chain.", DRK.JobID, 0, "", "Ugly name for an ugly job")]
        DarkStalwartSoulCombo = 5001,

        [ParentCombo(DarkSouleaterCombo)]
        [ConflictingCombos(DeliriumFeatureOption)]
        [CustomComboInfo("Delirium Feature", "Replace Souleater and Stalwart Soul with Bloodspiller and Quietus when Delirium is active.", DRK.JobID, 0, "", "Delirium is what you have if you choose to play DRK.\nDoc's words, not mine")]
        DeliriumFeature = 5002,

        [CustomComboInfo("Dark Knight Gauge Overcap Feature", "Replace AoE combo with gauge spender if you are about to overcap.", DRK.JobID, 0, "", "Hey big spenderrrrr")]
        DRKOvercapFeature = 5003,

        [ParentCombo(DarkSouleaterCombo)]
        [CustomComboInfo("Living Shadow Feature", "Living shadow will now be on main combo if its not on CD and you have gauge for it.", DRK.JobID, 0, "", "Trick everyone into thinking a party member is standing where they shouldn't be!")]
        DRKLivingShadowFeature = 5004,

        [ParentCombo(DarkSouleaterCombo)]
        [CustomComboInfo("EoS Overcap Feature", "Uses EoS if you are above 8.5k mana or Darkside is about to expire (10sec or less)", DRK.JobID, 0, "Something about mana", "You're basically a black mage! Well done!")]
        DarkManaOvercapFeature = 5005,

        [CustomComboInfo("oGCD Feature", "Adds Living Shadow > Salted Earth > Carve And Spit > Salt And Darkness to Carve And Spit and Abysal Drain", DRK.JobID, 0, "", "Just does your whole job for you, really")]
        DarkoGCDFeature = 5006,

        [ParentCombo(DarkoGCDFeature)]
        [CustomComboInfo("Shadowbringer Feature", "Adds Shadowbringer to oGCD Feature ", DRK.JobID, 0, "", "Wasn't this last expansion?")]
        DarkShadowbringeroGCDFeature = 5007,

        [ParentCombo(DarkSouleaterCombo)]
        [ConflictingCombos(DarkPlungeFeatureOption)]
        [CustomComboInfo("Plunge Feature", "Adds Plunge onto main combo whenever its available (Uses all stacks).", DRK.JobID, 0, "", "Take the plunge. All the way!")]
        DarkPlungeFeature = 5008,

        [ParentCombo(DarkSouleaterCombo)]
        [ConflictingCombos(DarkPlungeFeature)]
        [CustomComboInfo("Plunge Option", "Adds Plunge onto main combo whenever its available (Leaves 1 stack).", DRK.JobID, 0, "", "Take the plunge. Or, just dip your toes in. Whatever.")]
        DarkPlungeFeatureOption = 5009,

        [ParentCombo(DarkSouleaterCombo)]
        [ConflictingCombos(DeliriumFeature)]
        [CustomComboInfo("Delirium Feature Option", "Replaces Souleather with Bloodspiller when Delirium has 10sec or less remaining.", DRK.JobID, 0, "", "Delirium is what you have if you choose to play DRK.\nDoc's words, not mine")]
        DeliriumFeatureOption = 5010,

        [ParentCombo(DarkSouleaterCombo)]
        [CustomComboInfo("Unmend Uptime Feature", "Replace Souleater Combo Feature with Unmend when you are out of range.", DRK.JobID, 0, "Ranged DPS job now, duh", "Stubby little arms, huh")]
        DarkRangedUptimeFeature = 5011,

        [CustomComboInfo("Interrupt Feature", "Replaces Low Blow with Interject when target can be interrupted .", DRK.JobID, 0, "Lower blow", "Blow, but low.")]
        DarkKnightInterruptFeature = 5012,

        [CustomComboInfo("Abyssal Drain Feature", "Adds abyssal drain to the AoE Combo when you fall below 60 percent hp.", DRK.JobID, 0, "", "Even the un-cool kids got heals these days")]
        DRKStalwartabyssalDrainFeature = 5013,

        [CustomComboInfo("AoE Shadowbringer Feature", "Adds Shadowbringer to the AoE Combo.", DRK.JobID, 0, "", "Wasn't this last expansion?")]
        DRKStalwartShadowbringerFeature = 5014,

        [ParentCombo(DarkStalwartSoulCombo)]
        [CustomComboInfo("FoS Overcap Feature", "Uses FoS if you are above 8.5k mana or Darkside is about to expire (10sec or less)", DRK.JobID, 0, "Something about mana", "You're basically a black mage! Well done!")]
        DarkManaOvercapAoEFeature = 5015,

        [ParentCombo(DarkSouleaterCombo)]
        [CustomComboInfo("Blood Gauge Overcap Feature", "Adds Bloodspiller onto main combo when at 80 blood gauge or higher", DRK.JobID, 0, "", "Take the plunge. Or, just dip your toes in. Whatever.")]
        DarkBloodGaugeOvercapFeature = 5016,
        #endregion
        // ====================================================================================
        #region DRAGOON

        [ConflictingCombos(DragoonSimple)]
        [CustomComboInfo("Jump + Mirage Dive", "Replace (High) Jump with Mirage Dive when Dive Ready.", DRG.JobID, 0, "Jump off map", "Oh no, muh double-weaves!")]
        DragoonJumpFeature = 6000,

        [ConflictingCombos(DragoonSimpleAoE)]
        [CustomComboInfo("Coerthan Torment Combo", "Replace Coerthan Torment with its combo chain.", DRG.JobID, 0, "", "One combo!")]
        DragoonCoerthanTormentCombo = 6001,

        [ConflictingCombos(DragoonSimple)]
        [CustomComboInfo("Chaos Thrust Combo", "Replace Chaos Thrust with its combo chain.", DRG.JobID, 0, "", "Two combo!")]
        DragoonChaosThrustCombo = 6002,

        [ParentCombo(DragoonChaosThrustCombo)]
        [CustomComboInfo("Chaos Piercing Talon Uptime", "Replaces Chaos Thrust Combo with Piercing Talon when you are out of range.", DRG.JobID, 0, "", "Never stop hitting them.")]
        DragoonPiercingTalonChaosFeature = 6003,

        [ConflictingCombos(DragoonFullThrustComboPlus, DragoonSimple)]
        [CustomComboInfo("Full Thrust Combo", "Replace Full Thrust with its combo chain.", DRG.JobID, 0, "", "Wait... Three combo?")]
        DragoonFullThrustCombo = 6004,

        [ParentCombo(DragoonFullThrustCombo)]
        [CustomComboInfo("Full Piercing Talon Uptime", "Replaces Full Thrust Combo with Piercing Talon when you are out of range.", DRG.JobID, 0, "", "Never stop hitting them.")]
        DragoonPiercingTalonFullFeature = 6005,

        [ConflictingCombos(DragoonFullThrustCombo, DragoonSimple)]
        [CustomComboInfo("Full Thrust Combo Plus", "Replace Full Thrust Plus Combo with its combo chain (Disembowel/Chaosthrust/life surge added).", DRG.JobID, 0, "", "F- Three combo MORE!")]
        DragoonFullThrustComboPlus = 6006,

        [ParentCombo(DragoonFullThrustComboPlus)]
        [CustomComboInfo("High Jump Plus Feature", "Includes High Jump in the rotation.", DRG.JobID, 0, "", "Jumping, but higher.")]
        DragoonHighJumpPlusFeature = 6007,

        [ParentCombo(DragoonHighJumpPlusFeature)]
        [CustomComboInfo("Mirage Plus Feature", "Includes Mirage in the rotation.", DRG.JobID, 0, "", "They thought they saw it coming.")]
        DragoonMiragePlusFeature = 6008,

        [ParentCombo(DragoonFullThrustComboPlus)]
        [CustomComboInfo("Plus Piercing Talon Uptime", "Replaces Full Thrust with Piercing Talon when you are out of range.", DRG.JobID, 0, "", "Never stop hitting them.")]
        DragoonPiercingTalonPlusFeature = 6009,

        [ConflictingCombos(DragoonFullThrustCombo, DragoonFullThrustComboPlus, DragoonJumpFeature, DragoonChaosThrustCombo, DragoonFangThrustFeature, DragoonFangAndClawFeature)]
        [CustomComboInfo("Simple Dragoon", "One Button, One Dragoon. Conflicts with every non-AoE feature.", DRG.JobID, 0, "", "Nidhogg never stood a chance.")]
        DragoonSimple = 6010,

        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("Simple Opener", "Includes an opener to the Simple Dragoon rotation. NOTE: Requires ReAction or MoAction for optimal Dragon Sight use.", DRG.JobID, 0, "", "Open with a backjump into the wall!")]
        DragoonOpenerFeature = 6011,

        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("Wyrmwind Thrust Feature", "Includes Wyrmwind Thrust to the Simple Dragoon rotation.", DRG.JobID, 0, "", "Blue and red Dragons! Oh my.")]
        DragoonWyrmwindFeature = 6012,

        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("Geirskogul and Nastrond Feature", "Includes Geirskogul and Nastrond in the rotation.", DRG.JobID, 0, "", "Let me chuck another dragon soul at them!")]
        DragoonGeirskogulNastrondFeature = 6013,

        [ConflictingCombos(DragoonLifeLitanyDiveFeature)]
        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("Dives under Litany Features", "Includes Spineshatter Dive and Dragonfire Dive in the rotation, while under Battle Litany, and Stardiver while under Life of the Dragon.", DRG.JobID, 0, "", "Don't jump to your death!")]
        DragoonLitanyDiveFeature = 6014,

        [ConflictingCombos(DragoonLitanyDiveFeature)]
        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("Dives under Litany and Life of the Dragon Features", "Includes Spineshatter Dive and Dragonfire Dive in the rotation, while under Battle Litany and Life of the Dragon, and Stardiver while under Life of the Dragon.", DRG.JobID, 0, "", "Don't jump to your death!")]
        DragoonLifeLitanyDiveFeature = 6015,

        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("High Jump Feature", "Includes High Jump in the rotation.", DRG.JobID, 0, "", "Jumping, but higher.")]
        DragoonHighJumpFeature = 6016,

        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("Mirage Feature", "Includes Mirage in the rotation.", DRG.JobID, 0, "", "They thought they saw it coming.")]
        DragoonMirageFeature = 6017,

        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("Buffs Feature", "Includes Lance Charge and Battle Litany to the rotation.", DRG.JobID, 0, "", "This is why your team loves you.")]
        DragoonBuffsFeature = 6018,

        [ParentCombo(DragoonBuffsFeature)]
        [CustomComboInfo("Dragon Sight Feature", "Includes Dragon Sight to the rotation. OPTIONAL: USE REACTION OR MOACTION FOR OPTIMAL TARGETING.", DRG.JobID, 0, "", "This is why your team loves you, too.")]
        DragoonDragonSightFeature = 6019,

        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("Life Surge Feature", "Includes Life Surge, while under proper buffs, onto proper GCDs, to the rotation.", DRG.JobID, 0, "", "Hit them with more feeling!")]
        DragoonLifeSurgeFeature = 6020,

        [ParentCombo(DragoonSimple)]
        [CustomComboInfo("Simple Piercing Talon Feature", "Replaces Full Thrust Combo with Piercing Talon when you are out of range. NOT OPTIMAL", DRG.JobID, 0, "", "Never stop hitting them.")]
        DragoonSimplePiercingTalonFeature = 6021,

        [ConflictingCombos(DragoonCoerthanTormentCombo)]
        [CustomComboInfo("Simple Dragoon AoE", "One Button, many enemies hit.", DRG.JobID, 0, "", "Never stop hitting them ALL.")]
        DragoonSimpleAoE = 6022,

        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("Wyrmwind Thrust AoE Feature", "Includes Wyrmwind Thrust to the Simple Dragoon AoE rotation.", DRG.JobID, 0, "", "Blue and red Dragons! Oh my.")]
        DragoonAoEWyrmwindFeature = 6023,

        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("Geirskogul and Nastrond AoE Feature", "Includes Geirskogul and Nastrond in the AoE rotation.", DRG.JobID, 0, "", "Let me chuck another dragon soul at them!")]
        DragoonAoEGeirskogulNastrondFeature = 6024,

        [ConflictingCombos(DragoonAoELifeLitanyDiveFeature)]
        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("Dives under Litany AoE Features", "Includes Spineshatter Dive and Dragonfire Dive in the AoE rotation, while under Battle Litany, and Stardiver while under Life of the Dragon.", DRG.JobID, 0, "", "Don't jump to your death!")]
        DragoonAoELitanyDiveFeature = 6025,

        [ConflictingCombos(DragoonAoELitanyDiveFeature)]
        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("Dives under Litany and Life of the Dragon AoE Features", "Includes Spineshatter Dive and Dragonfire Dive in the AoE rotation, while under Battle Litany and Life of the Dragon, and Stardiver while under Life of the Dragon.", DRG.JobID, 0, "", "Don't jump to your death!")]
        DragoonAoELifeLitanyDiveFeature = 6026,

        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("High Jump AoE Feature", "Includes High Jump in the AoE rotation.", DRG.JobID, 0, "", "Jumping, but higher.")]
        DragoonAoEHighJumpFeature = 6027,

        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("Mirage AoE Feature", "Includes Mirage in the AoE rotation.", DRG.JobID, 0, "", "They thought they saw it coming.")]
        DragoonAoEMirageFeature = 6028,

        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("Buffs AoE Feature", "Includes Lance Charge and Battle Litany to the AoE rotation.", DRG.JobID, 0, "", "This is why your team loves you.")]
        DragoonAoEBuffsFeature = 6029,

        [ParentCombo(DragoonAoEBuffsFeature)]
        [CustomComboInfo("Dragon Sight AoE Feature", "Includes Dragon Sight to the AoE rotation. OPTIONAL: USE REACTION OR MOACTION FOR OPTIMAL TARGETING.", DRG.JobID, 0, "", "This is why your team loves you, too.")]
        DragoonAoEDragonSightFeature = 6030,

        [ParentCombo(DragoonSimpleAoE)]
        [CustomComboInfo("Life Surge AoE Feature", "Includes Life Surge, while under proper buffs, onto proper GCDs, to the AoE rotation.", DRG.JobID, 0, "", "Hit them with more feeling!")]
        DragoonAoELifeSurgeFeature = 6031,

        [ConflictingCombos(DragoonSimple)]
        [CustomComboInfo("Wheeling Thrust/Fang and Claw Option", "When you have either Enhanced Fang and Claw or Wheeling Thrust, Chaos Thrust Combo becomes Wheeling Thrust and Full Thrust Combo becomes Fang and Claw. Requires Chaos Thrust Combo and Full Thrust Combo.", DRG.JobID, 0, "ALL THE COMBOS", "Turns Wheeling Thrust into Fire IV when Hallowed or PvP options are active.")]
        DragoonFangThrustFeature = 6032,

        [ConflictingCombos(DragoonSimple)]
        [CustomComboInfo("Wheeling Thrust/Fang and Claw Feature", "Fang And Claw Becomes Wheeling Thrust when under Enhanced Wheeling Thrust Buff.", DRG.JobID, 0, "Reinventing the Wheel", "Absolutely WHEELING, my guy")]
        DragoonFangAndClawFeature = 6033,

        #endregion
        // ====================================================================================
        #region GUNBREAKER

        [CustomComboInfo("Solid Barrel Combo", "Replace Solid Barrel with its combo chain. \nIf all sub options are selected will turn into a full one button rotation (Simple Gunbreaker)", GNB.JobID, 0, "Floppy Barrel Combo", "Not so solid NOW, are ya?")]
        GunbreakerSolidBarrelCombo = 7000,

        [ParentCombo(GunbreakerSolidBarrelCombo)]
        [CustomComboInfo("Gnashing Fang and Continuation on Main Combo", "Adds Gnashing Fang to the main combo. Gnashing Fang must be started manually and the combo will finish it off.\n Useful for when Gnashing Fang needs to be help due to downtime.", GNB.JobID, 0, "Fashing Gnang", "Why grandma, what big teeth you have!")]
        GunbreakerGnashingFangOnMain = 7001,

        [ParentCombo(GunbreakerGnashingFangOnMain)]
        [CustomComboInfo("Sonic Break/Bow Shock/Blasting Zone on Main Combo", "Adds Sonic Break/Bow Shock/Blasting Zone on main combo when under No Mercy buff", GNB.JobID, 0, "Gee Whiz!", "Mom, I can't manage my oGCDs!")]
        GunbreakerCDsOnMainComboFeature = 7002,

        [ParentCombo(GunbreakerGnashingFangOnMain)]
        [CustomComboInfo("Double Down on Main Combo", "Adds Double Down on main combo when under No Mercy buff", GNB.JobID, 0, "ALL the deeps", "For when you're both feeling merciless and are stuffed full of powder. BANG!")]
        GunbreakerDDonMain = 7003,

        [ParentCombo(GunbreakerSolidBarrelCombo)]
        [ConflictingCombos(GunbreakerRoughDivide2StackOption)]
        [CustomComboInfo("Rough Divide Option (Leaves 1 Stack)", "Adds Rough Divide onto main combo whenever it's available (Leaves 1 stack).", GNB.JobID, 0, "Divide... Roughly", "Ayo pour one out for the homie Squall")]
        GunbreakerRoughDivide1StackOption = 7004,

        [ParentCombo(GunbreakerDemonSlaughterCombo)]
        [CustomComboInfo("Bow Shock on AoE Feature", "Adds Bow Shock onto the aoe combo when it's off cooldown. Recommended to use with Gnashing Fang features.", GNB.JobID, 0, "AoE cattleprod enabler")]
        GunbreakerBowShockFeature = 7017,
        
        [ConflictingCombos(GunbreakerRoughDivide1StackOption)]
        [ParentCombo(GunbreakerSolidBarrelCombo)]
        [CustomComboInfo("Rough Divide Option (Uses all stacks)", "Adds Rough Divide onto main combo whenever its available (Uses all stacks).", GNB.JobID, 0, "Divide... Rougher!", "Ayo pour two out for the homie Squall")]
        GunbreakerRoughDivide2StackOption = 7005,

        [CustomComboInfo("Demon Slaughter Combo", "Replace Demon Slaughter with its combo chain.", GNB.JobID, 0, "dEmOn SlAuGhTeR", "Demon Slaughter? Really? What is this, RPR?")]
        GunbreakerDemonSlaughterCombo = 7006,

        [CustomComboInfo("Ammo Overcap Feature", "Uses Burst Strike/Fated Circle on the respective ST/AoE combos when ammo is about to overcap.", GNB.JobID, 0, "Pew Pew Forever", "The whole nine yards")]
        GunbreakerAmmoOvercapFeature = 7007,

        [CustomComboInfo("Gnashing Fang Continuation Combo", "Adds Continuation to Gnashing Fang.", GNB.JobID, 0, "More Mercy", "More, no wait, less, no wait, MORE Mercy! No, wait...")]
        GunbreakerGnashingFangCombo = 7008,

        [ParentCombo(GunbreakerGnashingFangCombo)]
        [CustomComboInfo("No Mercy on Gnashing Fang", "Adds No Mercy to Gnashing Fang when it's ready.", GNB.JobID, 0, "Blue DPS be like", "This one comes with teeth.")]
        GunbreakerNoMercyonGF = 7009,

        [ParentCombo(GunbreakerGnashingFangCombo)]
        [CustomComboInfo("Double Down on Gnashing Fang", "Adds Double Down to Gnashing Fang when No Mercy buff is up.", GNB.JobID, 0, "My hotbars are a (tiny) mess!", "Thanks plogon!")]
        GunbreakerDDOnGF = 7010,

        [ParentCombo(GunbreakerGnashingFangCombo)]
        [CustomComboInfo("CDs on Gnashing Fang", "Adds Sonic Break/Bow Shock/Blasting Zone on Gnashing Fang, order dependent on No Mercy buff. \nBurst Strike added if there's charges while No Mercy buff is up.", GNB.JobID, 0, "More Teeth", "Gnashing fang, but like, if a shark did it. Or something.")]
        GunbreakerCDsOnGF = 7011,

        [CustomComboInfo("BurstStrikeContinuation", "Adds Hypervelocity on Burst Strike Continuation combo and main combo and Gnashing Fang.", GNB.JobID, 0, "Swish, swoosh", "Now we're cooking with gas! Hyper!")]
        GunbreakerBurstStrikeConFeature = 7012,

        [CustomComboInfo("Burst Strike to Bloodfest Feature", "Replace Burst Strike with Bloodfest if you have no powder gauge.", GNB.JobID, 0, "P4S Vampire man Bloodfest Feature", "Again with the edgelord names?\nTut, tut, Yoshi-P. Do better.")]
        GunbreakerBloodfestOvercapFeature = 7013,

        [ParentCombo(GunbreakerSolidBarrelCombo)]
        [CustomComboInfo("Lightning Shot Uptime", "Replace Solid Barrel Combo Feature with Lightning Shot when you are out of range.", GNB.JobID, 0, "Stubby-armed GNB", "Can't reach?")]
        GunbreakerRangedUptimeFeature = 7015,

        [CustomComboInfo("Interrupt Feature", "Replaces LowBlow with Interject when target can be interrupted .", GNB.JobID, 0, "Lower blow", "Blow, but low.")]
        GunbreakerInterruptFeature = 7016,

        [ParentCombo(GunbreakerSolidBarrelCombo)]
        [CustomComboInfo("Bloodfest on Main Combo", "Adds Bloodfest to main combo when ammo is 0.", GNB.JobID, 0)]
        GunbreakerBloodfestonST = 7014,

        [ParentCombo(GunbreakerSolidBarrelCombo)]
        [CustomComboInfo("No Mercy on Main Combo", "Adds No Mercy to main combo when at full ammo.", GNB.JobID, 0)]
        GunbreakerNoMercyonST = 7018,

        [ParentCombo(GunbreakerGnashingFangOnMain)]
        [CustomComboInfo("Gnashing Fang Starter", "Begins Gnashing Fang on main combo.", GNB.JobID, 0)]
        GunbreakerGFStartonMain = 7019,

        #endregion
        // ====================================================================================
        #region MACHINIST

        [CustomComboInfo("(Heated) Shot Combo", "Replace either form of Clean Shot with its combo chain.", MCH.JobID, 0, "Alright, Hotshot -", "Is there really such a thing as a clean shot? Let's find out.")]
        MachinistMainCombo = 8000,

        [CustomComboInfo("Overdrive Feature", "Replace Rook Autoturret and Automaton Queen with Overdrive while active.", MCH.JobID, 0, "Drive (2011) Feature", "Insert synthwave soundtrack here.")]
        MachinistOverdriveFeature = 8002,

        [CustomComboInfo("Gauss Round / Ricochet Feature", "Replace Gauss Round and Ricochet with one or the other depending on which has more charges.", MCH.JobID, 0, "Gatling feature", "It's just a lot of bullets, really.")]
        MachinistGaussRoundRicochetFeature = 8003,

        [CustomComboInfo("Drill / Air Anchor (Hot Shot) Feature", "Replace Drill and Air Anchor (Hot Shot) with one or the other (or Chainsaw) depending on which is on cooldown.", MCH.JobID, 0, "Multi-tool", "Why does MCH have a drill and a chainsaw? What is this, DoH?")]
        MachinistHotShotDrillChainsawFeature = 8004,

        [ParentCombo(MachinistMainCombo)]
        [ConflictingCombos(MachinistAlternateMainCombo)]
        [CustomComboInfo("Drill/Air/Chain Saw Feature On Main Combo", "Air Anchor followed by Drill is added onto main combo if you use Reassemble.\nIf Air Anchor is on cooldown and you use Reassemble, Chainsaw will be added to main combo instead.", MCH.JobID, 0, "A bit of everything feature", "Don't rub your last two brain-cells together! We got you!")]
        MachinistDrillAirOnMainCombo = 8005,

        [CustomComboInfo("Single Button Heat Blast", "Switches Heat Blast to Hypercharge.", MCH.JobID, 0, "So-called 'Heat Blast'", "Basically a large hair-dryer.")]
        MachinistHeatblastGaussRicochetFeature = 8006,

        [CustomComboInfo("Single Button Auto Crossbow", "Switches Auto Crossbow to Hypercharge and weaves gauss/rico.", MCH.JobID, 0, "Laser Crossbow", "It's a crossbow, from the future!")]
        MachinistAutoCrossBowGaussRicochetFeature = 8018,

        [ParentCombo(MachinistMainCombo)]
        [ConflictingCombos(MachinistDrillAirOnMainCombo)]
        [CustomComboInfo("Alternate Drill/Air Feature on Main Combo", "Drill/Air/Hotshot Feature is added onto main combo (Note: It will add them onto main combo ONLY if you are under Reassemble Buff\nOr Reasemble is on CD (Will do nothing if Reassemble is OFF CD)", MCH.JobID, 0, "Gunbreaker feature", "Look at me - I'm the tank now.")]
        MachinistAlternateMainCombo = 8007,

        [ParentCombo(MachinistMainCombo)]
        [CustomComboInfo("Single Button HeatBlast On Main Combo Option", "Adds Single Button Heatblast onto the main combo when the option is enabled.", MCH.JobID, 0, "Scalp burner", "Dry your hair even faster! Even hotter! Owch!")]
        MachinistHeatBlastOnMainCombo = 8008,

        [ParentCombo(MachinistMainCombo)]
        [CustomComboInfo("Battery Overcap Option", "Overcharge protection for your Battery, If you are at 100 battery charge rook/queen will be added to your (Heated) Shot Combo.", MCH.JobID, 0, "Battery", "Isn't battery like, assault? What's wrong with you?")]
        MachinistOverChargeOption = 8009,

        [ParentCombo(MachinistSpreadShotFeature)]
        [CustomComboInfo("Battery AOE Overcap Option", "Adds overcharge protection to Spread Shot/Scattergun.", MCH.JobID, 0, "Battery", "Isn't battery like, assault? What's wrong with you?")]
        MachinistAoEOverChargeOption = 8010,

        [ParentCombo(MachinistSpreadShotFeature)]
        [CustomComboInfo("Gauss Round Ricochet on AOE Feature", "Adds Gauss Round/Ricochet to the AoE combo during Hypercharge.", MCH.JobID, 0, "Ratchet and Clank Feature", "Bouncing off the walls")]
        MachinistAoEGaussRicochetFeature = 8011,

        [ParentCombo(MachinistAoEGaussRicochetFeature)]
        [CustomComboInfo("Always Gauss Round/Ricochet on AoE Option", "Adds Gauss Round/Ricochet to the AoE combo outside of Hypercharge windows.", MCH.JobID, 0, "Ratchet and Clank Feature", "Bouncing off the walls")]
        MachinistAoEGaussOption = 8012,

        [ConflictingCombos(MachinistRicochetGaussMainCombo)]
        [ParentCombo(MachinistMainCombo)]
        [CustomComboInfo("Ricochet & Gauss Round Feature", "Adds Ricochet and Gauss Round to main combo. Will use all charges.", MCH.JobID, 0, "Pew +1", "All the shots, ALL of the time.")]
        MachinistRicochetGaussChargesMainCombo = 8017,

        [ConflictingCombos(MachinistRicochetGaussChargesMainCombo)]
        [ParentCombo(MachinistMainCombo)]
        [CustomComboInfo("Ricochet & Gauss Round overcap protection option", "Adds Ricochet and Gauss Round to main combo. Will leave 1 charge of each.", MCH.JobID, 0, "", "Never run out of bullets again! Or never have too many! Or something!\nBullets!")]
        MachinistRicochetGaussMainCombo = 8013,

        [ParentCombo(MachinistMainCombo)]
        [CustomComboInfo("Barrel Stabilizer drift protection feature", "Adds Barrel Stabilizer onto the main combo if heat is between 5-20.", MCH.JobID, 0, "Third Leg", "Adds Barrel Stabiliser when you're in heat. You heard me.")]
        BarrelStabilizerDrift = 8014,

        [ParentCombo(MachinistHeatblastGaussRicochetFeature)]
        [CustomComboInfo("Wildfire Feature", "Adds Wildfire to the Single Button Heat Blast Feature if Wildfire is off cooldown and you have enough heat for Hypercharge then Hypercharge will be replaced with Wildfire.\nAlso weaves Ricochet/Gauss Round on Heat Blast when necessary.", MCH.JobID, 0, "PEW", "PEW PEW PEW PEW, AND PEW.\nALSO WEAVES PEW AND PEW.")]
        MachinistWildfireFeature = 8015,

        [ParentCombo(MachinistSpreadShotFeature)]
        [CustomComboInfo("BioBlaster Feature", "Adds Bioblaster to the Spreadshot feature", MCH.JobID, 0, "War crime feature", "This is like uh, some sort of anthrax? Jeez bro. Relax.\nBanned by the Geneva Convention.")]
        MachinistBioblasterFeature = 8016,

        [CustomComboInfo("Barrel Feature", "Adds Barrel Stabalizer to Single Button Heat Blast and Single Button Auto Crossbow Features when below 50 heat and is off cooldown", MCH.JobID, 0, "Hot Cross Bow", "Now multi-purpose!")]
        MachinistAutoBarrel = 8019,

        [ConflictingCombos(MachinistMainCombo)]
        [CustomComboInfo("Simple Machinist", "Single button single target machinist, including buffs and overprotections.\nConflicts with other single target toggles!!", MCH.JobID, 0, "", "Goodbye, brain!")]
        MachinistSimpleFeature = 8020,

        [ParentCombo(MachinistSimpleFeature)]
        [CustomComboInfo("Simple Interrupt", "Uses interrupt during simple machinist rotation, if applicable.", MCH.JobID, 0, "Simple Interr-", "Excuse me, I wa-")]
        MachinistSimpleInterrupt = 8021,

        [ParentCombo(MachinistSimpleFeature)]
        [CustomComboInfo("Simple Gadget", "Adds Queen or Rook uses to the feature, based on your current level.\nTry to use Queen at optimal intervals between :55 to :05 windows.", MCH.JobID, 0, "Gadgeteer", "My queen!")]
        MachinistSimpleGadget = 8022,

        [ParentCombo(MachinistSimpleFeature)]
        [CustomComboInfo("Simple Assembling", "Adds optimal reassemble uses to the feature.", MCH.JobID, 0, "Megablox", "It's like Lego bricks! But worse!")]
        MachinistSimpleAssembling = 8023,

        [ParentCombo(MachinistSimpleFeature)]
        [CustomComboInfo("Simple Gauss Ricochet", "Adds Gauss Round and Ricochet uses to the feature.", MCH.JobID, 0, "", "More bullets!")]
        MachinistSimpleGaussRicochet = 8024,

        [ParentCombo(MachinistSimpleFeature)]
        [CustomComboInfo("Simple Wildcharge", "Adds Hypercharge and Wildfire uses to the feature.\nIt respects the 8 second rule of Drill, AirAnchor and Chainsaw.", MCH.JobID, 0, "Simply fantastic", "Is it really THAT simple?")]
        MachinistSimpleWildCharge = 8025,

        [ParentCombo(MachinistSimpleFeature)]
        [CustomComboInfo("Simple Stabilizer", "Adds Barrel Stabilizer to the feature.\nWhen heat < 50 and Wildfire is off CD or about to come off CD.", MCH.JobID, 0, "Third Leg", "Reduces recoil when spraying and praying.")]
        MachinistSimpleStabilizer = 8026,

        [ParentCombo(MachinistSpreadShotFeature)]
        [CustomComboInfo("Hypercharge", "Adds hypercharge to the AoE.", MCH.JobID, 0, "Sugar Rush", "I'm gonna slap @augporto for putting in so many damn MCH features.\nHow full of witty one-liners do you think I am?!")]
        MachinistAoEHyperchargeFeature = 8027,

        [CustomComboInfo("Simple Machinist AOE", "Spread Shot turns into Scattergun when lvl 82 or higher, Both turn into Auto Crossbow when overheated\nand Bioblaster is used first whenever it is off cooldown.", MCH.JobID, 0, "Dungeon go zzzz", "AoE, but you're just not here. Go make a coffee.")]
        MachinistSpreadShotFeature = 8028,

        #endregion
        // ====================================================================================
        #region MONK

        [CustomComboInfo("AoE Combo", "Replaces Arm Of The Destroyer/Shadow Of The Destroyer with the AoE combo chain.", MNK.JobID, 0, "", "Punching, but wide. It's like having extra hands!")]
        MnkAoECombo = 9000,

        [CustomComboInfo("Bootshine Feature", "Replaces Dragon Kick with Bootshine if both a form and Leaden Fist are up.", MNK.JobID, 0, "", "Shine ya shoes, guv'na?")]
        MnkBootshineFeature = 9001,

        [CustomComboInfo("Twin Snakes Feature", "Replaces True Strike with Twin Snakes if Disciplined Fist is not applied or is less than 6 seconds from falling off.", MNK.JobID, 0, "", "I've had it with these MF snakes on this MF plane!")]
        MnkTwinSnakesFeature = 9011,

        [ConflictingCombos(MnkBasicComboPlus)]
        [CustomComboInfo("Basic Rotation", "Basic Monk Combo on one button", MNK.JobID, 0, "", "I presses the buttons, I does the deeps")]
        MnkBasicCombo = 9002,

        [CustomComboInfo("Perfect Balance Feature", "Perfect Balance becomes Masterful Blitz while you have 3 Beast Chakra.", MNK.JobID, 0, "", "They say life is like walking a tightrope...")]
        MonkPerfectBalanceFeature = 9003,

        [CustomComboInfo("Bootshine Balance Feature", "Replaces Dragon Kick with Masterful Blitz if you have 3 Beast Chakra.", MNK.JobID, 0, "The tin", "Does what it says on the tin")]
        MnkBootshineBalanceFeature = 9004,

        [CustomComboInfo("Howling Fist/Meditation Feature", "Replaces Howling Fist/Enlightenment with Meditation when the Fifth Chakra is not open.", MNK.JobID, 0, "", "Imagine using your fist to scream at someone. Welcome to MNK!\nEnjoy your stay.")]
        MonkHowlingFistMeditationFeature = 9005,

        [ConflictingCombos(MnkBasicCombo)]
        [CustomComboInfo("Basic Rotation Plus", "Basic Monk Combo on one button Plus (Only for Testing)", MNK.JobID, 0, "", "They call it 'basic' for a reason, you donkey")]
        MnkBasicComboPlus = 9006,

        [CustomComboInfo("Perfect Balance Feature Plus", "All of the (Optimal?) Blitz combos on Masterful Blitz when Perfect Balance Is Active", MNK.JobID, 0, "", "Try not to fall over, eh")]
        MnkPerfectBalancePlus = 9007,

        [ParentCombo(MnkBasicComboPlus)]
        [CustomComboInfo("Masterful Blitz to Main Combo", "Adds all of (Optimal?) Blitz combos and Masterful Blitz on Main Combo", MNK.JobID, 0, "", "It's maths, but for your Single Target combo!")]
        MonkMasterfullBlizOnMainCombo = 9008,

        [ParentCombo(MnkAoECombo)]
        [CustomComboInfo("Masterful Blitz to AoE Combo", "Adds all of (Optimal?) Blitz combos and Masterful Blitz on AoE Combo.", MNK.JobID, 0, "", "It's maths, but for your AoE combo!")]
        MonkMasterfullBlizOnAoECombo = 9009,

        [CustomComboInfo("Forbidden Chakra Feature", "Adds Forbidden Chakra/Enlightement to the Main/AoE feature combo. Testing Only for now!", MNK.JobID, 0, "But, wait!", "Mom said no! It's forbidden!")]
        MonkForbiddenChakraFeature = 9010,

        [CustomComboInfo("Riddle of Fire/Brotherhood Feature", "Replaces Riddle of Fire with Brotherhood when Riddle of Fire is on cooldown.", MNK.JobID, 0, "", "Riddle me this, brotha'")]
        MnkRiddleOfFireBrotherhoodFeature = 9012,

        [ParentCombo(MnkBasicComboPlus)]
        [CustomComboInfo("Damage Buffs to Main Combo Feature", "Places Riddle of Fire and Brotherhood onto main combo when Perfect Balance is up.", MNK.JobID, 0, "", "Been passed on for dance partner again? Don't worry, you have some buffs of your own.")]
        MnkMainComboBuffsFeature = 9013,

        [ParentCombo(MnkBasicComboPlus)]
        [CustomComboInfo("Riddle of Wind Main Combo Feature", "Places Riddle of Wind onto main combo after using Twin Snakes.", MNK.JobID, 0, "", "Easy, breezy.")]
        MnkRiddleOfWindFeature = 9014,

        #endregion
        // ====================================================================================
        #region NINJA

        [ConflictingCombos(NinSimpleSingleTarget)]
        [CustomComboInfo("Armor Crush Combo", "Replace Armor Crush with its combo chain.", NIN.JobID, 0, "One, Two, Three", "It's a Ninja's life for me")]
        NinjaArmorCrushCombo = 10000,

        [ConflictingCombos(NinSimpleSingleTarget)]
        [CustomComboInfo("Aeolian Edge Combo", "Replace Aeolian Edge with its combo chain.", NIN.JobID, 0, "Edgy Edge Combo", "Knife go stab")]
        NinjaAeolianEdgeCombo = 10001,

        //[CustomComboInfo("Simple AoE", "Replaces Death Blossom with the AoE rotation.", NIN.JobID)]
        //NinjaHakkeMujinsatsuCombo = 10002,

        //[CustomComboInfo("Dream to Assassinate", "Replace Dream Within a Dream with Assassinate when Assassinate Ready.", NIN.JobID)]
        //NinjaAssassinateFeature = 10003,

        [CustomComboInfo("Kassatsu to Trick", "Replaces Kassatsu with Trick Attack while Suiton or Hidden is up.\nCooldown tracking plugin recommended.", NIN.JobID, 0, "Katsu Curry to Trick", "This is how we eat at a restaurant and don't pay the bill.\nRUN!")]
        NinjaKassatsuTrickFeature = 10004,

        [CustomComboInfo("Ten Chi Jin to Meisui", "Replaces Ten Chi Jin (the move) with Meisui while Suiton is up.\nCooldown tracking plugin recommended.", NIN.JobID, 0, "Ten Chin Scratches to Chop-Suey", "Does something, probably.\nHow do you deal with all these attack names?")]
        NinjaTCJMeisuiFeature = 10005,

        [CustomComboInfo("Kassatsu Chi/Jin Feature", "Replaces Chi with Jin while Kassatsu is up if you have Enhanced Kassatsu.", NIN.JobID, 0, "", "Swaps your Katsu curry with a Chi Chin-scratch.")]
        NinjaKassatsuChiJinFeature = 10006,

        [CustomComboInfo("Hide to Mug", "Replaces Hide with Mug while in combat.", NIN.JobID, 0, "Stand and Deliver", "John Cena is a thief, now?")]
        NinjaHideMugFeature = 10007,

        [CustomComboInfo("Aeolian to Ninjutsu Feature", "Replaces Aeolian Edge (combo) with Ninjutsu if any Mudra are used.", NIN.JobID, 0, "Hand signs and all that", "Do the Naruto thing, I think.\nIdk I don't watch anime, sorry")]
        NinjaNinjutsuFeature = 10008,

        [ConflictingCombos(NinSimpleSingleTarget)]
        [CustomComboInfo("GCDs to Ninjutsu Feature", "Every GCD combo becomes Ninjutsu while Mudras are being used.", NIN.JobID, 0, "Full-on Sign Language", "NOW you're really communicating with the party.")]
        NinjaGCDNinjutsuFeature = 10009,

        [CustomComboInfo("Huraijin / Raiju Feature", "Replaces Huraijin with Forked and Fleeting Raiju when available.", NIN.JobID, 0, "Pikachu / Raichu Feature", "Does something? Maybe? Evolutions? Combos? Probably.")]
        NinjaHuraijinRaijuFeature = 10010,

        [ParentCombo(NinjaHuraijinRaijuFeature)]
        [CustomComboInfo("Huraijin / Raiju Feature Option 1", "Replaces Huraijin with Fleeting Raiju when available.", NIN.JobID, 0, "Pikachu / Raichu Option 1", "Does the same thing probably, who knows.")]
        NinjaHuraijinRaijuFeature1 = 10011,

        [ParentCombo(NinjaHuraijinRaijuFeature)]
        [CustomComboInfo("Huraijin / Raiju Feature Option 2", "Replaces Huraijin with Forked Raiju when available.", NIN.JobID, 0, "Pikachu / Raichu Option 2", "What we DO know, is that all NIN mains just slam their heads on the keyboard to do combos, anyway.")]
        NinjaHuraijinRaijuFeature2 = 10012,

        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("Armor Crush Feature", "Adds Armor Crush onto main combo.", NIN.JobID, 0, "", "Act like you can crush armor with your kitchen knives or whatever.")]
        NinjaArmorCrushOnMainCombo = 10013,

        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("Raiju Feature", "Adds Fleeting Raiju to Aeolian Edge Combo.", NIN.JobID, 0, "Raichu Feature", "Thunderbolt!")]
        NinjaFleetingRaijuFeature = 10014,

        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("HuraijinToMainCombo", "Adds Huraijin to main combo if Huton buff is not present", NIN.JobID, 0, "", "Smells like a hurricane. No idea.")]
        NinjaHuraijinFeature = 10015,

        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("BunshinOnMainCombo", "Adds Bunshin whenever its off cd and you have gauge for it on main combo.", NIN.JobID, 0, "What do you call a Viera that's been cut off at the knees?", "Bun-shin KEK")]
        NinjaBunshinFeature = 10016,

        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("BavacakraOnMainCombo", "Adds Bavacakra you have gauge for it on main combo.", NIN.JobID, 0, "BAKLAVA!", "BAKLAVA!")]
        NinjaBhavacakraFeature = 10017,

        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("Throwing Dagger Uptime Feature", "Replace Aeolian Edge with Throwing Daggers when targer is our of range.", NIN.JobID, 0, "", "Would probably make more sense for NIN to be a Ranged DPS, anyway.")]
        NinjaRangedUptimeFeature = 10018,

        [CustomComboInfo("Simple Mudras", "Simplify the mudra casting to avoid failing.", NIN.JobID, 0, "Simple Murder", "Murder, made simple. For the everyday user.")]
        NinjaSimpleMudras = 10020,

        [ParentCombo(NinjaTCJMeisuiFeature)]
        [CustomComboInfo("Ten Chi Jin Feature", "Turns Ten Chi Jin (the move) into Ten, Chi, and Jin.", NIN.JobID, 0, "", "Does literally nothing. Ever")]
        NinTCJFeature = 10021,

        [ConflictingCombos(NinjaArmorCrushCombo, NinjaAeolianEdgeCombo, NinjaGCDNinjutsuFeature)]
        [CustomComboInfo("Simple Ninja Single Target", "Turns Spinning Edge into a one-button full single target rotation.\nUses Ninjitsus, applies Trick Attack and uses Armor Crush to upkeep Huton buff.\nConflicts with a lot of features. Please only use this and the AoE version and disable all other Ninja features.", NIN.JobID, 0, "", "")]
        NinSimpleSingleTarget = 10022,

        [CustomComboInfo("Simple Ninja AoE", "Turns Death Blossom into a one-button full AoE rotation.\nApplies Doton but will only use Ninjitsus if under the effect of Kassatsu or have 2 charges to ensure more Doton uptime.", NIN.JobID, 0, "Dote-on AoE", "Uses /dote on every target.")]
        NinSimpleAoE = 10023,

        [ParentCombo(NinSimpleSingleTarget)]
        [CustomComboInfo("Include Trick Attack", "Add or disable Trick Attack as part of the feature.", NIN.JobID, 0, "Surprise!", "It's like the Uno Reverse card of XIV!")]
        NinSimpleTrickFeature = 10024,

        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("Assassinate/Dream Within a Dream Feature", "Adds Assassinate and Dream Within a Dream to the combo.", NIN.JobID, 0, "Fever Dream", "Frothinig at the mouth")]
        NinAeolianAssassinateFeature = 10025,

        [ParentCombo(NinjaAeolianEdgeCombo)]
        [CustomComboInfo("Mug Feature", "Adds Mug to the combo.", NIN.JobID, 0, "Petty Theft", "Embarrassing.")]
        NinAeolianMugFeature = 10026,

        [ParentCombo(NinSimpleTrickFeature)]
        [CustomComboInfo("Kassatsu for Suiton Feature", "Allows the use of Kassatsu to set up Suiton. Suiton is prioritised above Hyosho Ranryu under this effect \nand your trick cooldown window has elapsed.", NIN.JobID)]
        NinSimpleTrickKassatsuFeature = 10027,

        [ParentCombo(NinSimpleAoE)]
        [CustomComboInfo("Hellfrog Medium Feature", "Adds Hellfrog Medium to the combo if you have Ninki to spend.", NIN.JobID)]
        NinSimpleHellfrogFeature = 10028,

        [ParentCombo(NinSimpleAoE)]
        [CustomComboInfo("Mudra Feature", "Adds Doton and Katon/Goka Mekkyaku to the combo.", NIN.JobID)]
        NinSimpleAoeMudras = 10029,

        [ParentCombo(NinSimpleAoE)]
        [CustomComboInfo("Bunshin Feature", "Adds Bunshin and Phantom Kamaitachi to the combo.", NIN.JobID)]
        NinSimpleAoeBunshin = 10030,

        #endregion
        // ====================================================================================
        #region PALADIN

        [CustomComboInfo("Goring Blade Combo", "Replace Goring Blade with its combo chain.", PLD.JobID, 0, "These aren't heals... huh?", "Just take the armour off and don a robe, we all know you're green on the inside.")]
        PaladinGoringBladeCombo = 11000,

        [CustomComboInfo("Royal Authority Combo", "Replace Royal Authority/Rage of Halone with its combo chain.", PLD.JobID, 0, "", "Lmao, 'Authority'... If you say so, buddy.")]
        PaladinRoyalAuthorityCombo = 11001,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [ConflictingCombos(PaladinAtonementTestFeature)]
        [CustomComboInfo("Atonement Feature", "Replace Royal Authority with Atonement when under the effect of Sword Oath.", PLD.JobID, 0, "", "Atonement for what? Picking the weakest Tank?")]
        PaladinAtonementFeature = 11002,

        [CustomComboInfo("Prominence Combo", "Replace Prominence with its combo chain.", PLD.JobID, 0, "Promenade feature", "Long walks on the promenade...")]
        PaladinProminenceCombo = 11003,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [CustomComboInfo("Requiescat Feature", "Replace Royal Authority/Goring Blade combo with Holy Spirit and Prominence combo with Holy Circle while Requiescat is active \n And when Fight Or Flight is not Active.\nRequires said combos to be activated to work.", PLD.JobID, 0, "Auto-PLD", "Plays the whole job for you.\nJust stand there and take damage, right?")]
        PaladinRequiescatFeature = 11004,

        [ParentCombo(PaladinRequiescatFeature)]
        [CustomComboInfo("Confiteor Feature", "Replace Holy Spirit/Circle with Confiteor when Requiescat is up and MP is under 2000 or only one stack remains \nand adds Faith/Truth/Valor Combo after Confiteor. \n Requiescat Feature Needs to be Enabled for this one to work!!!  ", PLD.JobID, 0, "Confetti Feature", "This is gonna be a nightmare to clean up.")]
        PaladinConfiteorFeature = 11005,

        [CustomComboInfo("Scornful Spirits Feature", "Replace Spirits Within and Circle of Scorn with whichever is available soonest.", PLD.JobID, 0, "", "Two for the price of one!")]
        PaladinScornfulSpiritsFeature = 11006,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [CustomComboInfo("Royal Goring Option", "Insert Goring Blade into the main combo when appropriate.\nRequires Royal Authority Combo", PLD.JobID, 0, "", "")]
        PaladinRoyalGoringOption = 11007,

        [CustomComboInfo("Standalone Holy Spirit Feature", "Replaces Holy Spirit with Confiteor and Confiteor combo", PLD.JobID, 0, "", "It's Christmas already?")]
        PaladinStandaloneHolySpiritFeature = 11008,

        [CustomComboInfo("Standalone Holy Circle Feature", "Replaces Holy Circle with Confiteor and Confiteor combo", PLD.JobID, 0, "", "This is MY circle.")]
        PaladinStandaloneHolyCircleFeature = 11009,

        [ConflictingCombos(PaladinInterveneFeatureOption)]
        [CustomComboInfo("Intervene Feature", "Adds intervene onto main combo whenever its available (Uses all stacks).", PLD.JobID, 0, "", "It looks like a gap-closer. It smells like a gap-closer...")]
        PaladinInterveneFeature = 11010,

        [ConflictingCombos(PaladinInterveneFeature)]
        [CustomComboInfo("Intervene Option", "Adds intervene onto main combo whenever its available (Leaves 1 stack).", PLD.JobID, 0, "", "It must be a gap-closer!")]
        PaladinInterveneFeatureOption = 11011,

        [ConflictingCombos(PaladinRangedUptimeFeature2)]
        [CustomComboInfo("Shield Lob Uptime Feature", "Replace Royal Authority/Rage of Halone Feature with Shield Lob when out of range.", PLD.JobID, 0, "", "Don't throw your shield, you're not Captain America.\nJust get close!")]
        PaladinRangedUptimeFeature = 11012,

        [ParentCombo(PaladinFightOrFlightMainComboFeature)]
        [ConflictingCombos(PaladinFightOrFlightMainComboFeatureTest)]
        [CustomComboInfo("FoF Feature", "Adds FoF onto the main combo (Testing).", PLD.JobID, 0, "", "What is this, P3S?")]
        PaladinFightOrFlightMainComboFeature = 11013,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [CustomComboInfo("Req Feature", "Adds Req onto the main combo (Testing).", PLD.JobID, 0, "", "Just defend 4hed")]
        PaladinReqMainComboFeature = 11014,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [ConflictingCombos(PaladinAtonementFeature, SkillCooldownRemaining)]
        [CustomComboInfo("Atonement Drop Feature", "Drops Atonement to prevent Potency loss (Testing).", PLD.JobID, 0, "Anti-Atonement Missile", "Imagine worrying about potency loss when you play a job like this. Couldn't be me!")]
        PaladinAtonementTestFeature = 11015,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [ConflictingCombos(PaladinRangedUptimeFeature)]
        [CustomComboInfo("Holy Spirit Uptime Feature", "Replace Royal Authority/Rage of Halone Feature with Holy Spirit when out of range.", PLD.JobID, 0, "(Un)Holy Halone", "Who is Halone and why are they so angry?")]
        PaladinRangedUptimeFeature2 = 11016,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [ConflictingCombos(PaladinRangedUptimeFeature, PaladinFightOrFlightMainComboFeature)]
        [CustomComboInfo("FoF Feature (Custom Values) ", "Adds FoF onto the main combo (Testing). You can Input your own gcd value (Value represtents percentage of your GCD, 1 = Full GCD).", PLD.JobID, 0, "", "This feature hurts my brain. Yours too, no doubt")]
        PaladinFightOrFlightMainComboFeatureTest = 11017,

        [ParentCombo(PaladinRoyalAuthorityCombo)]
        [ConflictingCombos(PaladinAtonementFeature, PaladinAtonementTestFeature)]
        [CustomComboInfo("Atonement Drop Feature (Custom Value Test)", "Drops Atonement to prevent Potency loss when FoF is about to expire.", PLD.JobID, 0, "", "Clumsy-ass dropped the Atonement again")]
        SkillCooldownRemaining = 11018,

        [CustomComboInfo("Interrupt Feature", "Replaces Shield Bash with Interject when target can be interrupted or Low Blow if it's off cooldown. .", PLD.JobID, 0, "Lower blow", "Blow, but low.")]
        PaladinInterruptFeature = 11019,

        #endregion
        // ====================================================================================
        #region REAPER

        // Single Target Combo Section
        [CustomComboInfo("Slice Combo Feature", "Replace Slice with its combo chain. Features and options inside.\nCollapsing this category disables the features inside.", RPR.JobID, 0, "One, Two, Three", "It's a slicer's life for me~")]
        ReaperSliceCombo = 12000,

        [ParentCombo(ReaperSliceCombo)]
        [CustomComboInfo("Soul Slice Option", "Adds Soul Slice to Slice Combo when Soul Gauge is 50 or less, and target is under Death's Design debuff.", RPR.JobID, 0, "", "FETCH ME THEIR SOULS...")]
        ReaperSoulSliceFeature = 12001,

        [ParentCombo(ReaperSliceCombo)]
        [CustomComboInfo("Shadow Of Death Option", "Adds Shadow of Death to Slice Combo if debuff is not present or is about to expire.", RPR.JobID, 0, "DoB - Damage over Brain", "Already using all of your brain on positionals? Look no further!")]
        ReaperShadowOfDeathFeature = 12002,

        [ParentCombo(ReaperSliceCombo)]
        [CustomComboInfo("Stun Option", "Adds Leg Sweep to main combo when target is performing an interruptible cast i.e. uses stun as an interrupt.", RPR.JobID, 0, "ZAP", "The male was too stunned to speak")]
        ReaperStunOption = 12003,

        [ParentCombo(ReaperSliceCombo)]
        [CustomComboInfo("Combo Heals Option", "Adds Bloodbath and Second Wind to the combo at 65 and 40 percent HP, respectively.", RPR.JobID, 0, "Pretend Play Heals", "Look mom, I'm a White Mage!")]
        ReaperComboHealsOption = 12004,

        [ParentCombo(ReaperSliceCombo)]
        [CustomComboInfo("Ranged Filler Option", "Replaces the combo chain with Harpe (or Harvest Moon, if available) when outside of melee range. Will not override Communio.", RPR.JobID, 0, "Stretch Armstrong", "Can't quite reach? Here.")]
        ReaperRangedFillerOption = 12005,

        [ParentCombo(ReaperSliceCombo)]
        [CustomComboInfo("Feint Option", "Adds Feint into the combo.\nOnly use this if you're really asleep at the wheel (NOT optimal).", RPR.JobID, 0, "Use this during downtime", "Hey! I'm contributing to the raid!")]
        ReaperFeintOption = 12006,

        // AoE Combo Section
        [CustomComboInfo("Scythe Combo Feature", "Replace Spinning Scythe with its combo chain. Features and options inside.\nCollapsing this category disables the features inside.", RPR.JobID, 0, "One, Two, Th-", "Oh. It's barely a combo!")]
        ReaperScytheCombo = 12010,

        [ParentCombo(ReaperScytheCombo)]
        [CustomComboInfo("Soul Scythe Option", "Adds Soul Scythe to Scythe Combo when Soul Gauge is 50 or less, and target is under Death's Design debuff.", RPR.JobID, 0, "", "I've made the CoD Zombies joke too many times, but I'm too tired to think of anything else.\nSorry!")]
        ReaperSoulScytheFeature = 12011,

        [ParentCombo(ReaperScytheCombo)]
        [CustomComboInfo("Whorl Of Death Option", "Adds Whorl of Death to Scythe Combo if debuff is not present or is about to expire.", RPR.JobID, 0, "DoB - Damage over Brains", "Already using all of your brain-cells on positionals? Look no further!")]
        ReaperWhorlOfDeathFeature = 12012,


        // Gibbet, Gallows, Guillotine Combo Section
        [CustomComboInfo("[Unveiled Features]", "Features and options involving Gibbet, Gallows and Guillotine.\nCollapsing this category does NOT disable the features inside.", RPR.JobID, 0, "Gubbins, Gibberish and Globular", "They all do the same thing, really.")]
        ReaperMenuUnveiledFeatures = 12020,

        [ParentCombo(ReaperMenuUnveiledFeatures)]
        [ConflictingCombos(ReaperGibbetGallowsInverseFeature)]
        [CustomComboInfo("Gibbet/Gallows Feature", "Slice and Shadow of Death are replaced with Gibbet and Gallows while Soul Reaver or Shroud is active.", RPR.JobID, 0, "Drown in FX!", "Now with even less buttons!")]
        ReaperGibbetGallowsFeature = 12021,

        [ParentCombo(ReaperGibbetGallowsFeature)]
        [CustomComboInfo("Gibbet/Gallows One-Button Option", "Slice is instead replaced with whichever move is procced, and Shadow of Death remains untouched.", RPR.JobID, 0, "Gubbins/Gibberish One-Button Option", "Positionals were SO last patch, anyway.")]
        ReaperGibbetGallowsOption = 12022,

        [ParentCombo(ReaperMenuUnveiledFeatures)]
        [ConflictingCombos(ReaperGibbetGallowsFeature)]
        [CustomComboInfo("Gallows/Gibbet (Inverse) Feature - BROKEN (Currently same effect as above)", "Slice and Shadow of Death are replaced with Gallows and Gibbet while Soul Reaver or Shroud is active.\n(Positional replacements swapped)", RPR.JobID, 0, "BoRkEd", "Don't use this bruh, you KNOW it's broken.\nShit the bed!")]
        ReaperGibbetGallowsInverseFeature = 12023,

        [ParentCombo(ReaperMenuUnveiledFeatures)]
        [CustomComboInfo("Guillotine Feature", "Spinning Scythe's combo gets replaced with Guillotine while Soul Reaver or Shroud is active.", RPR.JobID, 0, "", "As if this job wasn't the easiest Melee already. You're welcome, little sloth.")]
        ReaperGuillotineFeature = 12024,


        // Blood Stalk, Grim Swathe, Gluttony Combo Section
        [CustomComboInfo("[Soul Reaver Features]", "Features and options involving Blood Stalk, Grim Swathe and Gluttony.\nCollapsing this category does NOT disable the features inside.", RPR.JobID, 0, "Grass Farmer Features", "oGCDs? You betcha")]
        ReaperMenuSoulReaverFeatures = 12030,

        [ParentCombo(ReaperMenuSoulReaverFeatures)]
        [ConflictingCombos(ReaperBloodStalkComboFeature, ReaperBloodStalkAlternateComboOption, ReaperGrimSwatheComboFeature)]
        [CustomComboInfo("Blood Stalk/Grim Swathe Feature", "When Gluttony is off-cooldown, Blood Stalk and Grim Swathe will turn into Gluttony.", RPR.JobID, 0, "Buttony", "It's like the normal buttons, but better! Double the fun!")]
        ReaperBloodSwatheFeature = 12031,

        [ParentCombo(ReaperMenuSoulReaverFeatures)]
        [ConflictingCombos(ReaperBloodSwatheFeature, ReaperBloodStalkAlternateComboOption)]
        [CustomComboInfo("Blood Stalk Multi-Combo Feature", "Turns Blood Stalk into Gluttony when off-cooldown and puts Gibbet and Gallows on the same button as Blood Stalk. Also adds Enshrouded Combo.", RPR.JobID, 0, "", "Play the job properly u stinker!")]
        ReaperBloodStalkComboFeature = 12032,

        [ParentCombo(ReaperMenuSoulReaverFeatures)]
        [ConflictingCombos(ReaperBloodSwatheFeature, ReaperBloodStalkComboFeature)]
        [CustomComboInfo("Blood Stalk Multi-Combo Feature Alternative - Same but better (?)", "Turns Blood Stalk into Gluttony when off-cooldown and puts Gibbet and Gallows on the same button as Blood Stalk. Also adds Enshrouded Combo.\n[Seems like the code is more effective in edge cases. Both features need further review.", RPR.JobID, 0, "", "You heard me the first time!")]
        ReaperBloodStalkAlternateComboOption = 12033,

        [ParentCombo(ReaperMenuSoulReaverFeatures)]
        [ConflictingCombos(ReaperBloodSwatheFeature)]
        [CustomComboInfo("Grim Swathe Multi-Combo Feature", "Turns Grim Swathe into Gluttony when off-cooldown and puts Guillotine on the same button as Grim Swathe. Also adds Enshrouded Combo.", RPR.JobID, 0, "", "I SAID - Play the job u stinker!!!!")]
        ReaperGrimSwatheComboFeature = 12034,


        // Enshroud Combo Section
        [CustomComboInfo("[Enshroud Features]", "Features and options involving the Enshrouded burst phase.\nCollapsing this category does NOT disable the features inside.", RPR.JobID, 0, "Edgelord mode", "Devil May Cry reboot when?")]
        ReaperMenuEnshroudFeatures = 12040,

        [ParentCombo(ReaperMenuEnshroudFeatures)]
        [CustomComboInfo("Lemure Feature", "When you have two or more stacks of Void Shroud, Lemure Slice replaces Gibbet/Gallows and Lemure Scythe replaces Guillotine.", RPR.JobID, 0, "One-button farming burst", "Who is Lemure and what do they want?")]
        ReaperLemureFeature = 12041,

        [ParentCombo(ReaperMenuEnshroudFeatures)]
        [CustomComboInfo("Combo Communio Feature", "When one stack of Lemure Shroud remains, Communio replaces Gibbet/Gallows/Guillotine.", RPR.JobID, 0, "", "They say strong communio is the key to a healthy relationship")]
        ReaperComboCommunioFeature = 12042,

        [ParentCombo(ReaperMenuEnshroudFeatures)]
        // [ConflictingCombos(ReaperEnshroudComboFeature)]
        [CustomComboInfo("Enshroud Communio Feature", "Replace Enshroud with Communio when Enshrouded.", RPR.JobID, 0, "", "Go on, press it as soon as you enter Enshroud.\nI dare you. Dingus.")]
        ReaperEnshroudCommunioFeature = 12043,

        // [ParentCombo(ReaperMenuEnshroudFeatures)]
        // [ConflictingCombos(ReaperEnshroudCommunioFeature)]
        // [CustomComboInfo("Enshroud One-Button Single Target Combo - DOESN'T EXIST YET", "Turns Enshroud into Void/Cross Reaping, weaves Lemure Slice and finishes with Communio.", RPR.JobID)]
        // ReaperEnshroudComboFeature = 12044,


        // Miscellaneous Combo Section
        [CustomComboInfo("[Extra Features]", "Miscellaneous features and options.\nCollapsing this category does NOT disable the features inside.", RPR.JobID, 0, "M O R E", "More? Haven't we made this job easy enough already?")]
        ReaperMenuExtraFeatures = 12050,

        [ParentCombo(ReaperMenuExtraFeatures)]
        [CustomComboInfo("Arcane Circle Harvest Feature", "Replace Arcane Circle with Plentiful Harvest when you have stacks of Immortal Sacrifice.", RPR.JobID, 0, "Farming Simulator 2022", "You might as well buy a tractor at this point")]
        ReaperHarvestFeature = 12051,

        [ParentCombo(ReaperMenuExtraFeatures)]
        [CustomComboInfo("Regress Feature", "Both Hell's Ingress and Hell's Egress turn into Regress when Threshold is active, instead of just the opposite of the one you used.", RPR.JobID, 0, "You're a DRG now, son", "GO WHENCE YOU CAME")]
        ReaperRegressFeature = 12052,

        [ParentCombo(ReaperMenuExtraFeatures)]
        [CustomComboInfo("Harpe Soulsow Feature", "Changes Harpe into Soulsow when you are out of combat or have no target, and are not already under the effect of Soulsow.", RPR.JobID, 0, "", "Gotta have something to do before the pull, right?")]
        ReaperHarpeSoulsowFeature = 12053,

        [ParentCombo(ReaperMenuExtraFeatures)]
        [CustomComboInfo("Harpe Harvest Moon Feature", "Changes Harpe into Harvest Moon when you are in combat with Soulsow active.", RPR.JobID, 0, "Dumb reaper be dumb", "Good luck finding the best place to use this kek")]
        ReaperHarpeHarvestMoonFeature = 12054,

        [ParentCombo(ReaperHarpeHarvestMoonFeature)]
        [CustomComboInfo("Enhanced Harpe Option", "Prevent Harvest Moon replacing Harpe when Enhanced Harpe is active.\nThis option also affects the Ranged Filler Option for the Slice Combo Feature.", RPR.JobID, 0, "", "Look at me, all SMN-like and that")]
        ReaperHarpeHarvestMoonEnhancedOption = 12055,

        [ParentCombo(ReaperHarpeHarvestMoonFeature)]
        [CustomComboInfo("Combat Harpe Option", "Prevent Harvest Moon replacing Harpe when you are not in combat.\nThis option also affects the Ranged Filler Option for the Slice Combo Feature.", RPR.JobID, 0, "", "OoOoH uNaSpEcTeD dAmAgE")]
        ReaperHarpeHarvestMoonCombatOption = 12056,

        #endregion
        // ====================================================================================
        #region RED MAGE

        [ConflictingCombos(RedMageSmartcastAoECombo)]
        [CustomComboInfo("Red Mage AoE Combo", "Replaces Veraero/Verthunder 2 with Impact when Dualcast or Swiftcast are active.", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        RedMageAoECombo = 13000,

        [CustomComboInfo("Redoublement combo", "Replaces Redoublement with its combo chain, following enchantment rules.", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        RedMageMeleeCombo = 13001,

        [CustomComboInfo("Redoublement Combo Plus", "Replaces Redoublement with Verflare/Verholy after Enchanted Redoublement, whichever is more appropriate.\nRequires Redoublement Combo.", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        RedMageMeleeComboPlus = 13002,

        [ConflictingCombos(RedMageSmartSingleTargetCombo)]
        [CustomComboInfo("Verproc into Jolt", "Replaces Verstone/Verfire with Jolt/Scorch when no proc is available.", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        RedMageVerprocCombo = 13003,

        [ConflictingCombos(RedMageSmartSingleTargetCombo)]
        [CustomComboInfo("Verproc into Jolt Plus", "Additionally replaces Verstone/Verfire with Veraero/Verthunder if dualcast/swiftcast are up.\nRequires Verproc into Jolt.", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        RedMageVerprocComboPlus = 13004,

        [ConflictingCombos(RedMageSmartSingleTargetCombo)]
        [CustomComboInfo("Verproc into Jolt Plus Opener Feature", "Turns Verfire into Verthunder when out of combat.\nRequires Verproc into Jolt Plus.", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        RedMageVerprocOpenerFeature = 13005,

        [CustomComboInfo("Resolution Feature", "Adds Resolution finisher to Verthunder/Verareo Combo ", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        RedmageResolutionFinisher = 13006,

        [CustomComboInfo("Resolution Feature Melee", "Adds Resolution finisher to melee combo ", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        RedmageResolutionFinisherMelee = 13007,

        [ConflictingCombos(RedMageAoECombo)]
        [CustomComboInfo("Smart AoE Feature", "Replaces Verthunder II With Veraero II and impact depending on mana", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        RedMageSmartcastAoECombo = 13008,

        [ConflictingCombos(RedMageVerprocComboPlus, RedMageVerprocOpenerFeature, RedMageVerprocCombo)]
        [CustomComboInfo("Smart Single Target Feature", "Smart Single target feature Credit: PrincessRTFM", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        RedMageSmartSingleTargetCombo = 13009,

        [CustomComboInfo("oGCD Feature", "Replace Contre Strike and Fleche with whichever is available soonest.", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        RedMageOgcdCombo = 13010,

        [CustomComboInfo("SmartCast Opener Feature", "Verthunder Opener Feature. Allows you to prepull with verthunder and still let the combo balance the mana for you", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        RedMageVerprocOpenerSmartCastFeature = 13011,

        [ParentCombo(RedMageSmartcastAoECombo)]
        [CustomComboInfo("Red Mage AoE Finisher", "Adds Finishers onto Moulinet and SmartCast AoE Feature.", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        RedMageMeleeAoECombo = 13012,

        [CustomComboInfo("Engagement Feature", "Adds Engagement in all melee combos. (Testing Only!)", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        RedMageEngagementFeature = 13013,

        [CustomComboInfo("Simple Red Mage Feature Single Target", "Combines Smartcast feature with melee combo on Verstone,Verfire or melee skills (This is not optimal until i find a solution for distance delay)", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        SimpleRedMage = 13014,

        [CustomComboInfo("Simple Red Mage Feature AoE", "Combines Smartcast AoE feature with melee AoE combo on Verthunder2/Veraero2 (This is not optimal until i find a solution for distance delay)", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        SimpleRedMageAoE = 13015,

        [CustomComboInfo("Corps-A-corps/Displacement Feature", "Corps-A-corps becomes displacement when in melee range", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        RedMageMovementFeature = 13016,

        [ParentCombo(RedMageOgcdCombo)]
        [CustomComboInfo("oGCD Feature Everywhere", "Adds oGCD Feature to all other combos", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        RedMageOgcdComboOnCombos = 13017,

        [ParentCombo(SimpleRedMage)]
        [CustomComboInfo("Verstone/Verfire Activation", "Add Acceleration and Swiftcast to Simple Red Mage to force activation of verstone or verfire effects when necessary.", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        SimpleRedMageFishing = 13018,

        [ParentCombo(SimpleRedMageFishing)]
        [CustomComboInfo("Acceleration only", "Only use Acceleration to force verfire or verstone activations.", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        SimpleRedMageAccelOnlyFishing = 13019,

        [ParentCombo(SimpleRedMage)]
        [ConflictingCombos(RedMageVerprocOpenerSmartCastFeature)]
        [CustomComboInfo("Simple opener", "Do the optimal opener. [lv90 only]", RDM.JobID, 0, "Swiftcast -> Verraise", "Ah look, it's what you were always meant to do")]
        SimpleRedMageOpener = 13020,

        #endregion
        // ====================================================================================
        #region SAGE

        [CustomComboInfo("Soteria into Kardia Feature", "Soteria turns into Kardia when not active or Soteria is on-cooldown.", SGE.JobID, 0, "Spoopy into Kpoopy", "Don't forget your danc- uh, heal partner!")]
        SageKardiaFeature = 14000,

        [CustomComboInfo("Rhizomata Feature", "Replaces Taurochole, Druochole, Ixochole and Kerachole with Rhizomata when Addersgall is empty.", SGE.JobID, 0, "Rhizomatato", "Can't quite manage that gauge? Neither can we.")]
        SageRhizomataFeature = 14001,

        [CustomComboInfo("Taurochole into Druochole Feature", "Replaces Taurochole with Druochole when Taurochole is on cooldown.", SGE.JobID, 0, "This for that", "They do the same thing, really. If you close your eyes.")]
        SageTauroDruoFeature = 14002,

        [CustomComboInfo("Phlegma into Toxikon Feature", "Phlegma turns into Toxikon when you are out of charges and have Addersting.\nTakes priority over the Phlegma into Dyskrasia Feature.", SGE.JobID, 0, "", "Changes Phlegma to Toxikon, purely because the name is awful.")]
        SagePhlegmaToxikonFeature = 14003,

        [CustomComboInfo("Phlegma into Dyskrasia Feature", "Phlegma turns into Dyskrasia when you are out of charges.", SGE.JobID, 0, "", "Again, Phlegma is the worst skill name in the game. GET RID!")]
        SagePhlegmaDyskrasiaFeature = 14004,

        [ConflictingCombos(SageDPSFeatureTest)]
        [CustomComboInfo("Dosis DPS Feature", "Adds Eukrasia and Eukrasian Dosis on one combo button.", SGE.JobID, 0, "", "Oh look, you're basically WHM now!")]
        SageDPSFeature = 14005,

        [ParentCombo(SageDPSFeature)]
        [CustomComboInfo("Lucid Dreaming Option", "Adds Lucid Dreaming into the Dosis DPS feature when you have 8,000 mana or less.", SGE.JobID, 0, "Muh piety", "Never run out of steam!")]
        SageLucidFeature = 14006,

        [ConflictingCombos(SageAlternateEgeiroFeature)]
        [CustomComboInfo("Swiftcast into Egeiro Feature", "Changes Swiftcast to Egeiro when under the effect of Swiftcast.", SGE.JobID, 0, "Swiftcast to Swiftcast", "GET BACK TO DOING DAMAGE")]
        SageEgeiroFeature = 14007,

        [ConflictingCombos(SageEgeiroFeature)]
        [CustomComboInfo("Egeiro into Swiftcast Feature", "Changes Egiero to Swiftcast when Swiftcast is available.", SGE.JobID, 0, "Raise to Raise", "Swaps your raise with WHM's raise.\nDoesn't work any more. You're welcome")]
        SageAlternateEgeiroFeature = 14008,

        [ConflictingCombos(SageDPSFeature)]
        [CustomComboInfo("Dosis DPS Feature (Testing)", "Identical to the Dosis DPS feature, but you can input some values to your liking.", SGE.JobID, 0, "", "WHM again, but with numbers!")]
        SageDPSFeatureTest = 14009,

        [ParentCombo(SageDPSFeatureTest)]
        [CustomComboInfo("Lucid Dreaming Option", "Adds Lucid Dreaming into the Dosis DPS feature (Testing) when you have 8,000 mana or less.", SGE.JobID, 0, "", "Don't worry, we won't let you shit the bed. Back to DPS!")]
        SageLucidFeatureTest = 14010,

        #endregion
        // ====================================================================================
        #region SAMURAI

        [ConflictingCombos(SamuraiSimpleSamuraiFeature)]
        [CustomComboInfo("Yukikaze Combo", "Replace Yukikaze with its combo chain.", SAM.JobID, 0, "Yakuza Combo", "Gang affiliation? Surely not.")]
        SamuraiYukikazeCombo = 15000,

        [ConflictingCombos(SamuraiSimpleSamuraiFeature)]
        [CustomComboInfo("Gekko Combo", "Replace Gekko with its combo chain.", SAM.JobID, 0, "Geico Combo", "Fifteen minutes could save you 15% or more on car insurance!")]
        SamuraiGekkoCombo = 15001,

        [ConflictingCombos(SamuraiSimpleSamuraiFeature)]
        [CustomComboInfo("Kasha Combo", "Replace Kasha with its combo chain.", SAM.JobID, 0, "Cashman Combo", "Dolla dolla bill, y'all")]
        SamuraiKashaCombo = 15002,

        [CustomComboInfo("Mangetsu Combo", "Replace Mangetsu with its combo chain.", SAM.JobID, 0, "Mangetout Combo", "EAT IT ALL!")]
        SamuraiMangetsuCombo = 15003,

        [CustomComboInfo("Oka Combo", "Replace Oka with its combo chain.", SAM.JobID, 0, "Okeh Combo", "Okeh")]
        SamuraiOkaCombo = 15004,

        [CustomComboInfo("Jinpu/Shifu Feature", "Replace Meikyo Shisui with Jinpu or Shifu depending on what is needed.", SAM.JobID, 0, "Jumpup/Sitdown", "Work those glutes.")]
        SamuraiJinpuShifuFeature = 15005,

        [ConflictingCombos(SamuraiIaijutsuTsubameGaeshiFeature)]
        [CustomComboInfo("Tsubame-gaeshi to Iaijutsu", "Replace Tsubame-gaeshi with Iaijutsu when Sen is empty.", SAM.JobID, 0, "", "You don't know the difference between this one and that one?")]
        SamuraiTsubameGaeshiIaijutsuFeature = 15006,

        [ConflictingCombos(SamuraiIaijutsuShohaFeature)]
        [CustomComboInfo("Tsubame-gaeshi to Shoha", "Replace Tsubame-gaeshi with Shoha when meditation is 3.", SAM.JobID, 0, "", "Don't worry, neither do we.")]
        SamuraiTsubameGaeshiShohaFeature = 15007,

        [ConflictingCombos(SamuraiTsubameGaeshiIaijutsuFeature)]
        [CustomComboInfo("Iaijutsu to Tsubame-gaeshi", "Replace Iaijutsu with Tsubame-gaeshi when Sen is not empty.", SAM.JobID, 0, "", "Wait, there's more?")]
        SamuraiIaijutsuTsubameGaeshiFeature = 15008,

        [ConflictingCombos(SamuraiTsubameGaeshiShohaFeature)]
        [CustomComboInfo("Iaijutsu to Shoha", "Replace Iaijutsu with Shoha when meditation is 3.", SAM.JobID, 0, "", "You WHAT?!")]
        SamuraiIaijutsuShohaFeature = 15009,

        [CustomComboInfo("Shinten to Senei", "Replace Hissatsu: Shinten with Senei when its cooldown is up.", SAM.JobID, 0, "", "Kicks you in the shins if Senei is on cooldown")]
        SamuraiSeneiFeature = 15010,

        [CustomComboInfo("Shinten to Shoha", "Replace Hissatsu: Shinten with Shoha when Meditation is full.", SAM.JobID, 0, "", "Kicks you in the shins if Shoha is on cooldown")]
        SamuraiShohaFeature = 15011,

        [CustomComboInfo("Kyuten to Guren", "Replace Hissatsu: Kyuten with Guren when its cooldown is up.", SAM.JobID, 0, "", "Hey Kyutie!")]
        SamuraiGurenFeature = 15012,

        [CustomComboInfo("Kyuten to Shoha II", "Replace Hissatsu: Kyuten with Shoha II when Meditation is full.", SAM.JobID, 0, "", "Hey Kyutie 2, Electric Boogaloo!")]
        SamuraiShoha2Feature = 15013,

        [CustomComboInfo("Ikishoten Namikiri Feature", "Replace Ikishoten with Ogi Namikiri and then Kaeshi Namikiri when available.\nIf you have full Meditation stacks, Ikishoten becomes Shoha while you have Ogi Namikiri ready.", SAM.JobID, 0, "Sticky-icky-shoten", "Wait, you guys use meditation?")]
        SamuraiIkishotenNamikiriFeature = 15014,

        [ConflictingCombos(SamuraiYukikazeCombo, SamuraiGekkoCombo, SamuraiKashaCombo)]
        [CustomComboInfo("Simple Samurai Single Target", "Every sticker combo on one button (Hakaze).", SAM.JobID, 0, "Sleepy Samurai", "zzzz....wha?")]
        SamuraiSimpleSamuraiFeature = 15015,

        [CustomComboInfo("Simple Samurai AoE", "Both AoE Combos on same button (On Oka). Big thanks to Stein121", SAM.JobID, 0, "", "Hardly any buttons in the first place, but we got you. Lazy-ass.")]
        SamuraiSimpleSamuraiAoECombo = 15016,

        [CustomComboInfo("Kaiten Feature Option 1", "Adds Kaiten to Higanbana when it has < 5 seconds remaining.", SAM.JobID, 0, "", "MORE!")]
        SamuraiKaitenFeature1 = 15018,

        [CustomComboInfo("Kaiten Feature Option 2", "Adds Kaiten to Tenka Goken.", SAM.JobID, 0, "", "MORE!!")]
        SamuraiKaitenFeature2 = 15019,

        [CustomComboInfo("Kaiten Feature Option 3", "Adds Kaiten to Midare Setsugekka.", SAM.JobID, 0, "", "MORE!!!")]
        SamuraiKaitenFeature3 = 15020,

        [CustomComboInfo("Gyoten Feature", "Hissatsu: Gyoten becomes Yaten/Gyoten depending on the distance from your target.", SAM.JobID, 0, "Gyoza Feature", "Mm, tasty.")]
        SamuraiYatenFeature = 15021,

        [CustomComboInfo("Kaiten Feature Option 4", "Adds Kaiten when above 20 gauge to OgiNamikiri and OgiNamikiri is ready.", SAM.JobID, 0, "", "MORE!!!!")]
        SamuraiOgiNamikiriFeature = 15022,

        [ConflictingCombos(SamuraiOvercapFeature85)]
        [CustomComboInfo("Samurai Overcap Feature 1", "Adds Senei>Shinten onto main combo at 75 or more Kenki", SAM.JobID, 0, "Wink emoji Overcap Feature 1", "Kinky.")]
        SamuraiOvercapFeature75 = 15023,

        [ConflictingCombos(SamuraiOvercapFeature75)]
        [CustomComboInfo("Samurai Overcap Feature 2", "Adds Senei>Shinten onto main combo at 85 or more Kenki", SAM.JobID, 0, "Wink emoji Overcap Feature 2", "Even more kinky.")]
        SamuraiOvercapFeature85 = 15024,

        [ConflictingCombos(SamuraiOvercapFeatureAoe85)]
        [CustomComboInfo("Samurai AoE Overcap Feature 1", "Adds Guren>Kyuten onto main AoE combos at 75 or more Kenki", SAM.JobID, 0, "Wink emoji Overcap Feature 3", "Kinkier")]
        SamuraiOvercapFeatureAoe75 = 15025,

        [ConflictingCombos(SamuraiOvercapFeatureAoe75)]
        [CustomComboInfo("Samurai AoE Overcap Feature 2", "Adds Guren>Kyuten onto main AoE combos at 85 or more Kenki", SAM.JobID, 0, "Wink emoji Overcap Feature 4", "Kinkiest")]
        SamuraiOvercapFeatureAoe85 = 15026,

        [CustomComboInfo("Ikishoten on combos", "Adds Ikishoten to most Single Target/AoE combos when at or below 50 Kenki", SAM.JobID, 0, "Gauge pls", "You heard me. Gauge pls")]
        SamuraiIkishotenonmaincombo = 15027,

        [ParentCombo(SamuraiIkishotenNamikiriFeature)]
        [CustomComboInfo("Kaiten On Ikishoten", "Adds Kaiten to Ikishoten Namikiri Feature", SAM.JobID, 0, "", "MORE!!!!!")]
        SamuraiIkishotenKaitenNamikiriFeature = 15028,



        #endregion
        // ====================================================================================
        #region SCHOLAR

        [CustomComboInfo("Seraph Fey Blessing/Consolation", "Change Fey Blessing into Consolation when Seraph is out.", SCH.JobID, 0, "", "Stupid little fairy thing")]
        ScholarSeraphConsolationFeature = 16000,

        [CustomComboInfo("ED Aetherflow", "Change Energy Drain into Aetherflow when you have no more Aetherflow stacks.", SCH.JobID, 0, "", "Stop trying to pretend you're a SMN. You're not fooling anyone")]
        ScholarEnergyDrainFeature = 16001,

        [ConflictingCombos(SCHAlternateRaiseFeature)]
        [CustomComboInfo("SCH Raise Feature", "Changes Swiftcast to Resurrection.", SCH.JobID, 0, "", "Well, at least PF wants you for something")]
        SchRaiseFeature = 16002,

        [ConflictingCombos(SchRaiseFeature)]
        [CustomComboInfo("SCH Raise Alternate Feature", "Changes Resurrection To Swiftcast when Swiftcast is available.", SCH.JobID, 0, "", "Well, this raise stuff and Peloton Extreme, I guess.")]
        SCHAlternateRaiseFeature = 16008,

        [CustomComboInfo("Fairy Feature", "Change every action that requires a fairy into Summon Eos if you do not have a fairy summoned.", SCH.JobID, 0, "", "You're really gonna forget? Really?")]
        ScholarFairyFeature = 16004,

        [CustomComboInfo("DPS Feature", "Adds Bio1/Bio2/Biosys to Broil/Ruin whenever the debuff is not present or about to expire.", SCH.JobID, 0, "", "Pretend something interesting is going on. DPS Routine!")]
        ScholarDPSFeature = 16005,

        [ParentCombo(ScholarDPSFeature)]
        [CustomComboInfo("DPS Feature Buff Option", "Adds Chain Stratagem to the DPS Feature.", SCH.JobID, 0, "", "Raid buffs for everyone!")]
        ScholarDPSFeatureBuffOption = 16006,

        [ParentCombo(ScholarDPSFeature)]
        [CustomComboInfo("DPS Feature Lucid Dreaming Option", "Adds Lucid dreaming to the DPS feature when below set MP value.", SCH.JobID, 0, "", "Nobody's perfect. Maybe this'll help")]
        ScholarLucidDPSFeature = 16007,

        [CustomComboInfo("SCH Extra DPS Feature", "Adds Biolysis on Ruin II. Won't work below level 38", SCH.JobID, 0, "", "People still use Ruin 2? Shouldn't you be healing or something?")]
        SCHDPSAlternateFeature = 16003,

        #endregion
        // ====================================================================================
        #region SUMMONER

        [ConflictingCombos(SummonerMainComboFeature, SummonerRuinIVMobilityFeature)]
        [CustomComboInfo("Enable Single Target (Ruin1)", "Enables changing Single-Target Combo (Ruin I).", SMN.JobID, 0, "Ruin 420 Feature", "Ruination is come")]
        SummonerMainComboFeatureRuin1 = 16999,

        [ConflictingCombos(SummonerMainComboFeatureRuin1)]
        [CustomComboInfo("Enable Single Target (RuinIII)", "Enables changing Single-Target Combo (Ruin III).", SMN.JobID, 0, "Ruin 7 Feature", "Ruination is come... again?")]
        SummonerMainComboFeature = 17000,

        [CustomComboInfo("Enable AOE", "Enables changing AOE Combo (Tri-Disaster)", SMN.JobID, 0, "", "Can't deal with dungeons on your own? Fear not.")]
        SummonerAOEComboFeature = 17001,

        [CustomComboInfo("Single Target Demi Feature", "Replaces Astral Impulse/Fountain of Fire with Enkindle/Deathflare/Rekindle when appropriate.", SMN.JobID, 0, "Demi Dingus Feature", "Can't tell the difference between a Bahamut and a Phoenix?\nWe know.")]
        SummonerSingleTargetDemiFeature = 17002,

        [ParentCombo(SummonerAOEComboFeature)]
        [CustomComboInfo("AOE Demi Feature", "Replaces Astral Flare/Brand of Purgatory with Enkindle/Deathflare/Rekindle when appropriate.", SMN.JobID, 0, "BRRRR", "Upgrade!")]
        SummonerAOEDemiFeature = 17003,

        [CustomComboInfo("Egi Attacks Feature", "Replaces RuinI/Ruin III (Depending On Enabled Combo) and Tri-Disaster with Egi attacks. Will not work without enabling Single Target and/or AOE.", SMN.JobID, 0, "Eggy-bread", "No idea when you're in burst phase?\nHint: It's all the time, really")]
        SummonerEgiAttacksFeature = 17004,

        [CustomComboInfo("Garuda Slipstream Feature", "Adds Slipstream on RuinI/Ruin III/Tri-disaster.", SMN.JobID, 0, "Slipstream", "2 Fast 2 Furious")]
        SummonerGarudaUniqueFeature = 17005,

        [CustomComboInfo("Ifrit Cyclone Feature", "Adds Crimson Cyclone/Crimson Strike on RuinI/Ruin III/Tri-disaster.", SMN.JobID, 0, "Fists of Fury", "Show MNK how it's done, will ya?")]
        SummonerIfritUniqueFeature = 17006,

        [CustomComboInfo("Titan Mountain Buster Feature", "Adds Mountain Buster on RuinI/Ruin III/Tri-disaster.", SMN.JobID, 0, "Mountain, BUSTA", "Bring the mountain to Mohammed, as they say")]
        SummonerTitanUniqueFeature = 17007,

        [CustomComboInfo("ED Fester", "Change Fester into Energy Drain when our of Aetherflow stacks.", SMN.JobID, 0, "Festering", "Festering? Go take a shower, bro")]
        SummonerEDFesterCombo = 17008,

        [CustomComboInfo("ES Painflare", "Change Painflare into Energy Siphon when out of Aetherflow stacks.", SMN.JobID, 0, "Old age", "I sometimes get a painflare in my middle-back, too.")]
        SummonerESPainflareCombo = 17009,


        // BONUS TWEAKS
        [CustomComboInfo("Carbuncle Reminder Feature", "Reminds you always to summon Carbuncle by replacing Ruin (Carbuncle Summon Reminder Feature).", SMN.JobID, 0, "Rabbit Reminder", "C'mon. You had ONE job.")]
        SummonerCarbuncleSummonFeature = 17010,

        [CustomComboInfo("Ruin 4 On Ruin3 Combo Feature", "Adds Ruin4 on main RuinI/RuinIII combo feature when there are currently no summons being active.", SMN.JobID, 0, "Ruin -> Ruin -> Ruin", "Ruin this, ruin that. Can't you see I'm busy ruining the plugin?!")]
        SummonerRuin4ToRuin3Feature = 17011,

        [CustomComboInfo("Ruin 4 On Tri-disaster Feature", "Adds Ruin4 on main Tridisaster combo feature when there are currently no summons being active.", SMN.JobID, 0, "", "More Ruin this, more ruin that! Now in sharing size!")]
        SummonerRuin4ToTridisasterFeature = 17012,

        [ParentCombo(SummonerEDFesterCombo)]
        [CustomComboInfo("Ruin IV Fester/PainFlare Feature", "Change Fester/PainFlare into Ruin IV when out of Aetherflow stacks, ED/ES is on cooldown, and Ruin IV is up.", SMN.JobID, 0, "Festering Painflare", "Just take some Advil for that, or see the doc?")]
        SummonerFesterPainflareRuinFeature = 17013,

        [ParentCombo(SummonerEDFesterCombo)]
        [CustomComboInfo("Lazy Fester Feature", "Adds ED/Fester during (AstralImpulse).\n. Will only ED during Phoenix phase in order to save it Fester for burst in bahamut", SMN.JobID, 0, "I don't read descriptions -", "Why is Fester Not working properly?")]
        SummonerLazyFesterFeature = 17014,

        [ConflictingCombos(SimpleSummonerOption2)]
        [CustomComboInfo("One Button Rotation Feature", "Summoner Single Target One Button Rotation (Single Target) on Ruin1/Ruin3.(Titan>Garuda>Ifrit) ", SMN.JobID, 0, "", "We'll play the game for you. Shush, now")]
        SimpleSummoner = 17015,

        [CustomComboInfo("One Button AoE Rotation Feature", "Summoner AoE One Button Rotation (AoE) on Tridisaster", SMN.JobID, 0, "", "We'll play the game for you. Shush, now")]
        SimpleAoESummoner = 17016,

        [ParentCombo(SimpleSummoner)]
        [CustomComboInfo("Searing Light Rotation Option", "Adds Searing Light to Simple Summoner Rotation, Single Target", SMN.JobID, 0, "My eyes!", "I can't see!")]
        BuffOnSimpleSummoner = 17017,

        [ParentCombo(SimpleAoESummoner)]
        [CustomComboInfo("Searing Light AoE Option", "Adds Searing Light to Simple Summoner Rotation, AoE", SMN.JobID, 0, "Our Eyes!", "Yay, we're all legally blind!")]
        BuffOnSimpleAoESummoner = 17018,

        [CustomComboInfo("DemiReminderFeature", "Adds Only Demi Summons on RuinIII (So you can still choose your Egis but never forget to summon Demis) ", SMN.JobID, 0, "Chad Kroeger Demi Feature", "This is how, you remind me, of what I really am")]
        SummonerDemiSummonsFeature = 17019,

        [CustomComboInfo("DemiReminderAoEFeature", "Adds Only Demi Summons on TriDisaster (So you can still choose your Egis but never forget to summon Demis) ", SMN.JobID, 0, "Nickelback Demi Feature", "Oh fuck, the whole band is here! Run!")]
        SummonerDemiAoESummonsFeature = 17020,

        [ConflictingCombos(SummonerMainComboFeatureRuin1)]
        [CustomComboInfo("Ruin III mobility", "Allows you to cast Ruin III while Ruin IV is unavailable for mobility reasons. Shows up as Ruin I.\nWill break combos with Ruin I. Might break combos with Ruin IV.", SMN.JobID, 0, "", "Don't you have enough mobility as it is?\nThis isn't Ranged DPS, y'know.")]
        SummonerRuinIVMobilityFeature = 17021,

        [ConflictingCombos(SummonerSwiftcastFeatureIfrit)]
        [CustomComboInfo("Swiftcast Garuda Option", "Always swiftcasts Slipstream if available.", SMN.JobID, 0, "No Raising for me!", "Always slips swiftstream, sometimes")]
        SummonerSwiftcastFeatureGaruda = 17022,

        [ConflictingCombos(SummonerSwiftcastFeatureGaruda)]
        [CustomComboInfo("Swiftcast Ifrit Option", "Always swiftcasts 2nd Ruby Rite if available.", SMN.JobID, 0, "No Raising for you!", "Always cancels the Ifrit phase entirely, doing nothing instead.")]
        SummonerSwiftcastFeatureIfrit = 17023,

        [ConflictingCombos(SimpleSummoner)]
        [CustomComboInfo("One Button Rotation Feature Option2 ", "Same feature as One Button Rotation Feature but Garuda>Titan>Ifrit .", SMN.JobID, 0, "The Egi Shuffle", "You just had to be different, didn't you?")]
        SimpleSummonerOption2 = 17024,

        [CustomComboInfo("Prevent Ruin4 Waste Feature", "Puts Ruin4 Above anything if FurtherRuin about to expire and there is no Demi present.", SMN.JobID, 0, "", "Waste not, want not")]
        SummonerRuin4WastePrevention = 17025,

        [CustomComboInfo("Rekindle Feature", "Adds Rekindle onto the main Ruin1 or Ruin3 combo. Requires other features to work.", SMN.JobID, 0, "Tinderbox", "Remember making those fires in runescape? Yeah. That.")]
        SummonerRekindlePhoenix = 17026,

        #endregion
        // ====================================================================================
        #region WARRIOR

        [CustomComboInfo("Storms Path Combo", "All in one main combo feature adds Storm's Eye/Path", WAR.JobID, 0, "", "Follow the yellow-brick road.")]
        WarriorStormsPathCombo = 18000,

        [CustomComboInfo("Storms Eye Combo", "Replace Storms Eye with its combo chain", WAR.JobID, 0, "", "Ow! My fucking eye!")]
        WarriorStormsEyeCombo = 18001,

        [CustomComboInfo("Overpower Combo", "Add combos to Overpower", WAR.JobID, 0, "Underpower", "Bet you wish you had damage like DRK right now, huh")]
        WarriorMythrilTempestCombo = 18002,

        [CustomComboInfo("Warrior Gauge Overcap Feature", "Replace Single target or AoE combo with gauge spender if you are about to overcap and are before a step of a combo that would generate beast gauge", WAR.JobID, 0, "", "Taming the beast... for now.")]
        WarriorGaugeOvercapFeature = 18003,

        [CustomComboInfo("Inner Release Feature", "Replace Single target and AoE combo with Fell Cleave/Decimate during Inner Release", WAR.JobID, 0, "", "Unleash your deepest thoughts and feelings upon the party. They'll love it!")]
        WarriorInnerReleaseFeature = 18004,

        [CustomComboInfo("Nascent Flash Feature", "Replace Nascent Flash with Raw intuition when level synced below 76", WAR.JobID, 0, "Nasty-ass Flash", "Jeez. Keep it to yourself.")]
        WarriorNascentFlashFeature = 18005,

        [ParentCombo(WarriorStormsPathCombo)]
        [CustomComboInfo("Upheaval Feature", "Adds Upheaval into maincombo if you have Surging Tempest", WAR.JobID, 0, "", "I use this feature when I'm moving house.")]
        WarriorUpheavalMainComboFeature = 18007,

        [CustomComboInfo("Primal Rend Feature", "Replace Inner Beast and Steel Cyclone with Primal Rend when available (Also added onto Main AoE combo)", WAR.JobID, 0, "", "Going back to our roots. Let's get Primal!")]
        WarriorPrimalRendFeature = 18008,

        [ParentCombo(WarriorMythrilTempestCombo)]
        [CustomComboInfo("Orogeny Feature", "Adds Orogeny onto main AoE combo when you are buffed with Surging Tempest", WAR.JobID, 0, "Orange-y feature", "Orange flavour. Mm.")]
        WarriorOrogenyFeature = 18009,

        [ConflictingCombos(WarriorSpenderOption)]
        [CustomComboInfo("Inner Chaos option", "Adds Inner Chaos to Storms Path Combo and Chaotic Cyclone to Overpower Combo if you are buffed with Nascent Chaos.\nRequires Storms Path Combo and Overpower Combo", WAR.JobID, 0, "", "THE EYE OF THE TIGERRRRR")]
        WarriorInnerChaosOption = 18010,

        [ConflictingCombos(WarriorInnerChaosOption)]
        [CustomComboInfo("Fell Cleave/Decimate Option", "Adds Fell Cleave to main combo when gauge is at 50 or more and adds Decimate to the AoE combo .\nWill use Inner Chaos/Chaotic Cyclone if Infuriate is used.", WAR.JobID, 0, "", "MORE CLEAVE!")]
        WarriorSpenderOption = 18011,

        [ConflictingCombos(WarriorOnslaughtFeatureOption, WarriorOnslaughtFeatureOptionTwo)]
        [ParentCombo(WarriorStormsPathCombo)]
        [CustomComboInfo("Onslaught Feature", "Adds Onslaught to Storm's Path feature combo if you are under Surging Tempest Buff (Uses all stacks)", WAR.JobID, 0, "", "Onslaught! Full Power!")]
        WarriorOnslaughtFeature = 18012,

        [ConflictingCombos(WarriorOnslaughtFeature, WarriorOnslaughtFeatureOptionTwo)]
        [ParentCombo(WarriorStormsPathCombo)]
        [CustomComboInfo("Onslaught Option", "Adds Onslaught to Storm's Path feature combo if you are under Surging Tempest Buff (Leaves 1 stack)", WAR.JobID, 0, "", "Onslaught! But a bit less!")]
        WarriorOnslaughtFeatureOption = 18013,

        [ConflictingCombos(WarriorOnslaughtFeature, WarriorOnslaughtFeatureOption)]
        [ParentCombo(WarriorStormsPathCombo)]
        [CustomComboInfo("Onslaught Option Two", "Adds Onslaught to Storm's Path feature combo if you are under Surging Tempest Buff (Leaves 2 stacks, only usable at 88 and above)", WAR.JobID, 0, "", "Did you really need three versions of this? Just hit the boss 4hed")]
        WarriorOnslaughtFeatureOptionTwo = 18014,

        [CustomComboInfo("Infuriate Feature", "Replaces Infuriate with Fell Cleave when under Inner Release buff.\nReplaces Infuriate with Inner Chaos When under Nascent Chaos buff", WAR.JobID, 0, "Cleave of annoyance", "Infuriating stuff, if you ask me. Truly chaotic.")]
        WarriorInfuriateFeature = 18015,

        [ParentCombo(WarriorStormsPathCombo)]
        [CustomComboInfo("Tomahawk Uptime Feature", "Replace Storm's Path Combo Feature with Tomahawk when you are out of range.", WAR.JobID, 0, "Tomahawk!", "You heard me! Tomahawk! Ka-chow!")]
        WARRangedUptimeFeature = 18016,

        [CustomComboInfo("Interrupt Feature", "Replaces Low Blow with Interject when target can be interrupted .", WAR.JobID, 0, "", "That's a low blow to my bro-bro, bro.")]
        WarriorInterruptFeature = 18017,

        [CustomComboInfo("Infuriate on Fell Cleave / Decimate", "Turns Fell Cleave and Decimate into Infuriate if at or under set rage value", WAR.JobID)]
        WarriorInfuriateFellCleave = 18018,

        #endregion
        // ====================================================================================
        #region WHITE MAGE

        [CustomComboInfo("Solace into Misery", "Replaces Afflatus Solace with Afflatus Misery when Misery is ready to be used", WHM.JobID, 0, "Misery", "I'd be miserable too if this were one of my DPS options.")]
        WhiteMageSolaceMiseryFeature = 19000,

        [CustomComboInfo("Rapture into Misery", "Replaces Afflatus Rapture with Afflatus Misery when Misery is ready to be used", WHM.JobID, 0, "Misery, but with freinds", "Let's cry together!")]
        WhiteMageRaptureMiseryFeature = 19001,

        [CustomComboInfo("Cure 2 to Cure Level Sync", "Changes Cure 2 to Cure when below level 30 in synced content.", WHM.JobID, 0, "Weenie Cure", "Bet you forgot Cure 1 existed for a sec, huh")]
        WhiteMageCureFeature = 19002,

        [CustomComboInfo("Afflatus Feature", "Changes Cure 2 into Afflatus Solace, and Medica into Afflatus Rapture, when lilies are up.", WHM.JobID, 0, "Inflatus Feature", "Pumps you full of air. Boing!")]
        WhiteMageAfflatusFeature = 19003,

        [ConflictingCombos(WHMAlternativeRaise)]
        [CustomComboInfo("WHM Raise Feature", "Changes Swiftcast to Raise", WHM.JobID, 0, "What you're really here for", "You're the best at this. You got this.")]
        WHMRaiseFeature = 19004,

        [ConflictingCombos(WHMRaiseFeature)]
        [CustomComboInfo("WHM Raise Feature alternative", "Raise Becomes Swiftcast when Swiftcast is available. Thin air feature also applies to this if enabled.", WHM.JobID, 0, "Look up!", "It's this, but that.")]
        WHMAlternativeRaise = 19015,

        [CustomComboInfo("DoT on Glare3 Feature", "Adds DoT on Glare3 when DoT is not preset on about to expire and when you are inCombat (You can still prepull Glare)", WHM.JobID, 0, "Weak", "WHM DPS rotation too much?")]
        WHMDotMainComboFeature = 19005,

        [ParentCombo(WHMDotMainComboFeature)]
        [CustomComboInfo("Lucid Dreaming Feature", "Adds Lucid dreaming onto Glare1/3 Feature combo when you are below 8k mana", WHM.JobID, 0, "Dream within a Dream", "Awake, yet wholly asleep")]
        WHMLucidDreamingFeature = 19006,

        [CustomComboInfo("Medica Feature", "Replaces Medica2 whenever you are under Medica2 regen with Medica1", WHM.JobID, 0, "Big Brain AoE Heals", "God bless us all, eh")]
        WHMMedicaFeature = 19007,

        [ParentCombo(WHMDotMainComboFeature)]
        [CustomComboInfo("Presence Of Mind Feature", "Adds Presence of mind as oGCD onto main DPS Feature(Glare3)", WHM.JobID, 0, "", "This would imply you're actually paying attention.")]
        WHMPresenceOfMindFeature = 19008,

        [ParentCombo(WHMDotMainComboFeature)]
        [CustomComboInfo("Assize Feature", "Adds Assize as oGCD onto main DPS Feature(Glare3)", WHM.JobID, 0, "", "Size 'em up, knock 'em down")]
        WHMAssizeFeature = 19009,

        [ParentCombo(WHMMedicaFeature)]
        [CustomComboInfo("Afflatus Misery On Medica Feature", "Adds Afflatus Misery onto the Medica Feature", WHM.JobID, 0, "", "Ah, back to beinig miserable.")]
        WhiteMageAfflatusMiseryMedicaFeature = 19010,

        [ParentCombo(WHMMedicaFeature)]
        [CustomComboInfo("Afflatus Rapture On Medica Feature", "Adds Afflatus Rapture onto the Medica Feature", WHM.JobID, 0, "CRapture", "The final days are upon us!")]
        WhiteMageAfflatusRaptureMedicaFeature = 19011,

        [CustomComboInfo("Afflatus Misery Feature", "Changes Cure 2 into Afflatus Misery.", WHM.JobID, 0, "", "Cures? Who needs 'em?")]
        WhiteMageAfflatusMiseryCure2Feature = 19012,

        [ParentCombo(WHMDotMainComboFeature)]
        [CustomComboInfo("Remove DoT From Glare3 Feature", "Removes DoT from DPS feature", WHM.JobID, 0, "I'm an idiot", "Yes, one serving of less DPS, please.")]
        WHMRemoveDotFromDPSFeature = 19013,

        [CustomComboInfo("Thin Air Raise Feature", "Adds Thin Air to the WHM Raise Feature/Alternative Feature", WHM.JobID, 0, "", "I can hardly breathe as it is!")]
        WHMThinAirFeature = 19014,

        #endregion
        // ====================================================================================
        #region DOH

        // [CustomComboInfo("Placeholder", "Placeholder.", DOH.JobID)]
        // DohPlaceholder = 50001,

        #endregion
        // ====================================================================================
        #region DOL

        [CustomComboInfo("Eureka Feature", "Replace Ageless Words and Solid Reason with Wise to the World when available.", DOL.JobID)]
        DolEurekaFeature = 51001,

        [CustomComboInfo("Cast / Hook Feature", "Replace Cast with Hook when fishing.", DOL.JobID)]
        DolCastHookFeature = 51002,

        [CustomComboInfo("Cast / Gig Feature", "Replace Cast with Gig when underwater.", DOL.JobID)]
        DolCastGigFeature = 51003,

        [CustomComboInfo("Surface Slap / Veteran Trade Feature", "Replace Surface Slap with Veteran Trade when underwater.", DOL.JobID)]
        DolSurfaceTradeFeature = 51004,

        [CustomComboInfo("Prize Catch / Nature's Bounty Feature", "Replace Prize Catch with Nature's Bounty when underwater.", DOL.JobID)]
        DolPrizeBountyFeature = 51005,

        [CustomComboInfo("Snagging / Salvage Feature", "Replace Snagging with Salvage when underwater.", DOL.JobID)]
        DolSnaggingSalvageFeature = 51006,

        [CustomComboInfo("Cast Light / Electric Current Feature", "Replace Cast Light with Electric Current when underwater.", DOL.JobID)]
        DolCastLightElectricCurrentFeature = 51007,

        #endregion
        // ====================================================================================
        #region PvP Combos

        [SecretCustomCombo]
        [CustomComboInfo("BurstShotFeature", "Adds Shadowbite/EmpyArrow/PitchPerfect(3stacks)/SideWinder(When Target is low hp)/ApexArrow when gauge is 100 all on one button combo.", BRDPvP.JobID)]
        BurstShotFeaturePVP = 80000,

        [SecretCustomCombo]
        [CustomComboInfo("SongsFeature", "Replaces WanderersMinnuet and Peons song all on one button in an optimal order", BRDPvP.JobID)]
        SongsFeaturePVP = 80001,

        [SecretCustomCombo]
        [CustomComboInfo("SouleaterComboFeature", "Adds EoS as oGCD onto main combo and Bloodspiller when at 50 gauge or under delirium buff.", DRKPVP.JobID)]
        SouleaterComboFeature = 80002,

        [SecretCustomCombo]
        [CustomComboInfo("StalwartSoulComboFeature", "Adds FoS as oGCD onto main combo and Quietus when at 50 gauge or under delirium buff.", DRKPVP.JobID)]
        StalwartSoulComboFeature = 80003,

        [SecretCustomCombo]
        [CustomComboInfo("StormsPathComboFeature", "Replaces Storm's Path Combo with FellCleave/IC when at 50 gauge or under IR", WARPVP.JobID)]
        StormsPathComboFeature = 80004,

        [SecretCustomCombo]
        [CustomComboInfo("SteelCycloneFeature", "Replaces Steel Cyclone Combo with Decimate/CC when at 50 gauge or under IR", WARPVP.JobID)]
        SteelCycloneFeature = 80005,

        [SecretCustomCombo]
        [CustomComboInfo("RoyalAuthorityComboFeature", "Adds HolySpirit To the main combo", PLDPVP.JobID)]
        RoyalAuthorityComboFeature = 80006,

        [SecretCustomCombo]
        [CustomComboInfo("ProminenceComboFeature", "Adds HolyCircle to the main AoE Combo", PLDPVP.JobID)]
        ProminenceComboFeature = 80007,

        [SecretCustomCombo]
        [CustomComboInfo("GnashingFangComboFeature", "Adds BowShock(When target is meleeRange) and Burststrike at 2 ammo gauge to the main combo", GNBPVP.JobID)]
        SolidBarrelComboFeature = 80008,

        [SecretCustomCombo]
        [CustomComboInfo("DemonSlaughterComboFeature", "Adds BowShock(When target is meleeRange) and Fated Circle at 2 ammo gauge to the main AoE combo", GNBPVP.JobID)]
        DemonSlaughterComboFeature = 80009,

        [SecretCustomCombo]
        [CustomComboInfo("HeatedCleanShotFeature", "Adds Gauss/Rico weave to maincombo", MCHPVP.JobID)]
        HeatedCleanShotFeature = 80010,

        [SecretCustomCombo]
        [CustomComboInfo("WildfireBlankFeature", "Adds Blank To Wildfire if you are in melee Range", MCHPVP.JobID)]
        WildfireBlankFeature = 80011,

        [SecretCustomCombo]
        [CustomComboInfo("InfernalSliceComboFeature", "Adds Gluttony/BloodStalk/Smite/EnshroudComboRotation on InfernalSliceCombo", RPRPVP.JobID)]
        InfernalSliceComboFeature = 80012,

        [SecretCustomCombo]
        [CustomComboInfo("NightmareScytheComboFeature", "Adds Gluttony/GrimSwathe/Smite/EnshroudComboRotation on InfernalScytheCombo", RPRPVP.JobID)]
        NightmareScytheComboFeature = 80013,

        [SecretCustomCombo]
        [CustomComboInfo("NinjaAeolianEdgePvpCombo", "Adds Cha/Assassinate/Smite on AeolianEdge combo", NINPVP.JobID)]
        NinjaAeolianEdgePvpCombo = 80014,

        [SecretCustomCombo]
        [CustomComboInfo("MnkBootshinePvPFeature", "Adds Axekick/Smite/TornadoKick on main combo", MNKPVP.JobID)]
        MnkBootshinePvPFeature = 80015,

        [SecretCustomCombo]
        [CustomComboInfo("BlackEnochianPVPFeature", "Enochian Stance Switcher", BLMPVP.JobID)]
        BlackEnochianPVPFeature = 80016,


        #endregion
    }
}
