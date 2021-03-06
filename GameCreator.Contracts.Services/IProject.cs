﻿using System;
using System.Collections.Generic;
using App.Contracts;

namespace GameCreator.Contracts.Services
{
    /// <summary>
    /// Interface for representing a project.
    /// </summary>
    public interface IProject
    {
        IGameMakerSettings Settings { get; set; }

        /// <summary>
        /// Gets or sets the repository for this project's resources.
        /// </summary>
        IAppRepository Repository { get; set; }

        int LastInstanceIdPlaced { get; set; }
        int LastTileIdPlaced { get; set; }
        GameInformation GameInformation { get; set; }
        List<string> LibraryCreationCodes { get; set; }
        List<int> ExecutableRoomList { get; set; }
        List<TreeResource> ResourceTree { get; set; }
    }
}
