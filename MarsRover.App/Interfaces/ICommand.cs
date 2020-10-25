﻿using MarsRover.App.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.App.Interfaces
{
    public interface ICommand
    {
        void UpdatePosition(Position position);
    }
}
