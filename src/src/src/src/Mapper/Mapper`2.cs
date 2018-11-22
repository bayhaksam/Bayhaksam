//-----------------------------------------------------------------------
// <copyright file="Mapper`2.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Mapper
{
    public interface Mapper<From, To> : MapperFrom<From, To>, MapperTo<From, To>
    {
    }
}
