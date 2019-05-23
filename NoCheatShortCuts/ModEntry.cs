using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley.Locations;
using StardewValley;
using xTile.Dimensions;
using xTile.Layers;
using xTile.Tiles;
using xTile;
using System.Collections.Generic;

namespace NoCheatShortcuts
{
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            helper.Events.Player.Warped += AfterDayLoaded;
            this.Config = this.Helper.ReadConfig<ModConfig>();
        }

        class ModConfig
        {
            public bool BeachShortcut { get; set; } = true;
            public bool AdventureShortcut { get; set; } = true;
            public bool RiverShortcut { get; set; } = true;
        }
        private ModConfig Config;


        private void AfterDayLoaded(object sender, EventArgs args)
        {
            GameLocation location = Game1.getLocationFromName("Mountain");
            GameLocation Beach = Game1.getLocationFromName("Beach");
            bool BeachShortcut = this.Config.BeachShortcut;
            bool AdventureShortcut = this.Config.AdventureShortcut;
            bool RiverShortcut = this.Config.RiverShortcut;


            Layer layer = location.map.GetLayer("Buildings");
            TileSheet tilesheet = location.map.GetTileSheet("outdoors");
            if (AdventureShortcut) //////////////////////////////////////////////////////////////////////////
            {
                if (Game1.stats.DaysPlayed >= 5)
                {
                    layer.Tiles[68, 15] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 809);
                    layer.Tiles[68, 16] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 834);
                    layer.Tiles[68, 17] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 884);

                }
            }

            location = Game1.getLocationFromName("Town");
            tilesheet = location.map.GetTileSheet("Landscape");
            layer = location.map.GetLayer("Back");

            List<string> layers = new List<string>
            {
                "Back",
                "Buildings",
                "Front"
            };
            // layers.Add("AlwaysFront");

            if (RiverShortcut) ///////////////////////////////////////////////////////////////////////
            { 
                foreach (string p in layers)
                {
                    for (int o = 0; o < 10; o++)
                    {
                        for (int i = 81; i < 91; i++)
                        {
                            location.removeTile(i, o, p);
                        }
                    }
                }
                
                for (int o = 0; o < 10; o++)
                {
                    for (int i = 81; i < 91; i++)
                    {
                        location.removeTile(i, o, "Back");
                    }
                }


                layer.Tiles[81, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 614);
                layer.Tiles[82, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[83, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 350);
                layer.Tiles[84, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[85, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[86, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[87, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[88, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 353);
                layer.Tiles[89, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 377);
                layer.Tiles[90, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);

                layer.Tiles[81, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 488);
                layer.Tiles[82, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[83, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 375);
                layer.Tiles[84, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 403);
                layer.Tiles[85, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[86, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[87, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 304);
                layer.Tiles[88, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 352);
                layer.Tiles[89, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[90, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);

                layer.Tiles[81, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[82, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 177);
                layer.Tiles[83, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 203);
                layer.Tiles[84, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 375);
                layer.Tiles[85, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 376);
                layer.Tiles[86, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 376);
                layer.Tiles[87, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 376);
                layer.Tiles[88, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 377);
                layer.Tiles[89, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[90, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);

                layer.Tiles[81, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 252);
                layer.Tiles[82, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[83, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 177);
                layer.Tiles[84, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 179);
                layer.Tiles[85, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 180);
                layer.Tiles[86, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 180);
                layer.Tiles[87, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 567);
                layer.Tiles[88, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 568);
                layer.Tiles[89, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[90, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);

                layer.Tiles[81, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 202);
                layer.Tiles[82, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[83, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 206);
                layer.Tiles[84, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[85, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[86, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 231);
                layer.Tiles[87, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 207);
                layer.Tiles[88, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[89, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 594);
                layer.Tiles[90, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);

                layer.Tiles[81, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 178);
                layer.Tiles[82, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 251);
                layer.Tiles[83, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 251);
                layer.Tiles[84, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 251);
                layer.Tiles[85, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 251);
                layer.Tiles[86, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 252);
                layer.Tiles[87, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[88, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[89, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 619);
                layer.Tiles[90, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);

                layer.Tiles[81, 6] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[82, 6] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 150);
                layer.Tiles[83, 6] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[84, 6] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[85, 6] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[86, 6] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 289);
                layer.Tiles[87, 6] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 289);
                layer.Tiles[88, 6] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 289);
                layer.Tiles[89, 6] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 289);
                layer.Tiles[90, 6] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);

                layer.Tiles[81, 7] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 177);
                layer.Tiles[82, 7] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 203);
                layer.Tiles[83, 7] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 256);
                layer.Tiles[84, 7] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 256);
                layer.Tiles[85, 7] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 275);
                layer.Tiles[86, 7] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 337);
                layer.Tiles[87, 7] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 337);
                layer.Tiles[88, 7] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 337);
                layer.Tiles[89, 7] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 337);
                layer.Tiles[90, 7] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 202);

                layer.Tiles[81, 8] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 231);
                layer.Tiles[82, 8] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[83, 8] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 401);
                layer.Tiles[84, 8] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[85, 8] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 275);
                layer.Tiles[86, 8] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 337);
                layer.Tiles[87, 8] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 337);
                layer.Tiles[88, 8] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 337);
                layer.Tiles[89, 8] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 337);
                layer.Tiles[90, 8] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);

                layer.Tiles[81, 9] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 178);
                layer.Tiles[82, 9] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 253);
                layer.Tiles[83, 9] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[84, 9] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 150);
                layer.Tiles[85, 9] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 325);
                layer.Tiles[86, 9] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 337);
                layer.Tiles[87, 9] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 337);
                layer.Tiles[88, 9] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 337);
                layer.Tiles[89, 9] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 337);
                layer.Tiles[90, 9] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);

                layer = location.map.GetLayer("Buildings");
                //for (int o = 0; o < 10; o++)
                //{
                //    for (int i = 81; i < 91; i++)
                //    {
                //        location.removeTile(i, o, "Buildings");
                //    }
                //}
                ///////////////////////////////////////////////////// Building Tile Changes
                layer.Tiles[84, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 411);
                layer.Tiles[90, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 419);


                layer.Tiles[84, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[85, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 358);
                layer.Tiles[86, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 358);
                layer.Tiles[87, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 358);
                layer.Tiles[88, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 358);
                layer.Tiles[89, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 360);
                layer.Tiles[90, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 419);

                layer.Tiles[84, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 436);
                layer.Tiles[85, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 383);
                layer.Tiles[86, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 383);
                layer.Tiles[87, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 383);
                layer.Tiles[88, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 383);
                layer.Tiles[89, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 385);
                layer.Tiles[90, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 419);

                layer.Tiles[90, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 419);

                layer.Tiles[90, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 419);

                layer.Tiles[90, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 419);

                layer.Tiles[86, 6] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 444);
                layer.Tiles[89, 6] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 441);
                layer.Tiles[90, 6] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 444);

                layer.Tiles[85, 7] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 294);
                layer.Tiles[86, 7] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 469);
                layer.Tiles[89, 7] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 466);
                layer.Tiles[90, 7] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 469);

                layer.Tiles[85, 8] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 319);
                layer.Tiles[86, 8] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 494);
                layer.Tiles[89, 8] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 491);
                layer.Tiles[90, 8] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 494);

                layer.Tiles[85, 9] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 344);
                layer.Tiles[86, 9] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 519);
                layer.Tiles[89, 9] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 516);
                layer.Tiles[90, 9] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 519);

                layer.Tiles[85, 10] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 369);
                layer.Tiles[86, 10] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 544);
                layer.Tiles[89, 10] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 541);
                layer.Tiles[90, 10] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 544);


                ///////////////////////////////////////////////////// Front Tile Changes
                layer = location.map.GetLayer("Front");

                //for (int o = 0; o < 10; o++)
                //{
                //    for (int i = 81; i < 91; i++)
                //    {
                //        location.removeTile(i, o, "Front");
                //    }
                //}

                layer.Tiles[88, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 136);

                for (int o = 0; o < 10; o++)
                {
                    for (int i = 81; i < 90; i++)
                    {
                        location.removeTile(i, o, "AlwaysFront");
                    }
                }

                //   Warp warpy = new Warp(5, 53, "BusStop", 34, 23, false);


                ///////////////////////////////////////////////////////////////////////////// TOWN WARPS
                location = Game1.getLocationFromName("Town");

        }




            if(BeachShortcut)
            { 
                //BEACH ENTRANCE
                Beach beach = (Beach)Game1.getLocationFromName("Beach");

                List<Warp> Townwarps = new List<Warp>
                {
                    new Warp(101, 110, "Beach", 67, 0, false),
                    new Warp(102, 110, "Beach", 67, 0, false)
                };

                foreach (Warp warpy in Townwarps)
                {
                    location.warps.Add(warpy);

                }
                foreach (string p in layers)
                {
                    for (int o = 93; o < 110; o++)
                    {
                        for (int i = 91; i < 120; i++)
                        {
                            location.removeTile(i, o, p);
                        }
                    }
                }

                for (int o = 94; o < 110; o++)
                {
                    location.removeTile(101, o, "AlwaysFront");
                    location.removeTile(102, o, "AlwaysFront");
                }
                location.removeTile(103, 94, "AlwaysFront");
                location.removeTile(103, 95, "AlwaysFront");
                location.removeTile(103, 96, "AlwaysFront");
                location.removeTile(99, 99, "Buildings");

                for (int o = 93; o < 110; o++)
                {
                    for (int i = 91; i < 119; i++)
                    {
                        location.removeTile(i, o, "AlwaysFront");
                    }
                }
                tilesheet = location.map.GetTileSheet("Landscape");
                TileSheet tilesheet2 = location.map.GetTileSheet("Town");
                layer = location.map.GetLayer("AlwaysFront");
                layer.Tiles[103, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 6);
                layer.Tiles[103, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 31);
                layer.Tiles[103, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 56);
                layer.Tiles[103, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 81);

                // town from x100 - 103 y107 -109 

                layer = location.map.GetLayer("Back");
                layer.Tiles[91, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[92, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[93, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 177);
                layer.Tiles[94, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 201);
                layer.Tiles[95, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 179);
                layer.Tiles[96, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 180);
                layer.Tiles[97, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 205);
                layer.Tiles[98, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 201);
                layer.Tiles[99, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 201);
                layer.Tiles[100, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 202);
                layer.Tiles[101, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[102, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[103, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[104, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 150);
                layer.Tiles[105, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[106, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[107, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 151);
                layer.Tiles[108, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[109, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[110, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 286);
                layer.Tiles[111, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[112, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[113, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[114, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[115, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[116, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[117, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 404);
                layer.Tiles[118, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 156);
                layer.Tiles[119, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);

                layer.Tiles[91, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[92, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 231);
                layer.Tiles[93, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[94, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[95, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[96, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[97, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 610);
                layer.Tiles[98, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[99, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[100, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 206);
                layer.Tiles[101, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 227);
                layer.Tiles[102, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[103, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[104, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 256);
                layer.Tiles[105, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 256);
                layer.Tiles[106, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[107, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 275);
                layer.Tiles[108, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[109, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 401);
                layer.Tiles[110, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 311);
                layer.Tiles[111, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[112, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[113, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[114, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[115, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[116, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[117, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[118, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 379);
                layer.Tiles[119, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);

                layer.Tiles[91, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 204);
                layer.Tiles[92, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 251);
                layer.Tiles[93, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 229);
                layer.Tiles[94, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 230);
                layer.Tiles[95, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 204);
                layer.Tiles[96, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 251);
                layer.Tiles[97, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 251);
                layer.Tiles[98, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 229);
                layer.Tiles[99, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 230);
                layer.Tiles[100, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 204);
                layer.Tiles[101, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 252);
                layer.Tiles[102, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[103, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[104, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[105, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 275);
                layer.Tiles[106, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[107, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 150);
                layer.Tiles[108, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 325);
                layer.Tiles[109, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 326);
                layer.Tiles[110, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 328);
                layer.Tiles[111, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[112, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[113, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 354);
                layer.Tiles[114, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 355);
                layer.Tiles[115, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 355);
                layer.Tiles[116, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 355);
                layer.Tiles[117, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 356);
                layer.Tiles[118, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 379);
                layer.Tiles[119, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);

                layer.Tiles[91, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[92, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[93, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[94, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 151);
                layer.Tiles[95, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[96, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[97, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[98, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[99, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[100, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[101, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);
                layer.Tiles[102, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[103, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[104, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[105, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 401);
                layer.Tiles[106, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 325);
                layer.Tiles[107, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 326);
                layer.Tiles[108, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 328);
                layer.Tiles[109, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[110, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[111, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[112, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[113, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 379);
                layer.Tiles[114, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[115, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[116, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 357);
                layer.Tiles[117, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 406);
                layer.Tiles[118, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 404);
                layer.Tiles[119, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 353);

                layer.Tiles[91, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 325);
                layer.Tiles[92, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 326);
                layer.Tiles[93, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 326);
                layer.Tiles[94, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 326);
                layer.Tiles[95, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 326);
                layer.Tiles[96, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 326);
                layer.Tiles[97, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 326);
                layer.Tiles[98, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 326);
                layer.Tiles[99, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 326);
                layer.Tiles[100, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 327);
                layer.Tiles[101, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);
                layer.Tiles[102, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[103, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 325);
                layer.Tiles[104, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 326);
                layer.Tiles[105, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 326);
                layer.Tiles[106, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 328);
                layer.Tiles[107, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[108, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[109, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[110, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[111, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[112, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[113, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 379);
                layer.Tiles[114, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[115, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 357);
                layer.Tiles[116, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 406);
                layer.Tiles[117, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[118, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 354);
                layer.Tiles[119, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 352);

                layer.Tiles[91, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 350);
                layer.Tiles[92, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[93, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[94, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[95, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[96, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[97, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[98, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[99, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[100, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 352);
                layer.Tiles[101, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);
                layer.Tiles[102, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[103, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 350);
                layer.Tiles[104, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[105, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[106, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[107, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[108, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[109, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[110, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[111, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[112, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[113, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 404);
                layer.Tiles[114, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 405);
                layer.Tiles[115, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 406);
                layer.Tiles[116, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 403);
                layer.Tiles[117, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 304);
                layer.Tiles[118, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 379);
                layer.Tiles[119, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);

                layer.Tiles[91, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 261);
                layer.Tiles[92, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[93, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[94, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 354);
                layer.Tiles[95, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 356);
                layer.Tiles[96, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 354);
                layer.Tiles[97, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 355);
                layer.Tiles[98, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 355);
                layer.Tiles[99, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 356);
                layer.Tiles[100, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 352);
                layer.Tiles[101, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);
                layer.Tiles[102, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[103, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 350);
                layer.Tiles[104, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[105, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[106, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[107, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[108, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[109, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[110, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[111, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[112, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[113, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 354);
                layer.Tiles[114, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 355);
                layer.Tiles[115, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 355);
                layer.Tiles[116, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 356);
                layer.Tiles[117, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 354);
                layer.Tiles[118, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 332);
                layer.Tiles[119, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);

                layer.Tiles[91, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 286);
                layer.Tiles[92, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[93, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[94, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 404);
                layer.Tiles[95, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 406);
                layer.Tiles[96, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 404);
                layer.Tiles[97, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 405);
                layer.Tiles[98, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[99, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 381);
                layer.Tiles[100, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 352);
                layer.Tiles[101, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);
                layer.Tiles[102, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[103, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 350);
                layer.Tiles[104, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[105, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[106, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[107, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[108, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[109, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[110, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[111, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[112, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 304);
                layer.Tiles[113, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 379);
                layer.Tiles[114, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[115, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[116, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 382);
                layer.Tiles[117, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 332);
                layer.Tiles[118, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[119, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);

                layer.Tiles[91, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 311);
                layer.Tiles[92, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[93, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[94, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 304);
                layer.Tiles[95, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 305);
                layer.Tiles[96, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[97, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[98, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 407);
                layer.Tiles[99, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 381);
                layer.Tiles[100, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 352);
                layer.Tiles[101, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);
                layer.Tiles[102, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[103, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 350);
                layer.Tiles[104, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[105, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[106, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[107, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[108, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[109, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[110, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[111, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[112, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[113, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 379);
                layer.Tiles[114, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[115, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[116, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[117, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[118, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[119, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);

                layer.Tiles[91, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 375);
                layer.Tiles[92, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 403);
                layer.Tiles[93, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[94, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[95, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[96, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[97, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[98, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 379);
                layer.Tiles[99, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 381);
                layer.Tiles[100, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 352);
                layer.Tiles[101, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);
                layer.Tiles[102, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[103, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 350);
                layer.Tiles[104, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[105, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[106, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[107, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[108, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[109, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[110, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[111, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[112, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[113, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 379);
                layer.Tiles[114, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[115, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[116, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[117, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 156);
                layer.Tiles[118, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[119, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);

                layer.Tiles[91, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 203);
                layer.Tiles[92, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 375);
                layer.Tiles[93, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 403);
                layer.Tiles[94, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[95, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[96, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[97, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[98, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 404);
                layer.Tiles[99, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 406);
                layer.Tiles[100, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 352);
                layer.Tiles[101, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);
                layer.Tiles[102, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[103, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 350);
                layer.Tiles[104, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[105, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[106, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[107, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[108, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[109, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[110, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[111, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 305);
                layer.Tiles[112, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[113, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 404);
                layer.Tiles[114, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 405);
                layer.Tiles[115, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 407);
                layer.Tiles[116, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[117, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[118, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[119, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);

                layer.Tiles[91, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 177);
                layer.Tiles[92, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 203);
                layer.Tiles[93, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 375);
                layer.Tiles[94, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 403);
                layer.Tiles[95, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[96, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[97, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[98, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[99, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 304);
                layer.Tiles[100, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 352);
                layer.Tiles[101, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);
                layer.Tiles[102, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[103, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 350);
                layer.Tiles[104, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[105, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[106, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[107, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[108, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[109, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[110, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[111, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 304);
                layer.Tiles[112, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[113, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[114, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[115, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 379);
                layer.Tiles[116, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[117, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[118, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 156);
                layer.Tiles[119, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);

                layer.Tiles[91, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 1244);
                layer.Tiles[92, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 177);
                layer.Tiles[93, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 203);
                layer.Tiles[94, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 375);
                layer.Tiles[95, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 376);
                layer.Tiles[96, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 403);
                layer.Tiles[97, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[98, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[99, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[100, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 352);
                layer.Tiles[101, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);
                layer.Tiles[102, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[103, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 350);
                layer.Tiles[104, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[105, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[106, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[107, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[108, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[109, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[110, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[111, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[112, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[113, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[114, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 304);
                layer.Tiles[115, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 379);
                layer.Tiles[116, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[117, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[118, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[119, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);

                layer.Tiles[91, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 1270);
                layer.Tiles[92, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 1244);
                layer.Tiles[93, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 177);
                layer.Tiles[94, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 201);
                layer.Tiles[95, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 203);
                layer.Tiles[96, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 350);
                layer.Tiles[97, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[98, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[99, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[100, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 352);
                layer.Tiles[101, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);
                layer.Tiles[102, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[103, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 350);
                layer.Tiles[104, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[105, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[106, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[107, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[108, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[109, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[110, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[111, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[112, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[113, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[114, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 354);
                layer.Tiles[115, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 332);
                layer.Tiles[116, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[117, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[118, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[119, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);

                layer.Tiles[91, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 1267);
                layer.Tiles[92, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 1270);
                layer.Tiles[93, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 1244);
                layer.Tiles[94, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 207);
                layer.Tiles[95, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[96, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 375);
                layer.Tiles[97, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 376);
                layer.Tiles[98, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 376);
                layer.Tiles[99, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 403);
                layer.Tiles[100, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 352);
                layer.Tiles[101, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);
                layer.Tiles[102, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[103, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 350);
                layer.Tiles[104, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[105, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[106, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[107, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[108, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[109, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[110, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[111, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[112, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[113, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 354);
                layer.Tiles[114, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 332);
                layer.Tiles[115, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[116, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[117, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[118, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[119, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);

                layer.Tiles[91, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 1229);
                layer.Tiles[92, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 1267);
                layer.Tiles[93, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 1270);
                layer.Tiles[94, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 1244);
                layer.Tiles[95, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[96, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[97, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[98, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[99, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 375);
                layer.Tiles[100, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 377);
                layer.Tiles[101, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);
                layer.Tiles[102, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[103, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 350);
                layer.Tiles[104, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[105, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[106, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[107, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 354);
                layer.Tiles[108, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 355);
                layer.Tiles[109, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 355);
                layer.Tiles[110, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 355);
                layer.Tiles[111, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 355);
                layer.Tiles[112, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[113, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[114, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[115, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[116, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[117, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[118, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[119, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);

                layer.Tiles[91, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 1274);
                layer.Tiles[92, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 1229);
                layer.Tiles[93, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 1267);
                layer.Tiles[94, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 1270);
                layer.Tiles[95, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 177);
                layer.Tiles[96, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 203);
                layer.Tiles[97, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[98, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 175);
                layer.Tiles[99, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 275);
                layer.Tiles[100, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 275);
                layer.Tiles[101, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 225);
                layer.Tiles[102, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 228);
                layer.Tiles[103, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 350);
                layer.Tiles[104, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[105, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[106, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 351);
                layer.Tiles[107, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 379);
                layer.Tiles[108, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[109, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[110, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[111, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[112, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[113, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[114, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[115, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[116, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[117, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[118, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);
                layer.Tiles[119, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 380);









                layer = location.map.GetLayer("AlwaysFront");
                layer.Tiles[95, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 16);
                layer.Tiles[96, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 17);
                layer.Tiles[97, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 18);
                layer.Tiles[98, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 19);
                layer.Tiles[99, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 20);
                layer.Tiles[100, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 21);

                layer.Tiles[95, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 41);
                layer.Tiles[96, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 42);
                layer.Tiles[97, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 43);
                layer.Tiles[98, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 44);
                layer.Tiles[99, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 45);
                layer.Tiles[100, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 46);

                layer.Tiles[95, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 66);
                layer.Tiles[96, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 67);
                layer.Tiles[97, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 68);
                layer.Tiles[98, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 69);
                layer.Tiles[99, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 70);
                layer.Tiles[100, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 71);
                layer.Tiles[103, 97] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 782);
                layer.Tiles[104, 97] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 783);
                layer.Tiles[105, 97] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 784);
                layer.Tiles[106, 97] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 785);
                layer.Tiles[107, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 16);
                layer.Tiles[108, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 17);
                layer.Tiles[109, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 18);
                layer.Tiles[110, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 19);
                layer.Tiles[111, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 20);
                layer.Tiles[112, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 21);

                layer.Tiles[95, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 91);
                layer.Tiles[96, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 92);
                layer.Tiles[97, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 93);
                layer.Tiles[98, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 94);
                layer.Tiles[99, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 95);
                layer.Tiles[100, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 96);
                layer.Tiles[101, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 103);
                layer.Tiles[103, 98] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 814);
                layer.Tiles[104, 98] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 815);
                layer.Tiles[105, 98] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 816);
                layer.Tiles[106, 98] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 817);
                layer.Tiles[107, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 41);
                layer.Tiles[108, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 42);
                layer.Tiles[109, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 43);
                layer.Tiles[110, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 44);
                layer.Tiles[111, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 45);
                layer.Tiles[112, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 46);
                layer.Tiles[114, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 3);
                layer.Tiles[115, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 4);
                layer.Tiles[116, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 5);

                layer.Tiles[103, 99] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 846);
                layer.Tiles[104, 99] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 847);
                layer.Tiles[105, 99] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 848);
                layer.Tiles[106, 99] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 849);
                layer.Tiles[107, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 66);
                layer.Tiles[108, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 67);
                layer.Tiles[109, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 68);
                layer.Tiles[110, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 69);
                layer.Tiles[111, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 70);
                layer.Tiles[112, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 71);
                layer.Tiles[114, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 28);
                layer.Tiles[115, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 29);
                layer.Tiles[116, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 30);

                layer.Tiles[103, 100] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 878);
                layer.Tiles[104, 100] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 879);
                layer.Tiles[105, 100] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 880);
                layer.Tiles[106, 100] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 881);
                layer.Tiles[107, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 91);
                layer.Tiles[108, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 92);
                layer.Tiles[109, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 93);
                layer.Tiles[110, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 94);
                layer.Tiles[111, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 95);
                layer.Tiles[112, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 96);
                layer.Tiles[114, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 53);
                layer.Tiles[115, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 54);
                layer.Tiles[116, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 55);
                layer.Tiles[118, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 3);
                layer.Tiles[119, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 4);

                layer.Tiles[95, 101] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 782);
                layer.Tiles[96, 101] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 783);
                layer.Tiles[97, 101] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 784);
                layer.Tiles[98, 101] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 785);
                layer.Tiles[103, 101] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 910);
                layer.Tiles[104, 101] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 911);
                layer.Tiles[105, 101] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 912);
                layer.Tiles[106, 101] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 913);
                layer.Tiles[114, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 78);
                layer.Tiles[115, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 79);
                layer.Tiles[116, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 80);
                layer.Tiles[118, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 28);
                layer.Tiles[119, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 29);

                layer.Tiles[95, 102] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 814);
                layer.Tiles[96, 102] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 815);
                layer.Tiles[97, 102] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 816);
                layer.Tiles[98, 102] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 817);
                layer.Tiles[114, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 103);
                layer.Tiles[115, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 104);
                layer.Tiles[116, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 105);
                layer.Tiles[118, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 53);
                layer.Tiles[119, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 54);

                layer.Tiles[95, 103] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 846);
                layer.Tiles[96, 103] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 847);
                layer.Tiles[97, 103] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 848);
                layer.Tiles[98, 103] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 849);
                layer.Tiles[118, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 78);
                layer.Tiles[119, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 79);

                layer.Tiles[95, 104] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 878);
                layer.Tiles[96, 104] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 879);
                layer.Tiles[97, 104] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 880);
                layer.Tiles[98, 104] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 881);
                layer.Tiles[118, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 103);
                layer.Tiles[119, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 104);

                layer.Tiles[95, 105] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 910);
                layer.Tiles[96, 105] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 911);
                layer.Tiles[97, 105] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 912);
                layer.Tiles[98, 105] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 913);
                layer.Tiles[110, 105] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 782);
                layer.Tiles[111, 105] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 783);
                layer.Tiles[112, 105] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 784);
                layer.Tiles[113, 105] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 785);

                layer.Tiles[95, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 17);
                layer.Tiles[96, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 18);
                layer.Tiles[97, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 19);
                layer.Tiles[98, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 20);
                layer.Tiles[99, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 21);
                layer.Tiles[104, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 16);
                layer.Tiles[105, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 17);
                layer.Tiles[106, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 18);
                layer.Tiles[107, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 19);
                layer.Tiles[108, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 20);
                layer.Tiles[109, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 21);
                layer.Tiles[110, 106] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 814);
                layer.Tiles[111, 106] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 815);
                layer.Tiles[112, 106] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 816);
                layer.Tiles[113, 106] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 817);
                layer.Tiles[116, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 16);

                layer.Tiles[95, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 42);
                layer.Tiles[96, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 43);
                layer.Tiles[97, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 44);
                layer.Tiles[98, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 45);
                layer.Tiles[99, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 46);
                layer.Tiles[104, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 41);
                layer.Tiles[105, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 42);
                layer.Tiles[106, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 43);
                layer.Tiles[107, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 44);
                layer.Tiles[108, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 45);
                layer.Tiles[109, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 46);
                layer.Tiles[110, 107] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 846);
                layer.Tiles[111, 107] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 847);
                layer.Tiles[112, 107] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 848);
                layer.Tiles[113, 107] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 849);
                layer.Tiles[116, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 6);
                layer.Tiles[117, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 7);
                layer.Tiles[118, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 8);
                layer.Tiles[119, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 9);

                layer.Tiles[95, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 67);
                layer.Tiles[96, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 68);
                layer.Tiles[97, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 69);
                layer.Tiles[98, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 70);
                layer.Tiles[99, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 71);
                layer.Tiles[104, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 66);
                layer.Tiles[105, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 67);
                layer.Tiles[106, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 68);
                layer.Tiles[107, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 69);
                layer.Tiles[108, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 70);
                layer.Tiles[109, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 71);
                layer.Tiles[110, 108] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 878);
                layer.Tiles[111, 108] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 879);
                layer.Tiles[112, 108] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 880);
                layer.Tiles[113, 108] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 881);
                layer.Tiles[116, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 31);
                layer.Tiles[117, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 32);
                layer.Tiles[118, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 33);
                layer.Tiles[119, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 34);

                layer.Tiles[95, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 92);
                layer.Tiles[96, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 93);
                layer.Tiles[97, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 94);
                layer.Tiles[98, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 95);
                layer.Tiles[99, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 96);
                layer.Tiles[104, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 91);
                layer.Tiles[105, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 92);
                layer.Tiles[106, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 93);
                layer.Tiles[107, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 94);
                layer.Tiles[108, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 95);
                layer.Tiles[109, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 96);
                layer.Tiles[110, 109] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 910);
                layer.Tiles[111, 109] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 911);
                layer.Tiles[112, 109] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 912);
                layer.Tiles[113, 109] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 913);
                layer.Tiles[116, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 56);
                layer.Tiles[117, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 57);
                layer.Tiles[118, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 58);
                layer.Tiles[119, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 59);







                layer = location.map.GetLayer("Buildings");
                layer.Tiles[111, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[112, 93] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 914);
                layer.Tiles[113, 93] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 915);
                layer.Tiles[118, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[119, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);

                layer.Tiles[105, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 129);
                layer.Tiles[111, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[112, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[118, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[119, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);

                layer.Tiles[111, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[112, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 232);
                layer.Tiles[113, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[117, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);

                layer.Tiles[111, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 411);
                layer.Tiles[112, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[115, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 143);
                layer.Tiles[116, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 144);
                layer.Tiles[117, 96] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);

                layer.Tiles[111, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 436);
                layer.Tiles[112, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[113, 97] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 914);
                layer.Tiles[114, 97] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 915);
                layer.Tiles[115, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 168);
                layer.Tiles[116, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 169);
                layer.Tiles[117, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[118, 97] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 850);
                layer.Tiles[119, 97] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 851);

                layer.Tiles[92, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 383);
                layer.Tiles[93, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 384);
                layer.Tiles[94, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 384);
                layer.Tiles[95, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 384);
                layer.Tiles[96, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 384);
                layer.Tiles[97, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 384);
                layer.Tiles[98, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 384);
                layer.Tiles[99, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 385);
                layer.Tiles[100, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[103, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[104, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 383);
                layer.Tiles[105, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 384);
                layer.Tiles[106, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 384);
                layer.Tiles[107, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 384);
                layer.Tiles[108, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 384);
                layer.Tiles[109, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 384);
                layer.Tiles[110, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 384);
                layer.Tiles[111, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 385);
                layer.Tiles[112, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[117, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[119, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);

                layer.Tiles[92, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[95, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[96, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[100, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[103, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[113, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 307);
                layer.Tiles[117, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[118, 99] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 15);
                layer.Tiles[119, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);

                layer.Tiles[92, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[93, 100] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 914);
                layer.Tiles[94, 100] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 915);
                layer.Tiles[95, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[96, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[97, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 143);
                layer.Tiles[98, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 144);
                layer.Tiles[99, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[100, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[103, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[113, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[117, 100] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);

                layer.Tiles[92, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[93, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[94, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[97, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 168);
                layer.Tiles[98, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 169);
                layer.Tiles[99, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[100, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[103, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[106, 101] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 850);
                layer.Tiles[107, 101] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 851);
                layer.Tiles[108, 101] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 852);
                layer.Tiles[111, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[112, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[113, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[117, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);

                layer.Tiles[92, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 411);
                layer.Tiles[93, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[94, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 257);
                layer.Tiles[99, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 232);
                layer.Tiles[100, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[103, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[104, 102] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 943);
                layer.Tiles[105, 102] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 944);
                layer.Tiles[106, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[107, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[108, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[109, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 143);
                layer.Tiles[110, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 144);
                layer.Tiles[111, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[117, 102] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);

                layer.Tiles[92, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 436);
                layer.Tiles[99, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[100, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[103, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[104, 103] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 975);
                layer.Tiles[105, 103] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 976);
                layer.Tiles[107, 103] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 887);
                layer.Tiles[108, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[109, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 168);
                layer.Tiles[110, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 169);
                layer.Tiles[111, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[115, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 129);
                layer.Tiles[117, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 257);

                layer.Tiles[92, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 38);
                layer.Tiles[93, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 39);
                layer.Tiles[94, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 40);
                layer.Tiles[99, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[100, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[103, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[107, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[110, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[111, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[112, 104] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 850);
                layer.Tiles[113, 104] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 851);
                layer.Tiles[114, 104] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 852);
                layer.Tiles[118, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);

                layer.Tiles[91, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 185);
                layer.Tiles[92, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 63);
                layer.Tiles[93, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 64);
                layer.Tiles[94, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 65);
                layer.Tiles[95, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[100, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[103, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[107, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[108, 105] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 914);
                layer.Tiles[109, 105] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 915);
                layer.Tiles[119, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 129);

                layer.Tiles[91, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 284);
                layer.Tiles[92, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 185);
                layer.Tiles[93, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[94, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[95, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[96, 106] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 943);
                layer.Tiles[97, 106] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 944);
                layer.Tiles[98, 106] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 914);
                layer.Tiles[99, 106] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 915);
                layer.Tiles[100, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[103, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[108, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[109, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);

                layer.Tiles[92, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 284);
                layer.Tiles[93, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 185);
                layer.Tiles[96, 107] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 975);
                layer.Tiles[97, 107] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 976);
                layer.Tiles[99, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 257);
                layer.Tiles[100, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[103, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[104, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 107);
                layer.Tiles[105, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 108);
                layer.Tiles[109, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 307);

                layer.Tiles[93, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 284);
                layer.Tiles[94, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 185);
                layer.Tiles[100, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[103, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[104, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 132);
                layer.Tiles[105, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 133);
                layer.Tiles[109, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[110, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[111, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[112, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[113, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[116, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 118);
                layer.Tiles[117, 108] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 119);

                layer.Tiles[94, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 235);
                layer.Tiles[100, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[103, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 386);
                layer.Tiles[104, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 157);
                layer.Tiles[105, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 158);
                layer.Tiles[109, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[110, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[111, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[112, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[113, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 102);
                layer.Tiles[114, 109] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 914);
                layer.Tiles[115, 109] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 915);
                layer.Tiles[116, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 143);
                layer.Tiles[117, 109] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 144);











                layer = location.map.GetLayer("Front");
                layer.Tiles[108, 90] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 46);

                layer.Tiles[94, 91] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 9);
                layer.Tiles[113, 91] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 16);
                layer.Tiles[114, 91] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 17);
                layer.Tiles[115, 91] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 18);
                layer.Tiles[116, 91] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 19);
                layer.Tiles[117, 91] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 20);
                layer.Tiles[118, 91] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 21);

                layer.Tiles[113, 92] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 41);
                layer.Tiles[114, 92] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 42);
                layer.Tiles[115, 92] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 43);
                layer.Tiles[116, 92] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 44);
                layer.Tiles[117, 92] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 45);
                layer.Tiles[118, 92] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 46);

                layer.Tiles[105, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 100);
                layer.Tiles[113, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 66);
                layer.Tiles[114, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 67);
                layer.Tiles[115, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 68);
                layer.Tiles[116, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 69);
                layer.Tiles[117, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 70);
                layer.Tiles[118, 93] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 71);

                layer.Tiles[113, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 91);
                layer.Tiles[114, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 92);
                layer.Tiles[115, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 93);
                layer.Tiles[116, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 94);
                layer.Tiles[117, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 95);
                layer.Tiles[118, 94] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 96);

                layer.Tiles[115, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 118);
                layer.Tiles[116, 95] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 119);
                layer.Tiles[118, 95] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 786);
                layer.Tiles[119, 95] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 787);

                layer.Tiles[113, 96] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 882);
                layer.Tiles[114, 96] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 883);
                layer.Tiles[118, 96] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 818);
                layer.Tiles[119, 96] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 819);

                layer.Tiles[93, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 358);
                layer.Tiles[93, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 359);
                layer.Tiles[94, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 359);
                layer.Tiles[95, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 359);
                layer.Tiles[96, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 359);
                layer.Tiles[97, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 359);
                layer.Tiles[98, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 359);
                layer.Tiles[99, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 360);
                layer.Tiles[100, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 361);
                layer.Tiles[103, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 361);
                layer.Tiles[104, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 358);
                layer.Tiles[105, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 359);
                layer.Tiles[106, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 359);
                layer.Tiles[107, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 359);
                layer.Tiles[108, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 359);
                layer.Tiles[109, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 359);
                layer.Tiles[110, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 359);
                layer.Tiles[111, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 360);

                layer.Tiles[92, 97] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 358);
                layer.Tiles[92, 98] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 361);

                layer.Tiles[92, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 13);

                layer.Tiles[93, 99] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 882);
                layer.Tiles[94, 99] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 883);
                layer.Tiles[97, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 118);
                layer.Tiles[98, 99] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 119);
                layer.Tiles[106, 99] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 786);
                layer.Tiles[107, 99] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 787);
                layer.Tiles[108, 99] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 788);

                layer.Tiles[106, 100] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 818);
                layer.Tiles[107, 100] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 819);
                layer.Tiles[108, 100] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 820);

                layer.Tiles[109, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 118);
                layer.Tiles[110, 101] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 119);

                layer.Tiles[112, 102] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 786);
                layer.Tiles[113, 102] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 787);
                layer.Tiles[114, 102] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 788);

                layer.Tiles[93, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 14);
                layer.Tiles[94, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 15);
                layer.Tiles[104, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 7);
                layer.Tiles[105, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 8);
                layer.Tiles[106, 103] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 9);
                layer.Tiles[112, 103] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 818);
                layer.Tiles[113, 103] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 819);
                layer.Tiles[114, 103] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 820);

                layer.Tiles[104, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 32);
                layer.Tiles[105, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 33);
                layer.Tiles[106, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 34);
                layer.Tiles[108, 104] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 882);
                layer.Tiles[109, 104] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 883);
                layer.Tiles[114, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 16);
                layer.Tiles[115, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 17);
                layer.Tiles[116, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 18);
                layer.Tiles[117, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 19);
                layer.Tiles[118, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 20);
                layer.Tiles[119, 104] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 21);

                layer.Tiles[98, 105] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 882);
                layer.Tiles[99, 105] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 883);
                layer.Tiles[104, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 57);
                layer.Tiles[105, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 58);
                layer.Tiles[106, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 59);
                layer.Tiles[114, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 41);
                layer.Tiles[115, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 42);
                layer.Tiles[116, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 43);
                layer.Tiles[117, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 44);
                layer.Tiles[118, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 45);
                layer.Tiles[119, 105] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 46);

                layer.Tiles[104, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 82);
                layer.Tiles[105, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 83);
                layer.Tiles[106, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 84);
                layer.Tiles[114, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 66);
                layer.Tiles[115, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 67);
                layer.Tiles[116, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 68);
                layer.Tiles[117, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 69);
                layer.Tiles[118, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 70);
                layer.Tiles[119, 106] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 71);

                layer.Tiles[114, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 91);
                layer.Tiles[115, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 92);
                layer.Tiles[116, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 93);
                layer.Tiles[117, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 94);
                layer.Tiles[118, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 95);
                layer.Tiles[119, 107] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 96);

                layer.Tiles[114, 108] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 882);
                layer.Tiles[115, 108] = new StaticTile(layer, tilesheet2, BlendMode.Alpha, 883);
                location = Game1.getLocationFromName("Beach");

                foreach (string p in layers)
                {
                    for (int o = 0; o < 6; o++)
                    {
                        for (int i = 65; i < 69; i++)
                        {
                            location.removeTile(i, o, p);
                        }
                    }
                }

                layer = location.map.GetLayer("Front");
                tilesheet = location.map.GetTileSheet("untitled tile sheet");
                // 65 ,0 
                // 69, 5

                layer = location.map.GetLayer("Back");
                layer.Tiles[65, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 100); layer.Tiles[66, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 116); layer.Tiles[67, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 24); layer.Tiles[68, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 132); layer.Tiles[69, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 101);
                layer.Tiles[65, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 100); layer.Tiles[66, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 116); layer.Tiles[67, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 24); layer.Tiles[68, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 132); layer.Tiles[69, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 101);
                layer.Tiles[65, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 100); layer.Tiles[66, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 116); layer.Tiles[67, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 24); layer.Tiles[68, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 132); layer.Tiles[69, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 101);
                layer.Tiles[65, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 117); layer.Tiles[66, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 116); layer.Tiles[67, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 24); layer.Tiles[68, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 132); layer.Tiles[69, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 118);
                layer.Tiles[65, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 98); layer.Tiles[66, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 115); layer.Tiles[67, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 24); layer.Tiles[68, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 133); layer.Tiles[69, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 98);
                layer.Tiles[65, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 51); layer.Tiles[66, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 70); layer.Tiles[67, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 42); layer.Tiles[68, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 69); layer.Tiles[69, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 54);

                layer = location.map.GetLayer("Buildings");
                layer.Tiles[65, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 357); layer.Tiles[69, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 66);
                layer.Tiles[69, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 83);
                layer.Tiles[65, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 150); layer.Tiles[66, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 357); layer.Tiles[68, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 357); layer.Tiles[69, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 357);
                layer.Tiles[65, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 167); layer.Tiles[66, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 170); layer.Tiles[68, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 157); layer.Tiles[69, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 166);

                layer = location.map.GetLayer("Front");
                layer.Tiles[65, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 33); layer.Tiles[66, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 33); layer.Tiles[67, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 48); layer.Tiles[68, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 33); layer.Tiles[69, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 31);
                layer.Tiles[65, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 33); layer.Tiles[66, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 32); layer.Tiles[68, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 29); layer.Tiles[69, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 33);
                layer.Tiles[65, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 46); layer.Tiles[66, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 49); layer.Tiles[68, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 46); layer.Tiles[69, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 65);
                layer.Tiles[69, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 149);




                List<Warp> BeachWarps = new List<Warp>
                {
                    new Warp(67, -1, "Town", 101, 109, false),
                    new Warp(68, -1, "Town", 101, 109, false),
                    new Warp(66, -1, "Town", 101, 109, false)
                };
                foreach (Warp warpy in BeachWarps)
                {
                    location.warps.Add(warpy);

                }
                if (!beach.bridgeFixed.Value)
                {
                    layer = location.map.GetLayer("Buildings");
                    layer.Tiles[67, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 140);
                }



                location = Game1.getLocationFromName("BeachNightMarket");

                foreach (string p in layers)
                {
                    for (int o = 0; o < 6; o++)
                    {
                        for (int i = 65; i < 69; i++)
                        {
                            location.removeTile(i, o, p);
                        }
                    }
                }

                layer = location.map.GetLayer("Front");
                tilesheet = location.map.GetTileSheet("untitled tile sheet");

                layer = location.map.GetLayer("Back");
                layer.Tiles[65, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 100); layer.Tiles[66, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 116); layer.Tiles[67, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 24); layer.Tiles[68, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 132); layer.Tiles[69, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 101);
                layer.Tiles[65, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 100); layer.Tiles[66, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 116); layer.Tiles[67, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 24); layer.Tiles[68, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 132); layer.Tiles[69, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 101);
                layer.Tiles[65, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 100); layer.Tiles[66, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 116); layer.Tiles[67, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 24); layer.Tiles[68, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 132); layer.Tiles[69, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 101);
                layer.Tiles[65, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 117); layer.Tiles[66, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 116); layer.Tiles[67, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 24); layer.Tiles[68, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 132); layer.Tiles[69, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 118);
                layer.Tiles[65, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 98); layer.Tiles[66, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 115); layer.Tiles[67, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 24); layer.Tiles[68, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 133); layer.Tiles[69, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 98);
                layer.Tiles[65, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 51); layer.Tiles[66, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 70); layer.Tiles[67, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 42); layer.Tiles[68, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 69); layer.Tiles[69, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 54);

                layer = location.map.GetLayer("Buildings");
                layer.Tiles[65, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 357); layer.Tiles[69, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 66);
                layer.Tiles[69, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 83);
                layer.Tiles[65, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 150); layer.Tiles[66, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 357); layer.Tiles[68, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 357); layer.Tiles[69, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 357);
                layer.Tiles[65, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 167); layer.Tiles[66, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 170); layer.Tiles[68, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 157); layer.Tiles[69, 4] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 166);

                layer = location.map.GetLayer("Front");
                layer.Tiles[65, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 33); layer.Tiles[66, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 33); layer.Tiles[67, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 48); layer.Tiles[68, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 33); layer.Tiles[69, 0] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 31);
                layer.Tiles[65, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 33); layer.Tiles[66, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 32); layer.Tiles[68, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 29); layer.Tiles[69, 1] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 33);
                layer.Tiles[65, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 46); layer.Tiles[66, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 49); layer.Tiles[68, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 46); layer.Tiles[69, 2] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 65);
                layer.Tiles[69, 3] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 149);

                List<Warp> BeachWarpsNM = new List<Warp>
                {
                    new Warp(67, -1, "Town", 101, 109, false),
                    new Warp(68, -1, "Town", 101, 109, false),
                    new Warp(66, -1, "Town", 101, 109, false)
                };
                foreach (Warp warpy in BeachWarpsNM)
                {
                    location.warps.Add(warpy);

                }
                if (!beach.bridgeFixed.Value)
                {
                    layer = location.map.GetLayer("Buildings");
                    layer.Tiles[67, 5] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 140);
                }
            }
        }
    }
}