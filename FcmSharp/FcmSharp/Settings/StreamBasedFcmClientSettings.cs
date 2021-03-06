﻿// Copyright (c) Philipp Wagner. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;

namespace FcmSharp.Settings
{
    public static class StreamBasedFcmClientSettings
    {
        public static FcmClientSettings CreateFromStream(string project, Stream credentialsStream)
        {
            var credentials = ReadCredentialsFromStream(credentialsStream);

            return new FcmClientSettings(project, credentials);
        }

        private static string ReadCredentialsFromStream(Stream credentialStream)
        {
            if (credentialStream == null)
            {
                throw new ArgumentNullException("credentialStream");
            }

            if (!credentialStream.CanRead)
            {
                throw new ArgumentException("Cannot read from the given stream", "credentialStream");
            }

            using (StreamReader reader = new StreamReader(credentialStream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}