﻿using System.Windows;

using Jamesnet.Wpf.Global.Event;

using KakaoTalk.Core.Args;
using KakaoTalk.Core.Events;
using KakaoTalk.Core.Models;

using Microsoft.AspNetCore.SignalR.Client;


namespace KakaoTalk.Receiver
{
    public class HubManager
    {
        public HubConnection? Connection;
        private IEventHub? _ea;

        public int Test { get; private set; }

        public static HubManager Create()
        {
            HubManager hubManager = new();
            hubManager.Connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7275/chathub")
                .Build();

            return hubManager;
        }

        public async void Start(IEventHub ea)
        {
            _ea = ea;

            Connection.On<List<FriendsModel>>("ResponseFriendsPack", (message) =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    SyncFriendsArgs args = new();
                    args.Friends = message;
                    _ea.Publish<SyncFriendsPubSub, SyncFriendsArgs>(args);
                });
            });

            try
            {
                if (Connection != null)
                {
                    await Connection.StartAsync();
                }
            }
            catch (Exception) { }
        }
    }
}
