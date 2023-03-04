﻿using System;

namespace Geo.Gps;

public class GpsFileFormat
{
    public GpsFileFormat(string extension, string name)
    {
        Extension = extension;
        Name = name;
    }

    public GpsFileFormat(string extension, string name, string specificationUrl)
    {
        Extension = extension;
        Name = name;
        SpecificationUri = new Uri(specificationUrl);
    }

    public string Extension { get; }
    public string Name { get; }
    public Uri SpecificationUri { get; }
}