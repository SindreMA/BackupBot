using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BackupBot;

namespace UtilityBot.Modules.Janitor
{
    public class Main : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        [Alias("?")]
        public async Task help()
        {
            var channel = Context.User.CreateDMChannelAsync();
            await channel.Result.SendMessageAsync(
                ""
                );


        }
        [Command("Backup")]
        public async Task Backup ([Optional]string name)
        {

            try
            {

                
                var json = JsonConvert.SerializeObject(Context.Guild, Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
                var finname = name;
                if (name == null)
                {
                    finname = "Backup - " + DateTime.Now;
                    
                }
                var filename = finname + ".json";
                File.WriteAllText(filename, json);
                await Context.Channel.SendFileAsync(filename);
                System.Threading.Thread.Sleep(100);
                File.Delete(finname);
            }
            catch (Exception)
            {

            }



        }

 
        [Command("Restore")]
        public async Task Restore()
        {
            try
            {

                JsonConvertedGuild.Rootobject e = JsonConvert.DeserializeObject<JsonConvertedGuild.Rootobject>(File.ReadAllText("test.json"));
                SocketGuild guild = Context.Guild;

                foreach (var channel in guild.VoiceChannels)
                {
                    try
                    {
                        await channel.DeleteAsync();
                    }
                    catch (Exception)
                    {
                    }
                }
                foreach (var channel in guild.TextChannels)
                {
                    try
                    {
                        if (channel != guild.DefaultChannel)
                        {

                     
                        await channel.DeleteAsync();
                    }
                    }
                    catch (Exception)
                    {
                    }
                    
                }
                foreach (var channel in e.VoiceChannels.OrderBy(o => o.Position))
                {
                    await guild.CreateVoiceChannelAsync(channel.Name);
                }
                foreach (var channel in e.TextChannels.OrderBy(o => o.Position))
                {
                    await guild.CreateTextChannelAsync(channel.Name);
                }

                if (e.AFKChannel != null)
                {


                    foreach (var channel in guild.VoiceChannels)
                    {
                        if (channel.Name == e.AFKChannel.Name)
                        {
                            await guild.ModifyAsync(x => x.AfkChannel = channel);
                            break;
                        }
                    }
                }
              // 

            }
            catch (Exception)
            {

            }


        }
        [Command("info")]
        public async Task Info()
        {
            var application = await Context.Client.GetApplicationInfoAsync();
            await ReplyAsync(
                $"{Format.Bold("Info")}\n" +
                $"- Author: SindreMA#9630\n" +
                $"- Library: Discord.Net ({DiscordConfig.Version})\n" +
                $"- Runtime: {RuntimeInformation.FrameworkDescription} {RuntimeInformation.OSArchitecture}\n" +
                $"- Uptime: {GetUptime()}\n\n" +

                $"{Format.Bold("Stats")}\n" +
                $"- Heap Size: {GetHeapSize()} MB\n" +
                $"- Guilds: {(Context.Client as DiscordSocketClient).Guilds.Count}\n" +
                $"- Channels: {(Context.Client as DiscordSocketClient).Guilds.Sum(g => g.Channels.Count)}\n" +
                $"- Users: {(Context.Client as DiscordSocketClient).Guilds.Sum(g => g.Users.Count)}"
            );
        }
        [Command("setgame")]
        [RequireUserPermission(GuildPermission.Administrator)]
        public async Task SetGame([Remainder]string text)
        {
            if (Context.User.Id == 170605899189190656)
            {
                await Context.Client.SetGameAsync(text);
            }
          
        }
        private static string GetUptime()
           => (DateTime.Now - Process.GetCurrentProcess().StartTime).ToString(@"dd\.hh\:mm\:ss");
        private static string GetHeapSize() => Math.Round(GC.GetTotalMemory(true) / (1024.0 * 1024.0), 2).ToString();
   
    }
}
