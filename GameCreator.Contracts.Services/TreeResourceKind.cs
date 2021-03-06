﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameCreator.Contracts.Services
{
    public enum TreeResourceKind
    {
        Objects = 1,
        Sprites = 2,
        Sounds = 3,
        Rooms = 4,
        Backgrounds = 6,
        Paths = 8,
        Scripts = 7,
        DataFiles = 9,
        Fonts = 9,
        GameInformation = 10,
        GlobalGameSettings = 11,
        TimeLines = 12,
        ExtensionPackages = 13,
    }
}
