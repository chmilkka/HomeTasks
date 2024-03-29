﻿namespace HomeTask13;

/// <summary>
/// Represents contact model
/// </summary>
public interface IContact : IIdentity
{
    string Name { get; set; }
    string PhoneNumber { get; set; }
}