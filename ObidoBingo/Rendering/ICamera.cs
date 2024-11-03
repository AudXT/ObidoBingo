﻿using SFML.System;

namespace ObidoBingo.Rendering
{
    public interface ICamera : IUpdateable
    {
        public bool Changed { get; }
        public Vector2f Position { get; set; }
        public Vector2f Size { get; set; }
        public float Zoom { get; set; }
        public float MaxZoom { get; set; }
        public float MinZoom { get; set; }

        public SFML.Graphics.View GetView();
    }
}