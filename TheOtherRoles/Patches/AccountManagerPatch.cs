﻿using HarmonyLib;
using TMPro;
using UnityEngine;


namespace TheOtherRolesEdited;

[HarmonyPatch(typeof(AccountTab), nameof(AccountTab.Awake))]
public static class UpdateFriendCodeUIPatch
{
    private static GameObject VersionShower;
    public static void Prefix(AccountTab __instance)
    {

        string credentialsText = string.Format($"<color=#FF0000> TheOtherRolesEdited </color> - {TheOtherRolesEditedPlugin.VersionString}" + " - ©️ 2024 - " + "<color=#00BFFF>毒液</color>" );
        string versionText = $"{TheOtherRolesEditedPlugin.VersionString}";


        var friendCode = GameObject.Find("FriendCode");
        if (friendCode != null && VersionShower == null)
        {
            VersionShower = Object.Instantiate(friendCode, friendCode.transform.parent);
            VersionShower.name = "TheOtherRolesEdited Version Shower";
            VersionShower.transform.localPosition = friendCode.transform.localPosition + new Vector3(3.2f, 0f, 0f);
            VersionShower.transform.localScale *= 1.7f;
            var TMP = VersionShower.GetComponent<TextMeshPro>();
            TMP.alignment = TextAlignmentOptions.Right;
            TMP.fontSize = 30f;
            TMP.SetText(credentialsText);
        }

        var newRequest = GameObject.Find("NewRequest");
        if (newRequest != null)
        {
            newRequest.transform.localPosition -= new Vector3(0f, 0f, 10f);
            newRequest.transform.localScale = new Vector3(0.8f, 1f, 1f);
        }
    }
}