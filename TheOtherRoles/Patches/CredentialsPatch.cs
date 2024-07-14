using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TheOtherRolesEdited.CustomGameModes;
using TheOtherRolesEdited.Players;
using TheOtherRolesEdited.Utilities;
using TMPro;
using UnityEngine;

namespace TheOtherRolesEdited.Patches
{
    [HarmonyPatch]
    public static class CredentialsPatch
    {
        public static string PingTextColor = "";
        public static string fullCredentialsVersion =
$@"<size=130%><color=#ff351f>TheOtherRolesEdited</color></size> v{TheOtherRolesEditedPlugin.Version.ToString() + (TheOtherRolesEditedPlugin.betaDays > 0 ? "-BETA" : "")}";
        public static string fullCredentials =
        $@"<size=60%><color=#FF0000>TOR</color>模组作者:<color=#FCCE03FF>Eisbison</color>, <color=#FCCE03FF>EndOfFile</color>
<color=#FCCE03FF>Thunderstorm584</color>, <color=#FCCE03FF>Mallöris</color> & <color=#FCCE03FF>Gendelo</color>
美术:<color=#FCCE03FF>Bavari</color>
<color=#FF0000>TORE</color>模组作者:<color=#FCCE03FF>毒液</color>
美术:<color=#FCCE03FF>毒液</color> & <color=#FCCE03FF>尤路丽丝</color>
中文翻译:<color=#FCCE03FF>毒液</color></size>";

        public static string mainMenuCredentials =
    $@"<color=#FF0000>TOR</color>模组作者:<color=#FCCE03FF>Eisbison</color>, <color=#FCCE03FF>Thunderstorm584</color>, <color=#FCCE03FF>EndOfFile</color>, <color=#FCCE03FF>Mallöris</color> & <color=#FCCE03FF>Gendelo</color>
美术:<color=#FCCE03FF>Bavari</color>
<color=#FF0000>TORE</color>模组作者:<color=#FCCE03FF>毒液</color></color>
美术:<color=#FCCE03FF>毒液</color> & <color=#FCCE03FF>尤路丽丝</color>
中文翻译:<color=#FCCE03FF>毒液</color>";

        public static string contributorsCredentials =
$@"<size=60%> <color=#FCCE03FF>特别感谢 Smeggy & Imp11 & 方块</color></size>";

        [HarmonyPatch(typeof(PingTracker), nameof(PingTracker.Update))]
        internal static class PingTrackerPatch
        {
            public static GameObject modStamp;
            /*static void Prefix(PingTracker __instance) {
                if (modStamp == null) {
                    modStamp = new GameObject("ModStamp");
                    var rend = modStamp.AddComponent<SpriteRenderer>();
                    rend.sprite = TheOtherRolesEditedPlugin.GetModStamp();
                    rend.color = new Color(1, 1, 1, 0.5f);
                    modStamp.transform.parent = __instance.transform.parent;
                    modStamp.transform.localScale *= SubmergedCompatibility.Loaded ? 0 : 0.6f;
                }
                float offset = (AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Started) ? 0.75f : 0f;
                modStamp.transform.position = FastDestroyableSingleton<HudManager>.Instance.MapButton.transform.position + Vector3.down * offset;
            }*/

