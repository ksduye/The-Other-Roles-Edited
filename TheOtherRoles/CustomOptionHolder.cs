using System.Collections.Generic;
using UnityEngine;
using static TheOtherRolesEdited.TheOtherRolesEdited;
using Types = TheOtherRolesEdited.CustomOption.CustomOptionType;

namespace TheOtherRolesEdited {
    public class CustomOptionHolder {
        public static string[] rates = new string[]{"0%", "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"};
        public static string[] ratesModifier = new string[]{"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" };
        public static string[] presets = new string[]{"Ԥ��1", "Ԥ��2", "���Ԥ�����ý�", "���Ԥ������HQ", "���Ԥ�貨³˹", "���Ԥ��߿շ�ͧ", "���Ԥ���Ǳͧ", "���Ԥ���������" };

        public static CustomOption presetSelection;
        public static CustomOption activateRoles;
        public static CustomOption crewmateRolesCountMin;
        public static CustomOption crewmateRolesCountMax;
        public static CustomOption crewmateRolesFill;
        public static CustomOption neutralRolesCountMin;
        public static CustomOption neutralRolesCountMax;
        public static CustomOption impostorRolesCountMin;
        public static CustomOption impostorRolesCountMax;
        public static CustomOption modifiersCountMin;
        public static CustomOption modifiersCountMax;

        //public static CustomOption enableCodenameHorsemode;
        //public static CustomOption enableCodenameDisableHorses;
        public static CustomOption enableEventMode;

        public static CustomOption mafiaSpawnRate;
        public static CustomOption janitorCooldown;

        public static CustomOption morphlingSpawnRate;
        public static CustomOption morphlingCooldown;
        public static CustomOption morphlingDuration;

        public static CustomOption camouflagerSpawnRate;
        public static CustomOption camouflagerCooldown;
        public static CustomOption camouflagerDuration;

        public static CustomOption vampireSpawnRate;
        public static CustomOption vampireKillDelay;
        public static CustomOption vampireCooldown;
        public static CustomOption vampireCanKillNearGarlics;

        public static CustomOption eraserSpawnRate;
        public static CustomOption eraserCooldown;
        public static CustomOption eraserCanEraseAnyone;
        public static CustomOption guesserSpawnRate;
        public static CustomOption guesserIsImpGuesserRate;
        public static CustomOption guesserNumberOfShots;
        public static CustomOption guesserHasMultipleShotsPerMeeting;
        public static CustomOption guesserKillsThroughShield;
        public static CustomOption guesserEvilCanKillSpy;
        public static CustomOption guesserSpawnBothRate;
        public static CustomOption guesserCantGuessSnitchIfTaksDone;

        public static CustomOption jesterSpawnRate;
        public static CustomOption jesterCanCallEmergency;
        public static CustomOption jesterHasImpostorVision;

        public static CustomOption arsonistSpawnRate;
        public static CustomOption arsonistCooldown;
        public static CustomOption arsonistDuration;

        public static CustomOption jackalSpawnRate;
        public static CustomOption jackalKillCooldown;
        public static CustomOption jackalCreateSidekickCooldown;
        public static CustomOption jackalCanUseVents;
        public static CustomOption jackalCanCreateSidekick;
        public static CustomOption sidekickPromotesToJackal;
        public static CustomOption sidekickCanKill;
        public static CustomOption sidekickCanUseVents;
        public static CustomOption jackalPromotedFromSidekickCanCreateSidekick;
        public static CustomOption jackalCanCreateSidekickFromImpostor;
        public static CustomOption jackalAndSidekickHaveImpostorVision;

        public static CustomOption bountyHunterSpawnRate;
        public static CustomOption bountyHunterBountyDuration;
        public static CustomOption bountyHunterReducedCooldown;
        public static CustomOption bountyHunterPunishmentTime;
        public static CustomOption bountyHunterShowArrow;
        public static CustomOption bountyHunterArrowUpdateIntervall;

        public static CustomOption witchSpawnRate;
        public static CustomOption witchCooldown;
        public static CustomOption witchAdditionalCooldown;
        public static CustomOption witchCanSpellAnyone;
        public static CustomOption witchSpellCastingDuration;
        public static CustomOption witchTriggerBothCooldowns;
        public static CustomOption witchVoteSavesTargets;

        public static CustomOption ninjaSpawnRate;
        public static CustomOption ninjaCooldown;
        public static CustomOption ninjaKnowsTargetLocation;
        public static CustomOption ninjaTraceTime;
        public static CustomOption ninjaTraceColorTime;
        public static CustomOption ninjaInvisibleDuration;

        public static CustomOption mayorSpawnRate;
        public static CustomOption mayorCanSeeVoteColors;
        public static CustomOption mayorTasksNeededToSeeVoteColors;
        public static CustomOption mayorMeetingButton;
        public static CustomOption mayorMaxRemoteMeetings;
        public static CustomOption mayorChooseSingleVote;

        public static CustomOption portalmakerSpawnRate;
        public static CustomOption portalmakerCooldown;
        public static CustomOption portalmakerUsePortalCooldown;
        public static CustomOption portalmakerLogOnlyColorType;
        public static CustomOption portalmakerLogHasTime;
        public static CustomOption portalmakerCanPortalFromAnywhere;

        public static CustomOption engineerSpawnRate;
        public static CustomOption engineerNumberOfFixes;
        public static CustomOption engineerHighlightForImpostors;
        public static CustomOption engineerHighlightForTeamJackal;

        public static CustomOption sheriffSpawnRate;
        public static CustomOption sheriffCooldown;
        public static CustomOption sheriffCanKillNeutrals;
        public static CustomOption deputySpawnRate;

        public static CustomOption deputyNumberOfHandcuffs;
        public static CustomOption deputyHandcuffCooldown;
        public static CustomOption deputyGetsPromoted;
        public static CustomOption deputyKeepsHandcuffs;
        public static CustomOption deputyHandcuffDuration;
        public static CustomOption deputyKnowsSheriff;

        public static CustomOption lighterSpawnRate;
        public static CustomOption lighterModeLightsOnVision;
        public static CustomOption lighterModeLightsOffVision;
        public static CustomOption lighterFlashlightWidth;

        public static CustomOption detectiveSpawnRate;
        public static CustomOption detectiveAnonymousFootprints;
        public static CustomOption detectiveFootprintIntervall;
        public static CustomOption detectiveFootprintDuration;
        public static CustomOption detectiveReportNameDuration;
        public static CustomOption detectiveReportColorDuration;

        public static CustomOption timeMasterSpawnRate;
        public static CustomOption timeMasterCooldown;
        public static CustomOption timeMasterRewindTime;
        public static CustomOption timeMasterShieldDuration;

        public static CustomOption medicSpawnRate;
        public static CustomOption medicShowShielded;
        public static CustomOption medicShowAttemptToShielded;
        public static CustomOption medicSetOrShowShieldAfterMeeting;
        public static CustomOption medicShowAttemptToMedic;
        public static CustomOption medicSetShieldAfterMeeting;

        public static CustomOption swapperSpawnRate;
        public static CustomOption swapperCanCallEmergency;
        public static CustomOption swapperCanOnlySwapOthers;
        public static CustomOption swapperSwapsNumber;
        public static CustomOption swapperRechargeTasksNumber;

        public static CustomOption seerSpawnRate;
        public static CustomOption seerMode;
        public static CustomOption seerSoulDuration;
        public static CustomOption seerLimitSoulDuration;

        public static CustomOption hackerSpawnRate;
        public static CustomOption hackerCooldown;
        public static CustomOption hackerHackeringDuration;
        public static CustomOption hackerOnlyColorType;
        public static CustomOption hackerToolsNumber;
        public static CustomOption hackerRechargeTasksNumber;
        public static CustomOption hackerNoMove;

        public static CustomOption trackerSpawnRate;
        public static CustomOption trackerUpdateIntervall;
        public static CustomOption trackerResetTargetAfterMeeting;
        public static CustomOption trackerCanTrackCorpses;
        public static CustomOption trackerCorpsesTrackingCooldown;
        public static CustomOption trackerCorpsesTrackingDuration;

        public static CustomOption snitchSpawnRate;
        public static CustomOption snitchLeftTasksForReveal;
        public static CustomOption snitchMode;
        public static CustomOption snitchTargets;

        public static CustomOption spySpawnRate;
        public static CustomOption spyCanDieToSheriff;
        public static CustomOption spyImpostorsCanKillAnyone;
        public static CustomOption spyCanEnterVents;
        public static CustomOption spyHasImpostorVision;

        public static CustomOption tricksterSpawnRate;
        public static CustomOption tricksterPlaceBoxCooldown;
        public static CustomOption tricksterLightsOutCooldown;
        public static CustomOption tricksterLightsOutDuration;

        public static CustomOption cleanerSpawnRate;
        public static CustomOption cleanerCooldown;
        
        public static CustomOption warlockSpawnRate;
        public static CustomOption warlockCooldown;
        public static CustomOption warlockRootTime;

        public static CustomOption securityGuardSpawnRate;
        public static CustomOption securityGuardCooldown;
        public static CustomOption securityGuardTotalScrews;
        public static CustomOption securityGuardCamPrice;
        public static CustomOption securityGuardVentPrice;
        public static CustomOption securityGuardCamDuration;
        public static CustomOption securityGuardCamMaxCharges;
        public static CustomOption securityGuardCamRechargeTasksNumber;
        public static CustomOption securityGuardNoMove;

