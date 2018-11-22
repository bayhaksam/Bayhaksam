//-----------------------------------------------------------------------
// <copyright file="MapperFrom`2.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Mapper
{
    public interface MapperFrom<in TFrom, out TTo>
    {
        TTo From(TFrom type);
    }
}
