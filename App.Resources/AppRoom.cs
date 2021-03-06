﻿using App.Contracts;
using System.Collections.Generic;

namespace App.Resources
{
    public class AppRoom : NamedResource, IAppRoom
    {
        public override string DefaultPrefix { get { return "room"; } }

        public int EditorWidth { get; set; }
        public int EditorHeight { get; set; }
        public bool ShowGrid { get; set; }
        public bool ShowObjects { get; set; }
        public bool ShowForegrounds { get; set; }
        public bool ShowViews { get; set; }
        public bool DeleteUnderlyingObjects { get; set; }
        public int ScrollbarY { get; set; }
        public int ScrollbarX { get; set; }
        public int CurrentTab { get; set; }
        public int TileVerticalOffset { get; set; }
        public int TileHorizontalOffset { get; set; }
        public int TileVerticalSeparation { get; set; }
        public int TileHorizontalSeparation { get; set; }
        public int TileHeight { get; set; }
        public int TileWidth { get; set; }
        public bool DeleteUnderlyingTiles { get; set; }
        public bool ShowBackgrounds { get; set; }
        public bool ShowTiles { get; set; }
        public bool RememberRoomEditorInfo { get; set; }
        public List<RoomTile> Tiles { get; set; }
        public List<RoomInstance> Instances { get; set; }
        public List<RoomView> Views { get; set; }
        public bool EnableViews { get; set; }
        public List<RoomBackground> Backgrounds { get; set; }
        public string CreationCode { get; set; }
        public bool DrawBackgroundColor { get; set; }
        public int BackgroundColor { get; set; }
        public bool Persistent { get; set; }
        public int Speed { get; set; }
        public bool Isometric { get; set; }
        public int SnapX { get; set; }
        public int SnapY { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Caption { get; set; }
    }
}
