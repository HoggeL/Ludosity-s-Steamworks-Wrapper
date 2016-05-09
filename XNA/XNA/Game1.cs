using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Runtime.InteropServices;
using ManagedSteam;
using System.Text;
using ManagedSteam.CallbackStructures;
using ManagedSteam.Exceptions;
using ManagedSteam.SteamTypes;
using System.Net;

namespace XNA
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Steam steam;
        private ServicesGameServer GameServer;
        private KeyboardState oldKeyboard;
        private Color clearColor = Color.CornflowerBlue;
        //public uint myIp = (uint)BitConverter.ToInt32(IPAddress.Parse("129.168.22.23").GetAddressBytes(), 0);
        public uint myIp = 0x00000000;
        public int counter = 0;
        public bool testbool;
        public float value = 0;
        public AppID MyAppId = new AppID();
        public ushort commport = 0;
        public ushort port = 0;
        public uint NewInt = 0;
        public uint NewInt2 = 0;
        public SteamID MySteamID = new SteamID();
        public SteamID SecondSteamID = new SteamID();
        public string NewKey = "U";
        public string StringValue = "1.0.0.0";
        private byte[] mybyte = new byte[128];
        //public ChatEntryType myChatEntry = ChatEntryType.ChatMsg;
        public ServerMode myServermode = ServerMode.eServerModeNoAuthentication;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            this.IsMouseVisible = true;
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
			steam = Steam.Initialize();
            GameServer = ServicesGameServer.Initialize(myIp, 8766, 27015, 27016, myServermode, StringValue);

            //MatchmakingServerList responseObject = new MatchmakingServerList();
            //MatchMakingKeyValuePair[] filter = new MatchMakingKeyValuePair[2];
            //filter[0] = new MatchMakingKeyValuePair("TestKey0", "TestValue0Â‰ˆı");
            //filter[1] = new MatchMakingKeyValuePair("TestKey1", "TestValue1≈ƒ÷’");
            //steam.MatchmakingServers.RequestInternetServerList(steam.AppID, filter, responseObject);

            steam.Friends.GameOverlayActivated += GameOverlayToggle;


            base.Initialize();
        }

        private void GameOverlayToggle(GameOverlayActivated value)
        {
            if (value.Active)
            {
                clearColor = Color.OrangeRed;
                Console.WriteLine("Overlay activated");
            }
            else
            {
                clearColor = Color.LawnGreen;
                Console.WriteLine("Overlay closed");
            }
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {

        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            KeyboardState keyboard = Keyboard.GetState();
            steam.Update();

            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                keyboard.IsKeyDown(Keys.Escape))
            {
                steam.Shutdown();
                //GameServer.Shutdown();
                this.Exit();
                return;
            }

			if (Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(Keys.G))
			{
				GC.Collect();
				System.Diagnostics.Debug.Print("GC.Collect() triggered @ " + gameTime.TotalGameTime.TotalSeconds.ToString());
			}

            if (keyboard.IsKeyDown(Keys.Space) && oldKeyboard.IsKeyUp(Keys.Space))
            {

                //NewInt2 = (uint)steam.Networking.GetMaxPacketSize(NewInt);
                GameServer.GameServer.SetBotPlayerCount(0);
                GameServer.GameServerStats.GetUserAchievement(MySteamID, "Pop", out testbool);

                base.Update(gameTime);
                oldKeyboard = keyboard;
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(clearColor);



            base.Draw(gameTime);
        }
    }


    class MatchmakingServerList : MatchmakingServerListResponse
    {
        private int respondCount = 0;
        private int failedCount = 0;

        protected override void ServerResponded(ServerListRequestHandle request, int server)
        {
            //Console.WriteLine("ServerResponded: request " + request + " server " + server);
            ++respondCount;
        }

        protected override void ServerFailedToRespond(ServerListRequestHandle request, int server)
        {
            //Console.WriteLine("ServerFailedToRespond: request " + request + " server " + server);
            ++failedCount;
        }

        protected override void RefreshComplete(ServerListRequestHandle request, MatchMakingServerResponse response)
        {
            Console.WriteLine("RefreshComplete: request " + request + " response " + response +
                " respondCount " + respondCount + " failedCount " + failedCount);
        }
    }
}
