//-----------------------------------------------------------------------
// <copyright file="MapperTo`2.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Mapper
{
    public interface MapperTo<out TFrom, in TTo>
    {
        TFrom To(TTo type);
    }
}