            static void Postfix(PingTracker __instance)
            {
                //Ping文字颜色
                var ping = AmongUsClient.Instance.Ping;
                if (ping < 10) PingTextColor = ("<color=#ff0000>" + "孩子你无敌了\n");
                else if (ping < 50) PingTextColor = ("<color=#00ffff>" + "你的网络真好!\n");
                else if (ping < 100) PingTextColor = ("<color=#00ec00>" + "网络有待提高\n");
                else if (ping < 200) PingTextColor = ("<color=#ff44ff>" + "好晕\n");
                else if (ping < 300) PingTextColor = ("<color=#8600ff>" + "小心树懒发疯\n");
                else if (ping < 400) PingTextColor = ("<color=#ff0000>" + "over！\n");
                else if (ping > 700) PingTextColor = ("<color=#ff0000>" + "请检查网络连接\n");
                __instance.text.alignment = TMPro.TextAlignmentOptions.TopRight;
                if (AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Started)
                {
                    string gameModeText = $"";
                    if (HideNSeek.isHideNSeekGM) gameModeText = $"捉迷藏模式";
                    else if (HandleGuesser.isGuesserGm) gameModeText = $"赌怪模式";
                    else if (PropHunt.isPropHuntGM) gameModeText = "变形躲猫猫模式";
                    if (gameModeText != "") gameModeText = Helpers.cs(Color.yellow, gameModeText) + "\n";
                    __instance.text.text = $"<size=130%><color=#ff351f>TheOtherRolesEdited</color></size> v{TheOtherRolesEditedPlugin.Version.ToString() + (TheOtherRolesEditedPlugin.betaDays > 0 ? "-BETA" : "<size=80%>\n模组作者:<color=#FCCE03FF>毒液</color>\n美术:<color=#FCCE03FF>毒液</color> & <color=#FCCE03FF>尤路丽丝</color>\n中文翻译:<color=#FCCE03FF>毒液</color></size>")}\n{gameModeText}" + $"{PingTextColor}延迟: {AmongUsClient.Instance.Ping}毫秒";
                    if (CachedPlayer.LocalPlayer.Data.IsDead || (!(CachedPlayer.LocalPlayer.PlayerControl == null) && (CachedPlayer.LocalPlayer.PlayerControl == Lovers.lover1 || CachedPlayer.LocalPlayer.PlayerControl == Lovers.lover2)))
                    {
                        __instance.transform.localPosition = new Vector3(3.45f, __instance.transform.localPosition.y, __instance.transform.localPosition.z);
                    }
                    else
                    {
                        __instance.transform.localPosition = new Vector3(4.2f, __instance.transform.localPosition.y, __instance.transform.localPosition.z);
                    }
                }
                else
                {
                    string gameModeText = $"";
                    if (TORMapOptions.gameMode == CustomGamemodes.HideNSeek) gameModeText = $"捉迷藏模式";
                    else if (TORMapOptions.gameMode == CustomGamemodes.Guesser) gameModeText = $"赌怪模式";
                    else if (TORMapOptions.gameMode == CustomGamemodes.PropHunt) gameModeText = $"变形躲猫猫模式";
                    if (gameModeText != "") gameModeText = Helpers.cs(Color.yellow, gameModeText) + "\n";

                    __instance.text.text = $"{fullCredentialsVersion}\n<size=60%>{gameModeText + fullCredentials}\n"+$"{PingTextColor}延迟: {AmongUsClient.Instance.Ping}毫秒</size>";
                    __instance.transform.localPosition = new Vector3(3.5f, __instance.transform.localPosition.y, __instance.transform.localPosition.z);
                }
            }
        }

