﻿namespace MyBucks.Core.Model.Abstractions
{
    public interface IBaseContextModel : IBaseModel
    {
        string Context { get; set; }
    }
}