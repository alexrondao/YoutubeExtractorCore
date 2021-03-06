﻿using System;

namespace YoutubeExtractorCore
{
    /// <summary>
    /// The exception that is thrown when the video is not available for viewing.
    /// This can happen when the uploader restricts the video to specific countries.
    /// </summary>
    public class YoutubeVideoNotAvailableException : Exception
    {
        public YoutubeVideoNotAvailableException()
        { }

        public YoutubeVideoNotAvailableException(string message)
            : base(message)
        { }
    }
}