        [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.Start))]
        public static class LogoPatch
        {
            public static SpriteRenderer renderer;
            public static Sprite bannerSprite;
            public static Sprite horseBannerSprite;
            public static Sprite banner2Sprite;
            private static PingTracker instance;

            public static GameObject motdObject;
            public static TextMeshPro motdText;

            static void Postfix(PingTracker __instance)
            {
                var torLogo = new GameObject("bannerLogo_TOR");
                torLogo.transform.SetParent(GameObject.Find("RightPanel").transform, false);
                torLogo.transform.localPosition = new Vector3(-0.4f, 1f, 5f);

                renderer = torLogo.AddComponent<SpriteRenderer>();
                loadSprites();
                renderer.sprite = Helpers.loadSpriteFromResources("TheOtherRolesEdited.Resources.Banner.png", 300f);

                instance = __instance;
                loadSprites();
                // renderer.sprite = TORMapOptions.enableHorseMode ? horseBannerSprite : bannerSprite;
                renderer.sprite = EventUtility.isEnabled ? banner2Sprite : bannerSprite;
                var credentialObject = new GameObject("credentialsTOR");
                var credentials = credentialObject.AddComponent<TextMeshPro>();
                credentials.SetText($"v{TheOtherRolesEditedPlugin.Version.ToString() + (TheOtherRolesEditedPlugin.betaDays > 0 ? "-BETA" : "")}\n<size=30f%>\n</size>{mainMenuCredentials}\n<size=30%>\n</size>{contributorsCredentials}");
                credentials.alignment = TMPro.TextAlignmentOptions.Center;
                credentials.fontSize *= 0.05f;

                credentials.transform.SetParent(torLogo.transform);
                credentials.transform.localPosition = Vector3.down * 1.25f;
                motdObject = new GameObject("torMOTD");
                motdText = motdObject.AddComponent<TextMeshPro>();
                motdText.alignment = TMPro.TextAlignmentOptions.Center;
                motdText.fontSize *= 0.04f;

                motdText.transform.SetParent(torLogo.transform);
                motdText.enableWordWrapping = true;
                var rect = motdText.gameObject.GetComponent<RectTransform>();
                rect.sizeDelta = new Vector2(5.2f, 0.25f);

                motdText.transform.localPosition = Vector3.down * 2.25f;
                motdText.color = new Color(1, 53f / 255, 31f / 255);
                Material mat = motdText.fontSharedMaterial;
                mat.shaderKeywords = new string[] { "OUTLINE_ON" };
                motdText.SetOutlineColor(Color.white);
                motdText.SetOutlineThickness(0.025f);
            }

            public static void loadSprites()
            {
                if (bannerSprite == null) bannerSprite = Helpers.loadSpriteFromResources("TheOtherRolesEdited.Resources.Banner.png", 300f);
                if (banner2Sprite == null) banner2Sprite = Helpers.loadSpriteFromResources("TheOtherRolesEdited.Resources.Banner2.png", 300f);
                if (horseBannerSprite == null) horseBannerSprite = Helpers.loadSpriteFromResources("TheOtherRolesEdited.Resources.bannerTheHorseRoles.png", 300f);
            }

            public static void updateSprite()
            {
                loadSprites();
                if (renderer != null)
                {
                    float fadeDuration = 1f;
                    instance.StartCoroutine(Effects.Lerp(fadeDuration, new Action<float>((p) => {
                        renderer.color = new Color(1, 1, 1, 1 - p);
                        if (p == 1)
                        {
                            renderer.sprite = TORMapOptions.enableHorseMode ? horseBannerSprite : bannerSprite;
                            instance.StartCoroutine(Effects.Lerp(fadeDuration, new Action<float>((p) => {
                                renderer.color = new Color(1, 1, 1, p);
                            })));
                        }
                    })));
                }
            }
        }

        [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.LateUpdate))]
        public static class MOTD
        {
            public static List<string> motds = new List<string>();
            private static float timer = 0f;
            private static float maxTimer = 5f;
            private static int currentIndex = 0;

            public static void Postfix()
            {
                if (motds.Count == 0)
                {
                    timer = maxTimer;
                    return;
                }
                if (motds.Count > currentIndex && LogoPatch.motdText != null)
                    LogoPatch.motdText.SetText(motds[currentIndex]);
                else return;

                // fade in and out:
                float alpha = Mathf.Clamp01(Mathf.Min(new float[] { timer, maxTimer - timer }));
                if (motds.Count == 1) alpha = 1;
                LogoPatch.motdText.color = LogoPatch.motdText.color.SetAlpha(alpha);
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    timer = maxTimer;
                    currentIndex = (currentIndex + 1) % motds.Count;
                }
            }

            public static async Task loadMOTDs()
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://raw.githubusercontent.com/TheOtherRolesAU/MOTD/main/motd.txt");
                response.EnsureSuccessStatusCode();
                string motds = await response.Content.ReadAsStringAsync();
                foreach (string line in motds.Split("\n", StringSplitOptions.RemoveEmptyEntries))
                {
                    MOTD.motds.Add(line);
                }
            }
        }
    }
}
