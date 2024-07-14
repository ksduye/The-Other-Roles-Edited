using System.Collections.Generic;
using UnityEngine;

namespace TheOtherRolesEdited
{
    static class TORMapOptions
    {
        // Set values
        public static int maxNumberOfMeetings = 10;
        public static bool blockSkippingInEmergencyMeetings = false;
        public static bool noVoteIsSelfVote = false;
        public static bool hidePlayerNames = false;
        public static bool ghostsSeeRoles = true;
        public static bool ghostsSeeModifier = true;
        public static bool ghostsSeeInformation = true;
        public static bool ghostsSeeVotes = true;
        public static bool showRoleSummary = true;
        public static bool allowParallelMedBayScans = false;
        public static bool showLighterDarker = true;
        public static bool enableSoundEffects = true;
        public static bool enableHorseMode = false;
        public static bool shieldFirstKill = false;
        public static bool ShowVentsOnMap = true;
        public static CustomGamemodes gameMode = CustomGamemodes.Classic;

        // Updating values
        public static int meetingsCount = 0;
        public static List<SurvCamera> camerasToAdd = new List<SurvCamera>();
        public static List<Vent> ventsToSeal = new List<Vent>();
        public static Dictionary<byte, PoolablePlayer> playerIcons = new Dictionary<byte, PoolablePlayer>();
        public static string firstKillName;
        public static PlayerControl firstKillPlayer;

        public static void clearAndReloadMapOptions()
        {
            meetingsCount = 0;
            camerasToAdd = new List<SurvCamera>();
            ventsToSeal = new List<Vent>();
            playerIcons = new Dictionary<byte, PoolablePlayer>(); ;

            maxNumberOfMeetings = Mathf.RoundToInt(CustomOptionHolder.maxNumberOfMeetings.getSelection());
            blockSkippingInEmergencyMeetings = CustomOptionHolder.blockSkippingInEmergencyMeetings.getBool();
            noVoteIsSelfVote = CustomOptionHolder.noVoteIsSelfVote.getBool();
            hidePlayerNames = CustomOptionHolder.hidePlayerNames.getBool();
            allowParallelMedBayScans = CustomOptionHolder.allowParallelMedBayScans.getBool();
            shieldFirstKill = CustomOptionHolder.shieldFirstKill.getBool();
            firstKillPlayer = null;
        }

        public static void reloadPluginOptions()
        {
            ghostsSeeRoles = TheOtherRolesEditedPlugin.GhostsSeeRoles.Value;
            ghostsSeeModifier = TheOtherRolesEditedPlugin.GhostsSeeModifier.Value;
            ghostsSeeInformation = TheOtherRolesEditedPlugin.GhostsSeeInformation.Value;
            ghostsSeeVotes = TheOtherRolesEditedPlugin.GhostsSeeVotes.Value;
            showRoleSummary = TheOtherRolesEditedPlugin.ShowRoleSummary.Value;
            showLighterDarker = TheOtherRolesEditedPlugin.ShowLighterDarker.Value;
            enableSoundEffects = TheOtherRolesEditedPlugin.EnableSoundEffects.Value;
            enableHorseMode = TheOtherRolesEditedPlugin.EnableHorseMode.Value;
            ShowVentsOnMap = TheOtherRolesEditedPlugin.ShowVentsOnMap.Value;
            //Patches.ShouldAlwaysHorseAround.isHorseMode = TheOtherRolesEditedPlugin.EnableHorseMode.Value;
        }
    }
}