        public static CustomOption vultureSpawnRate;
        public static CustomOption vultureCooldown;
        public static CustomOption vultureNumberToWin;
        public static CustomOption vultureCanUseVents;
        public static CustomOption vultureShowArrows;

        public static CustomOption mediumSpawnRate;
        public static CustomOption mediumCooldown;
        public static CustomOption mediumDuration;
        public static CustomOption mediumOneTimeUse;
        public static CustomOption mediumChanceAdditionalInfo;

        public static CustomOption lawyerSpawnRate;
        public static CustomOption lawyerIsProsecutorChance;
        public static CustomOption lawyerTargetCanBeJester;
        public static CustomOption lawyerVision;
        public static CustomOption lawyerKnowsRole;
        public static CustomOption lawyerCanCallEmergency;
        public static CustomOption pursuerCooldown;
        public static CustomOption pursuerBlanksNumber;

        public static CustomOption thiefSpawnRate;
        public static CustomOption thiefCooldown;
        public static CustomOption thiefHasImpVision;
        public static CustomOption thiefCanUseVents;
        public static CustomOption thiefCanKillSheriff;
        public static CustomOption thiefCanStealWithGuess;


        public static CustomOption trapperSpawnRate;
        public static CustomOption trapperCooldown;
        public static CustomOption trapperMaxCharges;
        public static CustomOption trapperRechargeTasksNumber;
        public static CustomOption trapperTrapNeededTriggerToReveal;
        public static CustomOption trapperAnonymousMap;
        public static CustomOption trapperInfoType;
        public static CustomOption trapperTrapDuration;

        public static CustomOption bomberSpawnRate;
        public static CustomOption bomberBombDestructionTime;
        public static CustomOption bomberBombDestructionRange;
        public static CustomOption bomberBombHearRange;
        public static CustomOption bomberDefuseDuration;
        public static CustomOption bomberBombCooldown;
        public static CustomOption bomberBombActiveAfter;

        public static CustomOption yoyoSpawnRate;
        public static CustomOption yoyoBlinkDuration;
        public static CustomOption yoyoMarkCooldown;
        public static CustomOption yoyoMarkStaysOverMeeting;
        public static CustomOption yoyoHasAdminTable;
        public static CustomOption yoyoAdminTableCooldown;
        public static CustomOption yoyoSilhouetteVisibility;

        public static CustomOption modifiersAreHidden;

        public static CustomOption modifierBait;
        public static CustomOption modifierBaitQuantity;
        public static CustomOption modifierBaitReportDelayMin;
        public static CustomOption modifierBaitReportDelayMax;
        public static CustomOption modifierBaitShowKillFlash;

        public static CustomOption modifierLover;
        public static CustomOption modifierLoverImpLoverRate;
        public static CustomOption modifierLoverBothDie;
        public static CustomOption modifierLoverEnableChat;

        public static CustomOption modifierBloody;
        public static CustomOption modifierBloodyQuantity;
        public static CustomOption modifierBloodyDuration;

        public static CustomOption modifierAntiTeleport;
        public static CustomOption modifierAntiTeleportQuantity;

        public static CustomOption modifierTieBreaker;

        public static CustomOption modifierSunglasses;
        public static CustomOption modifierSunglassesQuantity;
        public static CustomOption modifierSunglassesVision;
        
        public static CustomOption modifierMini;
        public static CustomOption modifierMiniGrowingUpDuration;
        public static CustomOption modifierMiniGrowingUpInMeeting;

        public static CustomOption modifierVip;
        public static CustomOption modifierVipQuantity;
        public static CustomOption modifierVipShowColor;

        public static CustomOption modifierInvert;
        public static CustomOption modifierInvertQuantity;
        public static CustomOption modifierInvertDuration;

        public static CustomOption modifierChameleon;
        public static CustomOption modifierChameleonQuantity;
        public static CustomOption modifierChameleonHoldDuration;
        public static CustomOption modifierChameleonFadeDuration;
        public static CustomOption modifierChameleonMinVisibility;

        public static CustomOption modifierShifter;

        public static CustomOption maxNumberOfMeetings;
        public static CustomOption blockSkippingInEmergencyMeetings;
        public static CustomOption noVoteIsSelfVote;
        public static CustomOption hidePlayerNames;
        public static CustomOption allowParallelMedBayScans;
        public static CustomOption shieldFirstKill;
        public static CustomOption finishTasksBeforeHauntingOrZoomingOut;
        public static CustomOption camsNightVision;
        public static CustomOption camsNoNightVisionIfImpVision;

        public static CustomOption dynamicMap;
        public static CustomOption dynamicMapEnableSkeld;
        public static CustomOption dynamicMapEnableMira;
        public static CustomOption dynamicMapEnablePolus;
        public static CustomOption dynamicMapEnableAirShip;
        public static CustomOption dynamicMapEnableFungle;
        public static CustomOption dynamicMapEnableSubmerged;
        public static CustomOption dynamicMapSeparateSettings;

        //Guesser Gamemode
        public static CustomOption guesserGamemodeCrewNumber;
        public static CustomOption guesserGamemodeNeutralNumber;
        public static CustomOption guesserGamemodeImpNumber;
        public static CustomOption guesserForceJackalGuesser;
        public static CustomOption guesserForceThiefGuesser;
        public static CustomOption guesserGamemodeHaveModifier;
        public static CustomOption guesserGamemodeNumberOfShots;
        public static CustomOption guesserGamemodeHasMultipleShotsPerMeeting;
        public static CustomOption guesserGamemodeKillsThroughShield;
        public static CustomOption guesserGamemodeEvilCanKillSpy;
        public static CustomOption guesserGamemodeCantGuessSnitchIfTaksDone;

        // Hide N Seek Gamemode
        public static CustomOption hideNSeekHunterCount;
        public static CustomOption hideNSeekKillCooldown;
        public static CustomOption hideNSeekHunterVision;
        public static CustomOption hideNSeekHuntedVision;
        public static CustomOption hideNSeekTimer;
        public static CustomOption hideNSeekCommonTasks;
        public static CustomOption hideNSeekShortTasks;
        public static CustomOption hideNSeekLongTasks;
        public static CustomOption hideNSeekTaskWin;
        public static CustomOption hideNSeekTaskPunish;
        public static CustomOption hideNSeekCanSabotage;
        public static CustomOption hideNSeekMap;
        public static CustomOption hideNSeekHunterWaiting;

        public static CustomOption hunterLightCooldown;
        public static CustomOption hunterLightDuration;
        public static CustomOption hunterLightVision;
        public static CustomOption hunterLightPunish;
        public static CustomOption hunterAdminCooldown;
        public static CustomOption hunterAdminDuration;
        public static CustomOption hunterAdminPunish;
        public static CustomOption hunterArrowCooldown;
        public static CustomOption hunterArrowDuration;
        public static CustomOption hunterArrowPunish;

        public static CustomOption huntedShieldCooldown;
        public static CustomOption huntedShieldDuration;
        public static CustomOption huntedShieldRewindTime;
        public static CustomOption huntedShieldNumber;

        // Prop Hunt Settings
        public static CustomOption propHuntMap;
        public static CustomOption propHuntTimer;
        public static CustomOption propHuntNumberOfHunters;
        public static CustomOption hunterInitialBlackoutTime;
        public static CustomOption hunterMissCooldown;
        public static CustomOption hunterHitCooldown;
        public static CustomOption hunterMaxMissesBeforeDeath;
        public static CustomOption propBecomesHunterWhenFound;
        public static CustomOption propHunterVision;
        public static CustomOption propVision;
        public static CustomOption propHuntRevealCooldown;
        public static CustomOption propHuntRevealDuration;
        public static CustomOption propHuntRevealPunish;
        public static CustomOption propHuntUnstuckCooldown;
        public static CustomOption propHuntUnstuckDuration;
        public static CustomOption propHuntInvisCooldown;
        public static CustomOption propHuntInvisDuration;
        public static CustomOption propHuntSpeedboostCooldown;
        public static CustomOption propHuntSpeedboostDuration;
        public static CustomOption propHuntSpeedboostSpeed;
        public static CustomOption propHuntSpeedboostEnabled;
        public static CustomOption propHuntInvisEnabled;
        public static CustomOption propHuntAdminCooldown;
        public static CustomOption propHuntFindCooldown;
        public static CustomOption propHuntFindDuration;

        internal static Dictionary<byte, byte[]> blockedRolePairings = new Dictionary<byte, byte[]>();

        public static string cs(Color c, string s) {
            return string.Format("<color=#{0:X2}{1:X2}{2:X2}{3:X2}>{4}</color>", ToByte(c.r), ToByte(c.g), ToByte(c.b), ToByte(c.a), s);
        }
 
        private static byte ToByte(float f) {
            f = Mathf.Clamp01(f);
            return (byte)(f * 255);
        }

        public static bool isMapSelectionOption(CustomOption option) {
            return option == CustomOptionHolder.propHuntMap && option == CustomOptionHolder.hideNSeekMap;
        }

        public static void Load() {

            CustomOption.vanillaSettings = TheOtherRolesEditedPlugin.Instance.Config.Bind("Ԥ��0", "ģ��ѡ��", "");

            // Role Options
            presetSelection = CustomOption.Create(0, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "Ԥ��"), presets, null, true);
            activateRoles = CustomOption.Create(1, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "����ģ���ɫ����ֹʹ��ԭ���ɫ"), true, null, true);

