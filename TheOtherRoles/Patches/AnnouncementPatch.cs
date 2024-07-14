using System;
using System.Collections.Generic;
using System.Linq;
using AmongUs.Data;
using AmongUs.Data.Player;
using Assets.InnerNet;
using HarmonyLib;

namespace TheOtherRolesEdited;

// ##https://github.com/Yumenopai/TownOfHost_Y
public class ModNews
{
    public int Number;
    public int BeforeNumber;
    public string Title;
    public string SubTitle;
    public string ShortTitle;
    public string Text;
    public string Date;

    public Announcement ToAnnouncement()
    {
        var result = new Announcement
        {
            Number = Number,
            Title = Title,
            SubTitle = SubTitle,
            ShortTitle = ShortTitle,
            Text = Text,
            Language = (uint)DataManager.Settings.Language.CurrentLanguage,
            Date = Date,
            Id = "ModNews"
        };

        return result;
    }
}
[HarmonyPatch]
public class ModNewsHistory
{
    public static List<ModNews> AllModNews = new();
    public static void Init()
    {
        // 创建新公告时，不能删除旧公告   
        { 
            // TORE v1.0.6
            var news = new ModNews
            {
                Number = 100003,
                Title = "TheOtherRolesEdited v1.0.6",
                SubTitle = "★★★★重大更新！★★★★",
                ShortTitle = "★TORE v1.0.6",
                Text = "<size=100%>欢迎来到 TORE v1.0.6.</size>\n\n<size=125%>适配Among us v6.4s</size>\n"
                    + "\n【声明】-本模组不隶属于 Among Us 或 Innersloth LLC 其中包含的内容未得到 Innersloth LLC 的认可或以其他方式赞助 此处包含的部分材料是 Innersloth LLC的财产 ©Innersloth"
                    + "\n【对应官方版本】\n - TOR v.4.5.3\r"
                    + "\n【新职业】\n - 内鬼职业：Yoyo \n\r杀人于无形之中"
                    + "\n【更新机制】\n <size=125%>桌面UI</size>:\n- 将<b>TORE公告</b>和<b>QQ频道单独列出</b>\n- 将Amongus图标改为TORE图标\n- 在<b>制作人员</b>里面添加TORE制作人员\n- 在游戏编号旁边增添TORE字符\n- 更改MOD图标并将其放大 \n<size=125%>游戏中</size>:\n- 在游戏大厅时将<b>PING</b>增加色彩\n- 增加搞笑语(他会随着ping值颜色的变化而变化)"
                    + "\n【鸣谢】\n- 方块(适配)",
                Date = "2024-7-8T00:00:00Z"
            };
            AllModNews.Add(news);
        }

        {
            // TORE v1.0.4
            var news = new ModNews
            {
                Number = 100002,
                Title = "TheOtherRolesEdited v1.0.4",
                SubTitle = "★★★★乐！★★★★",
                ShortTitle = "★TORE v1.0.4",
                Text = "<size=100%>欢迎来到 TORE v1.0.4.</size>\n\n<size=125%>适配Among us v3.5s</size>\n"
                    + "\n【声明】-本模组不隶属于 Among Us 或 Innersloth LLC 其中包含的内容未得到 Innersloth LLC 的认可或以其他方式赞助 此处包含的部分材料是 Innersloth LLC的财产 ©Innersloth"
                    + "\n【对应官方版本】\n - TOR v.4.5.2\r"
                    + "\n【更正】\n - 无"
                    + "\n【修复】\n - 无"
                    + "\n【新职业】\n - 无"
                    + "\n【鸣谢】\n- 方块(适配)",
                Date = "2024-5-2T00:00:00Z"
            };
            AllModNews.Add(news);
        }

        {
            // TOHEF v1.0.3
            var news = new ModNews
            {
                Number = 100001,
                Title = "TheOtherRolesEdited v1.0.3",
                SubTitle = "★★★★更新啦★★★★",
                ShortTitle = "★TORE v1.0.3",
                Text = "<size=100%>欢迎来到 TORE v1.0.3</size>\n\n<size=125%>适配Among us v3.5s</size>\n"
                    + "\n【声明】-本模组不隶属于 Among Us 或 Innersloth LLC 其中包含的内容未得到 Innersloth LLC 的认可或以其他方式赞助 此处包含的部分材料是 Innersloth LLC的财产 ©Innersloth"
                    + "\n【对应官方版本】\n - TOR v4.5.2"
                    + "\n【更正】\n - 无"
                    + "\n【修复】\n - 无"
                    + "\n【新职业】\n - 无"
                    + "\n【鸣谢】\n -方块(适配)",
                Date = "2024-4-23T00:00:00Z"
            };
            AllModNews.Add(news);
        }
    }

[HarmonyPatch(typeof(PlayerAnnouncementData), nameof(PlayerAnnouncementData.SetAnnouncements)), HarmonyPrefix]
    public static bool SetModAnnouncements(PlayerAnnouncementData __instance, [HarmonyArgument(0)] ref Il2CppReferenceArray<Announcement> aRange)
    {
        if (AllModNews.Count < 1)
        {
            Init();
            AllModNews.Sort((a1, a2) => { return DateTime.Compare(DateTime.Parse(a2.Date), DateTime.Parse(a1.Date)); });
        }

        List<Announcement> FinalAllNews = new();
        AllModNews.Do(n => FinalAllNews.Add(n.ToAnnouncement()));
        foreach (var news in aRange)
        {
            if (!AllModNews.Any(x => x.Number == news.Number))
                FinalAllNews.Add(news);
        }
        FinalAllNews.Sort((a1, a2) => { return DateTime.Compare(DateTime.Parse(a2.Date), DateTime.Parse(a1.Date)); });

        aRange = new(FinalAllNews.Count);
        for (int i = 0; i < FinalAllNews.Count; i++)
            aRange[i] = FinalAllNews[i];

        return true;
    }
}