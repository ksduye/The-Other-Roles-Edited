using HarmonyLib;
using System.Collections.Generic;
using System.Linq;

namespace TheOtherRolesEdited;

[HarmonyPatch(typeof(CreditsController))]
public class CreditsControllerPatch
{
    private static List<CreditsController.CreditStruct> GetModCredits()
    {
        var devList = new List<string>()
            {
                //$"<color=#bd262a><size=150%>{GetString("FromChina")}</size></color>",

                $"毒液 - 开发者(<color=#FF0000>TheOtherRoles</color>)",
                $"YU - 贡献者(<color=#EEC900>MCI</color>)",
                $"尤路丽丝 - 美工",

            };
        var translatorList = new List<string>()
            {
                $"方块 - 贡献者",
            };
        var acList = new List<string>()
            {
                //Mods
                $"<color=#FF0000>TheOtherRoles</color>",
                $"<color=#FF0000>TheOtherRoles GM IA</color>",
                $"<color=#00FFFF>TownOfNewEpic_Xtreme</color>",

                // Sponsor
                $"小叨院长",
                $"Night_瓜",
                $"Slok",
                $"...",
            };

        var credits = new List<CreditsController.CreditStruct>();
        
        AddTitleToCredits("<color=#FF0000>模组开发者</color>");
        AddPersonToCredits(devList);
        AddSpcaeToCredits();

        AddTitleToCredits("<color=#FF0000>模组贡献者</color>");
        AddPersonToCredits(translatorList);
        AddSpcaeToCredits();

        AddTitleToCredits("<color=#FF0000>帮助我们的模组及个人</color>");
        AddPersonToCredits(acList);
        AddSpcaeToCredits();

        return credits;

        void AddSpcaeToCredits()
        {
            AddTitleToCredits(string.Empty);
        }
        void AddTitleToCredits(string title)
        {
            credits.Add(new()
            {
                format = "title",
                columns = new[] { title },
            });
        }
        void AddPersonToCredits(List<string> list)
        {
            foreach (var line in list)
            {
                var cols = line.Split(" - ").ToList();
                if (cols.Count < 2) cols.Add(string.Empty);
                credits.Add(new()
                {
                    format = "person",
                    columns = cols.ToArray(),
                });
            }
        }
    }

    [HarmonyPatch(nameof(CreditsController.AddCredit)), HarmonyPrefix]
    public static void AddCreditPrefix(CreditsController __instance, [HarmonyArgument(0)] CreditsController.CreditStruct originalCredit)
    {
        if (originalCredit.columns[0] != "logoImage") return;

        foreach (var credit in GetModCredits())
        {
            __instance.AddCredit(credit);
            __instance.AddFormat(credit.format);
        }
    }
}