﻿namespace MyBucks.Core.Model.Abstractions
{
    public interface IBaseContextDtoModel : IBaseDtoModel
    {
        string Context { get; set; }
    }
}