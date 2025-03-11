﻿using Microsoft.EntityFrameworkCore.Storage;

using org.apache.calcite.sql.type;

namespace Alethic.EntityFrameworkCore.Calcite.Storage.Internal.Mapping
{

    /// <summary>
    /// Maps <see cref="byte"/>.
    /// </summary>
    public class CalciteByteTypeMapping : ByteTypeMapping, ICalciteTypeMapping
    {

        /// <summary>
        /// Gets the default instance of this type mapping.
        /// </summary>
        public static new CalciteByteTypeMapping Default { get; } = new();

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public CalciteByteTypeMapping() :
            base(SqlTypeName.TINYINT.name())
        {

        }

    }

}