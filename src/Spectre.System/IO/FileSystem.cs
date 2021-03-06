﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Spectre.System.IO
{
    /// <summary>
    /// A physical file system implementation.
    /// </summary>
    public sealed class FileSystem : IFileSystem
    {
        /// <summary>
        /// Gets the <see cref="IFileProvider"/> belonging to this file system.
        /// </summary>
        /// <returns>The <see cref="IFileProvider" /> instance.</returns>
        public IFileProvider File { get; }

        /// <summary>
        /// Gets the <see cref="IDirectoryProvider"/> belonging to this file system.
        /// </summary>
        /// <returns>The <see cref="IDirectoryProvider" /> instance.</returns>
        public IDirectoryProvider Directory { get; }

        public FileSystem()
        {
            File = new FileProvider();
            Directory = new DirectoryProvider();
        }
    }
}