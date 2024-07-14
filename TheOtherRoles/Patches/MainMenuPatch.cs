using System;
using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Button;
using Object = UnityEngine.Object;
using TheOtherRolesEdited.Patches;
using UnityEngine.SceneManagement;
using TheOtherRolesEdited.Utilities;
using AmongUs.Data;
using Assets.InnerNet;
using System.Linq;
using System.Drawing;

namespace TheOtherRolesEdited.Modules {
    [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.Start))]
    public class MainMenuPatch {
        private static bool horseButtonState = TORMapOptions.enableHorseMode;
        //private static Sprite horseModeOffSprite = null;
        //private static Sprite horseModeOnSprite = null;
        private static AnnouncementPopUp popUp;

        private static void Prefix(MainMenuManager __instance) {
            var template = GameObject.Find("ExitGameButton");
            var template2 = GameObject.Find("CreditsButton");

            var buttonDiscord = UnityEngine.Object.Instantiate(template, template.transform.parent);

            buttonDiscord.GetComponent<AspectPosition>().anchorPoint = new Vector2(0.586f, 0.43f);

            var textDiscord = buttonDiscord.transform.GetComponentInChildren<TMPro.TMP_Text>();
            __instance.StartCoroutine(Effects.Lerp(0.5f, new System.Action<float>((p) => {
                textDiscord.SetText("QQ频道");
                textDiscord.color = new Color32(0, 191, 255, byte.MaxValue);
            })));
            PassiveButton passiveButtonDiscord = buttonDiscord.GetComponent<PassiveButton>();
            passiveButtonDiscord.activeTextColor = new Color32(110, 191, 255, byte.MaxValue);
            passiveButtonDiscord.OnClick = new Button.ButtonClickedEvent();
            passiveButtonDiscord.OnClick.AddListener((System.Action)(() => Application.OpenURL("http://qm.qq.com/cgi-bin/qm/qr?_wv=1027&k=1YPTXe2Sh93pAUXv1mwv4unI6J_G1FYK&authKey=%2BPzdgfi%2FpbaxyPTVU1Lx8xU69Zo1X4%2FCih0lTozAbZ0%2FsCiO%2FGe8sQ97p6jxEFlV&noverify=0&group_code=647668527")));


            
            // TOR credits button
            if (template == null) return;
            var creditsButton = Object.Instantiate(template, template.transform.parent);
            creditsButton.GetComponent<AspectPosition>().anchorPoint = new Vector2(0.412f, 0.43f);

            var textCreditsButton = creditsButton.transform.GetComponentInChildren<TMPro.TMP_Text>();
            __instance.StartCoroutine(Effects.Lerp(0.5f, new System.Action<float>((p) => {
                textCreditsButton.SetText("TORE公告");
            })));
                textCreditsButton.color = new Color32(0, 191, 255, byte.MaxValue);
            PassiveButton passiveCreditsButton = creditsButton.GetComponent<PassiveButton>();

            passiveCreditsButton.OnClick = new Button.ButtonClickedEvent();

            passiveCreditsButton.activeTextColor = new Color32(110, 191, 255, byte.MaxValue);

            passiveCreditsButton.OnClick.AddListener((System.Action)delegate {
                // do stuff
                if (popUp != null) Object.Destroy(popUp);
                var popUpTemplate = Object.FindObjectOfType<AnnouncementPopUp>(true);
                if (popUpTemplate == null) {
                    TheOtherRolesEditedPlugin.Logger.LogError("couldnt show credits, popUp is null");
                    return;
                }
                popUp = Object.Instantiate(popUpTemplate);

                popUp.gameObject.SetActive(true);
                string creditsString = @$"<align=""center""><u><b>TheOtherRolesEdited开发者</b></u>
毒液
方块
lezaiya
Yu

<u><b>TheOtherRoles开发者</b></u>
<b>团队:</b>
Mallöris    K3ndo    Bavari    Gendelo

<b>团队开发者:</b>
Eisbison (GOAT)    Thunderstorm584    EndOfFile

<b>开发者:</b>
EnoPM    twix    NesTT

<b>Github贡献者:</b>
Alex2911    amsyarasyiq    MaximeGillot
Psynomit    probablyadnf    JustASysAdmin

<b>[https://discord.gg/77RkMJHWsM]Discord[] 贡献者:</b>
Draco Cordraconis    Streamblox (formerly)
感谢所有dicord贡献者的帮助!

感谢miniduikboot & GD对模组的帮助

";
                creditsString += $@"<size=60%> <b>其他贡献 & 资源:</b>
OxygenFilter - 从版本v2.3.0 到v2.6.1, 对TOR有很大帮助
Reactor - 使得我们的模组更好
BepInEx - 使得模组能够运行
Essentials - Custom game options by DorCoMaNdO:
Before v1.6: We used the default Essentials release
v1.6-v1.8: We slightly changed the default Essentials.
v2.0.0 and later: As we were not using Reactor anymore, we are using our own implementation, inspired by the one from DorCoMaNdO
Jackal and Sidekick - Original idea for the Jackal and Sidekick came from Dhalucard
Among-Us-Love-Couple-Mod - Idea for the Lovers modifier comes from Woodi-dev
Jester - Idea for the Jester role came from Maartii
ExtraRolesAmongUs - Idea for the Engineer and Medic role came from NotHunter101. Also some code snippets from their implementation were used.
Among-Us-Sheriff-Mod - Idea for the Sheriff role came from Woodi-dev
TooManyRolesMods - Idea for the Detective and Time Master roles comes from Hardel-DW. Also some code snippets from their implementation were used.
TownOfUs - Idea for the Swapper, Shifter, Arsonist and a similar Mayor role came from Slushiegoose
Ottomated - Idea for the Morphling, Snitch and Camouflager role came from Ottomated
Crowded-Mod - Our implementation for 10+ player lobbies was inspired by the one from the Crowded Mod Team
Goose-Goose-Duck - Idea for the Vulture role came from Slushiegoose
TheEpicRoles - Idea for the first kill shield (partly) and the tabbed option menu (fully + some code), by LaicosVK DasMonschta Nova
TheOtherRolesGMIA - 许多代码来源于此，送葬者等职业也来源于此(感谢imp11的帮助！)[https://github.com/dabao40/TheOtherRolesGMIA]TheOtherRolesGMIA[] 下载传送门
ugackMiner53 - Idea and core code for the Prop Hunt game mode
ToHope - 主页按钮来自于此</size>";
                creditsString += "</align>";

                Assets.InnerNet.Announcement creditsAnnouncement = new() {
                    Id = "torCredits",
                    Language = 0,
                    Number = 500,
                    Title = "\nThe Other Roles\n贡献 & 资源",
                    ShortTitle = "TORE公告",
                    SubTitle = "",
                    PinState = false,
                    Date = "02.01.2024",
                    Text = creditsString,
                };
                __instance.StartCoroutine(Effects.Lerp(0.1f, new Action<float>((p) => {
                    if (p == 1) {
                        var backup = DataManager.Player.Announcements.allAnnouncements;
                        DataManager.Player.Announcements.allAnnouncements = new();
                        popUp.Init(false);
                        DataManager.Player.Announcements.SetAnnouncements(new Announcement[] { creditsAnnouncement });
                        popUp.CreateAnnouncementList();
                        popUp.UpdateAnnouncementText(creditsAnnouncement.Number);
                        popUp.visibleAnnouncements._items[0].PassiveButton.OnClick.RemoveAllListeners();
                        DataManager.Player.Announcements.allAnnouncements = backup;
                    }
                })));
            });
            
        }

        public static void addSceneChangeCallbacks() {
            SceneManager.add_sceneLoaded((Action<Scene, LoadSceneMode>)((scene, _) => {
                if (!scene.name.Equals("MatchMaking", StringComparison.Ordinal)) return;
                TORMapOptions.gameMode = CustomGamemodes.Classic;
                // Add buttons For Guesser Mode, Hide N Seek in this scene.
                // find "HostLocalGameButton"
                var template = GameObject.FindObjectOfType<HostLocalGameButton>();
                var gameButton = template.transform.FindChild("CreateGameButton");
                var gameButtonPassiveButton = gameButton.GetComponentInChildren<PassiveButton>();

                var guesserButton = GameObject.Instantiate<Transform>(gameButton, gameButton.parent);
                guesserButton.transform.localPosition += new Vector3(0f, -0.5f);
                var guesserButtonText = guesserButton.GetComponentInChildren<TMPro.TextMeshPro>();
                var guesserButtonPassiveButton = guesserButton.GetComponentInChildren<PassiveButton>();
                
                guesserButtonPassiveButton.OnClick = new Button.ButtonClickedEvent();
                guesserButtonPassiveButton.OnClick.AddListener((System.Action)(() => {
                    TORMapOptions.gameMode = CustomGamemodes.Guesser;
                    template.OnClick();
                }));

                var HideNSeekButton = GameObject.Instantiate<Transform>(gameButton, gameButton.parent);
                HideNSeekButton.transform.localPosition += new Vector3(1.7f, -0.5f);
                var HideNSeekButtonText = HideNSeekButton.GetComponentInChildren<TMPro.TextMeshPro>();
                var HideNSeekButtonPassiveButton = HideNSeekButton.GetComponentInChildren<PassiveButton>();
                
                HideNSeekButtonPassiveButton.OnClick = new Button.ButtonClickedEvent();
                HideNSeekButtonPassiveButton.OnClick.AddListener((System.Action)(() => {
                    TORMapOptions.gameMode = CustomGamemodes.HideNSeek;
                    template.OnClick();
                }));

                var PropHuntButton = GameObject.Instantiate<Transform>(gameButton, gameButton.parent);
                PropHuntButton.transform.localPosition += new Vector3(3.4f, -0.5f);
                var PropHuntButtonText = PropHuntButton.GetComponentInChildren<TMPro.TextMeshPro>();
                var PropHuntButtonPassiveButton = PropHuntButton.GetComponentInChildren<PassiveButton>();

                PropHuntButtonPassiveButton.OnClick = new Button.ButtonClickedEvent();
                PropHuntButtonPassiveButton.OnClick.AddListener((System.Action)(() => {
                    TORMapOptions.gameMode = CustomGamemodes.PropHunt;
                    template.OnClick();
                }));

                template.StartCoroutine(Effects.Lerp(0.1f, new System.Action<float>((p) => {
                    guesserButtonText.SetText("TORE赌怪模式");
                    HideNSeekButtonText.SetText("TORE捉迷藏模式");
                    PropHuntButtonText.SetText("TORE变形躲猫猫模式");
                })));
            }));
        }
    }
}
