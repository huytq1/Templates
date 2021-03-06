﻿namespace ApiTemplate.ViewModels
{
    using System.Collections.Generic;
#if (Swagger)
    using ApiTemplate.ViewModelSchemaFilters;
    using Swashbuckle.AspNetCore.SwaggerGen;

    [SwaggerSchemaFilter(typeof(PageResultCarSchemaFilter))]
#endif
    public class PageResult<T>
        where T : class
    {
        public int Page { get; set; }

        public int Count { get; set; }

        public int Total { get; set; }

        public IEnumerable<T> Items { get; set; }
    }
}
