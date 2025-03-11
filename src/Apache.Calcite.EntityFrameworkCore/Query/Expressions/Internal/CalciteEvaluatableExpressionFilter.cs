﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore.Query;

namespace Apache.Calcite.EntityFrameworkCore.Query.Expressions.Internal
{

    /// <inheritdoc />
    public class CalciteEvaluatableExpressionFilter : RelationalEvaluatableExpressionFilter
    {

        /// <inheritdoc />
        public CalciteEvaluatableExpressionFilter(EvaluatableExpressionFilterDependencies dependencies, RelationalEvaluatableExpressionFilterDependencies relationalDependencies) :
            base(dependencies, relationalDependencies)
        {

        }

    }

}
