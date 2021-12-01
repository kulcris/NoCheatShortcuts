+using System;
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
            public bool AdventureShortcut { get; set; } = true;
            public bool RiverShortcut { get; set; } = true;
            public bool BusStopShortcut { get; set; } = true;
        }
        private ModConfig Config;


        private void AfterDayLoaded(object sender, EventArgs args)
        {
            GameLocation location = Game1.getLocationFromName("Mountain");
            GameLocation Beach = Game1.getLocationFromName("Beach");

            bool AdventureShortcut = this.Config.AdventureShortcut;
            bool RiverShortcut = this.Config.RiverShortcut;
            bool BusStopSC = this.Config.BusStopShortcut;


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



            if (BusStopSC)
            {
                location = Game1.getLocationFromName("BusStop");


                for (int o = 0; o < 6; o++)
                {
                    for (int i = 27; i < 30; i++)
                    {
                        location.removeTile(i, o, "Buildings");
                    }
                }
                TileSheet tilesheetbus = location.map.GetTileSheet("outdoors");
                layer = location.map.GetLayer("Back");

                layer.Tiles[27, 0] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 337);
                layer.Tiles[27, 1] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 337);
                layer.Tiles[27, 2] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 337);
                layer.Tiles[27, 3] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 337);
                layer.Tiles[27, 4] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 337);

                layer.Tiles[28, 0] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 337);
                layer.Tiles[28, 1] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 337);
                layer.Tiles[28, 2] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 337);
                layer.Tiles[28, 3] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 337);
                layer.Tiles[28, 4] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 337);

                layer.Tiles[29, 0] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 337);
                layer.Tiles[29, 1] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 337);
                layer.Tiles[29, 2] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 337);
                layer.Tiles[29, 3] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 337);
                layer.Tiles[29, 4] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 337);


                layer = location.map.GetLayer("Buildings");

                layer.Tiles[27, 0] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 419);
                layer.Tiles[27, 1] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 444);
                layer.Tiles[27, 2] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 469);
                layer.Tiles[27, 3] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 494);
                layer.Tiles[27, 4] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 519);
                layer.Tiles[27, 5] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 544);
                
                layer.Tiles[29, 0] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 416);
                layer.Tiles[29, 1] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 441);
                layer.Tiles[29, 2] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 466);
                layer.Tiles[29, 3] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 491);
                layer.Tiles[29, 4] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 516);
                layer.Tiles[29, 5] = new StaticTile(layer, tilesheetbus, BlendMode.Alpha, 541);


                List<Warp> BusWarps = new List<Warp>
                {
                    new Warp(28, -1, "Mountain", 0, 36, false),
                };
                foreach (Warp warpy in BusWarps)
                {
                    location.warps.Add(warpy);

                }





                 location = Game1.getLocationFromName("Mountain");

                List<string> layers2 = new List<string>
            {
                "Buildings",
                "Front",
                "Paths",
                "AlwaysFront"
             };

                foreach (string p in layers2)
                {
                    for (int o = 27; o < 39; o++)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            location.removeTile(i, o, p);
                        }
                    }
                }


                TileSheet tilesheetMount = location.map.GetTileSheet("outdoors");
              //  layer = location.map.GetLayer("Back");

              //  layer.Tiles[0, 36] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 351);


                layer = location.map.GetLayer("Buildings");
                layer.Tiles[0, 27] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 304);
                layer.Tiles[1, 27] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 307);
                layer.Tiles[2, 27] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 394);

                layer.Tiles[0, 28] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 351);
                layer.Tiles[1, 28] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 352);
                layer.Tiles[2, 28] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 419);

                layer.Tiles[0, 29] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 351);
                layer.Tiles[1, 29] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 352);
                layer.Tiles[2, 29] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 394);

                layer.Tiles[0, 30] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 376);
                layer.Tiles[1, 30] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 377);
                layer.Tiles[2, 30] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 394);

                layer.Tiles[0, 31] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 402);
                layer.Tiles[1, 31] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 402);
                layer.Tiles[2, 31] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 444);

                layer.Tiles[0, 32] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 467);
                layer.Tiles[1, 32] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 468);
                layer.Tiles[2, 32] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 469);

                layer.Tiles[0, 33] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 492);
                layer.Tiles[1, 33] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 493);
                layer.Tiles[2, 33] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 494);

                layer.Tiles[0, 34] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 517);
                layer.Tiles[1, 34] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 518);
                layer.Tiles[2, 34] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 519);

                layer.Tiles[0, 35] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 542);
                layer.Tiles[1, 35] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 543);
                layer.Tiles[2, 35] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 544);


                layer.Tiles[0, 38] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 384);
                layer.Tiles[1, 38] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 384);
                layer.Tiles[2, 38] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 384);

                layer = location.map.GetLayer("Front");
                layer.Tiles[0, 37] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 359);
                layer.Tiles[1, 37] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 359);
                layer.Tiles[2, 37] = new StaticTile(layer, tilesheetMount, BlendMode.Alpha, 359);



                List<Warp> Mountwarps = new List<Warp>
                {
                    new Warp(-1, 36, "BusStop", 28, 1, false),
                    new Warp(-1, 37, "BusStop", 28, 1, false),
                };
                foreach (Warp warpy in Mountwarps)
                {
                    location.warps.Add(warpy);

                }
               
            }
        }
    }
}