            //if (Utilities.EventUtility.canBeEnabled) enableCodenameHorsemode = CustomOption.Create(10423, Types.General, cs(Color.green, "������ģʽ"), true, null, true);
            //if (Utilities.EventUtility.canBeEnabled) enableCodenameDisableHorses = CustomOption.Create(10424, Types.General, cs(Color.green, "������ģʽ"), false, enableCodenameHorsemode, false);
            if (Utilities.EventUtility.canBeEnabled) enableEventMode = CustomOption.Create(10423, Types.General, cs(Color.green, "�����ر�ģʽ"), true, null, true);


            // Using new id's for the options to not break compatibilty with older versions
            crewmateRolesCountMin = CustomOption.Create(300, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "���ٴ�Աְҵ"), 15f, 0f, 15f, 1f, null, true);
            crewmateRolesCountMax = CustomOption.Create(301, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��ബԱְҵ"), 15f, 0f, 15f, 1f);
            crewmateRolesFill = CustomOption.Create(308, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "���д�Աְҵ(��������/���ֵ)"), false);
            neutralRolesCountMin = CustomOption.Create(302, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��������ְҵ"), 15f, 0f, 15f, 1f);
            neutralRolesCountMax = CustomOption.Create(303, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "�������ְҵ"), 15f, 0f, 15f, 1f);
            impostorRolesCountMin = CustomOption.Create(304, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "�����ڹ�ְҵ"), 15f, 0f, 15f, 1f);
            impostorRolesCountMax = CustomOption.Create(305, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "����ڹ�ְҵ"), 15f, 0f, 15f, 1f);
            modifiersCountMin = CustomOption.Create(306, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "���ٸ���ְҵ"), 15f, 0f, 15f, 1f);
            modifiersCountMax = CustomOption.Create(307, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��฽��ְҵ"), 15f, 0f, 15f, 1f);

            mafiaSpawnRate = CustomOption.Create(18, Types.Impostor, cs(Janitor.color, "���ֵ�"), rates, null, true);
            janitorCooldown = CustomOption.Create(19, Types.Impostor, "��๤������ȴʱ��", 30f, 10f, 60f, 2.5f, mafiaSpawnRate);

            morphlingSpawnRate = CustomOption.Create(20, Types.Impostor, cs(Morphling.color, "������"), rates, null, true);
            morphlingCooldown = CustomOption.Create(21, Types.Impostor, "ȡ����ȴʱ��", 30f, 10f, 60f, 2.5f, morphlingSpawnRate);
            morphlingDuration = CustomOption.Create(22, Types.Impostor, "���γ���ʱ��", 10f, 1f, 20f, 0.5f, morphlingSpawnRate);

            camouflagerSpawnRate = CustomOption.Create(30, Types.Impostor, cs(Camouflager.color, "������"), rates, null, true);
            camouflagerCooldown = CustomOption.Create(31, Types.Impostor, "���μ�����ȴʱ��", 30f, 10f, 60f, 2.5f, camouflagerSpawnRate);
            camouflagerDuration = CustomOption.Create(32, Types.Impostor, "��ȴ���ܳ���ʱ��", 10f, 1f, 20f, 0.5f, camouflagerSpawnRate);

            vampireSpawnRate = CustomOption.Create(40, Types.Impostor, cs(Vampire.color, "��Ѫ��"), rates, null, true);
            vampireKillDelay = CustomOption.Create(41, Types.Impostor, "��Ѫ�����ӳٻ�ɱʱ��", 10f, 1f, 20f, 1f, vampireSpawnRate);
            vampireCooldown = CustomOption.Create(42, Types.Impostor, "��Ѫ������ȴʱ��", 30f, 10f, 60f, 2.5f, vampireSpawnRate);
            vampireCanKillNearGarlics = CustomOption.Create(43, Types.Impostor, "��Ѫ������ڴ��ⷶΧ�ڻ�ɱ", true, vampireSpawnRate);

            eraserSpawnRate = CustomOption.Create(230, Types.Impostor, cs(Eraser.color, "Ĩ����"), rates, null, true);
            eraserCooldown = CustomOption.Create(231, Types.Impostor, "Ĩ��������ȴʱ��", 30f, 10f, 120f, 5f, eraserSpawnRate);
            eraserCanEraseAnyone = CustomOption.Create(232, Types.Impostor, "����Ĩ�������˵�ְҵ(�������ѣ�", false, eraserSpawnRate);

            tricksterSpawnRate = CustomOption.Create(250, Types.Impostor, cs(Trickster.color, "ƭ��ʦ"), rates, null, true);
            tricksterPlaceBoxCooldown = CustomOption.Create(251, Types.Impostor, "���ú��Ӽ�����ȴʱ��", 10f, 2.5f, 30f, 2.5f, tricksterSpawnRate);
            tricksterLightsOutCooldown = CustomOption.Create(252, Types.Impostor, "Ϩ�Ƽ�����ȴʱ��", 30f, 10f, 60f, 5f, tricksterSpawnRate);
            tricksterLightsOutDuration = CustomOption.Create(253, Types.Impostor, "Ϩ�Ƽ��ܳ���ʱ��", 15f, 5f, 60f, 2.5f, tricksterSpawnRate);

            cleanerSpawnRate = CustomOption.Create(260, Types.Impostor, cs(Cleaner.color, "������"), rates, null, true);
            cleanerCooldown = CustomOption.Create(261, Types.Impostor, "��������ȴʱ��", 30f, 10f, 60f, 2.5f, cleanerSpawnRate);

            warlockSpawnRate = CustomOption.Create(270, Types.Impostor, cs(Cleaner.color, "��ʿ"), rates, null, true);
            warlockCooldown = CustomOption.Create(271, Types.Impostor, "���似����ȴʱ��", 30f, 10f, 60f, 2.5f, warlockSpawnRate);
            warlockRootTime = CustomOption.Create(272, Types.Impostor, "��ʿ����ʱ��", 5f, 0f, 15f, 1f, warlockSpawnRate);

            bountyHunterSpawnRate = CustomOption.Create(320, Types.Impostor, cs(BountyHunter.color, "�ͽ�����"), rates, null, true);
            bountyHunterBountyDuration = CustomOption.Create(321, Types.Impostor, "�ͽ�Ŀ���л�ʱ��",  60f, 10f, 180f, 10f, bountyHunterSpawnRate);
            bountyHunterReducedCooldown = CustomOption.Create(322, Types.Impostor, "��ɱ�ͽ�Ŀ����ɱ������ȴʱ��", 2.5f, 0f, 30f, 2.5f, bountyHunterSpawnRate);
            bountyHunterPunishmentTime = CustomOption.Create(323, Types.Impostor, "��ɱ���ͽ�Ŀ����ɱ������ȴʱ��", 20f, 0f, 60f, 2.5f, bountyHunterSpawnRate);
            bountyHunterShowArrow = CustomOption.Create(324, Types.Impostor, "��ʾָ���ͽ�Ŀ��ļ�ͷ", true, bountyHunterSpawnRate);
            bountyHunterArrowUpdateIntervall = CustomOption.Create(325, Types.Impostor, "�ͽ�Ŀ��λ�ø����ӳ�", 15f, 2.5f, 60f, 2.5f, bountyHunterShowArrow);

            witchSpawnRate = CustomOption.Create(370, Types.Impostor, cs(Witch.color, "Ů��"), rates, null, true);
            witchCooldown = CustomOption.Create(371, Types.Impostor, "Ů�����似����ȴʱ��", 30f, 10f, 120f, 5f, witchSpawnRate);
            witchAdditionalCooldown = CustomOption.Create(372, Types.Impostor, "Ů���������ʱ��", 10f, 0f, 60f, 5f, witchSpawnRate);
            witchCanSpellAnyone = CustomOption.Create(373, Types.Impostor, "Ů�׿�������������", false, witchSpawnRate);
            witchSpellCastingDuration = CustomOption.Create(374, Types.Impostor, "���似�ܳ���ʱ��", 1f, 0f, 10f, 1f, witchSpawnRate);
            witchTriggerBothCooldowns = CustomOption.Create(375, Types.Impostor, "����ͻ�ɱ������ȴʱ��", true, witchSpawnRate);
            witchVoteSavesTargets = CustomOption.Create(376, Types.Impostor, "Ů�������Ͷ���������߻��", true, witchSpawnRate);

            ninjaSpawnRate = CustomOption.Create(380, Types.Impostor, cs(Ninja.color, "����"), rates, null, true);
            ninjaCooldown = CustomOption.Create(381, Types.Impostor, "����ѡ��Ŀ����ȴʱ��", 30f, 10f, 120f, 5f, ninjaSpawnRate);
            ninjaKnowsTargetLocation = CustomOption.Create(382, Types.Impostor, "���߿�֪Ŀ���λ��", true, ninjaSpawnRate);
            ninjaTraceTime = CustomOption.Create(383, Types.Impostor, "��ɴ�ɱ����Ҷ���ٳ���ʱ��", 5f, 1f, 20f, 0.5f, ninjaSpawnRate);
            ninjaTraceColorTime = CustomOption.Create(384, Types.Impostor, "��Ҷ��ɫ��ʱ��", 2f, 0f, 20f, 0.5f, ninjaSpawnRate);
            ninjaInvisibleDuration = CustomOption.Create(385, Types.Impostor, "��������ʱ��", 3f, 0f, 20f, 1f, ninjaSpawnRate);

            bomberSpawnRate = CustomOption.Create(460, Types.Impostor, cs(Bomber.color, "��ը��"), rates, null, true);
            bomberBombDestructionTime = CustomOption.Create(461, Types.Impostor, "ը������ʱ��", 20f, 2.5f, 120f, 2.5f, bomberSpawnRate);
            bomberBombDestructionRange = CustomOption.Create(462, Types.Impostor, "ը���ƻ���Χ", 50f, 5f, 150f, 5f, bomberSpawnRate);
            bomberBombHearRange = CustomOption.Create(463, Types.Impostor, "ը����ը��Χ", 60f, 5f, 150f, 5f, bomberSpawnRate);
            bomberDefuseDuration = CustomOption.Create(464, Types.Impostor, "�𵯳���ʱ��", 3f, 0.5f, 30f, 0.5f, bomberSpawnRate);
            bomberBombCooldown = CustomOption.Create(465, Types.Impostor, "ը��������ȴʱ��", 15f, 2.5f, 30f, 2.5f, bomberSpawnRate);
            bomberBombActiveAfter = CustomOption.Create(466, Types.Impostor, "Bomb Is Active After", 3f, 0.5f, 15f, 0.5f, bomberSpawnRate);

            yoyoSpawnRate = CustomOption.Create(470, Types.Impostor, cs(Yoyo.color, "Yoyo"), rates, null, true);
            yoyoBlinkDuration = CustomOption.Create(471, Types.Impostor, "˲�Ƴ���ʱ��", 20f, 2.5f, 120f, 2.5f, yoyoSpawnRate);
            yoyoMarkCooldown = CustomOption.Create(472, Types.Impostor, "���λ����ȴʱ��", 20f, 2.5f, 120f, 2.5f, yoyoSpawnRate);
            yoyoMarkStaysOverMeeting = CustomOption.Create(473, Types.Impostor, "��ǵ�λ�û����������", true, yoyoSpawnRate);
            yoyoHasAdminTable = CustomOption.Create(474, Types.Impostor, "ӵ�б�Яʽ��ͼ", true, yoyoSpawnRate);
            yoyoAdminTableCooldown = CustomOption.Create(475, Types.Impostor, "��Яʽ��ͼ��ȴʱ��", 20f, 2.5f, 120f, 2.5f, yoyoHasAdminTable);
            yoyoSilhouetteVisibility = CustomOption.Create(476, Types.Impostor, "��Ӱ�ɼ���", new string[] { "0%", "10%", "20%", "30%", "40%", "50%" }, yoyoSpawnRate);

            guesserSpawnRate = CustomOption.Create(310, Types.Neutral, cs(Guesser.color, "�Ĺ�"), rates, null, true);
            guesserIsImpGuesserRate = CustomOption.Create(311, Types.Neutral, "�Ĺ����ڹ�Ļ���", rates, guesserSpawnRate);
            guesserNumberOfShots = CustomOption.Create(312, Types.Neutral, "�ĹֵĶ�ɱ����", 2f, 1f, 15f, 1f, guesserSpawnRate);
            guesserHasMultipleShotsPerMeeting = CustomOption.Create(313, Types.Neutral, "�Ĺֿ����ڻ����϶�ζ�ɱ", false, guesserSpawnRate);
            guesserKillsThroughShield  = CustomOption.Create(315, Types.Neutral, "�Ĺֶ�ɱʱ����ҽ���Ķ�", true, guesserSpawnRate);
            guesserEvilCanKillSpy  = CustomOption.Create(316, Types.Neutral, "а��ĶĹֿ��Զ�ɱ�Ե�", true, guesserSpawnRate);
            guesserSpawnBothRate = CustomOption.Create(317, Types.Neutral, "�����ĹֵĻ���", rates, guesserSpawnRate);
            guesserCantGuessSnitchIfTaksDone = CustomOption.Create(318, Types.Neutral, "�Ĺ��޷���ɱ�������ĸ�����", true, guesserSpawnRate);

            jesterSpawnRate = CustomOption.Create(60, Types.Neutral, cs(Jester.color, "С��"), rates, null, true);
            jesterCanCallEmergency = CustomOption.Create(61, Types.Neutral, "С������ٿ���������", true, jesterSpawnRate);
            jesterHasImpostorVision = CustomOption.Create(62, Types.Neutral, "С�����ڹ����Ұ", false, jesterSpawnRate);

            arsonistSpawnRate = CustomOption.Create(290, Types.Neutral, cs(Arsonist.color, "�ݻ�"), rates, null, true);
            arsonistCooldown = CustomOption.Create(291, Types.Neutral, "���ͼ�����ȴʱ��", 12.5f, 2.5f, 60f, 2.5f, arsonistSpawnRate);
            arsonistDuration = CustomOption.Create(292, Types.Neutral, "���ͼ��ܳ���ʱ��", 3f, 1f, 10f, 1f, arsonistSpawnRate);

            jackalSpawnRate = CustomOption.Create(220, Types.Neutral, cs(Jackal.color, "����"), rates, null, true);
            jackalKillCooldown = CustomOption.Create(221, Types.Neutral, "����/����Ļ�ɱ��ȴʱ��", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalCreateSidekickCooldown = CustomOption.Create(222, Types.Neutral, "������ļ������ȴʱ��", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalCanUseVents = CustomOption.Create(223, Types.Neutral, "���ǿ���ʹ�ùܵ�", true, jackalSpawnRate);
            jackalCanCreateSidekick = CustomOption.Create(224, Types.Neutral, "���ǿ�����ļһ������", false, jackalSpawnRate);
            sidekickPromotesToJackal = CustomOption.Create(225, Types.Neutral, "�����ڲ��������������", false, jackalCanCreateSidekick);
            sidekickCanKill = CustomOption.Create(226, Types.Neutral, "������Ի�ɱ", false, jackalCanCreateSidekick);
            sidekickCanUseVents = CustomOption.Create(227, Types.Neutral, "�������ʹ�ùܵ�", true, jackalCanCreateSidekick);
            jackalPromotedFromSidekickCanCreateSidekick = CustomOption.Create(228, Types.Neutral, "�����ĸ������ӵ����ļ����", true, sidekickPromotesToJackal);
            jackalCanCreateSidekickFromImpostor = CustomOption.Create(229, Types.Neutral, "���ǿ�����ļ�ڹ�Ϊ�Լ��ĸ���", true, jackalCanCreateSidekick);
            jackalAndSidekickHaveImpostorVision = CustomOption.Create(430, Types.Neutral, "���Ǻ͸���ӵ���ڹ����Ұ", false, jackalSpawnRate);

            vultureSpawnRate = CustomOption.Create(340, Types.Neutral, cs(Vulture.color, "ͺ��"), rates, null, true);
            vultureCooldown = CustomOption.Create(341, Types.Neutral, "���ɼ�����ȴʱ��", 15f, 10f, 60f, 2.5f, vultureSpawnRate);
            vultureNumberToWin = CustomOption.Create(342, Types.Neutral, "��Ҫ�Ե���ʬ������", 4f, 1f, 10f, 1f, vultureSpawnRate);
            vultureCanUseVents = CustomOption.Create(343, Types.Neutral, "ͺ�տ���ʹ�ùܵ�", true, vultureSpawnRate);
            vultureShowArrows = CustomOption.Create(344, Types.Neutral, "ͺ�տ�����ָ��ʬ��ļ�ͷ", true, vultureSpawnRate);

            lawyerSpawnRate = CustomOption.Create(350, Types.Neutral, cs(Lawyer.color, "��ʦ"), rates, null, true);
            lawyerIsProsecutorChance = CustomOption.Create(358, Types.Neutral, "��ʦ�������˵Ŀ�����", rates, lawyerSpawnRate);
            lawyerVision = CustomOption.Create(354, Types.Neutral, "��Ұ", 1f, 0.25f, 3f, 0.25f, lawyerSpawnRate);
            lawyerKnowsRole = CustomOption.Create(355, Types.Neutral, "��ʦ/������֪��Ŀ���ְҵ", false, lawyerSpawnRate);
            lawyerCanCallEmergency = CustomOption.Create(352, Types.Neutral, "��ʦ/�����˿����ٿ���������", true, lawyerSpawnRate);
            lawyerTargetCanBeJester = CustomOption.Create(351, Types.Neutral, "��ʦ�Ŀͻ�������С��", false, lawyerSpawnRate);
            pursuerCooldown = CustomOption.Create(356, Types.Neutral, "�����˿հ���������ȴʱ��", 30f, 5f, 60f, 2.5f, lawyerSpawnRate);
            pursuerBlanksNumber = CustomOption.Create(357, Types.Neutral, "�����˿հ���������", 5f, 1f, 20f, 1f, lawyerSpawnRate);

            mayorSpawnRate = CustomOption.Create(80, Types.Crewmate, cs(Mayor.color, "�г�"), rates, null, true);
            mayorCanSeeVoteColors = CustomOption.Create(81, Types.Crewmate, "�г����Կ���ͶƱ�ߵ���ɫ", false, mayorSpawnRate);
            mayorTasksNeededToSeeVoteColors = CustomOption.Create(82, Types.Crewmate, "�鿴ͶƱ��ɫ������ɵ�����", 5f, 0f, 20f, 1f, mayorCanSeeVoteColors);
            mayorMeetingButton = CustomOption.Create(83, Types.Crewmate, "���ñ�Яʽ�ƶ���������", true, mayorSpawnRate);
            mayorMaxRemoteMeetings = CustomOption.Create(84, Types.Crewmate, "��������Ĵ���", 1f, 1f, 5f, 1f, mayorMeetingButton);
            mayorChooseSingleVote = CustomOption.Create(85, Types.Crewmate, "�г�����ѡ��Ʊ", new string[] { "�ر�", "����(����֮ǰ)", "����(ֱ���������)" }, mayorSpawnRate);

            engineerSpawnRate = CustomOption.Create(90, Types.Crewmate, cs(Engineer.color, "����ʦ"), rates, null, true);
            engineerNumberOfFixes = CustomOption.Create(91, Types.Crewmate, "�����ܴ���", 1f, 1f, 3f, 1f, engineerSpawnRate);
            engineerHighlightForImpostors = CustomOption.Create(92, Types.Crewmate, "�ڹ���Կ�������ʦ�ڹܵ���", true, engineerSpawnRate);
            engineerHighlightForTeamJackal = CustomOption.Create(93, Types.Crewmate, "���Ǻ͸�����Կ�������ʦ�ڹܵ���", true, engineerSpawnRate);

            sheriffSpawnRate = CustomOption.Create(100, Types.Crewmate, cs(Sheriff.color, "����"), rates, null, true);
            sheriffCooldown = CustomOption.Create(101, Types.Crewmate, "��ɱ��ȴʱ��", 30f, 10f, 60f, 2.5f, sheriffSpawnRate);
            sheriffCanKillNeutrals = CustomOption.Create(102, Types.Crewmate, "�������Ի�ɱ������Ӫ�����", false, sheriffSpawnRate);
            deputySpawnRate = CustomOption.Create(103, Types.Crewmate, "��������ӵ��һ������", rates, sheriffSpawnRate);
            deputyNumberOfHandcuffs = CustomOption.Create(104, Types.Crewmate, "��������������", 3f, 1f, 10f, 1f, deputySpawnRate);
            deputyHandcuffCooldown = CustomOption.Create(105, Types.Crewmate, "����������ȴʱ��", 30f, 10f, 60f, 2.5f, deputySpawnRate);
            deputyHandcuffDuration = CustomOption.Create(106, Types.Crewmate, "�����������ʱ��", 15f, 5f, 60f, 2.5f, deputySpawnRate);
            deputyKnowsSheriff = CustomOption.Create(107, Types.Crewmate, "�����Ͳ��������ʶ", true, deputySpawnRate);
            deputyGetsPromoted = CustomOption.Create(108, Types.Crewmate, "�������󲶿���Խ�������", new string[] { "�ر�", "����(���ڱ仯)", "����(����֮��仯)" }, deputySpawnRate);
            deputyKeepsHandcuffs = CustomOption.Create(109, Types.Crewmate, "���������������������", true, deputyGetsPromoted);

            lighterSpawnRate = CustomOption.Create(110, Types.Crewmate, cs(Lighter.color, "ִ����"), rates, null, true);
            lighterModeLightsOnVision = CustomOption.Create(111, Types.Crewmate, "�ƹ���Ұ����", 1.5f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterModeLightsOffVision = CustomOption.Create(112, Types.Crewmate, "�ƹ���Ұ�ر�", 0.5f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterFlashlightWidth = CustomOption.Create(113, Types.Crewmate, "�ƹ���Ұ���", 0.3f, 0.1f, 1f, 0.1f, lighterSpawnRate);

            detectiveSpawnRate = CustomOption.Create(120, Types.Crewmate, cs(Detective.color, "��̽"), rates, null, true);
            detectiveAnonymousFootprints = CustomOption.Create(121, Types.Crewmate, "������ӡ", false, detectiveSpawnRate); 
            detectiveFootprintIntervall = CustomOption.Create(122, Types.Crewmate, "��ӡ���", 0.5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveFootprintDuration = CustomOption.Create(123, Types.Crewmate, "��ӡ����ʱ��", 5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveReportNameDuration = CustomOption.Create(124, Types.Crewmate, "��һ����ʱ������̽���������ֵ�����", 0, 0, 60, 2.5f, detectiveSpawnRate);
            detectiveReportColorDuration = CustomOption.Create(125, Types.Crewmate, "��һ����ʱ������̽��������ɫ����", 20, 0, 120, 2.5f, detectiveSpawnRate);

            timeMasterSpawnRate = CustomOption.Create(130, Types.Crewmate, cs(TimeMaster.color, "ʱ��֮��"), rates, null, true);
            timeMasterCooldown = CustomOption.Create(131, Types.Crewmate, "ʱ��֮����ȴʱ��", 30f, 10f, 120f, 2.5f, timeMasterSpawnRate);
            timeMasterRewindTime = CustomOption.Create(132, Types.Crewmate, "����ʱ��", 3f, 1f, 10f, 1f, timeMasterSpawnRate);
            timeMasterShieldDuration = CustomOption.Create(133, Types.Crewmate, "ʱ��֮�ܳ���ʱ��", 3f, 1f, 20f, 1f, timeMasterSpawnRate);

            medicSpawnRate = CustomOption.Create(140, Types.Crewmate, cs(Medic.color, "ҽ��"), rates, null, true);
            medicShowShielded = CustomOption.Create(143, Types.Crewmate, "��ʾ���ܱ��������", new string[] {"�����˿ɼ�", "�������ߺ�ҽ���ɼ�", "��ҽ���ɼ�"}, medicSpawnRate);
            medicShowAttemptToShielded = CustomOption.Create(144, Types.Crewmate, "�����ܱ���������类��ɱ��������һ�����ʾ", false, medicSpawnRate);
            medicSetOrShowShieldAfterMeeting = CustomOption.Create(145, Types.Crewmate, "���ܽ�������", new string[] { "����", "�����\n�����ɼ��ɼ�", "�����" }, medicSpawnRate);

            medicShowAttemptToMedic = CustomOption.Create(146, Types.Crewmate, "�����ܱ���������类��ɱҽ��������ʾ", false, medicSpawnRate);

            swapperSpawnRate = CustomOption.Create(150, Types.Crewmate, cs(Swapper.color, "��Ʊʦ"), rates, null, true);
            swapperCanCallEmergency = CustomOption.Create(151, Types.Crewmate, "��Ʊʦ���Կ�����������", false, swapperSpawnRate);
            swapperCanOnlySwapOthers = CustomOption.Create(152, Types.Crewmate, "��Ʊʦֻ�ܽ��������˵�Ʊ��", false, swapperSpawnRate);

            swapperSwapsNumber = CustomOption.Create(153, Types.Crewmate, "��ʼ��Ʊ����", 1f, 0f, 5f, 1f, swapperSpawnRate);
            swapperRechargeTasksNumber = CustomOption.Create(154, Types.Crewmate, "���������������", 2f, 1f, 10f, 1f, swapperSpawnRate);


            seerSpawnRate = CustomOption.Create(160, Types.Crewmate, cs(Seer.color, "��ý"), rates, null, true);
            seerMode = CustomOption.Create(161, Types.Crewmate, "��ý����Ϸ�еļ���", new string[]{ "��ʾ�������� + ���", "ֻ��ʾ��������", "ֻ��ʾ���"}, seerSpawnRate);
            seerLimitSoulDuration = CustomOption.Create(163, Types.Crewmate, "��ý�ɿ������ĳ���ʱ��", false, seerSpawnRate);
            seerSoulDuration = CustomOption.Create(162, Types.Crewmate, "��ý�������ĳ���ʱ��", 15f, 0f, 120f, 5f, seerLimitSoulDuration);
        
            hackerSpawnRate = CustomOption.Create(170, Types.Crewmate, cs(Hacker.color, "�ڿ�"), rates, null, true);
            hackerCooldown = CustomOption.Create(171, Types.Crewmate, "���뼼����ȴʱ��", 30f, 5f, 60f, 5f, hackerSpawnRate);
            hackerHackeringDuration = CustomOption.Create(172, Types.Crewmate, "���뼼�ܳ���ʱ��", 10f, 2.5f, 60f, 2.5f, hackerSpawnRate);
            hackerOnlyColorType = CustomOption.Create(173, Types.Crewmate, "�ڿ�ֻ���ڹ����ҿ��������ɫ", false, hackerSpawnRate);
            hackerToolsNumber = CustomOption.Create(174, Types.Crewmate, "����ƶ�װ�õĳ��ܴ���", 5f, 1f, 30f, 1f, hackerSpawnRate);
            hackerRechargeTasksNumber = CustomOption.Create(175, Types.Crewmate, "���������������", 2f, 1f, 5f, 1f, hackerSpawnRate);
            hackerNoMove = CustomOption.Create(176, Types.Crewmate, "��ʹ���ƶ��豸ʱ�޷��ƶ�", true, hackerSpawnRate);

            trackerSpawnRate = CustomOption.Create(200, Types.Crewmate, cs(Tracker.color, "׷����"), rates, null, true);
            trackerUpdateIntervall = CustomOption.Create(201, Types.Crewmate, "׷���߼�ͷ�����ӳ�", 5f, 1f, 30f, 1f, trackerSpawnRate);
            trackerResetTargetAfterMeeting = CustomOption.Create(202, Types.Crewmate, "׷�����ڻ��������׷��", false, trackerSpawnRate);
            trackerCanTrackCorpses = CustomOption.Create(203, Types.Crewmate, "׷���߿���׷��ʬ��", true, trackerSpawnRate);
            trackerCorpsesTrackingCooldown = CustomOption.Create(204, Types.Crewmate, "׷��ʬ����ȴʱ��", 30f, 5f, 120f, 5f, trackerCanTrackCorpses);
            trackerCorpsesTrackingDuration = CustomOption.Create(205, Types.Crewmate, "׷��ʬ�����ʱ��", 5f, 2.5f, 30f, 2.5f, trackerCanTrackCorpses);
                           
            snitchSpawnRate = CustomOption.Create(210, Types.Crewmate, cs(Snitch.color, "������"), rates, null, true);
            snitchLeftTasksForReveal = CustomOption.Create(219, Types.Crewmate, "��������ʣ�¶���ʱִ�еõ�����λ��", 5f, 0f, 25f, 1f, snitchSpawnRate);
            snitchMode = CustomOption.Create(211, Types.Crewmate, "��Ϣģʽ", new string[] { "����", "��ͼ", "���� & ��ͼ" }, snitchSpawnRate);
            snitchTargets = CustomOption.Create(212, Types.Crewmate, "Ŀ��", new string[] { "�����ڹ� & ����(����)���", "��ɱ���" }, snitchSpawnRate);

            spySpawnRate = CustomOption.Create(240, Types.Crewmate, cs(Spy.color, "�Ե�"), rates, null, true);
            spyCanDieToSheriff = CustomOption.Create(241, Types.Crewmate, "�Ե׿��Է��������Ļ�ɱ", false, spySpawnRate);
            spyImpostorsCanKillAnyone = CustomOption.Create(242, Types.Crewmate, "�����Ե�ʱ�ڹ���Ի�ɱ������(��������)", true, spySpawnRate);
            spyCanEnterVents = CustomOption.Create(243, Types.Crewmate, "�Ե׿���ʹ�ùܵ�", false, spySpawnRate);
            spyHasImpostorVision = CustomOption.Create(244, Types.Crewmate, "�Ե����ڹ���Ұ", false, spySpawnRate);

            portalmakerSpawnRate = CustomOption.Create(390, Types.Crewmate, cs(Portalmaker.color, "����ʦ"), rates, null, true);
            portalmakerCooldown = CustomOption.Create(391, Types.Crewmate, "������ż�����ȴʱ��", 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerUsePortalCooldown = CustomOption.Create(392, Types.Crewmate, "ʹ�ô�������ȴʱ��", 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerLogOnlyColorType = CustomOption.Create(393, Types.Crewmate, "����ʦ����־��ʾ��ɫ����", true, portalmakerSpawnRate);
            portalmakerLogHasTime = CustomOption.Create(394, Types.Crewmate, "��־��ʾʱ��", true, portalmakerSpawnRate);
            portalmakerCanPortalFromAnywhere = CustomOption.Create(395, Types.Crewmate, "����ʦ���Դ��κεط�ֱ�ﴫ���Ŵ�", true, portalmakerSpawnRate);

            securityGuardSpawnRate = CustomOption.Create(280, Types.Crewmate, cs(SecurityGuard.color, "����"), rates, null, true);
            securityGuardCooldown = CustomOption.Create(281, Types.Crewmate, "����������ȴʱ��", 30f, 10f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardTotalScrews = CustomOption.Create(282, Types.Crewmate, "������˿����", 7f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamPrice = CustomOption.Create(283, Types.Crewmate, "ÿ�����������˿����", 2f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardVentPrice = CustomOption.Create(284, Types.Crewmate, "ÿ���ܵ�������˿����", 1f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamDuration = CustomOption.Create(285, Types.Crewmate, "�������ܳ���ʱ��", 10f, 2.5f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardCamMaxCharges = CustomOption.Create(286, Types.Crewmate, "��˿������", 5f, 1f, 30f, 1f, securityGuardSpawnRate);
            securityGuardCamRechargeTasksNumber = CustomOption.Create(287, Types.Crewmate, "��Яʽ��������������������", 3f, 1f, 10f, 1f, securityGuardSpawnRate);
            securityGuardNoMove = CustomOption.Create(288, Types.Crewmate, "��ʹ�ñ�Яʽ�����ʱ�޷��ƶ�", true, securityGuardSpawnRate);

            mediumSpawnRate = CustomOption.Create(360, Types.Crewmate, cs(Medium.color, "ͨ��ʦ"), rates, null, true);
            mediumCooldown = CustomOption.Create(361, Types.Crewmate, "ͨ�鼼����ȴʱ��", 30f, 5f, 120f, 5f, mediumSpawnRate);
            mediumDuration = CustomOption.Create(362, Types.Crewmate, "ͨ�鼼�ܳ���ʱ��", 3f, 0f, 15f, 1f, mediumSpawnRate);
            mediumOneTimeUse = CustomOption.Create(363, Types.Crewmate, "ÿ�����ֻ�ܱ�ͨ��һ��", false, mediumSpawnRate);
            mediumChanceAdditionalInfo = CustomOption.Create(364, Types.Crewmate, "��Ϣ�Ļ��� \n    ������Ϣ", rates, mediumSpawnRate);

            thiefSpawnRate = CustomOption.Create(400, Types.Neutral, cs(Thief.color, "ǿ��"), rates, null, true);
            thiefCooldown = CustomOption.Create(401, Types.Neutral, "���Ἴ����ȴʱ��", 30f, 5f, 120f, 5f, thiefSpawnRate);
            thiefCanKillSheriff = CustomOption.Create(402, Types.Neutral, "ǿ�����Ի�ɱ����", true, thiefSpawnRate);
            thiefHasImpVision = CustomOption.Create(403, Types.Neutral, "ǿ��ӵ���ڹ����Ұ", true, thiefSpawnRate);
            thiefCanUseVents = CustomOption.Create(404, Types.Neutral, "ǿ������ʹ�ùܵ�", true, thiefSpawnRate);
            thiefCanStealWithGuess = CustomOption.Create(405, Types.Neutral, "ǿ������ͨ����ɱ�õ�ְҵ(�Ĺ�ģʽ)", false, thiefSpawnRate);

            trapperSpawnRate = CustomOption.Create(410, Types.Crewmate, cs(Trapper.color, "����"), rates, null, true);
            trapperCooldown = CustomOption.Create(420, Types.Crewmate, "���弼����ȴʱ��", 30f, 5f, 120f, 5f, trapperSpawnRate);
            trapperMaxCharges = CustomOption.Create(440, Types.Crewmate, "�����������ĳ���", 5f, 1f, 15f, 1f, trapperSpawnRate);
            trapperRechargeTasksNumber = CustomOption.Create(450, Types.Crewmate, "���������������", 2f, 1f, 15f, 1f, trapperSpawnRate);
            trapperTrapNeededTriggerToReveal = CustomOption.Create(451, Types.Crewmate, "������Ҫ���������ܽ�ʾ", 3f, 2f, 10f, 1f, trapperSpawnRate);
            trapperAnonymousMap = CustomOption.Create(452, Types.Crewmate, "��ʾ������ͼ", false, trapperSpawnRate);
            trapperInfoType = CustomOption.Create(453, Types.Crewmate, "������Ϣ����", new string[] { "ְҵ", "����/а���ְҵ", "����" }, trapperSpawnRate);
            trapperTrapDuration = CustomOption.Create(454, Types.Crewmate, "�������ʱ��", 5f, 1f, 15f, 1f, trapperSpawnRate);

            // Modifier (1000 - 1999)
            modifiersAreHidden = CustomOption.Create(1009, Types.Modifier, cs(Color.yellow, "�������ظ���ְҵ"), true, null, true);

            modifierBloody = CustomOption.Create(1000, Types.Modifier, cs(Color.yellow, "��Ѫ��"), rates, null, true);
            modifierBloodyQuantity = CustomOption.Create(1001, Types.Modifier, cs(Color.yellow, "��Ѫ������"), ratesModifier, modifierBloody);
            modifierBloodyDuration = CustomOption.Create(1002, Types.Modifier, "ѪҺ����ʱ��", 10f, 3f, 60f, 1f, modifierBloody);

            modifierAntiTeleport = CustomOption.Create(1010, Types.Modifier, cs(Color.yellow, "���˶�"), rates, null, true);
            modifierAntiTeleportQuantity = CustomOption.Create(1011, Types.Modifier, cs(Color.yellow, "���˶�����"), ratesModifier, modifierAntiTeleport);

            modifierTieBreaker = CustomOption.Create(1020, Types.Modifier, cs(Color.yellow, "��ƽ��"), rates, null, true);

            modifierBait = CustomOption.Create(1030, Types.Modifier, cs(Color.yellow, "�ն�"), rates, null, true);
            modifierBaitQuantity = CustomOption.Create(1031, Types.Modifier, cs(Color.yellow, "�ն�����"), ratesModifier, modifierBait);
            modifierBaitReportDelayMin = CustomOption.Create(1032, Types.Modifier, "�ն������ӳ���Сֵ", 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitReportDelayMax = CustomOption.Create(1033, Types.Modifier, "�ն������ӳ����ֵ", 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitShowKillFlash = CustomOption.Create(1034, Types.Modifier, "�����⾯������", true, modifierBait);

            modifierLover = CustomOption.Create(1040, Types.Modifier, cs(Color.yellow, "����"), rates, null, true);
            modifierLoverImpLoverRate = CustomOption.Create(1041, Types.Modifier, "һ���ڹ����˵Ļ���", rates, modifierLover);
            modifierLoverBothDie = CustomOption.Create(1042, Types.Modifier, "����ͬ������", true, modifierLover);
            modifierLoverEnableChat = CustomOption.Create(1043, Types.Modifier, "��������˽������", true, modifierLover);

            modifierSunglasses = CustomOption.Create(1050, Types.Modifier, cs(Color.yellow, "̫����"), rates, null, true);
            modifierSunglassesQuantity = CustomOption.Create(1051, Types.Modifier, cs(Color.yellow, "̫��������"), ratesModifier, modifierSunglasses);
            modifierSunglassesVision = CustomOption.Create(1052, Types.Modifier, "̫������Ұ", new string[] { "-10%", "-20%", "-30%", "-40%", "-50%" }, modifierSunglasses);

            modifierMini = CustomOption.Create(1061, Types.Modifier, cs(Color.yellow, "���㴬Ա"), rates, null, true);
            modifierMiniGrowingUpDuration = CustomOption.Create(1062, Types.Modifier, "���㴬Ա�ɳ�ʱ��", 400f, 100f, 1500f, 100f, modifierMini);
            modifierMiniGrowingUpInMeeting = CustomOption.Create(1063, Types.Modifier, "���㴬Ա�ڻ����гɳ�", true, modifierMini);

            modifierVip = CustomOption.Create(1070, Types.Modifier, cs(Color.yellow, "VIP"), rates, null, true);
            modifierVipQuantity = CustomOption.Create(1071, Types.Modifier, cs(Color.yellow, "VIP����"), ratesModifier, modifierVip);
            modifierVipShowColor = CustomOption.Create(1072, Types.Modifier, "��ʾ�Ŷ���ɫ", true, modifierVip);

            modifierInvert = CustomOption.Create(1080, Types.Modifier, cs(Color.yellow, "�ƹ�"), rates, null, true);
            modifierInvertQuantity = CustomOption.Create(1081, Types.Modifier, cs(Color.yellow, "�ƹ�����"), ratesModifier, modifierInvert);
            modifierInvertDuration = CustomOption.Create(1082, Types.Modifier, "�ߵ��Ļ������", 3f, 1f, 15f, 1f, modifierInvert);

            modifierChameleon = CustomOption.Create(1090, Types.Modifier, cs(Color.yellow, "��ɫ��"), rates, null, true);
            modifierChameleonQuantity = CustomOption.Create(1091, Types.Modifier, cs(Color.yellow, "��ɫ������"), ratesModifier, modifierChameleon);
            modifierChameleonHoldDuration = CustomOption.Create(1092, Types.Modifier, "��ɫ��ʼʱ��", 3f, 1f, 10f, 0.5f, modifierChameleon);
            modifierChameleonFadeDuration = CustomOption.Create(1093, Types.Modifier, "͸������ʱ��", 1f, 0.25f, 10f, 0.25f, modifierChameleon);
            modifierChameleonMinVisibility = CustomOption.Create(1094, Types.Modifier, "��Ϳɼ���", new string[] { "0%", "10%", "20%", "30%", "40%", "50%" }, modifierChameleon);

            modifierShifter = CustomOption.Create(1100, Types.Modifier, cs(Color.yellow, "����"), rates, null, true);

            // Guesser Gamemode (2000 - 2999)
            guesserGamemodeCrewNumber = CustomOption.Create(2001, Types.Guesser, cs(Guesser.color, "��Ա��Ӫ��ɱ����"), 15f, 1f, 15f, 1f, null, true);
            guesserGamemodeNeutralNumber = CustomOption.Create(2002, Types.Guesser, cs(Guesser.color, "������Ӫ��ɱ����"), 15f, 1f, 15f, 1f, null, true);
            guesserGamemodeImpNumber = CustomOption.Create(2003, Types.Guesser, cs(Guesser.color, "�ڹ���Ӫ��ɱ����"), 15f, 1f, 15f, 1f, null, true);
            guesserForceJackalGuesser = CustomOption.Create(2007, Types.Guesser, "ǿ�Ʋ���Ϊ�Ĺ�", false, null, true);
            guesserForceThiefGuesser = CustomOption.Create(2011, Types.Guesser, "ǿ��ǿ��Ϊ�Ĺ�", false, null, true);
            guesserGamemodeHaveModifier = CustomOption.Create(2004, Types.Guesser, "�Ĺֿ�����һ������ְҵ", true, null);
            guesserGamemodeNumberOfShots = CustomOption.Create(2005, Types.Guesser, "�Ĺֶ�ɱ����", 3f, 1f, 15f, 1f, null);
            guesserGamemodeHasMultipleShotsPerMeeting = CustomOption.Create(2006, Types.Guesser, "�Ĺֿ�����ͬһ�ֻ����϶�ζ�ɱ", false, null);
            guesserGamemodeKillsThroughShield = CustomOption.Create(2008, Types.Guesser, "�Ĺ�����ҽ���Ļ���", true, null);
            guesserGamemodeEvilCanKillSpy = CustomOption.Create(2009, Types.Guesser, "а��Ĺֿ��Զ�ɱ�Ե�", true, null);
            guesserGamemodeCantGuessSnitchIfTaksDone = CustomOption.Create(2010, Types.Guesser, "�Ĺֲ��ܶ�ɱ�������ĸ�����", true, null);

            // Hide N Seek Gamemode (3000 - 3999)
            hideNSeekMap = CustomOption.Create(3020, Types.HideNSeekMain, cs(Color.yellow, "��ͼ"), new string[] { "���ý�", "����HQ", "��³˹", "�߿շ�ͧ", "�������", "�Ǳͧ", "LI��ͼ"}, null, true, onChange: () => { int map = hideNSeekMap.selection; if (map >= 3) map++; GameOptionsManager.Instance.currentNormalGameOptions.MapId = (byte)map; });
            hideNSeekHunterCount = CustomOption.Create(3000, Types.HideNSeekMain, cs(Color.yellow, "��������"), 1f, 1f, 3f, 1f);
            hideNSeekKillCooldown = CustomOption.Create(3021, Types.HideNSeekMain, cs(Color.yellow, "��ɱ��ȴ"), 10f, 2.5f, 60f, 2.5f);
            hideNSeekHunterVision = CustomOption.Create(3001, Types.HideNSeekMain, cs(Color.yellow, "������Ұ"), 0.5f, 0.25f, 2f, 0.25f);
            hideNSeekHuntedVision = CustomOption.Create(3002, Types.HideNSeekMain, cs(Color.yellow, "�������Ұ"), 2f, 0.25f, 5f, 0.25f);
            hideNSeekCommonTasks = CustomOption.Create(3023, Types.HideNSeekMain, cs(Color.yellow, "��ͨ������"), 1f, 0f, 4f, 1f);
            hideNSeekShortTasks = CustomOption.Create(3024, Types.HideNSeekMain, cs(Color.yellow, "��������"), 3f, 1f, 23f, 1f);
            hideNSeekLongTasks = CustomOption.Create(3025, Types.HideNSeekMain, cs(Color.yellow, "��������"), 3f, 0f, 15f, 1f);
            hideNSeekTimer = CustomOption.Create(3003, Types.HideNSeekMain, cs(Color.yellow, "��ʱ����Сֵ"), 5f, 1f, 30f, 0.5f);
            hideNSeekTaskWin = CustomOption.Create(3004, Types.HideNSeekMain, cs(Color.yellow, "���������ʤ"), false);
            hideNSeekTaskPunish = CustomOption.Create(3017, Types.HideNSeekMain, cs(Color.yellow, "�������ͷ�����"), 10f, 0f, 30f, 1f);
            hideNSeekCanSabotage = CustomOption.Create(3019, Types.HideNSeekMain, cs(Color.yellow, "�����ƻ�"), false);
            hideNSeekHunterWaiting = CustomOption.Create(3022, Types.HideNSeekMain, cs(Color.yellow, "������Ҫ�ȴ���ʱ��"), 15f, 2.5f, 60f, 2.5f);

            hunterLightCooldown = CustomOption.Create(3005, Types.HideNSeekRoles, cs(Color.red, "���˵����ȴ"), 30f, 5f, 60f, 1f, null, true);
            hunterLightDuration = CustomOption.Create(3006, Types.HideNSeekRoles, cs(Color.red, "���˵�Ƴ���ʱ��"), 5f, 1f, 60f, 1f);
            hunterLightVision = CustomOption.Create(3007, Types.HideNSeekRoles, cs(Color.red, "���˵����Ұ"), 3f, 1f, 5f, 0.25f);
            hunterLightPunish = CustomOption.Create(3008, Types.HideNSeekRoles, cs(Color.red, "���˵�Ƴͷ�����"), 5f, 0f, 30f, 1f);
            hunterAdminCooldown = CustomOption.Create(3009, Types.HideNSeekRoles, cs(Color.red, "���˹����ͼ��ȴ"), 30f, 5f, 60f, 1f);
            hunterAdminDuration = CustomOption.Create(3010, Types.HideNSeekRoles, cs(Color.red, "���˹����ͼ����ʱ��"), 5f, 1f, 60f, 1f);
            hunterAdminPunish = CustomOption.Create(3011, Types.HideNSeekRoles, cs(Color.red, "���˹����ͼ�ͷ�����"), 5f, 0f, 30f, 1f);
            hunterArrowCooldown = CustomOption.Create(3012, Types.HideNSeekRoles, cs(Color.red, "����׷����ȴʱ��"), 30f, 5f, 60f, 1f);
            hunterArrowDuration = CustomOption.Create(3013, Types.HideNSeekRoles, cs(Color.red, "����׷�ٳ���ʱ��"), 5f, 0f, 60f, 1f);
            hunterArrowPunish = CustomOption.Create(3014, Types.HideNSeekRoles, cs(Color.red, "����׷�ٳͷ�����"), 5f, 0f, 30f, 1f);

            huntedShieldCooldown = CustomOption.Create(3015, Types.HideNSeekRoles, cs(Color.gray, "����߻�����ȴʱ��"), 30f, 5f, 60f, 1f, null, true);
            huntedShieldDuration = CustomOption.Create(3016, Types.HideNSeekRoles, cs(Color.gray, "����߻��ܳ���ʱ��"), 5f, 1f, 60f, 1f);
            huntedShieldRewindTime = CustomOption.Create(3018, Types.HideNSeekRoles, cs(Color.gray, "����߻���ʱ��"), 3f, 1f, 10f, 1f);
            huntedShieldNumber = CustomOption.Create(3026, Types.HideNSeekRoles, cs(Color.gray, "����߻�������"), 3f, 1f, 15f, 1f);

            // Prop Hunt General Options
            propHuntMap = CustomOption.Create(4020, Types.PropHunt, cs(Color.yellow, "��ͼ"), new string[] { "���ý�", "�����ܲ�", "��³˹", "��ͧ��ͼ", "�������", "Ǳͧ��ͼ", "�Զ����ͼ" }, null, true, onChange: () => { int map = propHuntMap.selection; if (map >= 3) map++; GameOptionsManager.Instance.currentNormalGameOptions.MapId = (byte)map; });
            propHuntTimer = CustomOption.Create(4021, Types.PropHunt, cs(Color.yellow, "��ʱ����Сֵ"), 5f, 1f, 30f, 0.5f);
            propHuntUnstuckCooldown = CustomOption.Create(4011, Types.PropHunt, cs(Color.yellow, "��ǽ��ȴʱ��"), 30f, 2.5f, 60f, 2.5f);
            propHuntUnstuckDuration = CustomOption.Create(4012, Types.PropHunt, cs(Color.yellow, "��ǽ����ʱ��"), 2f, 1f, 60f, 1f);
            propHunterVision = CustomOption.Create(4006, Types.PropHunt, cs(Color.yellow, "������Ұ"), 0.5f, 0.25f, 2f, 0.25f);
            propVision = CustomOption.Create(4007, Types.PropHunt, cs(Color.yellow, "������Ұ"), 2f, 0.25f, 5f, 0.25f);
            // Hunter Options
            propHuntNumberOfHunters = CustomOption.Create(4000, Types.PropHunt, cs(Color.red, "��������"), 1f, 1f, 5f, 1f, null, true);
            hunterInitialBlackoutTime = CustomOption.Create(4001, Types.PropHunt, cs(Color.red, "���˳�ʼͣ�����ʱ��"), 10f, 5f, 20f, 1f);
            hunterMissCooldown = CustomOption.Create(4004, Types.PropHunt, cs(Color.red, "�����ɱ�����ȴ"), 10f, 2.5f, 60f, 2.5f);
            hunterHitCooldown = CustomOption.Create(4005, Types.PropHunt, cs(Color.red, "��ɱ�����ȴ"), 10f, 2.5f, 60f, 2.5f);
            propHuntRevealCooldown = CustomOption.Create(4008, Types.PropHunt, cs(Color.red, "������ȴʱ��"), 30f, 10f, 90f, 2.5f);
            propHuntRevealDuration = CustomOption.Create(4009, Types.PropHunt, cs(Color.red, "���γ���ʱ��"), 5f, 1f, 60f, 1f);
            propHuntRevealPunish = CustomOption.Create(4010, Types.PropHunt, cs(Color.red, "��ʾ�ͷ�ʱ��"), 10f, 0f, 1800f, 5f);
            propHuntAdminCooldown = CustomOption.Create(4022, Types.PropHunt, cs(Color.red, "���˹����ͼ��ȴʱ��"), 30f, 2.5f, 1800f, 2.5f);
            propHuntFindCooldown = CustomOption.Create(4023, Types.PropHunt, cs(Color.red, "Ѱ����ȴʱ��"), 60f, 2.5f, 1800f, 2.5f);
            propHuntFindDuration = CustomOption.Create(4024, Types.PropHunt, cs(Color.red, "Ѱ�ҳ���ʱ��"), 5f, 1f, 15f, 1f);
            // Prop Options
            propBecomesHunterWhenFound = CustomOption.Create(4003, Types.PropHunt, cs(Palette.CrewmateBlue, "���α����ֺ�������"), false, null, true);
            propHuntInvisEnabled = CustomOption.Create(4013, Types.PropHunt, cs(Palette.CrewmateBlue, "��������"), true, null, true);
            propHuntInvisCooldown = CustomOption.Create(4014, Types.PropHunt, cs(Palette.CrewmateBlue, "������ȴʱ��"), 120f, 10f, 1800f, 2.5f, propHuntInvisEnabled);
            propHuntInvisDuration = CustomOption.Create(4015, Types.PropHunt, cs(Palette.CrewmateBlue, "���γ���ʱ��"), 5f, 1f, 30f, 1f, propHuntInvisEnabled);
            propHuntSpeedboostEnabled = CustomOption.Create(4016, Types.PropHunt, cs(Palette.CrewmateBlue, "���ü���"), true, null, true);
            propHuntSpeedboostCooldown = CustomOption.Create(4017, Types.PropHunt, cs(Palette.CrewmateBlue, "������ȴʱ��"), 60f, 2.5f, 1800f, 2.5f, propHuntSpeedboostEnabled);
            propHuntSpeedboostDuration = CustomOption.Create(4018, Types.PropHunt, cs(Palette.CrewmateBlue, "���ܳ���ʱ��"), 5f, 1f, 15f, 1f, propHuntSpeedboostEnabled);
            propHuntSpeedboostSpeed = CustomOption.Create(4019, Types.PropHunt, cs(Palette.CrewmateBlue, "���������ٶ�"), 2f, 1.25f, 5f, 0.25f, propHuntSpeedboostEnabled);



            // Other options
            maxNumberOfMeetings = CustomOption.Create(3, Types.General, "�����ܴ��� (�������г�)", 10, 0, 15, 1, null, true);
            blockSkippingInEmergencyMeetings = CustomOption.Create(4, Types.General, "���û�������Ʊ", false);
            noVoteIsSelfVote = CustomOption.Create(5, Types.General, "��ͶƱ����Ͷ�Լ�", false, blockSkippingInEmergencyMeetings);
            hidePlayerNames = CustomOption.Create(6, Types.General, "�����������", false);
            allowParallelMedBayScans = CustomOption.Create(7, Types.General, "����ͬʱ����ɨ��", false);
            shieldFirstKill = CustomOption.Create(8, Types.General, "��һ�ֱ����׵����", false);
            finishTasksBeforeHauntingOrZoomingOut = CustomOption.Create(9, Types.General, "��δ�����������ǰ������ʹ�ù�Ӱ���Ƽ�ǧ����", true);
            camsNightVision = CustomOption.Create(11, Types.General, "�ڵƹⱻ�ر�ʱ���ʹ�ú�ҹģʽ", false, null, true);
            camsNoNightVisionIfImpVision = CustomOption.Create(12, Types.General, "ӵ���ڹ���Ұ��������Ӻ�ҹģʽ", false, camsNightVision, false);



            dynamicMap = CustomOption.Create(500, Types.General, "�����һ����ͼ����", false, null, true);
            dynamicMapEnableSkeld = CustomOption.Create(501, Types.General, "���ý�", rates, dynamicMap, false);
            dynamicMapEnableMira = CustomOption.Create(502, Types.General, "����HQ", rates, dynamicMap, false);
            dynamicMapEnablePolus = CustomOption.Create(503, Types.General, "��³˹", rates, dynamicMap, false);
            dynamicMapEnableAirShip = CustomOption.Create(504, Types.General, "�߿շ�ͧ", rates, dynamicMap, false);
            dynamicMapEnableFungle = CustomOption.Create(506, Types.General, "�������", rates, dynamicMap, false);
            dynamicMapEnableSubmerged = CustomOption.Create(505, Types.General, "�Ǳͧ", rates, dynamicMap, false);
            dynamicMapSeparateSettings = CustomOption.Create(509, Types.General, "���õ�ͼ��Ԥ��", false, dynamicMap, false);

            blockedRolePairings.Add((byte)RoleId.Vampire, new [] { (byte)RoleId.Warlock});
            blockedRolePairings.Add((byte)RoleId.Warlock, new [] { (byte)RoleId.Vampire});
            blockedRolePairings.Add((byte)RoleId.Spy, new [] { (byte)RoleId.Mini});
            blockedRolePairings.Add((byte)RoleId.Mini, new [] { (byte)RoleId.Spy});
            blockedRolePairings.Add((byte)RoleId.Vulture, new [] { (byte)RoleId.Cleaner});
            blockedRolePairings.Add((byte)RoleId.Cleaner, new [] { (byte)RoleId.Vulture});
            
        }
    }
}
