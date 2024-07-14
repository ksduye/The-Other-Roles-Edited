using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Reflection;


namespace TheOtherRolesEdited;

[HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.Start)), HarmonyPriority(Priority.First)]
internal class TitleLogoPatch
{
    public static GameObject ModStamp;
    public static GameObject AULogo;

    public static void showPopup(string text){
        var popup = GameObject.Instantiate(DiscordManager.Instance.discordPopup, Camera.main!.transform);
        
        var background = popup.transform.Find("Background").GetComponent<SpriteRenderer>();
        var size = background.size;
        size.x *= 2.5f;
        background.size = size;

        popup.TextAreaTMP.fontSizeMin = 2;
        popup.Show(text);
    }

    private static void Postfix(MainMenuManager __instance)
    {
        if (!(ModStamp = GameObject.Find("ModStamp"))) return;
        ModStamp.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

        if (!(ModStamp = GameObject.Find("ModStamp"))) return;
        var ModStapRenderer = ModStamp.GetComponent<SpriteRenderer>();
        ModStapRenderer.sprite = LoadSprite("TheOtherRolesEdited.Resources.ModStamp.png", 150f);

        if (!(AULogo = GameObject.Find("LOGO-AU"))) return;
        var logoRenderer = AULogo.GetComponent<SpriteRenderer>();
        logoRenderer.sprite = LoadSprite("TheOtherRolesEdited.Resources.TORE.png", 150f);
    }

    public static Dictionary<string, Sprite> CachedSprites = new();
    public static Sprite LoadSprite(string path, float pixelsPerUnit = 1f)
    {
        try
        {
            if (CachedSprites.TryGetValue(path + pixelsPerUnit, out var sprite)) return sprite;
            Texture2D texture = LoadTextureFromResources(path);
            sprite = Sprite.Create(texture, new(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f), pixelsPerUnit);
            sprite.hideFlags |= HideFlags.HideAndDontSave | HideFlags.DontSaveInEditor;
            return CachedSprites[path + pixelsPerUnit] = sprite;
        }
        catch
        {
            
        }
        return null;
    }
    
    public static Texture2D LoadTextureFromResources(string path)
    {
        try
        {
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path);
            var texture = new Texture2D(1, 1, TextureFormat.ARGB32, false);
            using MemoryStream ms = new();
            stream.CopyTo(ms);
            ImageConversion.LoadImage(texture, ms.ToArray(), false);
            return texture;
        }
        catch
        {
        }
        return null;
    }
    
    [HarmonyPatch(typeof(VersionShower), nameof(VersionShower.Start))]
    public static class VersionShower_Start
    {
        public static void Postfix(VersionShower __instance)
        {
            __instance.text.text = $"v{Application.version}-<color=#FF1919FF>TheOtherRolesEdited</color> v{TheOtherRolesEditedPlugin.VersionString}-ping:{AmongUsClient.Instance.Ping}ms";
        }
    }
}